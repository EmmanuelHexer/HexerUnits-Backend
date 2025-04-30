using Entities.Dtos.Response;

namespace Services;

public interface ICalculationService
{
    HealthResponse GetHealth();
    UnitConversionResponse ConvertGramsToKilograms(double grams);
    UnitConversionResponse ConvertKilometersToMiles(double kilometers);
    UnitConversionResponse ConvertCelsiusToFahrenheit(double celsius);
    UnitConversionResponse ConvertLitersToGallons(double liters);
}