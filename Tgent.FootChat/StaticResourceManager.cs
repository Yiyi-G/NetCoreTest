using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tgnet.ServiceModel;
using Tgnet.Linq;
using Tgnet.FootChat.StaticResourceService;

namespace Tgnet.FootChat
{
    public interface IStaticResourceManager
    {
        Dictionary<string, string> GetBaseClassNames(string[] classNos);
        Dictionary<string, string> GetAreaNames(string[] areaNos);
        StaticResourceService.ProductClassInfo[] GetProductClassByNos(string[] classNos);
        AreaInfo GetIPArea(string ip);
        Address GetAddress(double longitude, double latitude);
        SimpleLocation GetAddressWithAreaNo(string address, string city);
        LocationAreaInfo GetAreaInfoByAddress(string address, string city);
        AddressWithAreaNo GetAddressWithAreaNo(double longitude, double latitude);
        string GetAreaNo(double longitude, double latitude);
        Dictionary<string, string[]> GetSubAreaNos(string[] areaNos, Tgnet.FootChat.StaticResourceService.AreaType startAreaType, Tgnet.FootChat.StaticResourceService.AreaType endAreaType);

        BassClass[] GetBaseClasses(string[] classNos);
        CompleteAreaInfo[] GetCompleteAreaInfos(string[] areaNos);
        AreaInfo[] GetAllAreaInfo();
        Dictionary<string, string> GetRangeAreas(AreaType startType, AreaType endType);
        ShortUrlModel CreateShortUrl(string url);
        string GetAreaByAreaName(string province,string city,string town);
    }
    class StaticResourceManager : IStaticResourceManager
    {
        private readonly IChannelProviderService<StaticResourceService.IStaticResourceService> _StaticResourceServiceProvider;
        public StaticResourceManager(IChannelProviderService<StaticResourceService.IStaticResourceService> staticResourceServiceProvider)
        {
            _StaticResourceServiceProvider = staticResourceServiceProvider;
        }
        public Dictionary<string, string> GetBaseClassNames(string[] classNos)
        {
            classNos = (classNos ?? Enumerable.Empty<string>()).Where(no => !String.IsNullOrWhiteSpace(no)).Distinct().ToArray();
            if (classNos.Count() == 0) return new Dictionary<string, string>();
            using (var provider = _StaticResourceServiceProvider.NewChannelProvider())
            {
                return provider.Channel.GetBaseClassNamesAsync(new Tgnet.Core.Api.OAuth2ClientIdentity(), classNos) ?? new Dictionary<string, string>();
            }
        }
        public Dictionary<string, string> GetBaseClassNames(string[] classNos)
        {
            classNos = (classNos ?? Enumerable.Empty<string>()).Where(no => !String.IsNullOrWhiteSpace(no)).Distinct().ToArray();
            if (classNos.Count() == 0) return new Dictionary<string, string>();
            using (var provider = _StaticResourceServiceProvider.NewChannelProvider())
            {
                return provider.Channel.GetBaseClassNames(new Api.OAuth2ClientIdentity(), classNos) ?? new Dictionary<string, string>();
            }
        }
        public BassClass[] GetBaseClasses(string[] classNos)
        {
            classNos = (classNos ?? Enumerable.Empty<string>()).Where(no => !String.IsNullOrWhiteSpace(no)).Distinct().ToArray();
            if (classNos.Count() == 0) return new BassClass[0];
            using (var provider = _StaticResourceServiceProvider.NewChannelProvider())
            {
                return provider.Channel.GetBaseClasses(new Api.OAuth2ClientIdentity(), classNos) ??new BassClass[0];
            }
        }

        public Dictionary<string, string> GetAreaNames(string[] areaNos)
        {
            areaNos = (areaNos ?? Enumerable.Empty<string>()).Where(no => !String.IsNullOrWhiteSpace(no)).Distinct().ToArray();
            if (areaNos.Count() == 0) return new Dictionary<string, string>();
            using (var provider = _StaticResourceServiceProvider.NewChannelProvider())
            {
                return provider.Channel.GetAreaNames(areaNos);
            }
        }
        public StaticResourceService.ProductClassInfo[] GetProductClassByNos(string[] classNos)
        {
            classNos = (classNos ?? Enumerable.Empty<string>()).Where(no => !String.IsNullOrWhiteSpace(no)).Distinct().ToArray();
            if (classNos.Count() == 0) return Enumerable.Empty<StaticResourceService.ProductClassInfo>().ToArray();
            using (var provider = _StaticResourceServiceProvider.NewChannelProvider())
            {
                return provider.Channel.GetProductClassByNos(new Api.OAuth2ClientIdentity(), classNos);
            }
        }
        public AreaInfo GetIPArea(string ip)
        {
            if (String.IsNullOrWhiteSpace(ip))
                return null;
            using (var provider = _StaticResourceServiceProvider.NewChannelProvider())
            {
                return provider.Channel.GetIPArea(new Api.OAuth2ClientIdentity(), ip);
            }
        }

        public Dictionary<string, string[]> GetSubAreaNos(string[] areaNos, AreaType startAreaType, AreaType endAreaType)
        {
            areaNos = (areaNos ?? Enumerable.Empty<string>()).Where(w => !string.IsNullOrWhiteSpace(w)).Distinct().ToArray();
            if (!areaNos.Any())
                return new Dictionary<string, string[]>();
            using (var provider=_StaticResourceServiceProvider.NewChannelProvider())
            {
                return provider.Channel.GetSubAreaNos(new Api.OAuth2ClientIdentity(), areaNos, startAreaType, endAreaType);
            }
        }
        public Address GetAddress(double longitude, double latitude)
        {
            using (var provider = _StaticResourceServiceProvider.NewChannelProvider())
            {
                return provider.Channel.GetAddress(new Api.OAuth2ClientIdentity(), longitude, latitude);
            }
        }
        public AddressWithAreaNo GetAddressWithAreaNo(double longitude, double latitude)
        {
            using (var provider = _StaticResourceServiceProvider.NewChannelProvider())
            {
                return provider.Channel.GetAddressWithAreaNo(new Api.OAuth2ClientIdentity(), longitude, latitude);
            }
        }
        public string GetAreaNo(double longitude, double latitude)
        {
            string areaNo = null;
            try
            {
                var area = GetAddressWithAreaNo(longitude, latitude);
                if (area != null)
                    areaNo = area.AreaNo;
            }
            catch (System.Exception ex)
            {
                Tgnet.Log.LoggerResolver.Current.Fail("GetAddressWithAreaNo", ex);
            }
            areaNo = areaNo ?? String.Empty;
            return areaNo;
        }
        public SimpleLocation GetAddressWithAreaNo(string address, string city)
        {
            using (var provider = _StaticResourceServiceProvider.NewChannelProvider())
            {
                return provider.Channel.GetSimpleLocation(new Api.OAuth2ClientIdentity(),address,city);
            }
        }
        public LocationAreaInfo GetAreaInfoByAddress(string address, string city)
        {
            using (var provider = _StaticResourceServiceProvider.NewChannelProvider())
            {
                return provider.Channel.GetAreaInfoByAddress(new Api.OAuth2ClientIdentity(), address, city);
            }
        }

        public CompleteAreaInfo[] GetCompleteAreaInfos(string[] areaNos)
        {
            using (var provider = _StaticResourceServiceProvider.NewChannelProvider())
            {
                return provider.Channel.GetCompleteAreaInfos(new Api.OAuth2ClientIdentity(), areaNos);
            }
        }
        public AreaInfo[] GetAllAreaInfo()
        {
            using (var provider = _StaticResourceServiceProvider.NewChannelProvider())
            {
                return provider.Channel.GetAllAreaInfo();
            }
        }
        public Dictionary<string,string> GetRangeAreas(AreaType startType,AreaType endType)
        {
            using (var provider = _StaticResourceServiceProvider.NewChannelProvider())
            {
                return provider.Channel.GetRangeAreas(new Api.OAuth2ClientIdentity(),startType,endType);
            }
        }

        public ShortUrlModel CreateShortUrl(string url)
        {
            var response = _StaticResourceServiceProvider.Execute(c=>c.CreateShortUrl(new Api.OAuth2ClientIdentity(),url));
            return response;
        }

        public string GetAreaByAreaName(string province, string city, string town)
        {
            using (var provider = _StaticResourceServiceProvider.NewChannelProvider())
            {
               var area =  provider.Channel.GetAreaByAreaName(new Api.OAuth2ClientIdentity(), province, city, town);
                return area == null ? "" : area.area_no;
            }
        }
    }
}
