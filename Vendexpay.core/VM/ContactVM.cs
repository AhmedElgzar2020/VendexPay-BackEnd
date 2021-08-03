using System;
using System.Collections.Generic;
using System.Text;

namespace Vendexpay.Core.VM
{
    public class ContactVM:BaseVM
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public int VendorId { get; set; }
    }
}
