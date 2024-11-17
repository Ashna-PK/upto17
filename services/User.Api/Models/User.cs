﻿using System.ComponentModel.DataAnnotations;

namespace User.Api.Models
{
    public class UserClass
    {
        [Key]
        public int Id { get; set; }       
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; }= string.Empty;
        public string Address { get; set; } = string.Empty;
        public string PhoneNo { get; set; } = string.Empty;
    }
}
