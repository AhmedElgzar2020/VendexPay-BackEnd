using System;
using System.Collections.Generic;
using System.Text;

namespace Vendexpay.Core.VM
{
    public class OfficeVM:BaseVM
    {
        public int MarchantId { get; set; }
        public string ZoneNo { get; set; }
        public string StreetNo { get; set; }
        public string BuildingNo { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string WebSite { get; set; }
        public int BuildingTypeid { get; set; }
    }
}
