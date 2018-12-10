using System.Web.Http;
using WebApiStart.Application.Interfaces;
using WebApiStart.Application.ViewModels;

namespace WebApiStart.Controllers
{
    public class UserController : ApiController
    {
        private IUserAppService _userService;

        public UserController(IUserAppService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        [AllowAnonymous]
        public IHttpActionResult Login(LoginViewModel model)
        {
            var user = _userService.Login(model.UserName, model.Password);
            if (user != null)
                return Ok(JwtManager.GenerateToken(user.UserName));

            return this.Unauthorized();
        }
    }
}