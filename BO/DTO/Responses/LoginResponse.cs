namespace BLL.Services
{
    public class LoginResponse
    {
        //JWT
        public string AccessToken { get; set; }
        public string Username { get; set; }

        public LoginResponse()
        {
        }
    }
}