using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.Text;
using Tgnet.ServiceModel;

namespace Tgnet.ServiceModel.Behaviors
{
    public class LogStatisticsRecordAttribute : Attribute, IOperationBehavior
    {
        private class StatisticsParameterInspector : IParameterInspector
        {
            public void AfterCall(string operationName, object[] outputs, object returnValue, object correlationState)
            {
                return;
            }

            public object BeforeCall(string operationName, object[] inputs)
            {
                //Tgnet.Core.Log.StatisticsResolver.Current.IncrementInvoke(OperationContext.Current.GetCurrentIP(), operationName);
                return null;
            }
        }

        public string ServiceName { get; set; }

        public void AddBindingParameters(OperationDescription operationDescription, System.ServiceModel.Channels.BindingParameterCollection bindingParameters)
        { }

        public void ApplyClientBehavior(OperationDescription operationDescription, ClientOperation clientOperation)
        { }

        public void ApplyDispatchBehavior(OperationDescription operationDescription, DispatchOperation dispatchOperation)
        {
            //dispatchOperation.ParameterInspectors.Add(new StatisticsParameterInspector());
        }

        public void Validate(OperationDescription operationDescription)
        { }
    }
}
