using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;

namespace Tgnet.FootChat.Model
{
    [MessageContract]
    public class UserFaceUrls
    {
        [MessageHeader]
        public string BigVirtualPath { get; set; }
        [MessageHeader]
        public string SmallVirtualPath { get; set; }
    }
}