using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace CabManagementSystem.Models.ViewModels
{
    public class CabRegistrationViewModel
    {
        [Display(Name ="Vehicle Number")]
        [StringLength(10)]
        public string VehicleNumber { get; set; }
        [Display(Name = "Type")]
        public VehicleType VehicleType { get; set; }
        public string VehicleModel { get; set; }

        public IEnumerable<ApplicationUser>? ApplicationUsers { get; set; }

    }
}
