using System;
using System.Collections.Generic;
using System.Text;

namespace Vendexpay.Model
{
     public class CR:BaseEntity
    {
        public int DocumentId { get; set; }
        public Document Document { get; set; }
        public int CR_No { get; set; }
        public int TaxId_No { get; set; }
        public decimal QAR { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public DateTime PrintDate { get; set; }
        public string LegalFirm { get; set; }
        public string WebSite { get; set; }
    }
}
