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
    public class CommBankLandingPage
    {

        private IWebDriver _driver;

        public CommBankLandingPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }


        [FindsBy(How = How.XPath, Using = "//h3[text()= 'Travel products']")]
        private IWebElement _lnkTravelProducts;

        [FindsBy(How = How.XPath, Using = "//a[@class='toast-dismiss-button']")]
        private IWebElement _lnkDismiss;


        public void SearchAndClickTravelProductsLink()
        {
            Helper.WaitAndClick(_lnkDismiss);
            Helper.WaitAndClick(_lnkTravelProducts);
        }
    }
}
