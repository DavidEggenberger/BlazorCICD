using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System.Threading.Tasks;
using Xunit;

namespace AcceptanceTests
{
    public class FetchDataAcceptanceTests : IClassFixture<EdgeDriverFactoryFixture>
    {
        private EdgeDriverFactoryFixture edgeDriverFactoryFixture;
        public FetchDataAcceptanceTests(EdgeDriverFactoryFixture edgeDriverFactoryFixture)
        {
            this.edgeDriverFactoryFixture = edgeDriverFactoryFixture;
        }

        [Fact]
        public async Task ShouldDisplay5Forecasts()
        {
            //Arrange
            EdgeDriver edgeDriver = await edgeDriverFactoryFixture.CreateEdgeDriverForPageAsync("fetchdata");
            //Act
            IWebElement counterElement = edgeDriver.FindElement(By.CssSelector("button.btn.btn-primary"));
            counterElement.Click();
            //Assert
            IWebElement countDisplayElement = edgeDriver.FindElement(By.CssSelector(".content.px-4 p"));
            Assert.True(countDisplayElement.Text == "Current count: 1");
        }
    }
}
