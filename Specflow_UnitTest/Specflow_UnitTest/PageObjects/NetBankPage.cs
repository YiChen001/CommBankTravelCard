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
    public class NetBankPage
    {
        private IWebDriver _driver;

        public NetBankPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        
        [FindsBy(How = How.Id, Using = "txtMyClientNumber_field")]
        private IWebElement _txtClientNumber;

        [FindsBy(How = How.Id, Using = "txtMyPassword_field")]
        private IWebElement _txtPassword;

        public bool IsClientNumberFieldVisible()
        {
            Helper.WaitAndSwitchForFrame(ref _driver, _txtClientNumber);
            return true;
          
        }

        public bool IstxtPasswordVisible()
        {
            Helper.WaitAndSwitchForFrame(ref _driver, _txtClientNumber);

            return true;
        }
    }
}
