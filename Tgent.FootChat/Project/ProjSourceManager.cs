using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tgnet;
using Tgnet.FootChat.YwqWcfService;
using Tgnet.ServiceModel;

namespace Tgnet.FootChat.Project
{
    public interface IProjSourceManager
    {
        ProjectSource GetSource(long id);
        ProjectSource[] GetSources(long[] ids);
        ProjectSource AddProject(string name, string areaNo, double? longitude, double? latitude, string address);
        Dictionary<long, ProjectSource> GetProjSourceByPids(long[] pids);
        Dictionary<long, ProjectService.SimpleProjectInfo> GetSimpleProjectInfoByPids(long[] pids);
        ProjectSearchItem[] SearchSimilarProject(ProjectSearchArgs args, int pageIndex, int limit, out int recordCount, out int pageCount);
        void UpdateAddress(long pid, string address, double? longitude, double? latitude, int? confidence);
        ProjectSource AssociatedToTgProject(long pid, long tgPid, string name, string areaNo, double? longitude, double? latitude, string address, bool? addressIsCertain);
        Dictionary<long, long> GetTpmPIdByTgPId(long[] tgpids);
        ProjectSource[] GetProjectByTgPids(long[] tgpids);
    }
    public class ProjSourceManager:IProjSourceManager
    {
        private readonly IChannelProviderService<YwqWcfService.IManagerService> _YwqManagerService;
        private readonly IChannelProviderService<ProjectService.IProjectService> _ProjectService;
        private readonly IChannelProviderService<SearchService.IProjectService> _SearchService;
        private readonly IChannelProviderService<TpmService.ITpmService> _TpmService;

        public ProjSourceManager(IChannelProviderService<YwqWcfService.IManagerService> ywqManagerService,
            IChannelProviderService<ProjectService.IProjectService> projectService,
            IChannelProviderService<SearchService.IProjectService> searchService,
            IChannelProviderService<TpmService.ITpmService> tpmService)
        {
            _YwqManagerService = ywqManagerService;
            _ProjectService = projectService;
            _SearchService = searchService;
            _TpmService = tpmService;
        }

        public ProjectSource AddProject(string name,string areaNo,double? longitude,double? latitude,string address)
        {
            using (var provider = _YwqManagerService.NewChannelProvider())
            {
                return provider.Channel.AddProject(new Api.OAuth2ClientIdentity(),
                    name, areaNo, longitude, latitude, address);
            }
        }

        public ProjectSource[] GetSources(long[] ids)
        {
            ids = (ids ?? new long[0]).Where(p => p > 0).Distinct().ToArray();
            if (ids.Length == 0) return new ProjectSource[0];
            using (var provider = _YwqManagerService.NewChannelProvider())
            {
                return provider.Channel.GetProjectByPids(new Api.OAuth2ClientIdentity(), ids);
            }
        }

        public ProjectSource GetSource(long id)
        {
            ExceptionHelper.ThrowIfNotId(id, nameof(id));
            using (var provider = _YwqManagerService.NewChannelProvider())
            {
                return provider.Channel.GetProjectByPids(new Api.OAuth2ClientIdentity(), new long[] { id }).FirstOrDefault();
            }
        }

        public Dictionary<long, ProjectSource> GetProjSourceByPids(long[] pids)
        {
            pids = (pids ?? Enumerable.Empty<long>()).Where(id => id > 0).Distinct().ToArray();
            var result = new Dictionary<long, ProjectSource>();
            if (pids.Length <= 0) return result;
            using (var provider = _YwqManagerService.NewChannelProvider())
            {
                var source=provider.Channel.GetProjectByPids(new Api.OAuth2ClientIdentity(), pids);
                result = source.GroupBy(p => p.pid).ToDictionary(p => p.Key, p => p.FirstOrDefault());
                return result;
            }
        }

        public Dictionary<long, ProjectService.SimpleProjectInfo> GetSimpleProjectInfoByPids(long[] pids)
        {
            if (pids.Length <= 0) return new Dictionary<long, ProjectService.SimpleProjectInfo>();
            using (var provider = _ProjectService.NewChannelProvider())
            {
                var source = provider.Channel.GetSimpleProjectInfo(new Api.OAuth2ClientIdentity(), pids);
                return source.GroupBy(p => p.pid).ToDictionary(p => p.Key, p => p.FirstOrDefault());
            }
        }

        public ProjectSearchItem[] SearchSimilarProject(ProjectSearchArgs args, int pageIndex, int limit, out int recordCount, out int pageCount)
        {
            pageIndex = Math.Max(pageIndex, 1);
            if (limit <= 0)
            {
                limit = 30;
            }
            if (limit > 100)
            {
                limit = 100;
            }

            using (var provider = _SearchService.NewChannelProvider())
            {
                //var HIGHLIGHT_TAG = "span";
                var setting = new SearchService.SearchSetting();
                //setting.Summary = new SearchService.SearchSetting.SearchSummary { Length = 500, Element = HIGHLIGHT_TAG };
                setting.Summary = new SearchService.SearchSetting.SearchSummary { Length = 500,Element="" };

                var request = new SearchService.ProjectSearchRequest();
                request.Limit = limit;
                request.Start = (pageIndex - 1) * limit;
                if (!String.IsNullOrWhiteSpace(args.Name))
                {
                    request.Keyword = args.Name;
                }

                var result = provider.Channel.SearchProject(new Api.OAuth2ClientIdentity(), request, setting);
                recordCount = result.Count;
                pageCount = (int)Math.Ceiling((float)recordCount / limit);
                return result.Models.Select(d => new ProjectSearchItem
                {
                    //Name = (d.Name ?? String.Empty).Replace(HIGHLIGHT_TAG, HIGHLIGHT_TAG + " style='color:red'"),
                    Name = (d.Name ?? String.Empty).Replace("<em>", "").Replace("</em>",""),
                    TgPid = d.Pid,
                    AreaNo = d.AreaNo,
                    Longitude = d.Longitude,
                    Latitude=d.Latitude,
                    Address=(d.Address??string.Empty).Replace("<em>", "").Replace("</em>", ""),
                }).ToArray();
            }
        }


        public void UpdateAddress(long pid, string address, double? longitude, double? latitude, int? confidence)
        {
            using (var provider = _YwqManagerService.NewChannelProvider())
            {
                provider.Channel.UpdateProject(new Api.OAuth2ClientIdentity(), pid, null, null, longitude, latitude, address, false, confidence);
            }
            var dicProject = GetProjectSources(new long[] { pid });
            var project = dicProject[pid];
            if (project != null && project.tgProjId > 0)
            {
                using (var provider = _ProjectService.NewChannelProvider())
                {
                    provider.Channel.UpdateProjectAddress(new Api.OAuth2ClientIdentity(), project.tgProjId.Value, address, longitude, latitude);
                }
            }
        }

        public Dictionary<long, ProjectSource> GetProjectSources(IEnumerable<long> pids)
        {
            pids = pids.Distinct();
            Dictionary<long, ProjectSource> dic = new Dictionary<long, ProjectSource>();
            foreach (var id in pids)
            {
                dic.Add(id, null);
            }

            using (var provider = _YwqManagerService.NewChannelProvider())
            {
                var result = provider.Channel.GetProjectByPids(new Api.OAuth2ClientIdentity(), pids.ToArray());
                if (result != null)
                {
                    foreach (var item in result)
                    {
                        dic[item.pid] = item;
                    }
                }
            }
            return dic;
        }

        public ProjectSource AssociatedToTgProject(long pid, long tgPid, string name, string areaNo, double? longitude, double? latitude, string address, bool? addressIsCertain)
        {
            ExceptionHelper.ThrowIfNotId(pid,nameof(pid));
            ExceptionHelper.ThrowIfNotId(tgPid, nameof(tgPid));
            using (var provider = _YwqManagerService.NewChannelProvider())
            {
                return provider.Channel.AssociatedToTgProject(new Api.OAuth2ClientIdentity(),pid, tgPid,name,areaNo,longitude,latitude,address,addressIsCertain);
            }
        }

        public Dictionary<long,long> GetTpmPIdByTgPId(long[] tgpids)
        {
            tgpids = (tgpids ?? Enumerable.Empty<long>()).Where(id => id > 0).Distinct().ToArray();
            var result = new Dictionary<long, long>();
            if (tgpids.Length <= 0) return result;
            using (var provider = _TpmService.NewChannelProvider())
            {
                result=provider.Channel.GetTpmPIdByTgPId(new Api.OAuth2ClientIdentity(), tgpids);
                return result;
            }           
        }

        public ProjectSource[] GetProjectByTgPids(long[] tgpids)
        {
            tgpids = (tgpids ?? Enumerable.Empty<long>()).Where(id => id > 0).Distinct().ToArray();
            if (tgpids.Length <= 0) return new ProjectSource[0];
            using (var provider = _YwqManagerService.NewChannelProvider())
            {
                return  provider.Channel.GetProjectByTgPids(new Api.OAuth2ClientIdentity(), tgpids);
            }
        }

    }
    public class ProjectSearchArgs
    {
        public String Name { get; set; }
    }

    public class ProjectSearchItem
    {
        public String Name { get; set; }
        public long TgPid { get; set; }
        public string AreaNo { get; set; }
        public double? Longitude { get; set; }
        public double? Latitude { get; set; }
        public string Address { get; set; }
    }
}
