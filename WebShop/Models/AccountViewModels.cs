namespace WebShop.Models
{
    public class RegisterUserViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string ImageBase64 { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

    }

    public class LoginViewModel
    {
        /// <summary>
        /// Email
        /// </summary>
        /// <example>expample@gmail.com</example>
        public string Email { get; set; }
        /// <summary>
        /// Password
        /// </summary>
        /// <example>qwerty123</example>
        public string Password { get; set; }
    }
}