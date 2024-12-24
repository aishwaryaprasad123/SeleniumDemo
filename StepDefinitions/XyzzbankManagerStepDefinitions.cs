using System;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public class XyzzbankManagerStepDefinitions
    {
        private ScenarioContext _scenarioContext;
        private IWebDriver _driver;

        public XyzzbankManagerStepDefinitions(ScenarioContext scenarioContext)
        {

            _scenarioContext = scenarioContext;
            _driver = _scenarioContext["WebDriver"] as IWebDriver;

        }
        [Given(@"the Bank Manager is on the login page,")]
        public void GivenTheBankManagerIsOnTheLoginPage()
        {
            _driver.Navigate().GoToUrl("https://www.globalsqa.com/angularJs-protractor/BankingProject/#/");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }

        [When(@"the Bank Manager clicks on the ""([^""]*)"" button")]
        public void WhenTheBankManagerClicksOnTheButton(string p0)
        {            
            IWebElement Manglog = _driver.FindElement(By.XPath("//button[normalize-space()='Bank Manager Login']"));
            Manglog.Click();
            Thread.Sleep(3000);
            Console.WriteLine("click button");
        }

        [When(@"selects the ""([^""]*)"" tab")]
        public void WhenSelectsTheTab(string p0)
        {
            IWebElement AddCust = _driver.FindElement(By.XPath("//button[normalize-space()='Add Customer']"));
            AddCust.Click();
            Thread.Sleep(3000);
            Console.WriteLine("click button");
        }

        [When(@"enters the First Name in the corresponding field")]
        public void WhenEntersTheFirstNameInTheCorrespondingField()
        {
            IWebElement firstNameField = _driver.FindElement(By.XPath("//input[@placeholder='First Name']"));
            firstNameField.SendKeys("Aish");
            Thread.Sleep(1000);
        }

        [When(@"enters the Last Name in the corresponding field")]
        public void WhenEntersTheLastNameInTheCorrespondingField()
        {
            IWebElement lastNameField = _driver.FindElement(By.XPath("//input[@placeholder='Last Name']"));
            lastNameField.SendKeys("Shetty");
            Thread.Sleep(1000);
        }
    

        [When(@"enters the Postcode in the corresponding field")]
        public void WhenEntersThePostcodeInTheCorrespondingField()
        {
            IWebElement postcodeField = _driver.FindElement(By.XPath("//input[@placeholder='Post Code']"));
            postcodeField.SendKeys("12345");
            Thread.Sleep(1000);
        }

        [When(@"clicks on the ""([^""]*)"" button")]
        public void WhenClicksOnTheButton(string p0)
        {

            IWebElement button = _driver.FindElement(By.XPath("//button[@class='btn home']"));
            button.Click();
            Thread.Sleep(2000);
        }
        
        [When(@"clicks on the ""([^""]*)"" button in the confirmation dialog")]
        public void WhenClicksOnTheButtonInTheConfirmationDialog(string oK)
        {

            Console.WriteLine("Ok");
            Thread.Sleep(5000);
        }
        

        [Then(@"the customer is successfully added")]
        public void ThenTheCustomerIsSuccessfullyAdded()
        {
            Console.WriteLine("Customer added successfully  ");
        }


    }
}
