using FluentAssertions;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Utils;
using OpenQA.Selenium;
using Selenium.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Luminus.Selenium.Implementation.Shared.Navegacao
{
    public class NavegacaoSpec
    {
        private IWebDriver _driver = DriverFactory.Driver;
        private Dictionary<string, string> _dicUrls = new Dictionary<string, string>();

        [Step("Navegar para <nomeCampoUrl>")]
        public void NavegarParaUrl(string nomeCampoUrl)
        {
            string url = ObterUrl(nomeCampoUrl);

            url = Path.Combine(Config.Url.UrlManipulae, url);

            _driver.LoadPage(url);
        }

        [Step("Navegar para Portal <nomeCampoUrl>")]
        public void NavegarParaUrlPortal(string nomeCampoUrl)
        {
            string url = ObterUrl(nomeCampoUrl);

            _driver.LoadPage(url);
        }

        [Step("Verificar pagina atual <nomeCampoUrl>")]
        public void VerificarUrlAtual(string nomeCampoUrl)
        {
            string url = ObterUrl(nomeCampoUrl);

            url = Path.Combine(Config.Url.UrlManipulae, url);

            _driver.Url.Should()
                .Be(url);
        }

        private string ObterUrl(string nomeCampoUrl)
        {
            string url;

            CriarDicUrls();

            if (!_dicUrls.TryGetValue(nomeCampoUrl, out url))
                throw new Exception($"Não foi possível encontrar a url para o campo {nomeCampoUrl} no arquivo de configuração 'config.json'");

            return url;
        }

        private void CriarDicUrls()
        {
            if (_dicUrls.Count != 0)
                return;

            var urls = Config.Url;

            _dicUrls = urls.GetType().GetProperties()
                .ToDictionary(x => x.Name, x => x.GetValue(urls)?.ToString());
        }
    }
}
