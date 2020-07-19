using AuthenticationJWT.API.Models;
using AuthenticationJWT.API.Providers;
using AuthenticationJWT.Application;
using AuthenticationJWT.Data;
using System.Net;
using System.Web.Http;

namespace AuthenticationJWT.API.Controllers
{
    [RoutePrefix("User")]
    [AllowAnonymous]
    public class UsersController : BaseController
    {
        private UserApp _user;


        public UsersController()
        {
            _user = new UserApp();
        }

        [HttpPost]
        [Route("Login")]
        public IHttpActionResult Login(Login login)
        {
            if (login == null)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var res = _user.ValidateUser(login.Username, login.Password);

            var tokenToReturn = new TokenToReturn
            {
                Token = "",
                Message = ""
            };

            if (res.Success)
            {

                var user = (User)res.Object;

                var token = TokenGenerator.GenerateTokenJwt(user.ID, user.UserName);

                tokenToReturn.Token = token;
                tokenToReturn.Message = "Good";

                return Ok(tokenToReturn);
            }
            else
            {
                return BadRequest(tokenToReturn.Message = "Wrong credentials");
            }
        }
    }
}