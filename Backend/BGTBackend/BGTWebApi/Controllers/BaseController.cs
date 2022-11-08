using Microsoft.AspNetCore.Mvc;

namespace BGTWebApi.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class BaseController : ControllerBase
    {
        internal Guid UserId()
        {
            return Guid.NewGuid(); // Fix later
        }
    }
}
