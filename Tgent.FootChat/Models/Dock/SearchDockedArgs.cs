using System;
using System.Collections.Generic;
using System.Text;
using Tgnet.Core;

namespace Tgnet.FootChat.Models.Dock
{
    public class SearchDockedArgs
    {
        public void VerifySearchDockedArgs()
        {
            if (!string.IsNullOrWhiteSpace(startTime) && !string.IsNullOrWhiteSpace(endTime))
            {
                var minTime = startTime.To<DateTime>();
                var maxTime = endTime.To<DateTime>();
                ExceptionHelper.ThrowIfTrue(minTime > maxTime, "时间范围", "开始日期不能大于结束日期");
            }
            if (status.HasValue)
            {
                ExceptionHelper.ThrowIfTrue(!Enum.IsDefined(typeof(DockedStatus), status.Value), "status", "值不在范围内");
            }
        }

        public string sender { get; set; }//发送人
        public string receiver { get; set; }//接收人
        public string startTime { get; set; }//搜索发送时间
        public string endTime { get; set; }//搜索发送时间
        public DockedStatus? status { get; set; }//处理结果
    }
}
