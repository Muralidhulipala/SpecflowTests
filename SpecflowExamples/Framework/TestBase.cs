using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecflowExamples.Framework
{

    public class TestBase:DriverFactory
    {
        public void initialize(string browser)
        {
            DriverFactory.InIt(browser);
            DriverFactory.GotoURL("https://demosite.executeautomation.com/Login.html");
        }
    }
}
