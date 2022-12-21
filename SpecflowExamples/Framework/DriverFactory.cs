using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V106.DOM;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SpecflowExamples.Framework
{
    public class DriverFactory
    {
        [ThreadStatic]
        public static RemoteWebDriver? driver;
       
        public static string remote_url_chrome = "http://localhost:4444/wd/hub";
        
        public static void InIt(string Browsername)
        {
            switch(Browsername.ToLower())
            {
                case "chrome":
                    ChromeOptions options=new ChromeOptions();
                    driver=new RemoteWebDriver(new Uri(remote_url_chrome), options);
                    //driver = new ChromeDriver();
                    break;
                case "firefox":
                    FirefoxOptions foptions = new FirefoxOptions();
                    driver=new RemoteWebDriver(new Uri(remote_url_chrome), foptions);
                    break;
            }
           
        }
        public static IWebDriver current => driver ?? throw new NullReferenceException("not null");
        public static void GotoURL(string url)
        {
            driver.Url = url;
            driver.Manage().Window.Maximize();
        }
    }
}
