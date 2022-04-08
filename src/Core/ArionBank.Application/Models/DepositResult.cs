﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArionBank.Application.Models
{
    public class DepositResult
    {
        public bool Successful { get; set; }
        public IEnumerable<string> Errors { get; set; }
    }
}
