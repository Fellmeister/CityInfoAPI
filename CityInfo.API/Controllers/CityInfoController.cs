using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers;

[ApiController]
public class CityInfoController : ControllerBase
{
    [HttpGet]
    public JsonResult GetCities()
    {
        return new JsonResult(
            new List<object>
            {
                new {
                    Id = 1, Name = "Paris", Country = "France"
                },
                new { Id = 2, Name = "London", Country = "UK" },
            });
    }
}