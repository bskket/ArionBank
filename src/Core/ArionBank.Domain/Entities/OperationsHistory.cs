﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArionBank.Domain.Entities
{
    public class OperationsHistory
    {
        [Key]
        public Guid Id { get; set; }
        public byte[] Image { get; set; }
        [MaxLength(20)]
        public decimal Ammount { get; set; }
        public DateTime Created { get; set; }
    }
}
