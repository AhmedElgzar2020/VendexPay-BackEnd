using System;
using System.Collections.Generic;
using System.Text;

namespace Vendexpay.Core.VM
{
    public class MarchantVM:BaseVM
    {
        public int VendorId { get; set; }

        public string UserName { get; set; }
        public string Name { get; set; }
        public string IdNo { get; set; }
        public string CompanyName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string ZipCode { get; set; }
        public string Logo { get; set; }
        public int CityId { get; set; }
        //public City City { get; set; }
        public int CompanyTypeId { get; set; }
        //public CompanyType CompanyType { get; set; }
        //public ICollection<Office> Offices { get; set; }
        //public ICollection<Contact> Contacts { get; set; }
        public VendorVM Vendor { get; set; }
    }
}
