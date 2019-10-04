using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Specflow_UnitTest.Extensions
{
    public static class Helper
    {
        public static bool WaitAndClick(IWebElement element)
        {
            DefaultWait<IWebElement> wait = new DefaultWait<IWebElement>(element);
            wait.Timeout = TimeSpan.FromSeconds(10);
            wait.PollingInterval = TimeSpan.FromMilliseconds(500);
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));

            bool IsElement = wait.Until<bool>((ele) =>
            {
                try
                {
                    if (ele.Enabled && ele.Displayed)
                    {
                        ele.Click();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception thrown :" + e.Message);
                    return false;
                }
            });

            return IsElement;
        }

        public static bool WaitForVisible(IWebElement element)
        {
            DefaultWait<IWebElement> wait = new DefaultWait<IWebElement>(element);
            wait.Timeout = TimeSpan.FromSeconds(20);
            wait.PollingInterval = TimeSpan.FromMilliseconds(500);
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));

            bool IsVisible = wait.Until<bool>((ele) =>
            {
                try
                {
                    if (ele.Enabled && ele.Displayed)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception thrown :" + e.Message);
                    return false;
                }
            });

            return IsVisible;
        }

        public static bool WaitAndSwitchForFrame(ref IWebDriver d, IWebElement element)
        {
            //TODO : Need to find the web element visibility

            //DefaultWait<IWebDriver> wait = new DefaultWait<IWebDriver>(d);
            //wait.Timeout = TimeSpan.FromSeconds(60);
            //wait.PollingInterval = TimeSpan.FromMilliseconds(500);
            //wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            //bool waitcondition = wait.Until<bool>((dd) =>
            //{
            //    try
            //    {
            //        dd.SwitchTo().DefaultContent();
            //        dd.SwitchTo().Frame(0);
            //        if (element.Enabled & element.Displayed)
            //        {
            //            return true;
            //        }
            //        else { return false; }
            //    }
            //    catch (Exception e)
            //    {
            //        return false;
            //    }
            //});

            //return waitcondition;
            return true;
        }
    }
}
