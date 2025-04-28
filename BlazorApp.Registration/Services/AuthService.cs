using BlazorApp.Registration.Components.Pages;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorApp.Registration.Services;

public class AuthService : BlazorApp.Registration.Services.IAuthService
{
    private readonly HttpClient _httpClient;

    public AuthService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<LoginResult> LoginAsync(LoginPage.LoginModel model)
    {
        try
        {
            var response = await _httpClient.PostAsJsonAsync("api/auth/login", model);

            if (response.IsSuccessStatusCode)
            {
                return new LoginResult { Success = true };
            }

            return new LoginResult
            {
                Success = false,
                ErrorMessage = "Invalid username or password"
            };
        }
        catch (Exception)
        {
            return new LoginResult
            {
                Success = false,
                ErrorMessage = "Failed to connect to authentication service"
            };
        }
    }

    Task<BlazorApp.Registration.Services.LoginResult> BlazorApp.Registration.Services.IAuthService.LoginAsync(LoginPage.LoginModel model)
    {
        throw new NotImplementedException();
    }
}