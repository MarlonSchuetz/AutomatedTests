using AutomatedTests.UI.Selenium.WebDrivers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace AutomatedTests.UI.Selenium
{
    public class Page
    {
        private IWebDriver _webDriver;
        private readonly int _pageLoad;
        private readonly int _implicitWait;

        public Page(int pageLoad = 3000, int implicitWait = 0)
        {
            _pageLoad = pageLoad;
            _implicitWait = implicitWait;
        }

        public IWebDriver WebDriver => _webDriver;

        public void Navigate(WebDriverEnum webDriver, string url, string urlRemoteWebDriver = null)
        {
            _webDriver = WebDriverFactory.CreateWebDriver(webDriver, urlRemoteWebDriver);

            _webDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(_pageLoad);
            _webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(_implicitWait);

            _webDriver.Navigate().GoToUrl(url);
        }

        public void Click(string id = null, string name = null, string xpath = null)
        {
            if (id != null)
            {
                _webDriver.FindElement(By.Id(id)).Click();
            }
            else if (name != null)
            {
                _webDriver.FindElement(By.Name(name)).Click();
            }
            else if (xpath != null)
            {
                _webDriver.FindElement(By.XPath(xpath)).Click();
            }
        }

        public void SendKeys(string xpath, string text)
        {
            var element = _webDriver.FindElement(By.XPath(xpath));

            element.SendKeys(text);
        }

        public void Wait(int seconds, Func<IWebDriver, bool> condition) 
        {
            var wait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(seconds));
            wait.Until(condition);
        }

        public void Close() 
        {
            _webDriver.Quit();
            _webDriver = null;
        }
    }
}
