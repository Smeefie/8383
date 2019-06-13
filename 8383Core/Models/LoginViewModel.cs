using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace _8383Core.Models
{
    public class LoginViewModel
    {
        [Required]
        public string username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string password { get; set; }

        public string firstname { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }

        public LoginViewModel(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public LoginViewModel(string username, string password, string firstname, string lastname, string email)
        {
            this.username = username;
            this.password = password;
            this.firstname = firstname;
            this.lastname = lastname;
            this.email = email;
        }

        public LoginViewModel()
        {

        }
    }
}
