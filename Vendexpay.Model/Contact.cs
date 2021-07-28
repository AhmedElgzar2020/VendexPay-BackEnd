using System;
using System.Collections.Generic;
using System.Text;

namespace Vendexpay.Model
{
    public class Contact:BaseEntity
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
    }
}
