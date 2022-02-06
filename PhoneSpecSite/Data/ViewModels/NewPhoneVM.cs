using PhoneSpecSite.Data;
using PhoneSpecSite.Data.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PhoneSpecSite.Models
{
    public class NewPhonesVM
    {
        public int PhoneID { get; set; }
        [Display(Name = "Phone Name")]
        [Required(ErrorMessage ="Name is required")]
        public string PhoneName { get; set; }
        [Display(Name = "Description")]
        [Required(ErrorMessage = "Description is required")]
        public string PhoneDescription { get; set; }
        [Display(Name = "Release Date")]
        [Required(ErrorMessage = "Date is required")]
        public string ReleaseDate { get; set; }
        [Display(Name = "Select a category ")]
        [Required(ErrorMessage = "category is required")]
        public PhoneCategory PhoneCategory { get; set; }
        [Display(Name = "Dimensions")]
        [Required(ErrorMessage = "Body is required")]
        public string Body { get; set; }
        [Display(Name = "Display")]
        [Required(ErrorMessage = "Display info is required")]
        public string Display { get; set; }
        [Display(Name = "Select OS for the phone")]
        [Required(ErrorMessage = "OS is required")]
        public PhoneOS PhoneOS { get; set; }
        [Display(Name = "Chipset Name")]
        [Required(ErrorMessage = "Chipset is required")]
        public string Chipset { get; set; }
        [Display(Name = "CPU Name")]
        [Required(ErrorMessage = "CPU is required")]
        public string CPU { get; set; }
        [Display(Name = "GPU Name")]
        [Required(ErrorMessage = "GPU is required")]
        public string GPU { get; set; }
        [Display(Name = "Memory Type")]
        [Required(ErrorMessage = "Memory is required")]
        public string Memory { get; set; }
        [Display(Name = "Camera Type")]
        [Required(ErrorMessage = "Camera is required")]
        public string Camera { get; set; }
        [Display(Name = "Selfie Camera")]
        [Required(ErrorMessage = "SelfieCamera is required")]
        public string SelfieCamera { get; set; }
        [Display(Name = "Battery Size")]
        [Required(ErrorMessage = "Battery is required")]
        public string Battery { get; set; }
        [Display(Name = "add Price")]
        [Required(ErrorMessage = "Price is required")]
        public string Price { get; set; }
        [Display(Name = "Phone Picture link")]
        [Required(ErrorMessage = "Picture is required")]
        public string PhonePictureURL { get; set; }

        //Relationship with PhoneCompany
        [Display(Name = "Select Company")]
        [Required(ErrorMessage = "Company is required")]
        public int Id { get; set; }
       
    }
}
