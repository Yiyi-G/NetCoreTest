using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.Text;

namespace Tgnet.ServiceModel.Behaviors
{

    /// <summary>
    /// 错误日志记录
    /// </summary>
    public class LogErrorRecordAttribute : Attribute//, IServiceBehavior
    {
        private class LogErrorHandler //: IErrorHandler
        {
            /// <summary>
            /// 节点名称
            /// </summary>
            public string Keyword { get; set; }

            /// <summary>
            /// 异常记录处理器
            /// </summary>
            /// <param name="point">节点名称</param>
            public LogErrorHandler(string keyword)
            {
                this.Keyword = keyword;
            }

            public bool HandleError(System.Exception error)
            {
                return false;
            }

            public void ProvideFault(System.Exception error, System.ServiceModel.Channels.MessageVersion version, ref System.ServiceModel.Channels.Message fault)
            {
                if (error != null)
                {
                    Tgnet.Log.LoggerResolver.Current.Error(Keyword, error);
                }
            }
        }

        /// <summary>
        /// 节点名称
        /// </summary>
        public string Keyword { get; set; }

        public LogErrorRecordAttribute()
        {
            Keyword = "WcfDefault";
        }

        //public void AddBindingParameters(ServiceDescription serviceDescription, System.ServiceModel.ServiceHostBase serviceHostBase, System.Collections.ObjectModel.Collection<ServiceEndpoint> endpoints, System.ServiceModel.Channels.BindingParameterCollection bindingParameters)
        //{
        //    return;
        //}

        //public void ApplyDispatchBehavior(ServiceDescription serviceDescription, System.ServiceModel.ServiceHostBase serviceHostBase)
        //{
        //    foreach (ChannelDispatcher item in serviceHostBase.ChannelDispatchers)
        //    {
        //        item.ErrorHandlers.Add(new LogErrorHandler(Keyword));
        //    }
        //}

        //public void Validate(ServiceDescription serviceDescription, System.ServiceModel.ServiceHostBase serviceHostBase)
        //{
        //    return;
        //}
    }
}
