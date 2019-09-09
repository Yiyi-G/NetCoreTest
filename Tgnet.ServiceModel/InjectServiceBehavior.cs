using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.Text;
using System.Threading.Tasks;

namespace Tgnet.ServiceModel
{
    public class InjectServiceBehavior : IServiceBehavior
    {
        private IInjectInstanceProvider m_Provider;

        public InjectServiceBehavior(IInjectInstanceProvider provider)
        {
            m_Provider = provider;
        }

        public void AddBindingParameters(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase, System.Collections.ObjectModel.Collection<System.ServiceModel.Description.ServiceEndpoint> endpoints, System.ServiceModel.Channels.BindingParameterCollection bindingParameters)
        {
            return;
        }

        public void ApplyDispatchBehavior(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase)
        {
            foreach (ChannelDispatcher channelDispatcher in serviceHostBase.ChannelDispatchers)
            {
                foreach (EndpointDispatcher endpointDispatcher in channelDispatcher.Endpoints)
                {
                    Type contractType = (from endpoint in serviceHostBase.Description.Endpoints
                                         where endpoint.Contract.Name == endpointDispatcher.ContractName && endpoint.Contract.Namespace == endpointDispatcher.ContractNamespace
                                         select endpoint.Contract.ContractType).FirstOrDefault();
                    if (null == contractType)
                    {
                        continue;
                    }
                    m_Provider.Register(contractType, serviceHostBase.Description.ServiceType);
                    endpointDispatcher.DispatchRuntime.InstanceProvider = m_Provider.GetInstanceProvider(contractType);
                }
            }
        }

        public void Validate(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase)
        {
            return;
        }
    }
}
