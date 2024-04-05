using OpenQA.Selenium;
using SpecFlowBasic.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowBasic.Pages
{
    public interface ILoginPage
    {
        void PerformLogin(string userName, string password);
    }

    public class LoginPage : ILoginPage
    {
        private readonly IDriverFixture driverFixture;

        public LoginPage(IDriverFixture driverFixture)
        {
            this.driverFixture = driverFixture;
        }
        IWebElement txtUserName => driverFixture.WebDriver.FindElement(By.Id("UserName"));
        IWebElement txtPassword => driverFixture.WebDriver.FindElement(By.Id("Password"));
        IWebElement btnLogin => driverFixture.WebDriver.FindElement(By.CssSelector(".btn-default"));

        public void PerformLogin(string userName, string password)
        {
            txtUserName.SendKeys(userName);
            txtPassword.SendKeys(password);
            btnLogin.Click();
        }
    }
}
