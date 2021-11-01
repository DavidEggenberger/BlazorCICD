using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System.Threading.Tasks;
using Xunit;

namespace AcceptanceTests
{
    public class CounterAcceptanceTests : IClassFixture<EdgeDriverFactoryFixture>
    {
        private EdgeDriverFactoryFixture edgeDriverFactoryFixture;
        public CounterAcceptanceTests(EdgeDriverFactoryFixture edgeDriverFactoryFixture)
        {
            this.edgeDriverFactoryFixture = edgeDriverFactoryFixture;
        }

        [Fact]
        public async Task ShouldIncrementBy1()
        {
            //Arrange
            EdgeDriver edgeDriver = await edgeDriverFactoryFixture.CreateEdgeDriverForPageAsync("counter");
            //Act
            IWebElement counterElement = edgeDriver.FindElement(By.CssSelector("button.btn.btn-primary"));
            counterElement.Click();
            //Assert
            IWebElement countDisplayElement = edgeDriver.FindElement(By.CssSelector(".content.px-4 p"));
            Assert.True(countDisplayElement.Text == "Current count: 1");
        }
    }
}
