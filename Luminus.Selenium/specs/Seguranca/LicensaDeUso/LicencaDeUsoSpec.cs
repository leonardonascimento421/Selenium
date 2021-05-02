using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Pages.Shared.Form;
using Luminus.Selenium.specs.ConfiguracaoDoEstacionamento.Equipamentos;
using Luminus.Selenium.specs.Seguranca.LicencaDeUso;

namespace Luminus.Selenium.specs.Seguranca.LicencaDeUso
{
    public class LicencaDeUsoSpec
    {
        private LicencaDeUsoManterPage _pageLicencaManter = new LicencaDeUsoManterPage();
        private LicencaDeUsoListarPage _pageLicencaListar = new LicencaDeUsoListarPage();
        private EquipamentosPage _pageEquipamento = new EquipamentosPage();
        private MensagemPage _pageMensagem = new MensagemPage();      

        #region ## Validar se a licença é valida [17560]

        [Step("Clicar no botão carregar da tela de consultar licença de uso")]
        public void ClicarNoBotaoCarregarDaTelaDeConsultarLicencaDeUso()
        {
            _pageLicencaListar.ClicarBotaoCarregar();
        }

        [Step("Clicar no botão carregar da tela de carregar licença de uso")]
        public void ClicarNoBotaoCarregarDaTelaDeCarregarLicençaDeUso()
        {
            _pageLicencaManter.ClicarBotaoCarregar();

        }

        [Step("Clicar no botão carregar licença de uso")]
        public void ClicarNoBotaoCarregarLicencaDeUso()
        {
            _pageLicencaListar.ClicarBotaoCarregar();
        }        

        #endregion ## Validar se a licença é valida [17560]

       
        #region ## Carregar licença de uso [17176]      


        #endregion ## Carregar licença de uso [17176]

        #region ## Carregar uma licença já existente no sistema [17177]
        

        [Step("Clicar no arquivo com o nome de <tabela> e clicar no botão Abrir Licenca")]
        public void ClicarNoArquivoComONomeDeEClicarNoBotaoAbrir(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _pageLicencaManter.EscolherArquivo(row.GetCell("caminhoArquivoLincenca") + row.GetCell("aplicativoLicenca"));
        }             

        #endregion ## Carregar uma licença já existente no sistema [17177]    
    }


}