using System.ComponentModel.DataAnnotations;

namespace Tasarim.Models
{
    public class LoginViewModel
    {

        [Required(ErrorMessage = "E-Posta girmek zorunludur")]
        public string Email { get; set; }

     //   [DataType(DataType.Password)]
        [Required(ErrorMessage = "Şifre girmek zorunludur")]
        [MinLength(6, ErrorMessage = "Şifreniz En Az 6 karakter uzunluğunda olmalıdır")] 
        public string Password { get; set; }
    }
}
