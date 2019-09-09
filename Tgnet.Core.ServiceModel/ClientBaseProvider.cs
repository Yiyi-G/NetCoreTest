using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;

namespace Tgnet.ServiceModel
{
    public interface IChannelProvider<TChannel> : ICommunicationObject, IDisposable
        where TChannel : class
    {
        bool LogOnFail { get; set; }
        TChannel Channel { get; }
        ClientCredentials Credentials { get; }
    }

    public interface IChannelProviderService<TChannel>
        where TChannel : class
    {
        IChannelProvider<TChannel> NewChannelProvider();
    }

    public sealed class ChannelProviderService<TChannel> : IChannelProviderService<TChannel>
        where TChannel : class
    {
        private ServiceEndpoint Endpoint;
        private string EndpointConfigurationName;

        public ChannelProviderService() { }
        public ChannelProviderService(ServiceEndpoint endpoint) { this.Endpoint = endpoint; }
        public ChannelProviderService(string endpointConfigurationName) { this.EndpointConfigurationName = endpointConfigurationName; }


        public IChannelProvider<TChannel> NewChannelProvider()
        {

            if (String.IsNullOrWhiteSpace(EndpointConfigurationName))
                return new ChannelProvider<TChannel>();
            else
                return new ChannelProvider<TChannel>(EndpointConfigurationName);

        }
    }

    internal sealed class ChannelProvider<TChannel> : ClientBase<TChannel>, IChannelProvider<TChannel>
        where TChannel : class
    {
        public bool LogOnFail { get; set; }

        public ChannelProvider()
            : base()
        {
            LogOnFail = true;
        }


        public ChannelProvider(string endpointConfigurationName)
            : base(endpointConfigurationName)
        {
            LogOnFail = true;
        }

        public new TChannel Channel { get { return base.Channel; } }
        public ClientCredentials Credentials
        {
            get
            {
                return base.ChannelFactory.Credentials;
            }
        }

        public void CloseConnection()
        {
            try
            {
                base.Close();
            }
            catch (TimeoutException ex)
            {
                base.Abort();
                if (LogOnFail)
                    Tgnet.Core.Log.LoggerResolver.Current.Fail("ChannelProvider", ex);
            }
            catch (CommunicationException ex)
            {
                base.Abort();
                if (LogOnFail)
                    Tgnet.Core.Log.LoggerResolver.Current.Fail("ChannelProvider", ex);
            }
            catch (System.Exception ex)
            {
                base.Abort();
                throw ex;
            }
        }

        public void Dispose()
        {
            CloseConnection();
        }
    }
}
