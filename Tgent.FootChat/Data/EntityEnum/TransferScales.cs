using System;
using System.Collections.Generic;
using System.Text;

namespace Tgnet.FootChat.FootPrint
{
    public enum TransferScales : byte
    {
        没有信息 = 0,
        有单位无联系人 = 1,
        有单位有人有号码 = 2,
        有单位有人无号码 = 3,
    }
}
