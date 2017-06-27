using AngularJsDemos.Models.APIAuthentication;
using System.Web.Http;

namespace AngularJsDemos.Controllers
{

    public class AuthenticationController : ApiController
    {
        
        //[Route("authenticate")]
        public IHttpActionResult Post(AuthenticateViewModel viewModel)
        {
            /* REPLACE THIS WITH REAL AUTHENTICATION
            ----------------------------------------------*/
            if (!(viewModel.Username == "test" && viewModel.Password == "test"))
            {
                return Ok(new { success = false, message = "User code or password is incorrect" });
            }

            return Ok(new { success = true });
        }

        //public IHttpActionResult Get()
        //{
        //    return Ok(new { secureData = "You have to be authenticated to access this!" });
        //}
    }
}
