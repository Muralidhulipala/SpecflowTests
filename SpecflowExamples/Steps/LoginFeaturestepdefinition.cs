using SpecflowExamples.Framework;
using SpecflowExamples.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecflowExamples.Steps
{
    [Binding]
    [Parallelizable]
    internal class LoginFeaturestepdefinition:TestBase
    {

        [Given(@"Launch the applicationin ""([^""]*)""")]
        public void GivenLaunchTheApplicationin(string chrome)
        {
            initialize(chrome);
            Pages.PageInitialize();
        }

        [Given(@"Launch the application")]
        public void GivenLaunchTheApplication()
        {
           
           
        }

        [When(@"enter the username and password")]
        public void WhenEnterTheUsernameAndPassword(Table table)
        {
           // LoginPage page = new LoginPage();

            dynamic data = table.CreateDynamicInstance();
           Pages.loginage.enterLoginData((string)data.username, (string)data.password);
        }

        [When(@"click on login button")]
        public void WhenClickOnLoginButton()
        {
           // LoginPage page = new LoginPage();
            Pages.loginage.Butonclick();
        }

        [Then(@"verfiy the home page with Logout button\.")]
        public void ThenVerfiyTheHomePageWithLogoutButton()
        {
           // HomePage h = new HomePage();
            Assert.That(Pages.homepage.Iselementpresent());
        }
        [Then(@"close the browser")]
        public void ThenCloseTheBrowser()
        {
            DriverFactory.current.Quit();
        }
        [When(@"enter the (.*) and (.*)")]
        public void WhenEnterTheAnd(string username0, string password1)
        {
            LoginPage page = new LoginPage();

            //dynamic data = table.CreateDynamicInstance();
            page.enterLoginData(username0, password1);
        }



    }
}
