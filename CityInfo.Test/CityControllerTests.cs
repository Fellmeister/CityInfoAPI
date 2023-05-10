using CityInfo.API.Controllers;
using Microsoft.AspNetCore.Mvc;
using Shouldly;

namespace CityInfo.Test;

public class CityControllerTests : IClassFixture<CityInfoController>
{
    private readonly CityInfoController _cityInfoController;

    public CityControllerTests(CityInfoController cityInfoController)
    {
        _cityInfoController = cityInfoController;
    }
    
    [Fact]
    public void GetCitiesMethodShouldReturnCities()
    {
        var result = _cityInfoController.GetCities();

        result.ShouldNotBeNull();
        result.ShouldBeOfType<OkObjectResult>();
    }

    [Fact]
    public void ShouldReturnCityInfoForId()
    {
        var result = _cityInfoController.GetCity(1);

        result.ShouldNotBeNull();
        result.ShouldBeOfType<OkObjectResult>();
    }
    
    [Fact]
    public void ShouldReturnCityInfoForInvalidId()
    {
        var result = _cityInfoController.GetCity(67);

        result.ShouldNotBeNull();
        result.ShouldBeOfType<NotFoundResult>();
    }
}