using System.Web.Http;

namespace AngularJsDemos.Controllers
{
    [Authorize]
    public class SecureDataController : ApiController
    {
        public IHttpActionResult Get()
        {
            return Ok(new { secureData = "You have to be authenticated to access this!" });
        }
    }
}
