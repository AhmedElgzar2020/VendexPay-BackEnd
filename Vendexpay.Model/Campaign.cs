using System;
using System.Collections.Generic;
using System.Text;

namespace Vendexpay.Model
{
    public class Campaign:BaseEntity
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int VendorId { get; set; }

        public Vendor Vendor { get; set; }
        public int MachineId { get; set; }
    }
}
