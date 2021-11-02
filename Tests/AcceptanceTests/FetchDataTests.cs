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
            var fetchDataRows = edgeDriver.FindElements(By.CssSelector("table tbody tr"));    
            //Assert
            Assert.True(fetchDataRows.Count == 5);
        }
    }
}
