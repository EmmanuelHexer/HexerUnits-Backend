using FluentAssertions;
using Services;
using Tests.__Tests.Helper;

namespace Tests.__Tests.Services;

public class UnitTest
{
    private readonly CalculationService _calculationService = new();
    
    [Fact]
    public void ItShouldBeHealthy()
    {
        var health = _calculationService.GetHealth();
        health.Message.Should().NotBeNullOrWhiteSpace();
        health.TimeStamp.Should().BeCloseTo(DateTime.UtcNow, TimeSpan.FromSeconds(3));
    }

    [Fact]
    public void ItShouldConvertGramsToKilograms()
    {
        var value = RandomNumber.GetRandomNumber(1, 10000);
        var expectedValue = value * 0.001;
        var conversion = _calculationService.ConvertGramsToKilograms(value);
        
        conversion.Message.Should().NotBeNullOrWhiteSpace();
        conversion.Result.Should().Be(expectedValue);
    }

    [Fact]
    public void ItShouldConvertGramsToKilogramsWhenValueIsZero()
    {
        var value = 0;
        var conversion = _calculationService.ConvertGramsToKilograms(value);
        conversion.Result.Should().Be(value);
    }

    [Fact]
    public void ItShouldConvertGramsToKilogramsWhenValueIsNegative()
    {
        var value = -1;
        var conversion = _calculationService.ConvertGramsToKilograms(value);
        conversion.Result.Should().BeLessThan(0);
    }

    [Fact]
    public void ItShouldConvertGramsToKilogramsWhenValueIsALargeNumber()
    {
        var value = 1_000_000;
        var conversion = _calculationService.ConvertGramsToKilograms(value);
        conversion.Result.Should().BeLessThan(value).And.BeGreaterThan(0);
    }

    [Fact]
    public void ItShouldConvertKilometersToMiles()
    {
        var value = RandomNumber.GetRandomNumber(1, 100000);
        var expectedValue = value / 1.609344;
        var conversion = _calculationService.ConvertKilometersToMiles(value);
        
        conversion.Message.Should().NotBeNullOrWhiteSpace();
        conversion.Result.Should().Be(expectedValue);
    }

    [Fact]
    public void ItShouldConvertCelsiusToFahrenheit()
    {
        var value = RandomNumber.GetRandomNumber(1, 100000);
        var conversion = _calculationService.ConvertCelsiusToFahrenheit(value);
        
        conversion.Message.Should().NotBeNullOrWhiteSpace();
        conversion.Result.Should().BeGreaterThan(value);
        conversion.Result.Should().BeGreaterThan(0);
    }

    [Fact]
    public void ItShouldConvertLitersToGallons()
    {
        var value = RandomNumber.GetRandomNumber(1, 100000);
        var expectedValue = value * 0.264172;
        var conversion = _calculationService.ConvertLitersToGallons(value);
        
        conversion.Message.Should().NotBeNullOrWhiteSpace();
        conversion.Result.Should().Be(expectedValue);
    }
}
