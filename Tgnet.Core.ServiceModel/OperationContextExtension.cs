using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using Tgnet.Core;

namespace Tgnet.ServiceModel
{
    public static class OperationContextExtension
    {
        //public static string GetCurrentIP(this OperationContext context)
        //{
        //    string ip = null;
        //    if (context != null)
        //    {
        //        var properties = context.IncomingMessageProperties;
        //        if (properties != null)
        //        {
        //            var property = properties.GetOrDefault(RemoteEndpointMessageProperty.Name) as RemoteEndpointMessageProperty;
        //            if (property != null)
        //            {
        //                ip = property.Address;
        //            }
        //        }
        //    }
        //    return ip ?? String.Empty;
        //}
    }
}
