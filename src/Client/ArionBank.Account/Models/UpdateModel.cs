﻿using System.ComponentModel.DataAnnotations;

namespace ArionBank.Account.Models
{
    public class UpdateUser
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Patronymic { get; set; }
        [Required]
        public string Login { get; set; }
        public byte[]? Image { get; set; }
    }
}