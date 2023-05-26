using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace OnlineShoppingProject.ViewModels
{
 
        public class LoginVM
        {
            [Required]
            public string UserName { get; set; }
            [Required]
            [PasswordPropertyText]
            public string Password { get; set; }
        }
    }

