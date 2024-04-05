using OpenQA.Selenium;
using SpecFlowBasic.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowBasic.Pages
{
    public interface IHomePage
    {
        void ClickLogin();
    }

    public class HomePage : IHomePage
    {
        private readonly IDriverFixture driverFixture;
        public HomePage(IDriverFixture driverFixture)
        {
            this.driverFixture = driverFixture;
        }

        IWebElement lnkLogin => driverFixture.WebDriver.FindElement(By.LinkText("Login"));
        public void ClickLogin() => lnkLogin.Click();
    }
}
