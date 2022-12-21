using OpenQA.Selenium;
using SpecflowExamples.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecflowExamples.PageObjects
{
    
    public class HomePage
    {
        public HomePageMap map;
        public HomePage()
        {
            map = new HomePageMap();
        }
        public bool Iselementpresent()
        {
            return map.Text.Displayed;
        }
    }
    public class HomePageMap
    {
        public IWebElement Text => DriverFactory.current.FindElement(By.XPath("//h1"));

    }

}
