using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace FinalProject.Controllers
{

    public class BaseController : ControllerBase
    {
        protected string GetUserAuthId()
        {
            var userNameClaim = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier);
            if (userNameClaim != null)
            {
                return userNameClaim.Value;
            }
            return "2";
        }

    }
}

