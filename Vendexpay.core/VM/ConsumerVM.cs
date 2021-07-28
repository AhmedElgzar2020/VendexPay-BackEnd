using System;
using System.Collections.Generic;
using System.Text;

namespace Vendexpay.Core.VM
{
    public class ConsumerVM:BaseVM
    {
        public int CampignId { get; set; }
        public int VendorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
