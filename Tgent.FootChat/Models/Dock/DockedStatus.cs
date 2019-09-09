using System;
using System.Collections.Generic;
using System.Text;

namespace Tgnet.FootChat.Models.Dock
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
