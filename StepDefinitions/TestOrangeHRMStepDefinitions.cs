using System;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class OrangeHRMStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private IWebDriver _driver = null;

        public OrangeHRMStepDefinitions(ScenarioContext scenarioContext)
        {   
            _scenarioContext = scenarioContext;
            _driver = _scenarioContext["WebDriver"] as IWebDriver;

        }
        [Given(@"User is on the orange hrm login page")]
        public void GivenUserIsOnTheOrangeHrmLoginPage()
        {
            _driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }

        [When(@"User enters the ""([^""]*)"" and ""([^""]*)"" in the text fields")]
        public void WhenUserEntersTheAndInTheTextFields(string admin, string p1)
        {
            IWebElement username = _driver.FindElement(By.XPath("//input[@name = 'username']"));
            username.SendKeys(admin);


            IWebElement password = _driver.FindElement(By.XPath("//input[@name = 'password']"));
            password.SendKeys(p1);
        }

        [When(@"User clicks on submit button")]
        public void WhenUserClicksOnSubmitButton()
        {
            IWebElement loginbutton = _driver.FindElement(By.XPath("//button[@type = 'submit']"));
            loginbutton.Click();
            Thread.Sleep(1000);
        }

        [Then(@"User is navigated to home page")]
        public void ThenUserIsNavigatedToHomePage()
        {
            IWebElement Admin = _driver.FindElement(By.XPath("(//a[@class = 'oxd-main-menu-item'])[1]"));
            Admin.Click();
        }
        [Then(@"User is  on the  home page and error is displayed")]
        public void ThenUserIsOnTheHomePageAndErrorIsDisplayed()
        {
            Console.WriteLine("Error");
        }


    }
}