using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luminus.Selenium.Utils
{
    public static class ByExtensions
    {
        public static By CombineBefore(this By by, By byBefore)
        {
            if (byBefore == null)
                return by;

            return new ByChained(byBefore, by);
        }
    }
}
