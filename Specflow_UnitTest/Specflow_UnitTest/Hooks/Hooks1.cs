using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Specflow_UnitTest.Hooks
{    
        [Binding]
        public sealed class Hooks1
        {
            private IWebDriver _driver;

            [BeforeScenario]
            public void BeforeScenario()
            {
                _driver = new ChromeDriver(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Drivers"));
                _driver.Manage().Window.Maximize();
                ScenarioContext.Current["driver"] = _driver;
            }

            [AfterScenario]
            public void AfterScenario()
            {
                //_driver.Close();
                //_driver.Quit();
            }
        }
}
