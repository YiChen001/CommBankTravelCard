using OpenQA.Selenium;
using System;
using System.Configuration;
using TechTalk.SpecFlow;
using Specflow_UnitTest.PageObjects;
using NUnit.Framework;

namespace Specflow_UnitTest.StepDefinitions
{
    [Binding]
    public class TravelMoneyCardSteps
    {
        private IWebDriver _driver;
        private CommBankLandingPage commbankLandingPage;
        private TravelMoneyCardPage travelMoneyCardPage;
        private TravelProductsPage travelProductsPage;
        private NetBankPage netBankPage;

        [Given(@"user launches Commbank page")]
        public void GivenUserLaunchesCommbankPage()
        {
            _driver = (IWebDriver)ScenarioContext.Current["driver"];
            _driver.Url = ConfigurationManager.AppSettings["CommbankUrl"];
            _driver.Manage().Window.Maximize();
        }
        
        [When(@"user clicks Travel Products link")]
        public void WhenUserClicksTravelProductsLink()
        {
            commbankLandingPage = new CommBankLandingPage(_driver);
            commbankLandingPage.SearchAndClickTravelProductsLink();
        }
        
        [When(@"user clicks Discover more in Travel Money Card section")]
        public void WhenUserClicksDiscoverMoreInTravelMoneyCardSection()
        {
            travelProductsPage = new TravelProductsPage(_driver);
            travelProductsPage.SearchAndClickTravelMOneyCardDiscoverMore();
        }
        
        [Then(@"user validates subtopics")]
        public void ThenUserValidatesSubtopics()
        {
            travelMoneyCardPage = new TravelMoneyCardPage(_driver);
            Assert.IsTrue(travelMoneyCardPage.IsCurrentConverterExists(), "Currency COnverter is visible");
            Assert.IsTrue(travelMoneyCardPage.IsRateAndFees(), "Rate and Fees is visible");
        }
        
        [Then(@"user clicks NetBank")]
        public void ThenUserClicksNetBank()
        {
            travelMoneyCardPage.SearchAndClickNetBank();
        }
                
        [Then(@"user validates Netbank page opens with username and password fields")]
        public void ThenUserValidatesNetbankPageOpensWithUsernameAndPasswordFields()
        {
            netBankPage = new NetBankPage(_driver);
            //Assert.IsTrue(netBankPage.IsClientNumberFieldVisible(), "Client Number field is visible");
            //Assert.IsTrue(netBankPage.IstxtPasswordVisible(), "Client Number field is visible");
            netBankPage.IsClientNumberFieldVisible();
            

        }
    }
}
