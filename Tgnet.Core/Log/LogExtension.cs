using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tgnet.Core.Log
{
    public static class LogExtension
    {
        public static System.Threading.Tasks.Task LogOnFaulted(this System.Threading.Tasks.Task self)
        {
            return self.ContinueWith(task => LoggerResolver.Current.Fail(self.Exception.InnerException), System.Threading.Tasks.TaskContinuationOptions.OnlyOnFaulted);
        }

        public static System.Threading.Tasks.Task<T> LogOnFaulted<T>(this System.Threading.Tasks.Task<T> self)
        {
            return self.ContinueWith<T>(task =>
            {
                LoggerResolver.Current.Fail(self.Exception.InnerException);
                return default(T);
            }, System.Threading.Tasks.TaskContinuationOptions.OnlyOnFaulted);
        }
    }
}
