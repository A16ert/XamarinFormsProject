using XamarinProjectSimple.Services.Authorization;

[assembly: Xamarin.Forms.Dependency(typeof(AuthService))]
namespace XamarinProjectSimple.Services.Authorization
{
    public class AuthService : IAuthService
    {
        public bool IsAuthorized => false;
    }
}
