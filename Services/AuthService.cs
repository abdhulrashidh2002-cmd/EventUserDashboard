using EventUserDashboard.Models;
using Microsoft.JSInterop;

namespace EventUserDashboard.Services
{
   
    

    public class AuthService
    {
        private readonly IJSRuntime _js;

        public User? CurrentUser { get; private set; }

        public AuthService(IJSRuntime js)
        {
            _js = js;
        }

        public async Task<User?> GetCurrentUserAsync()
        {
            User? user = null;

            try
            {
        
                user = await _js.InvokeAsync<User>("firebaseAuth.getUser");
            }
            catch (JSException jsEx)
            {
                Console.WriteLine($"JSInterop Error: {jsEx.Message}");
                return null;
            }

            if (user == null)
                return null;
            try
            {
                var role = await _js.InvokeAsync<string>("firebaseAuth.getUserRole", user.Uid);
                user.Role = role;
            }
            catch (JSException jsEx)
            {
                Console.WriteLine($"JSInterop Error while getting role: {jsEx.Message}");
                user.Role = "Unknown"; // fallback
            }

            CurrentUser = user;
            return user;
        }
    }
}
