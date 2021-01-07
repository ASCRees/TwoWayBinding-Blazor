using System;
using System.Linq;
using Bunit;
using FluentAssertions;
using System.Collections.Generic;
using TwoWayBinding_Blazor.Data;
using TwoWayBinding_Blazor.Pages;
using Xunit;
using FluentAssertions.Execution;

namespace TwoWayBinding_Blazor.Tests
{
    public class WeatherForecastTests
    {
        public WeatherForecastTests()
        {
        }

        [Fact]
        public void TestWeatherForecastFarenheight()
        {
            // Arrange
            WeatherForecast weatherForecast = new WeatherForecast();
            // Act
            weatherForecast.TemperatureC = 30;
            // Assert

            weatherForecast.TemperatureF.Should().Be(85);
        }
    }
}