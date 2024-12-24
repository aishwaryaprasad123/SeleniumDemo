using System;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public class XyzzbankCustomersStepDefinitions
    {


        private ScenarioContext _scenarioContext;
        private IWebDriver _driver;

        public XyzzbankCustomersStepDefinitions(ScenarioContext scenarioContext)
        {

            _scenarioContext = scenarioContext;
            _driver = _scenarioContext["WebDriver"] as IWebDriver;

        }
      


        [Given(@"Bank Manager is on the login Page")]
        public void GivenBankManagerIsOnTheLoginPage()
        {
            _driver.Navigate().GoToUrl("https://www.globalsqa.com/angularJs-protractor/BankingProject/#/");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }

        [Given(@"the Manager Click to the Login button")]
        public void GivenTheManagerClickToTheLoginButton()
        {
            IWebElement Manglog = _driver.FindElement(By.XPath("//button[normalize-space()='Bank Manager Login']"));
            Manglog.Click();
            Thread.Sleep(3000);
            Console.WriteLine("click button");
        }

        [Given(@"Click into Customer button")]
        public void GivenClickIntoCustomerButton()
        {
            IWebElement Custbtt = _driver.FindElement(By.XPath("//button[normalize-space()='Customers']"));
            Custbtt.Click();
            Thread.Sleep(3000);
            Console.WriteLine("click button");
        }

        [Given(@"Search the Customer name")]
        public void GivenSearchTheCustomerName()
        {
            IWebElement firstNameField = _driver.FindElement(By.XPath("//input[@placeholder='Search Customer']"));
            firstNameField.SendKeys("Harry");
            Thread.Sleep(1000);
        }

        [Given(@"delete the Customer detail")]
        public void GivenDeleteTheCustomerDetail()
        {
            IWebElement dltnam = _driver.FindElement(By.XPath("//tbody/tr[1]/td[5]/button[1]"));
            dltnam.Click();
            Thread.Sleep(3000);
            Console.WriteLine("click button");
        }
        [Then(@"go back to home page")]
        public void ThenGoBackToHomePage()
        {
             IWebElement button = _driver.FindElement(By.XPath("//button[@class='btn home']"));
            button.Click();
            Thread.Sleep(5000);
        }

    }
}
