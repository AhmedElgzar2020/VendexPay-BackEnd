﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Vendexpay.Core.VM
{
    public class BaseVM
    {
        public int Id { get; set; }
        public int createdBy { get; set; }
        public int? modefiedBy { get; set; }

        public DateTime createdDate { get; set; }
        public DateTime? modefiedDate { get; set; }
    }
}
