using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace specflowNEW.StepDefinitions
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

        [Given(@": user in on login page")]
        public void GivenUserInOnLoginPage()
        {
            _driver.Navigate().GoToUrl("https://www.globalsqa.com/angularJs-protractor/BankingProject/#/");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }

        [When(@"customer clicks on Customer Login button")]
        public void WhenCustomerClicksOnCustomerLoginButton()
        {
            IWebElement CustLogin = _driver.FindElement(By.XPath("//button[normalize-space()='Customer Login']"));
            CustLogin.Click();
            Thread.Sleep(3000);
            Console.WriteLine("click button");////button[normalize-space()='Customer Login']
        }

        [When(@"Selects the name")]
        public void WhenSelectsTheName()
        {
            Console.WriteLine("before");
            IWebElement NamesDropDown = _driver.FindElement(By.XPath("//select[@id='userSelect']"));
            NamesDropDown.Click();
            Console.WriteLine("afterclick");
            var select = new SelectElement(NamesDropDown);
            Thread.Sleep(2000);
            //select by value
            select.SelectByText("Harry Potter");
            Thread.Sleep(2000);
        }

        [When(@"user Clicks on login button")]
        public void WhenUserClicksOnLoginButton()
        {
            IWebElement NamesDropDown = _driver.FindElement(By.XPath("//button[normalize-space()='Login']"));
            NamesDropDown.Click();
        }

        [Then(@"user is logged in and can see data")]
        public void ThenUserIsLoggedInAndCanSeeData()
        {
            Console.WriteLine("Customer Logged In");
        }




















    }
}