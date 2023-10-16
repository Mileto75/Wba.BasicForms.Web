using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Wba.BasicForms.Web.ViewModels
{
    public class AccountLoginViewModel
    {
        [Display(Name = "Gebruikersnaam")]
        [EmailAddress(ErrorMessage = "Graag en email ingeven!")]
        [Required(ErrorMessage = "Email verplicht!")]
        public string Username { get; set; }
        [Display(Name = "Wachtwoord")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Wachtwoord verplicht!")]
        public string Password { get; set; }
        [Display(Name = "Onthoud mij")]
        public bool RememberMe { get; set; }
    }
}
