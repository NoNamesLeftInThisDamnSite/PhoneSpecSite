using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace PhoneSpecSite.Models
{
    //nasledqvame properitata na identity user 
    public class ApplicationUser:IdentityUser
    {
        [Display(Name="Full name")]
        public string FullName { get; set; }
    }
}
