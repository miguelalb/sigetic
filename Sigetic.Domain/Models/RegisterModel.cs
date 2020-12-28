﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Sigetic.Domain.Models
{
    public class RegisterModel
    {
        
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
