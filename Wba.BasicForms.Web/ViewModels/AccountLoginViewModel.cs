using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Wba.BasicForms.Web.ViewModels
{
    public class AccountLoginViewModel
    {
        [Display(Name = "Gebruikersnaam")]
        [EmailAddress]
        public string Username { get; set; }
        [Display(Name = "Wachtwoord")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = "Onthoud mij")]
        public bool RememberMe { get; set; }
    }
}
