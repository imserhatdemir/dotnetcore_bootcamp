using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Bootcamp.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage ="Lütfen Kullanıcı Adını girin")]
        public string username { get; set; }
        [Required(ErrorMessage = "Lütfen Şifrenizi girin")]
        public string password { get; set; }
    }
}
