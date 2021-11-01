using OpenQA.Selenium.Edge;
using System.Threading.Tasks;
using Xunit;

namespace AcceptanceTests
{
    public class EdgeDriverFactoryFixture
    {
        public async Task<EdgeDriver> CreateEdgeDriverForPageAsync(string uri)
        {
            EdgeDriver edgeDriver = new EdgeDriver();
            edgeDriver.Navigate().GoToUrl($"https://blazorcicdtesting.azurewebsites.net/{uri}");
            await Task.Delay(3000);
            return edgeDriver;
        }
    }
}
