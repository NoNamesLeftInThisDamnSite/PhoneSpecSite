using Microsoft.EntityFrameworkCore;
using PhoneSpecSite.Data.Base;
using PhoneSpecSite.Data.ViewModels;
using PhoneSpecSite.Models;
namespace PhoneSpecSite.Data.Services
{
    public class PhonesService : EntityBaseReposity<Phones>, IPhonesService
    {
        private readonly AppDbContext _context;
        public PhonesService(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task AddNewPhoneAsync(NewPhonesVM data)
        {
            var newphone = new Phones()
            {
                PhoneName = data.PhoneName,
                PhoneDescription = data.PhoneDescription,
                PhonePictureURL = data.PhonePictureURL,
                PhoneOS = data.PhoneOS,
                PhoneCategory = data.PhoneCategory,
                Battery = data.Battery,
                Id = data.Id,
                CPU = data.CPU,
                Camera = data.Camera,
                GPU = data.GPU,
                Price = data.Price,
                SelfieCamera = data.SelfieCamera,
                Body = data.Body,
                Memory = data.Memory,
                ReleaseDate = data.ReleaseDate,
                Display = data.Display,
                Chipset = data.Chipset,
            };
            await _context.Phones.AddAsync(newphone);
            await _context.SaveChangesAsync();
        }

        public async Task<NewPhoneDropDown> GetNewPhoneDropDownsValues()
        {
            var response = new NewPhoneDropDown();
            response.PhoneCompany = await _context.PhoneCompany.OrderBy(n => n.CompanyName).ToListAsync();
            return response;
        }

        public async Task<Phones> GetPhonesByIdAsync(int id)
        {
            var phoneDetails = await _context.Phones
                 .Include(p => p.PhoneCompany)
                 .FirstOrDefaultAsync(n => n.Id == id);

            return phoneDetails;
        }

        public async Task UpdatePhoneAsync(NewPhonesVM data)
        {
            var dbPhone = await _context.Phones.FirstOrDefaultAsync(n => n.Id == data.Id);
            if (dbPhone != null)
            {

                dbPhone.PhoneName = data.PhoneName;
                dbPhone.PhoneDescription = data.PhoneDescription;
                dbPhone.PhonePictureURL = data.PhonePictureURL;
                dbPhone.PhoneOS = data.PhoneOS;
                dbPhone.PhoneCategory = data.PhoneCategory;
                dbPhone.Battery = data.Battery;
                dbPhone.Id = data.Id;
                dbPhone.CPU = data.CPU;
                dbPhone.Camera = data.Camera;
                dbPhone.GPU = data.GPU;
                dbPhone.Price = data.Price;
                dbPhone.SelfieCamera = data.SelfieCamera;
                dbPhone.Body = data.Body;
                dbPhone.Memory = data.Memory;
                dbPhone.ReleaseDate = data.ReleaseDate;
                dbPhone.Display = data.Display;
                dbPhone.Chipset = data.Chipset;
            };
            await _context.SaveChangesAsync();
        }
    }
        
    
}
