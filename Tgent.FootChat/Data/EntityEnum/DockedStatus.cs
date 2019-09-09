using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tgnet.FootChat.Docked
{
    public enum DockedStatus : byte
    {
        None = 0,
        Apply = 1,
        Pass = 2,
        UnPass = 3,
    }

    public enum DockedState : byte
    {
        None = 0,
        Requested = 1,
        Success = 2,

    }
}
