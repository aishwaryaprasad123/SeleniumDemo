using System;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public class xyzbankStepDefinitions
    {
        [Binding]
        public class XYZBankStepDefinitions
        {
            private ScenarioContext _scenarioContext;
            private IWebDriver _driver;

            public XYZBankStepDefinitions(ScenarioContext scenarioContext)
            {

                _scenarioContext = scenarioContext;
                _driver = _scenarioContext["WebDriver"] as IWebDriver;

            }
            [Given(@": User in on login page")]
            public void GivenUserInOnLoginPage()
            {
                _driver.Navigate().GoToUrl("https://www.globalsqa.com/angularJs-protractor/BankingProject/#/");
                _driver.Manage().Window.Maximize();
                Thread.Sleep(2000);
            }

            [When(@"Customer clicks on Customer Login button")]
            public void WhenCustomerClicksOnButton()
            {
                IWebElement CustLogin = _driver.FindElement(By.XPath("//button[normalize-space()='Customer Login']"));
                CustLogin.Click();
            }

            [When(@"selects the name")]
            public void WhenSelectsTheName()
            {
                IWebElement NamesDropDown = _driver.FindElement(By.XPath("//select[@id='userSelect']"));
                NamesDropDown.Click();
                var select = new SelectElement(NamesDropDown);
                Thread.Sleep(2000);
                //select by value
                select.SelectByText("Harry Potter");
                Thread.Sleep(2000);
            }

            [When(@"User Clicks on login button")]
            public void WhenUserClicksOnLoginButton()
            {
                IWebElement NamesDropDown = _driver.FindElement(By.XPath("//button[normalize-space()='Login']"));
                NamesDropDown.Click();
            }

            [Then(@"User is logged in and can see data")]
            public void ThenUserIsLoggedInAndCanSeeData()
            {
                Console.WriteLine("Customer Logged In");
            }
        }
    }
}
