//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tgnet.FootChat.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Trade
    {
        public string tradeNo { get; set; }
        public long uid { get; set; }
        public bool isPaied { get; set; }
        public Tgnet.FootChat.Trade.TradeType type { get; set; }
        public System.DateTime created { get; set; }
        public Nullable<System.DateTime> paied { get; set; }
        public decimal total { get; set; }
        public bool isDelete { get; set; }
        public string extension { get; set; }
        public bool buySuccess { get; set; }
        public Nullable<long> seller { get; set; }
        public Tgnet.FootChat.Trade.Payment payment { get; set; }
        public Nullable<System.DateTime> successed { get; set; }
    }
}
