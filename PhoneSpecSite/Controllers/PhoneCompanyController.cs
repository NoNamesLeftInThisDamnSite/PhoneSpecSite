using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PhoneSpecSite.Data;
using PhoneSpecSite.Data.Services;
using PhoneSpecSite.Models;
using System.Threading.Tasks;

namespace PhoneSpecSite.Controllers
{
    public class PhoneCompanyController : Controller
    {
        private readonly IPhoneComanyService _service;
        public PhoneCompanyController(IPhoneComanyService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var allPhoneCompany= await _service.GetAllAsync();
            return View(allPhoneCompany);
        }
        //Get : PhoneCompany/Create
        public  IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Logo,CompanyName,CompanyDescription")]PhoneCompany company)
        {
            if (!ModelState.IsValid)
            {
                return View(company);
            }
            await _service.AddAsync(company);
            return RedirectToAction(nameof(Index));
        }

        //Get:PhoneCompany/Details
        public async Task<IActionResult> Details(int id)
        {
            var PhoneCompanyDetails = await _service.GetByIdAsync(id);

             if (PhoneCompanyDetails == null) return View("NotFound");
             return View(PhoneCompanyDetails);
        }

        //Get : PhoneCompany/Edit
        public async Task <IActionResult> Edit(int id)
        {
            var PhoneCompanyDetails = await _service.GetByIdAsync(id);
            if (PhoneCompanyDetails == null) return View("NotFound");
            return View(PhoneCompanyDetails);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id,[Bind("Id,Logo,CompanyName,CompanyDescription")] PhoneCompany company)
        {
            if (!ModelState.IsValid)
            {
                return View(company);
            }
            await _service.UpdateAsync(id,company);
            return RedirectToAction(nameof(Index));
        }

        //Get : PhoneCompany/Delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var PhoneCompanyDetails = await _service.GetByIdAsync(id);
            if (PhoneCompanyDetails == null) return View("NotFound");
            return View(PhoneCompanyDetails);
        }
        [HttpPost,ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var PhoneCompanyDetails = await _service.GetByIdAsync(id);
            if (PhoneCompanyDetails == null) return View("NotFound");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
