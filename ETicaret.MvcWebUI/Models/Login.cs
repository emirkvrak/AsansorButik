using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ETicaret.MvcWebUI.Models
{
    public class Login
    {

        [Required(ErrorMessage = "Kullanıcı adı zorunludur.")]
        [DisplayName("Kullanıcı Adı")]
        public string UserNameOrEmail { get; set; }

        [Required(ErrorMessage = "Şifre zorunludur.")]
        [DisplayName("Şifre")]
        public string Password { get; set; }

        [DisplayName("Beni Hatırla")]
        public bool RememberMe { get; set; }

    }
}