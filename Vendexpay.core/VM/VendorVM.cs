using System;
using System.Collections.Generic;
using System.Text;

namespace Vendexpay.Core.VM
{
    public class VendorVM:BaseVM
    {
        public string Name { get; set; }
        public int? ParentVendorId { get; set; }
        public VendorVM ParentVendor { get; set; }
        public ICollection<ManagerVM> Managers { get; set; }
        public ICollection<ContractVM> Contracts { get; set; }

    }
}
