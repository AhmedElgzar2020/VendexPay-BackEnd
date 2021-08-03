using System;
using System.Collections.Generic;
using System.Text;

namespace Vendexpay.Model
{
    public class POS:BaseEntity
    {
        public string ModelNO { get; set; }
        public string TermnalNO { get; set; }
        public string IT_AssetNO { get; set; }
        public string SIM_NO { get; set; }
        public string BankName { get; set; }
        public string BankAccountNO { get; set; }
    }
}
