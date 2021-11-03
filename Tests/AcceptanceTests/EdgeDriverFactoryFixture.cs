using OpenQA.Selenium.Edge;
using System.Threading.Tasks;

namespace AcceptanceTests
{
    public class EdgeDriverFactoryFixture
    {
        public async Task<EdgeDriver> CreateEdgeDriverForPageAsync(string uri)
        {
            EdgeDriver edgeDriver = new EdgeDriver();
            edgeDriver.Navigate().GoToUrl($"https://blazorcicdtesting.azurewebsites.net/{uri}");
            await Task.Delay(5000);
            return edgeDriver;
        }
    }
}
