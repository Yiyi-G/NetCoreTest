using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tgnet.FootChat.Pay
{
    public enum SceneKinds
    {
        Wap = 0,
        IOS = 1,
        Android = 2,
    }

    public enum PayFromKinds : byte
    {
        None = 0,
        PC = 1,

        Mobile = 2,
        Wap = 3,
    }
}
