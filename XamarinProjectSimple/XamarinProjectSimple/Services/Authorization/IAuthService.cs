using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinProjectSimple.Services.Authorization
{
    public interface IAuthService
    {
        bool IsAuthorized { get; }
    }
}
