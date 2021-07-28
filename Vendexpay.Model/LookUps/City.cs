using System;
using System.Collections.Generic;
using System.Text;

namespace Vendexpay.Model.LookUps
{
    public class City:BaseEntity
    {
        public string Name { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
    }
}
