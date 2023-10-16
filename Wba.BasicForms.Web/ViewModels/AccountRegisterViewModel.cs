using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Wba.BasicForms.Web.ViewModels
{
    public class AccountRegisterViewModel : AccountLoginViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Herhaal wachtwoord")]
        public string RepeatPassword { get; set; }
        [Display(Name = "Tel")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        //which country are you from
        //show a dropdown list
        [Display(Name = "Land")]
        public int SelectedCountryId { get; set; }
        public IEnumerable<SelectListItem> Countries { get; set; }
    }
}
