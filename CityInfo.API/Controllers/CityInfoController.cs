using CityInfo.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers;

[ApiController]
[Route("api/CityInfo")]
public class CityInfoController : ControllerBase
{
    private List<CityInfoDTO> CityInfoDataSource = new()
    {
        new CityInfoDTO() {Id = 1, Name = "Paris", Country = "France"},
        new CityInfoDTO() { Id = 2, Name = "London", Country = "UK" },
        new CityInfoDTO() { Id = 3, Name = "New York", Country = "USA" },
        new CityInfoDTO() { Id = 4, Name = "Sydney", Country = "Australia" },
    };

    [HttpGet]
    public ActionResult GetCities()
    {
        return Ok(CityInfoDataSource);
    }

    [HttpGet]
    [Route("{id:int}")]
    public ActionResult GetCity(int id)
    {
        var city = CityInfoDataSource.FirstOrDefault(x => x.Id == id);
        
        if (city == null) return NotFound();

        return Ok(city);
    }
}