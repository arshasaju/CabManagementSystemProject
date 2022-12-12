namespace CabManagementSystem.Models.ViewModels
{
    public class BookingViewModel
    {
        
        [Required]
        [Display(Name = "Pick Up")]
        public Location From { get; set; }



        [Required]
        [Display(Name = "Destination")]
        public Location To { get; set; }
        [Required]
        public DateTime Date { get; set; } = DateTime.Now;
        public CarModel CarModel { get; set; }
    }
}
