using System;
using System.Collections.Generic;
using System.Text;

namespace Vendexpay.Model
{
    public class Vendor:BaseEntity
    {
        public string Name { get; set; }
        public int? ParentVendorId { get; set; }
        public Vendor ParentVendor { get; set; }
        public ICollection<Manager> Managers { get; set; }
        public ICollection<Contract> Contracts { get; set; }
        public ICollection<Contact> Contacts { get; set; }
        public Marchant Marchant { get; set; }
        public Document Document { get; set; }

    }
}
