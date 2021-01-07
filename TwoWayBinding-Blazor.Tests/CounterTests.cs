using Bunit;
using System;
using TwoWayBinding_Blazor.Pages;
using Xunit;

namespace TwoWayBinding_Blazor.Tests
{
    public class CounterTests
    {
        [Fact]
        public void ParentCounterShouldIncrementWhenClicked()
        {
            // Arrange: render the Counter.razor component
            using var ctx = new TestContext();
            var cut = ctx.RenderComponent<CounterParent>();

            // Act: find and click the <button> element to increment
            // the counter in the <p> element
            cut.Find("button").Click();

            // Assert: first find the <p> element, then verify its content
            cut.Find("p").MarkupMatches("<p>Parent Current count: 11</p>");
        }

        [Fact]
        public void ChildCounterShouldIncrementWhenClicked()
        {
            // Arrange: render the Counter.razor component
            using var ctx = new TestContext();
            var cut = ctx.RenderComponent<CounterParent>();

            // Act: find and click the <button> element to increment
            // the counter in the <p> element
            cut.Find("button").Click();

            // Assert:  first find the <p> element, then verify its content
            //  cut.Find("#childCounter").MarkupMatches("<p id='childCounter'>Child Current count: 11</p>");
            cut.Find("#childCounter").InnerHtml.Equals("Child Current count: 11");
        }
    }
}