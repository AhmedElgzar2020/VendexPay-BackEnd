using System;
using System.Collections.Generic;
using System.Text;

namespace Vendexpay.Model
{
    public class MobilePayment:BaseEntity
    {
        public string Operator { get; set; }
        public string TermnalNO { get; set; }
        public string IT_AssetsNO { get; set; }
        public string SIM_Number { get; set; }
    }
}
