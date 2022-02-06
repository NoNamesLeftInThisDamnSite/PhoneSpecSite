using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PhoneSpecSite.Data;
using PhoneSpecSite.Data.Services;
using PhoneSpecSite.Models;

namespace PhoneSpecSite.Controllers
{

    public class PhonesController : Controller
    {
        private readonly IPhonesService _service;
        public PhonesController(IPhonesService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var allPhones = await _service.GetAllAsync(n=> n.PhoneCompany);
            return View(allPhones);
        }

        public async Task<IActionResult> Filter(string searchString)
        {
            var allPhones = await _service.GetAllAsync(n => n.PhoneCompany);

            if(!string.IsNullOrEmpty(searchString))
            {
                var filteredResult = allPhones.Where(n=>n.PhoneName.Contains(searchString)|| n.PhoneDescription.Contains(searchString)).ToList();
                return View("Index",filteredResult);
            }
            return View("Index",allPhones);
        } 


        //Get: Phones/Create
        public async Task<IActionResult> Create()
        {
            var phoneDropDownData = await _service.GetNewPhoneDropDownsValues();
            ViewBag.Company = new SelectList(phoneDropDownData.PhoneCompany,"Id","CompanyName");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(NewPhonesVM phone)
        {
            if(!ModelState.IsValid)
            {
                var phoneDropDownData = await _service.GetNewPhoneDropDownsValues();
                ViewBag.Company = new SelectList(phoneDropDownData.PhoneCompany, "Id", "CompanyName");
                return View(phone);
            }
            await _service.AddNewPhoneAsync(phone);
            return RedirectToAction(nameof(Index));
        }
        //Get:Phones/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var phoneDetails = await _service.GetPhonesByIdAsync(id);
            return View(phoneDetails);
        }

        //Get: Phones/Edit
        public async Task<IActionResult> Edit(int id)
        {
            var phoneDetails = await _service.GetPhonesByIdAsync(id);
            if (phoneDetails == null) return View("NotFound");
            
            var response= new NewPhonesVM()
            {
                PhoneID = phoneDetails.PhoneId,
                PhoneDescription = phoneDetails.PhoneDescription,
                PhonePictureURL = phoneDetails.PhonePictureURL,
                PhoneOS = phoneDetails.PhoneOS,
                PhoneCategory = phoneDetails.PhoneCategory,
                Battery = phoneDetails.Battery,
                Id = phoneDetails.Id,
                CPU = phoneDetails.CPU,
                Camera = phoneDetails.Camera,
                GPU = phoneDetails.GPU,
                Price = phoneDetails.Price,
                SelfieCamera = phoneDetails.SelfieCamera,
                Body = phoneDetails.Body,
                Memory = phoneDetails.Memory,
                ReleaseDate = phoneDetails.ReleaseDate,
                Display = phoneDetails.Display,
                Chipset = phoneDetails.Chipset,
            };
            var phoneDropDownData = await _service.GetNewPhoneDropDownsValues();
            ViewBag.Company = new SelectList(phoneDropDownData.PhoneCompany, "Id", "CompanyName");
            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int PhoneId,NewPhonesVM phone )
        {
            if (PhoneId != phone.PhoneID) return View("Not Found");
            if (!ModelState.IsValid)
            {
                var phoneDropDownData = await _service.GetNewPhoneDropDownsValues();
                ViewBag.Company = new SelectList(phoneDropDownData.PhoneCompany, "Id", "CompanyName");
                return View(phone);
            }
            await _service.UpdatePhoneAsync(phone);
            return RedirectToAction(nameof(Index));
        }
        //Get : Phones/Delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var phoneDetails = await _service.GetPhonesByIdAsync(id);
            if (phoneDetails == null) return View("NotFound");
            return View(phoneDetails);
        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var phoneDetails = await _service.GetPhonesByIdAsync(id);
            if (phoneDetails == null) return View("NotFound");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
