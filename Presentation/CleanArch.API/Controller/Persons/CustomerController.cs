using Microsoft.AspNetCore.Mvc;

namespace CleanArch.API.Controller
{
    [ApiController]
    [Route("[Controller]")]
    public class CustomerController : ControllerBase
    {
        public string Get()
        {
            return "Start Api Developing";
        }
    }
}
