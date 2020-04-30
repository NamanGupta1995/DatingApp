using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.API.DTOs
{
    public class RegisterUserDto
    {
        [Required]
        public string userName { set; get; }

        [Required]
        [StringLength(8,MinimumLength = 4, ErrorMessage = "Password must be between 4 to 8 characters")]
        public string password { set; get; }
    }
}
