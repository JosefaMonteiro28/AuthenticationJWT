using System.Web.Http;
using System.Web.Http.Cors;

namespace AuthenticationJWT.API.Controllers
{
    [Authorize]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class BaseController: ApiController 
    {
       
    }
}