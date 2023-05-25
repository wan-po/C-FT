using Microsoft.AspNetCore.Mvc;

namespace webTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {

        [HttpPost]
        public string Test(int input)
        {
            string message ;
            switch (input)
            {
                case 1:
                    message ="you inputted 1"; 
                    break;
                case 2:
                    message = "you inputted 2";
                    break;
                default:
                    message = "default";
                    break;
            }
            return message;
            
        }
    }
}
