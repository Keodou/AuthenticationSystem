namespace AuthenticationSystem.WebApi.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class UserDTO
    {
        /// <summary>
        /// Property for user login.
        /// </summary>
        public required string Login { get; set; }

        /// <summary>
        /// Property for user password.
        /// </summary>
        public required string Password { get; set; }
    }
}
