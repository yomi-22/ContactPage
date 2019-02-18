using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow.Assist;
using TechTalk.SpecFlow;

namespace SiteKitTest
{
  public  class PageActivator 
    {
      private static BasePage _activePage;
      public static BasePage activePage

  {
   get { return _activePage; }
            set { 
                 ScenarioContext.Current["class"]= value;
                 _activePage = ScenarioContext.Current.Get<BasePage>("class");
            }
  }

    }
}
