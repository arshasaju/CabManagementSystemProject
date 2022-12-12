namespace CabManagementSystem.Models.ViewModels
{
    public enum UserType
    {
        Cab_Driver,
        Cab_User

    }

    public class RegisterViewModel
    {
        [Required]

        [StringLength(15)]
        [Display(Name = "First Name")]
        public string? FirstName { get; set; }
        [Required]
        [StringLength(15)]
        [Display(Name = "Last Name")]
        public string? LastName { get; set; }

        [Required]
        public UserType UserTypes { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Email")]
        public string? Email { get; set; }

        [Required]
        [StringLength(25)]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Required]
        [StringLength(25)]
        [Compare(nameof(Password))]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        public string? ConfirmPassword { get; set; }
    }
}
