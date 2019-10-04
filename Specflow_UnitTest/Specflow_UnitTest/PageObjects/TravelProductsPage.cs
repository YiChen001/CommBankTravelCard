using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Specflow_UnitTest.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Specflow_UnitTest.PageObjects
{
    public class TravelProductsPage
    {
        private IWebDriver _driver;

        public TravelProductsPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }


        [FindsBy(How = How.XPath, Using = "//h3/following-sibling::p/a[text()='Discover more']")]
        private IWebElement _btnTravelMoneyCardDiscoverMore;

        public void SearchAndClickTravelMOneyCardDiscoverMore()
        {
            Helper.WaitAndClick(_btnTravelMoneyCardDiscoverMore);
        }
    }
}
