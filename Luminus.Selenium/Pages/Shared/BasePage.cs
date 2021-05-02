using System;
using System.Reflection;
using Luminus.Selenium.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Luminus.Selenium.Implementation.Pages
{
    public abstract class BasePage
    {
        protected static readonly string BaseUrl = Environment.GetEnvironmentVariable("APP_ENDPOINT");
        protected static readonly string AdminUrl = string.Format("{0}admin/", BaseUrl);
        protected readonly IWebDriver _driver = DriverFactory.Driver;

        protected BasePage()
        {
            PageFactory.InitElements(DriverFactory.Driver, this);
        }

        public IWebElement GetElement(string name)
        {
            var field = GetType().GetField(name, BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Public);
            return field == null ? null : field.GetValue(this) as IWebElement;
        }

        protected static void ClearAndSetValue(IWebElement element, string value)
        {
            element.Clear();
            element.SendKeys(value);
        }
    }
}
