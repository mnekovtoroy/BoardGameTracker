using Microsoft.AspNetCore.Mvc;

namespace BGTWebApi.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public string Test1()
        {
            return "test1";
        }

        [HttpGet]
        public string Test2()
        {
            return "test2";
        }
    }
}