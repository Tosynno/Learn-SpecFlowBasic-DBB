using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace SpecFlowBasic.Drivers
{
    public class DriverFixture : IDriverFixture
    {
        private readonly IWebDriver webDriver;

        public DriverFixture()
        {
            webDriver = GetWebDriver();
        }

        public IWebDriver WebDriver => webDriver;

        private IWebDriver GetWebDriver()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            return new ChromeDriver();
        }

        public void Dispose()
        {
            WebDriver.Quit();
        }
    }
}
