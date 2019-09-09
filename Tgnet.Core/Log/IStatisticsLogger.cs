using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tgnet.Core.Log
{
    public interface IStatisticsLogger
    {
        /// <summary>
        /// 调用统计加1
        /// </summary>
        /// <param name="serviceName">服务名称，比如：p.tgnet.com</param>
        /// <param name="ip">调用ip</param>
        /// <param name="invokeCommand">调用命令，比如：/Detail?projno=GDWSRY</param>
        void IncrementInvoke(string serviceName, string ip, string invokeCommand);
    }

    public class StatisticsResolver
    {
        private class NoneLogger : IStatisticsLogger
        {
            public void IncrementInvoke(string serviceName, string ip, string invokeCommand)
            {
                return;
            }
        }

        private static IStatisticsLogger _Logger;
        public static string ServiceName { get; private set; }
        public static StatisticsResolver Current { get; private set; }

        static StatisticsResolver()
        {
            _Logger = new NoneLogger();
        }

        public static void SetLogger(IStatisticsLogger logger)
        {
            _Logger = logger ?? new NoneLogger();
        }

        public static void SetServiceName(string serviceName)
        {
            ServiceName = (serviceName ?? String.Empty).Trim();
        }

        /// <summary>
        /// 调用统计加1
        /// </summary>
        /// <param name="ip">调用ip</param>
        /// <param name="invokeCommand">调用命令，比如：/Detail?projno=GDWSRY</param>
        public void IncrementInvoke(string ip, string invokeCommand)
        {
            _Logger.IncrementInvoke(ServiceName, ip, invokeCommand);
        }
    }
}
