using System;
using System.Collections.Generic;
using System.Text;

namespace Vendexpay.Core.VM
{
    public class BalaiyaVM:BaseVM
    {
        public int DocumentId { get; set; }
        public int TradingNo { get; set; }
        public DateTime ExpiryDate { get; set; }
        public DateTime PrintDate { get; set; }
        public string Type { get; set; }
    }
}
