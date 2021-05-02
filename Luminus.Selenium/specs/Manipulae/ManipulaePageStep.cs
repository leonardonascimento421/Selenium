using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Utils;
using OpenQA.Selenium;
using Selenium.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luminus.Selenium.specs.Manipulae
{
    class ManipulaePageStep
    {
        private IWebDriver _driver = DriverFactory.Driver;
        private Dictionary<string, string> _dicUrls = new Dictionary<string, string>();
        private ManipulaePage _page = new ManipulaePage();


        [Step("Acessar Url <nomeCampoUrl>")]
        public void AcesssarUrl(string nomeCampoUrl)
        {
            string url = ObterUrl2(nomeCampoUrl);

            url = Config.Url.UrlManipulae;

            _driver.LoadPage(url);
        }

        private string ObterUrl2(string nomeCampoUrl)
        {
            string url;

            CriarDicUrls2();

            if (!_dicUrls.TryGetValue(nomeCampoUrl, out url))
                throw new Exception($"Não foi possível encontrar a url para o campo {nomeCampoUrl} no arquivo de configuração 'config.json'");

            return url;
        }

        private void CriarDicUrls2()
        {
            if (_dicUrls.Count != 0)
                return;

            var urls = Config.Url;

            _dicUrls = urls.GetType().GetProperties()
                .ToDictionary(x => x.Name, x => x.GetValue(urls)?.ToString());
        }

        [Step("Clicar no botão cadastrar")]
        public void ClicarNoBotaoCadastrar()
        {
            _page.ClicarBotaoCadastrar();
        }

        [Step("Preencher os campos da tela de cadastro parte 1 <tabela>")]
        public void PreencherOsCamposDaTeladeCadastroParte1(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            //_page.PreencherCodigo(row.GetCell("codigoBolsaoDeVagas"));
            //_page.PreencherNome(row.GetCell("nomeBolsaoDeVagas"));
            //_page.PreencherQuantidade(row.GetCell("quantidadedevagasBolsaoDeVagas"));
            //_page.MarcarBloquearAcessoQuandoLotado(Convert.ToBoolean(row.GetCell("bloquearacessoquandolotadobolsaodevagas")));
            //_page.MarcarHabilitarControleVagasPorSetor(Convert.ToBoolean(row.GetCell("habilitarControledeVagasporSetorbolsaodevagas")));
        }

        [Step("Preencher os campos da tela de cadastro parte 2 <tabela>")]
        public void PreencherOsCamposDaTeladeCadastroParte2(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            //_page.PreencherCodigo(row.GetCell("codigoBolsaoDeVagas"));
            //_page.PreencherNome(row.GetCell("nomeBolsaoDeVagas"));
            //_page.PreencherQuantidade(row.GetCell("quantidadedevagasBolsaoDeVagas"));
            //_page.MarcarBloquearAcessoQuandoLotado(Convert.ToBoolean(row.GetCell("bloquearacessoquandolotadobolsaodevagas")));
            //_page.MarcarHabilitarControleVagasPorSetor(Convert.ToBoolean(row.GetCell("habilitarControledeVagasporSetorbolsaodevagas")));
        }


    }
}
