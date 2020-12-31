using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TwoWayBinding_Blazor.Data
{
    public partial class WeatherForecastService
    {

        public List<WeatherSummary> weatherSummaries = new List<WeatherSummary>()
        {
                new WeatherSummary()
                  {
                      LowerValue = -273,
                      UpperValue = 0,
                      Summary = "Freezing"
                  },
                 new WeatherSummary()
                  {
                      LowerValue = 1,
                      UpperValue = 10,
                      Summary = "Bracing"
                  },
                  new WeatherSummary()
                  {
                      LowerValue = 11,
                      UpperValue = 15,
                      Summary = "Chilly"
                  },
                new WeatherSummary()
                {
                    LowerValue = 16,
                    UpperValue = 20,
                    Summary = "Cool"
                },
                new WeatherSummary()
                {
                    LowerValue = 21,
                    UpperValue = 25,
                    Summary = "Mild"
                },
                new WeatherSummary()
                {
                    LowerValue = 26,
                    UpperValue = 30,
                    Summary = "Warm"
                },
                new WeatherSummary()
                {
                    LowerValue = 31,
                    UpperValue = 35,
                    Summary = "Hot"
                },
                new WeatherSummary()
                {
                    LowerValue = 36,
                    UpperValue = 40,
                    Summary = "Sweltering"
                },
                new WeatherSummary()
                {
                    LowerValue = 41,
                    UpperValue = 999999999,
                    Summary = "Scorching"
                }
        };

        public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        {
            var rng = new Random();

            List<WeatherForecast> weatherForcasts = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = rng.Next(-20, 55)
            }).ToList();

            for (int i = 0; i < weatherForcasts.Count(); i++)
            {                
                weatherForcasts[i].Summary = weatherSummaries.Where(c => c.LowerValue <= weatherForcasts[i].TemperatureC && c.UpperValue >= weatherForcasts[i].TemperatureC).Select(c => c.Summary).FirstOrDefault(); 
            }

            return Task.FromResult(weatherForcasts.ToArray());
        }


      
        

    }
}
