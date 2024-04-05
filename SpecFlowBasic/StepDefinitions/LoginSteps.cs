using OpenQA.Selenium;
using SpecFlowBasic.Drivers;
using SpecFlowBasic.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowBasic.StepDefinitions
{
    [Binding]
    public sealed class LoginSteps
    {
        private readonly IDriverFixture driverfixture;
        private readonly IHomePage homePage;
        private readonly ILoginPage loginPage;

        //public LoginSteps()
        //{
        //    driverfixture = new DriverFixture();
        //}

        public LoginSteps(IDriverFixture driverFixture, IHomePage homePage, ILoginPage loginPage)
        {
            driverfixture = driverFixture;
            this.homePage = homePage;
            this.loginPage = loginPage;
        }
        [Given(@"I navigate to EA App")]
        public void GivenINavigateToEAApp()
        {
            driverfixture.WebDriver.Navigate().GoToUrl("https://www.google.com");
        }

        [Given(@"I click login button")]
        public void GivenIClickLoginButton()
        {
            //driverfixture.WebDriver.FindElement(By.LinkText("Login")).Click();
            homePage.ClickLogin();
        }

        [Given(@"I enter usernam eand password")]
        public void GivenIEnterUsernamEandPassword()
        {
            //driverfixture.WebDriver.FindElement(By.Id("UserName")).SendKeys("admin");
            //driverfixture.WebDriver.FindElement(By.Id("Password")).SendKeys("password");
            //driverfixture.WebDriver.FindElement(By.CssSelector(".btn-default")).Click();

            loginPage.PerformLogin("admin", "password");
        }

    }
}
