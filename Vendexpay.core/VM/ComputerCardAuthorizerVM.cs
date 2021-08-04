using System;
using System.Collections.Generic;
using System.Text;

namespace Vendexpay.Core.VM
{
    public class ComputerCardAuthorizerVM:BaseVM
    {
        public int DocumentId { get; set; }
        public string Name { get; set; }
        public string title { get; set; }
        public string mobile { get; set; }
        public string qId { get; set; }
    }
}
