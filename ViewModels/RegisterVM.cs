namespace ARD.ViewModels
{
    public class RegisterVM
    {
        [Required]
        public string? Nickname { get; set;}
        [Required]
        [DataType(DataType.EmailAddress)]
        public string? Email { get;}
        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set;}

        [Compare("Password", ErrorMessage = "Passwords must match")]
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        public string? ConfirmPassword { get; set;}
    }
}