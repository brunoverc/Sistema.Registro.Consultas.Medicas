using SRCM.Services.AppService.DTOs.Requests;
using SRCM.Services.AppService.DTOs.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRCM.Services.AppService.Interfaces
{
    public interface IIdentityServices
    {
        Task<UserRegisteredResponse> RegisterUser(UserRegisteredRequest request);

        Task<UserLoginResponse> Login(UserLoginRequest request);
    }
}
