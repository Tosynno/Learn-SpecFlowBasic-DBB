using OpenQA.Selenium;

namespace SpecFlowBasic.Drivers
{
    public interface IDriverFixture
    {
        IWebDriver WebDriver { get; }

        void Dispose();
    }
}