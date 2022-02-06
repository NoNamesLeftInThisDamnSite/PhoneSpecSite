using Microsoft.EntityFrameworkCore;
using PhoneSpecSite.Data.Base;
using PhoneSpecSite.Models;

namespace PhoneSpecSite.Data.Services
{
    public class PhoneCompanyService :EntityBaseReposity<PhoneCompany>, IPhoneComanyService
    {
        public PhoneCompanyService(AppDbContext context) : base(context) { }
       
    }
}
