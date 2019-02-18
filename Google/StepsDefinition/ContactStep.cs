using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using System.Configuration;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using TechTalk.SpecFlow.Assist;
using System.Net;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using SiteKitTest.Pages;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using Baseclass.Contrib.SpecFlow.Selenium.NUnit.Bindings;


namespace SiteKitTest
{  // NOTE: All comment out scripts used page object model (POM) and generic method to call methods and class without need to duplication 
  //  my codes, they were tested and working when I first wrote it, but now sometimes it works and sometimes it does not
    //The uncommented scripts seem to work fine and reliable. I left both just incase the first one and it works fine
    [Binding]
    [TestFixture]
    class ContactStep
    {
        IWebDriver driver = new ChromeDriver();

        [SetUp]
       [Given(@"I am on homepage")]
        public void GivenIAmOnHomepage()
        {
        
            driver.Navigate().GoToUrl("https://www.sitekit.net/");
           
            //PageActivator.activePage = new ContactPage();
        }
        [Test]
        [When(@"I click on contact")]
        public void WhenIClickOnContact()
        {
            //PageActivator.activePage = PageActivator.activePage.As<ContactPage>().contactDetails();
            
               var contact = driver.FindElement(By.XPath("//*[contains(@href,'/#contact')]"));
            Actions action = new Actions(driver);
            action.MoveToElement(contact).Click().Build().Perform();
            Assert.That(driver.PageSource.Contains("0845 299 0900"), Is.EqualTo(true), "You are not on contact page");
        }

        [Then(@"I should see the contact details")]
        public void ThenIShouldSeeTheContactDetails()
        {
            var oxford = driver.FindElement(By.Id("Oxford"));
            var london = driver.FindElement(By.Id("London"));
            Assert.Multiple(() =>
            {
                Assert.That(oxford.Displayed, Is.Not.Null, "Oxford");
                Assert.That(london.Displayed, Is.Not.Null, "London");
            });
        }
        [TearDown]
        public void tearDown()
        {
            driver.Quit();
            
        }
    }
}


