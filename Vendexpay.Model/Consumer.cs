using System;
using System.Collections.Generic;
using System.Text;

namespace Vendexpay.Model
{
    public class Consumer:BaseEntity
    {
        public int CampignId { get; set; }
        public int VendorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Vendor Vendor { get; set; }
        public Campaign Campaign { get; set; }
    }
}
