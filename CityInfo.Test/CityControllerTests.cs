using CityInfo.API.Controllers;
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
    }
}