using System;
using System.Collections.Generic;
using System.Text;

namespace Vendexpay.Core.VM
{
     public class ComputerCardVM : BaseVM
    {
        public int DocumentId { get; set; }

        public int CardNo { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string Sector { get; set; }
    }
}
