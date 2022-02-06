using PhoneSpecSite.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace PhoneSpecSite.Models
{
    public class PhoneCompany:IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Logo")]
        [Required(ErrorMessage ="Logo Is Required")]
        public string Logo { get; set; }
        [Display(Name = "Company")]
        [Required(ErrorMessage = "Company Name Is Required")]
        public string CompanyName { get; set; }
        [Display(Name = "CompanyDescription")]
        [Required(ErrorMessage = "Company Description Is Required")]
        public string CompanyDescription { get; set; }

        //Relationships

        public List<Phones> Phones { get; set; }
    
}
}
