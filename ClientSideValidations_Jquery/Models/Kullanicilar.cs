using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClientSideValidations_Jquery.Models
{
    public class Kullanicilar
    {
        [Display(Name = "İsim")]
        [Required(ErrorMessage = "Lütfen İsim Giriniz!")]
        public string isim { get; set; }

        [Display(Name = "Soyisim")]
        [Required(ErrorMessage = "Lütfen Soyisim Giriniz!")]
        public string soyisim { get; set; }

        [Display(Name = "Yaş")]
        [Required(ErrorMessage = "Lütfen Yaş Giriniz!")]
        [Range(18, 65, ErrorMessage = "Yaşınız 18 İle 65 Arasında Olmak Zorundadır!")]
        public string yas { get; set; }

        [Display(Name = "Maaş")]
        [Required(ErrorMessage = "Lütfen Maaş Giriniz!")]
        public string mass { get; set; }

        [Display(Name = "Doğum Tarihi")]
        [Required(ErrorMessage = "Lütfen Doğrum Tarihi Giriniz!")]
        public string dogumtarihi { get; set; }
    }
}