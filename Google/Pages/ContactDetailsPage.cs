using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using Baseclass.Contrib.SpecFlow.Selenium;
using OpenQA.Selenium.Interactions;
using Baseclass.Contrib.SpecFlow.Selenium.NUnit.Bindings;

namespace SiteKitTest 
{
    public class ContactDetailsPage : BasePage
    {
        IWebDriver driver;
        public ContactDetailsPage()
        {
             PageFactory.InitElements(Utilities.driver, this);
         //  PageFactory.InitElements(Browser.Current, this); 
        }

        [FindsBy(How = How.Id, Using = "Oxford")]
        public IWebElement oxford;


        [FindsBy(How = How.Id, Using = "London")]
        public IWebElement london;
      
        
    }
}
