using System;
using System.Collections.Generic;
using System.Text;

namespace Vendexpay.Model
{
    public class Balaiya:BaseEntity
    {
        public int DocumentId { get; set; }
        public Document Document { get; set; }
        public int TradingNo { get; set; }
        public DateTime ExpiryDate { get; set; }
        public DateTime PrintDate { get; set; }
        public string Type { get; set; }
    }
}
