using Microsoft.AspNetCore.Mvc;

namespace AzureWebTestApi.Controllers
{
    [Route("calculate")]
    public class CalculateController : Controller
    {
        [HttpGet("sum")]
        public int CalculateSum(int x, int y)
        {
            return x + y;
        }
    }
}
