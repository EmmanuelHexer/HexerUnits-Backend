using Entities.Dtos.Response;
namespace Services;

public class CalculationService : ICalculationService
{
    public HealthResponse GetHealth()
    {
        return new HealthResponse
        {
            Message = "Success, application running smoothly!",
            TimeStamp = DateTime.UtcNow
        };
    }

    public UnitConversionResponse ConvertGramsToKilograms(double grams)
    {
        return new UnitConversionResponse
            { 
                Message = "Success", 
                Result = grams * 0.001 
            };
    }

    public UnitConversionResponse ConvertKilometersToMiles(double kilometers)
    {
        return new UnitConversionResponse
        {
            Message = "Success",
            Result = kilometers / 1.609344
        };
    }

    public UnitConversionResponse ConvertCelsiusToFahrenheit(double celsius)
    {
        return new UnitConversionResponse
        {
            Message = "Success",
            Result = (celsius * 9 / 5) + 32
        };
    }

    public UnitConversionResponse ConvertLitersToGallons(double liters)
    {
        return new UnitConversionResponse
        {
            Message = "Success",
            Result = liters * 0.264172
        };
    }
}