using PhoneSpecSite.Data.Base;
using PhoneSpecSite.Data.ViewModels;
using PhoneSpecSite.Models;

namespace PhoneSpecSite.Data.Services
{
    public interface IPhonesService:IEntityBaseRepository<Phones>
    {
     Task<Phones> GetPhonesByIdAsync(int id);
        Task<NewPhoneDropDown> GetNewPhoneDropDownsValues();
        Task AddNewPhoneAsync(NewPhonesVM data);

        Task UpdatePhoneAsync(NewPhonesVM data);
    }
}
