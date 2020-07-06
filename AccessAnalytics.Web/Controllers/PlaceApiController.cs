using System.Collections.Generic;
using System.Linq;
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
            var resp = GenerateFakeResponse();
            return resp;
        }

        [HttpGet("[action]")]
        public async Task<List<PlaceResponse>> GetPlaces()
        {
            var respList = new List<PlaceResponse>();
            for (var i = 0; i < 5; i++)
            {
                respList.Append(GenerateFakeResponse());
            }

            return respList;
        }

        // TODO: delete once we have actual data in place
        private static PlaceResponse GenerateFakeResponse()
        {
            var resp = new PlaceResponse
            {
                Id = 12345,
                Name = "Name",
                Description = "This is a description",
                Locations = new List<PlaceLocationsResponse>
                {
                  new PlaceLocationsResponse
                  {
                      Id = 123456,
                      Latitude = 123.12,
                      Longitude = 123.12,
                      Features = new PlaceLocationFeaturesResponse
                      {
                          Ramps = {},
                          Lighting = {},
                          Parking = {},
                          NoiseLevel = {}
                      },
                      Reviews = new List<PlaceLocationReviewsResponse>
                      {
                          new PlaceLocationReviewsResponse
                          {
                              Id = 1234567,
                              Text = "Some text",
                              Rating = 5
                          }
                      }
                  }
                }
            };

            return resp;
        }
    }
}