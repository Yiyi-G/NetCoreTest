using System;
using System.Collections.Generic;
using System.Text;
using Tgnet.Core;

namespace Tgnet.FootChat.FootPrint
{
    public class SearchFootPrintArgs
    {
        public void VerifySearchFootPrintArgs()
        {
            if (!string.IsNullOrWhiteSpace(startTime) && !string.IsNullOrWhiteSpace(endTime))
            {
                var minTime = startTime.To<DateTime>();
                var maxTime = endTime.To<DateTime>();
                ExceptionHelper.ThrowIfTrue(minTime > maxTime, "时间范围", "开始日期不能大于结束日期");
                var ts = maxTime - minTime;
                ExceptionHelper.ThrowIfTrue(ts.Days > 365, "时间范围", "时间区间不得超过1年");
            }
            if (!string.IsNullOrWhiteSpace(transferMinTime) && !string.IsNullOrWhiteSpace(transferMaxTime))
            {
                var sTime = transferMinTime.To<DateTime>();
                var eTime = transferMaxTime.To<DateTime>();
                ExceptionHelper.ThrowIfTrue(sTime > eTime, "时间范围", "开始日期不能大于结束日期");
            }
        }

        public SearchFootPrintArgs()
        {
            isInner = false;
        }
        public string keyWord { get; set; }
        public string userName { get; set; }
        public string startTime { get; set; }//搜索创建时间
        public string endTime { get; set; }//搜索创建时间
        public string projName { get; set; }
        public string mobile { get; set; }
        public FootPrintState? footPrintState { get; set; }
        public TransferScales? transferScales { get; set; }//采编标签
        public TransferState? transferState { get; set; }//采编状态
        public bool? isInnerProject { get; set; }//项目属性
        public bool? isInner { get; set; }
        public long? userId { get; set; }
        public bool? isProjectEdition { get; set; }//是否项目采编
        public string transferMinTime { get; set; }//搜索采编时间
        public string transferMaxTime { get; set; }//搜索采编时间
        public long? fid { get; set; }//足迹id
    }
}
