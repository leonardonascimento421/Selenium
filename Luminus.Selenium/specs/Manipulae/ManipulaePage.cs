using Luminus.Selenium.Implementation.Pages;
using OpenQA.Selenium;
using Selenium.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luminus.Selenium.specs.Manipulae
{
    class ManipulaePage : BasePage
    {
        public void ClicarBotaoCadastrar()
        {
            _driver.Click(By.XPath($"//p[contains(text(),'Cadastrar')]"));
        }
    }
}
