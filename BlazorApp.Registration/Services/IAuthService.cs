using BlazorApp.Registration.Components.Pages;


namespace BlazorApp.Registration.Services;

    public interface IAuthService
    {
        Task<LoginResult> LoginAsync(LoginPage.LoginModel model);
    }

    public class LoginResult
    {
        public bool Success { get; set; }
        public string ErrorMessage { get; set; } = string.Empty;
    }



//namespace LoginApp.Services;

//public interface IAuthService
//{
//    Task<LoginResult> LoginAsync(LoginPage.LoginModel model);
//}

