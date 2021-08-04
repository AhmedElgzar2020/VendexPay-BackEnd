using System;
using System.Collections.Generic;
using System.Text;

namespace Vendexpay.Model
{
    public class Document:BaseEntity
    {
        public int VendorId { get; set; }
        public Vendor Vendor { get; set; }
        public CR CR { get; set; }
        public Balaiya Balaiya { get; set; }
        public ComputerCard ComputerCard { get; set; }
        public ICollection<ComputerCardAuthorizer> computerCardAuthorizers { get; set; }
    }
}
