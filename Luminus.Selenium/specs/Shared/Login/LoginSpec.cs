using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Pages.Shared.Login;
using Luminus.Selenium.Utils;
using OpenQA.Selenium;
using Selenium.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luminus.Selenium.Implementation.Shared.Login
{
    public class LoginSpec
    {
        private LoginPage _page = new LoginPage();
        private IWebDriver _driver = DriverFactory.Driver;

        [Step("Efetuar Login")]
        public void EfetuarLogin()
        {
            _page.RedirecionarLogin(Config.Url.UrlManipulae);
        }
    }
}
