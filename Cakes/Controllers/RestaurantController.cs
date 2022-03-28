using Cakes.Data;
using Cakes.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Reflection;
using System.Text.Json.Nodes;

namespace Cakes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantController : ControllerBase
    {
        private readonly RestaurantRepository _repo;
        List<RestaurantJSON> restaurantJSON = new List<RestaurantJSON>();
        public RestaurantController(RestaurantRepository repo)
        {
            _repo = repo;
        }

        [HttpPost]
        public IActionResult CreateRestaurantWeekDays(RestaurantJSON restaurant)
        {
           
            _repo.GetResponseObject(restaurant);
            return Ok(restaurant);
        }
    }
}
