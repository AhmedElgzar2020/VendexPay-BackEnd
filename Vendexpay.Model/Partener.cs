using System;
using System.Collections.Generic;
using System.Text;
using Vendexpay.Model.LookUps;

namespace Vendexpay.Model
{
    public class Partener:BaseEntity
    {
        public int VendorId { get; set; }
        public Vendor Vendor { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AccountName { get; set; }
        public string Email { get; set; }
        public string Title { get; set; }
        public string Phone { get; set; }
        public string OtherPhone { get; set; }
        public string Mobile { get; set; }
        public string Assistant { get; set; }
        public string AssistantPhone { get; set; }
        public string SIC_Code { get; set; }
        public DateTime BirthDate { get; set; }

        public int CityId { get; set; }
        public City City { get; set; }
        public string Street { get; set; }
        public string BillingCode { get; set; }
        public string Note { get; set; }
        public string ImgPath { get; set; }

    }
}
