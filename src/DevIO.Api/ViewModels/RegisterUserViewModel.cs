using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DevIO.Api.ViewModels
{
    public class RegisterUserViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "As senhas não conferem")]
        public string ConfirmPassword { get; set; }
    }
    public class LoginUserViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
