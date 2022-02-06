using PhoneSpecSite.Models;

namespace PhoneSpecSite.Data.ViewModels
{
    public class NewPhoneDropDown
    {
        public NewPhoneDropDown()
        {
            PhoneCategory = new List<PhoneCategory>();
            PhoneCompany = new List<PhoneCompany>();
            PhoneOS = new List<PhoneOS>();

        }
        public List<PhoneCompany> PhoneCompany { get; set; }
        public List<PhoneCategory> PhoneCategory { get; set; }
        public List<PhoneOS> PhoneOS { get; set; }
    }
}
