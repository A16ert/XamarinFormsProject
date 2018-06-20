using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using XamarinProjectSimple.Services.Authorization;

//[assembly: Dependency(typeof(AuthService))]

namespace XamarinProjectSimple.Services.Authorization
{
    public class AuthService : IAuthService
    {
        public bool IsAuthorized => false;
    }
}
