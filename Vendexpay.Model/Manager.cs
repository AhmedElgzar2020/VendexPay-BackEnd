using System;
using System.Collections.Generic;
using System.Text;

namespace Vendexpay.Model
{
    public class Manager:BaseEntity
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string QId { get; set; }
        public string Mobile { get; set; }
        public int VendorId { get; set; }
        public Vendor Vendor { get; set; }
    }
}
