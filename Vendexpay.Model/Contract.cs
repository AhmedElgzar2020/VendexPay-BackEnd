using System;
using System.Collections.Generic;
using System.Text;

namespace Vendexpay.Model
{
    public class Contract:BaseEntity
    {
        public string ContractNo { get; set; }
        public string ClientNO { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public DateTime? RenewalDate { get; set; }
        public DateTime? RenewalExpireDate { get; set; }
        public string Email { get; set; }
        public string WebSite { get; set; }
    }
}
