using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace FinalProject.Controllers
{

    public class BaseController : ControllerBase
    {
        protected string GetUserAuthId()
        {
            if(User.Claims != null)
            {
                var userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value;
                if (string.IsNullOrEmpty(userId))
                {
                    return "none";
                }
                else
                {
                    return userId;
                }
            }

            return "none";
            
            
        }
    }
}
