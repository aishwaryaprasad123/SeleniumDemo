using System;
using OpenQA.Selenium.IE;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using NUnit.Framework;

[assembly: Parallelizable(ParallelScope.All)]
namespace SpecFlowProject.StepDefinitions

{
    [Binding]
   
    public class ParalleExecutionStepDefinitions
    {
            
        [Given(@"user is on the application page on IE browser")]
        public void GivenUserIsOnTheApplicationPageOnIEBrowser()
        {
            IWebDriver driver = new InternetExplorerDriver();
            driver.Navigate().GoToUrl("https://rahulshettyacademy.com/angularpractice/");
        }

        [Given(@"user is on the application page on FF browser")]
        public void GivenUserIsOnTheApplicationPageOnFFBrowser()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("https://toolsqa.com/specflow/tables-in-specflow/");
        }

        [Given(@"user is on the application page on Edge browser")]
        public void GivenUserIsOnTheApplicationPageOnEdgeBrowser()
        {
            IWebDriver driver = new EdgeDriver();
            driver.Navigate().GoToUrl("https://rahulshettyacademy.com/angularpractice/");
        }
    }
}
