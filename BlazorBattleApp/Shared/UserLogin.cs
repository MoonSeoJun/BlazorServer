using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorBattleApp.Shared
{
    public class UserLogin
    {
        [Required(ErrorMessage = "Pleaze enter a Username.")]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
