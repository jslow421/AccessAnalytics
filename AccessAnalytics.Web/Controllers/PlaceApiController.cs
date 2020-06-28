using System.Threading.Tasks;
using AccessAnalytics.Web.Models.PlaceApi;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AccessAnalytics.Web.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    public class PlaceApiController : Controller
    {
        [HttpGet("[action]")]
        public async Task<PlaceResponse> GetPlace()
        {
            return new PlaceResponse{Name = "Bunny Farts"};
        }
    }
}