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
    public class WeatherForecastServiceTests
    {
        private WeatherForecastService weatherForecastService;

        public WeatherForecastServiceTests()
        {
            weatherForecastService = new WeatherForecastService();
        }

        [Fact]
        public void TestWeatherSummariesCount()
        {
            // Arrange

            // Act

            // Assert

            weatherForecastService.WeatherSummaries.Count().Should().Be(9);
        }

        [Theory]
        [InlineData("Freezing", -273, 0)]
        [InlineData("Bracing", 1, 10)]
        [InlineData("Chilly", 11, 15)]
        [InlineData("Cool", 16, 20)]
        public void TestWeatherSummaries(string summary, int lowerResult, int upperResult)
        {
            // Arrange

            // Act
            WeatherForecastService.WeatherSummary weatherSummary = weatherForecastService.WeatherSummaries.Where(c => c.Summary.Equals(summary)).FirstOrDefault();

            // Assert
            using (new AssertionScope())
            {
                weatherSummary.LowerValue.Should().Be(lowerResult);
                weatherSummary.UpperValue.Should().Be(upperResult);
            }
        }
    }
}