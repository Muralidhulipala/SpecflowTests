using Dynamitey;
using OpenQA.Selenium.DevTools.V106.DOM;
using SpecflowExamples.PageObjects;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecflowExamples.Framework
{
    public class Pages
    {
        public static HomePage homepage;
        public static LoginPage loginage;
        public static void PageInitialize()
        {
            homepage = new HomePage();
            loginage = new LoginPage();
        }
    }
}
