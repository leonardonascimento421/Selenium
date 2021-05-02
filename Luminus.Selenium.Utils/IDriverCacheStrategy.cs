using System;
using OpenQA.Selenium;

namespace Luminus.Selenium.Utils
{
    public interface IDriverCacheStrategy : IDisposable
    {
        IWebDriver GetOrAdd(Func<IWebDriver> driverFactory);
    }
}