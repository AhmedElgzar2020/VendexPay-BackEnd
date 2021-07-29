using System;
using System.Collections.Generic;
using System.Text;

namespace Vendexpay.Core.VM
{
    public class CampaignVM:BaseVM
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int VendorId { get; set; }

        public int MachineId { get; set; }
    }
}
