using PhoneSpecSite.Data;
using PhoneSpecSite.Data.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PhoneSpecSite.Models
{
    public class Phones:IEntityBase
    {
        [Key]
        public int PhoneId { get; set; }
        public string PhoneName { get; set; }
        public string PhoneDescription { get; set; }
        public string ReleaseDate { get; set; }
        public PhoneCategory PhoneCategory { get; set; }
        public string Body { get; set; }
        public string Display { get; set; }
        public PhoneOS PhoneOS { get; set; }
        public string Chipset { get; set; }
        public string CPU { get; set; }
        public string GPU { get; set; }
        public string Memory { get; set; }
        public string Camera { get; set; }
        public string SelfieCamera { get; set; }
        public string Battery { get; set; }
        public string Price { get; set; }
        public string PhonePictureURL { get; set; }

        //Relationship with PhoneCompany
        public int Id { get; set; }
        [ForeignKey("Id")]
        public PhoneCompany PhoneCompany { get; set; }
    }
}
