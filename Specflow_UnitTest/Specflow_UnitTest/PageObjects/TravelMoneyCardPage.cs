using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Specflow_UnitTest.Extensions;

namespace Specflow_UnitTest.PageObjects
{
    public class TravelMoneyCardPage
    {
        private IWebDriver _driver;

        public TravelMoneyCardPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[@data-tracker-locationid='anch_currency']")]
        private IWebElement _btnCurrentConverter;

        [FindsBy(How = How.XPath, Using = "//a[@data-tracker-locationid='anch_rates']")]
        private IWebElement _btnRateAndFees;

        [FindsBy(How = How.XPath, Using = "//a[@data-tracker-locationid='how_ReloadInNetBank']")]
        private IWebElement _lnkNetBank;

        public bool IsCurrentConverterExists() => _btnCurrentConverter.Enabled && _btnCurrentConverter.Displayed;

        public bool IsRateAndFees() => _btnRateAndFees.Enabled && _btnRateAndFees.Displayed;

        public void SearchAndClickNetBank()
        {
            Helper.WaitAndClick(_lnkNetBank);
        }
    }
}
