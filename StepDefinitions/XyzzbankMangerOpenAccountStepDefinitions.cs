using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public class XyzzbankMangerOpenAccountStepDefinitions
    {
        private ScenarioContext _scenarioContext;
        private IWebDriver _driver;

        public XyzzbankMangerOpenAccountStepDefinitions(ScenarioContext scenarioContext)
        {

            _scenarioContext = scenarioContext;
            _driver = _scenarioContext["WebDriver"] as IWebDriver;

        }
        [Given(@"The Bank Manager is on the login page,")]
        public void GivenTheBankManagerIsOnTheLoginPage()
        {
            _driver.Navigate().GoToUrl("https://www.globalsqa.com/angularJs-protractor/BankingProject/#/");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }


        [Given(@"Manager Click to the Login button")]
        public void GivenManagerClickToTheLoginButton()
        {
            IWebElement Manglog = _driver.FindElement(By.XPath("//button[normalize-space()='Bank Manager Login']"));
            Manglog.Click();
            Thread.Sleep(3000);
            Console.WriteLine("click button");
        }


        [Given(@"the Manger clicks to the Open Account button")]
        public void GivenTheMangerClicksToTheOpenAccountButton()
        {
            IWebElement Opnacc = _driver.FindElement(By.XPath("//button[normalize-space()='Open Account']"));
            Opnacc.Click();
            Thread.Sleep(3000);
            Console.WriteLine("click button");
        }

        [Given(@"Select the Customer name")]
        public void GivenSelectTheCustomerName()
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

        [Given(@"Slect the Currency")]
        public void GivenSlectTheCurrency()
        {
           
            IWebElement NamesDropDownCurren = _driver.FindElement(By.XPath("//select[@id='currency']"));
            NamesDropDownCurren.Click();
          
            var select = new SelectElement(NamesDropDownCurren);
            Thread.Sleep(2000);
            //select by value
            select.SelectByText("Dollar");
            Thread.Sleep(3000);
        }

        [Then(@"then go to Home page")]
        public void ThenThenGoToHomePage()
        {
            IWebElement button = _driver.FindElement(By.XPath("//button[@class='btn home']"));
            button.Click();
            Thread.Sleep(2000);
        }
    }
}
