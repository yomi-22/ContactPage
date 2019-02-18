using System;
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


namespace SiteKitTest.Pages
{
    public class ContactPage : BasePage
    {
          public ContactPage()
        {
             PageFactory.InitElements(Utilities.driver, this);
         //  PageFactory.InitElements(Browser.Current, this);
              }
        [FindsBy(How = How.XPath, Using = "//*[contains(@ahref,'/#contact')]")] 
        public IWebElement txtContact;
        

        public ContactDetailsPage contactDetails()
        {
            txtContact.Click();
            return new ContactDetailsPage();
        }

        
    }
}
