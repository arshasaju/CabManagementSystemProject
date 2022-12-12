using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System.Security.Claims;

namespace CabManagementSystem.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> userManager;

        public UserController(ApplicationDbContext db,UserManager<ApplicationUser>userManager)
        {
            _db = db;
            this.userManager = userManager;
        }



        public IActionResult Index()
        {
            return View(_db.ApplicationUsers.ToList());
        }


        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            var user = await _db.ApplicationUsers.FindAsync(id);
            if (user == null)
                return NotFound();



            return View(new ApplicationUser()
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email
                
            });
        }


        [HttpPost]
        public async Task<IActionResult> Edit(string id, ApplicationUser model)
        {
            var user = await _db.ApplicationUsers.FindAsync(id);
            if (user == null)
                return NotFound();



            if (!ModelState.IsValid)
                return View(model);



            user.FirstName = model.FirstName;
            user.LastName = model.LastName;
            user.Email = model.Email;
            
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }



        public async Task<IActionResult> Delete(string id)
        {
            var user = await _db.Users.FindAsync(id);
            if (user == null)
                return NotFound();



            _db.Users.Remove(user);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult CabRegistration()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CabRegistration(CabRegistrationViewModel model)
        {
            var user = await userManager.GetUserAsync(User);

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            _db.Cabs.Add(new Cab()
            {
                VehicleNumber = model.VehicleNumber,
                VehicleType = model.VehicleType,
                VehicleModel = model.VehicleModel,
               
            });



            await _db.SaveChangesAsync();



            //ModelState.AddModelError("", "An Error Occured!!");
            return View(model);
        }
        [HttpGet]
        public IActionResult CabListing()
        {
            return View(_db.Cabs.ToList());
        }

        public async Task<IActionResult> VehicleDelete(int id)
        {
            var cab = await _db.Cabs.FindAsync(id);
            if (cab == null)
                return NotFound();
            _db.Cabs.Remove(cab);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(CabListing));
        }

    }
}

