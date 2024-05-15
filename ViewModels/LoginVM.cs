namespace ARD.ViewModels
{
    public class LoginVM
    {  
        [Required]
        public string? Nickname { get; set; }

        [DataType(DataType.Password)]
        [Required]
        public string? Password { get; set;}

        [Display(Name = "Remember Me")]
        public bool RememberMe { get; set; }
    }
}