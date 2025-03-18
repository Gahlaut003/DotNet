using Microsoft.AspNetCore.Mvc;
using CommonComponentBL.Services;
//C: \Users\Abhishek\Documents\learning\C#\repos\Utility_v1\CommonComponentBL\Services\UserAuthService.cs
namespace CommonComponent.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserAuth
    {
        private readonly UserAuthService userAuthService;
        [HttpDelete(Name = "userauthneticate")]
        public string userauthneticate(string username,string password) {

            userAuthService.userauthneticate(username, password);

            return "OK";
        }
    }
}
