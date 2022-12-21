using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SpecflowExamples.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecflowExamples.PageObjects
{
    public class LoginPage
    {
        public LoginPageMap map;
        public LoginPage()
        {
            map=new LoginPageMap();
        }
        public void enterLoginData(string username,string password)
        {
            map.UserName.SendKeys(username);
            map.Password.SendKeys(password);
            
        } 
        public void Butonclick()
        {
            map.Login.Submit();
        }
    }
    public class LoginPageMap
    {
        public IWebElement UserName => DriverFactory.current.FindElement(By.Name("UserName"));
        public IWebElement Password => DriverFactory.current.FindElement(By.Name("Password"));
        public IWebElement Login => DriverFactory.current.FindElement(By.Name("Login"));

    }
}
