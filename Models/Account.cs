using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpFinal_PasswordManager.Models
{
    public class Account
    {
        public int AccountId { get; set; }

        [Required(ErrorMessage = "Please enter the name of the website/resource.")]
        public String Resource { get; set; }
        public String Link { get; set; }

        [Required(ErrorMessage = "Please enter the email associated with this account.")]
        public String Email { get; set; }

        [Required(ErrorMessage = "Please enter the username associated with this account.")]
        public String Username { get; set; }

        [Required(ErrorMessage = "Please enter the password associated with this account.")]
        public String Password { get; set; }

    }
}
