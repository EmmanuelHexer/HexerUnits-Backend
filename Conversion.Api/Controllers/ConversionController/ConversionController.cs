using Microsoft.AspNetCore.Mvc;
using Entities.Dtos.Response;
using Services;

namespace Conversion.Api.Controllers.ConversionController;

[ApiController]
[Route("/[controller]")] 

public class ConversionController(ICalculationService calculationService) : ControllerBase
{
   [HttpGet]
   [Route("health")]
   public HealthResponse GetHealth()
   {
      return calculationService.GetHealth();
   }

   [HttpPost]
   [Route("grams-to-kilograms/{value}")]
   public UnitConversionResponse ConvertGramsToKilograms(double value)
   {
      return calculationService.ConvertGramsToKilograms(value);
   }

   [HttpPost]
   [Route("kilometers-to-miles/{value}")]
   public UnitConversionResponse ConvertKilometersToMiles(double value)
   {
      return calculationService.ConvertKilometersToMiles(value);
   }

   [HttpPost]
   [Route("celsius-to-fahrenheit/{value}")]
   public UnitConversionResponse ConvertCelsiusToFahrenheit(double value)
   {
      return calculationService.ConvertCelsiusToFahrenheit(value);
   }

   [HttpPost]
   [Route("liters-to-gallons/{value}")]
   public UnitConversionResponse ConvertLitersToGallons(double value)
   {
      return calculationService.ConvertLitersToGallons(value);
   }
}





