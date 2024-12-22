using System.ComponentModel.DataAnnotations;

namespace Tasarim.Models
{
    public class RegisterViewModel
    {

        [Required(ErrorMessage = "E-Posta girmek zorunludur")]
        public string Email { get; set; }

        //   [DataType(DataType.Password)]
        [Required(ErrorMessage = "Şifre girmek zorunludur")]
        [MinLength(6, ErrorMessage = "Şifreniz En Az 6 karakter uzunluğunda olmalıdır")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Şifreyi yeniden giriniz")]
        [MinLength(6, ErrorMessage = "Şifreniz En Az 6 karakter uzunluğunda olmalıdır")]
        [Compare(nameof(Password))]
        public string RePassword { get; set; }
    }
}
