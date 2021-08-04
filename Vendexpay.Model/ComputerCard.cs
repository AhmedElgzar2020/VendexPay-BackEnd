using System;
using System.Collections.Generic;
using System.Text;

namespace Vendexpay.Model
{
    public class ComputerCard:BaseEntity
    {
        public int DocumentId { get; set; }
        public Document Document { get; set; }

        public int CardNo { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string Sector { get; set; }
    }
}
