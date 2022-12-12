namespace CabManagementSystem.Models
{
    public enum CarModel
    {
        Auto,
        Sedan,
        CUV,
        SUV
    }
    public enum Location
    {
       
        Kothamangalam,
        Muvattupuzha,
        Kakkanad,
        Edappally,
        Palarivattom,
        Kaloor,
        Kalamassery,
        [Display(Name = "North Railway Station")]
        NorthRailwayStation,
        [Display(Name = "South Railway Station")]
        SouthRailwayStation,
        Thripunithura,
        Thodupuzha
    }

    public class Booking
    {
        public int Id { get; set; }



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