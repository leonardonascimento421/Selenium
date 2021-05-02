
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.specs.Operacao.OperacaoDeMultiplasCancelas;
using Luminus.Selenium.specs.Shared.SsCriarUmEquipamentoEntradaEaeInformatizado17936;
using Luminus.Selenium.specs.Shared.SsCriarUmEquipamentoSaidaEasInformatizado17633;
using Luminus.Selenium.specs.Shared.StCriarTiposDeOcorrenciasNasEstadiasTabela16272;
using Luminus.Selenium.specs.Shared.StCriarUmBolsaoDeVagas16266;
using Luminus.Selenium.specs.Shared.StCriarUmUsuarioDoSistemaTabela17595;

namespace Luminus.Selenium.specs.Operacao.OperacaoDeMultiplasCancelas
{
    public class OperacaoDeMultiplasCancelasPageStep
    {
        private OperacaoDeMultiplasCancelasPage _page = new OperacaoDeMultiplasCancelasPage();

        [Step("Carregar dependências Operação de múltiplas cancelas <tabela>")]
        public void CarregarDependenciasOperacaoMultiplasCancelas(Table tabela)
        {
            var objJaCarregou = DataStoreFactory.SpecDataStore.Get("operacaoMultiplasCancelasDependenciasCarregadas");
            bool jaCarregou = objJaCarregou != null && (bool)objJaCarregou == true;
            if (jaCarregou)
                return;

            DataStoreFactory.SpecDataStore.Add("operacaoMultiplasCancelasDependenciasCarregadas", true);

            // steps de dependências
            Console.WriteLine("ST - Criar um bolsão de vagas <table:resources/EnviarComandoAbrirOperacaoDeMultiplasCancelas17278.csv> [16266]");
            new StCriarUmBolsaoDeVagas16266PageStep().StCriarUmBolsaoDeVagas16266(tabela);
            Console.WriteLine("SS - Criar um equipamento entrada(EAE-Informatizado) <table:resources/EnviarComandoAbrirOperacaoDeMultiplasCancelas17278.csv> [17936]");
            new SsCriarUmEquipamentoEntradaEaeInformatizado17936PageStep().SsCriarUmEquipamentoEntradaEaeInformatizado17936(tabela);
            Console.WriteLine("ST - Criar um usuário do sistema <table:resources/EnviarComandoAbrirOperacaoDeMultiplasCancelas17278.csv> [17595]");
            new StCriarUmUsuarioDoSistemaTabela17595PageStep().StCriarUmUsuarioDoSistema17595(tabela);
            Console.WriteLine("SS - Criar um equipamento saída EAS (informatizado) <table:resources/EnviarComandoAbrirOperacaoDeMultiplasCancelas17278.csv> [17633]");
            new SsCriarUmEquipamentoSaidaEasInformatizado17633PageStep().SsCriarUmEquipamentoSaidaEasInformatizado17633(tabela);
            Console.WriteLine("ST - Criar tipos de ocorrências nas estadias <table:resources/EnviarComandoAbrirOperacaoDeMultiplasCancelas17278.csv> [16272]");
            new StCriarTiposDeOcorrenciasNasEstadiasTabelaPageStep().StCriarTiposDeOcorrenciasNasEstadias(tabela);
        }

        [Step("Na seção Ação acionar o radiobutton Abrir <tabela> [OperacaoDeMultiplasCancelasPageStep]")]
        public void NaSecaoAcaoAcionarORadiobuttonAbrirOperacaodemultiplascancelaspagestep(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.MarcarAcaoAbrir(Convert.ToBoolean(row.GetCell("abriroperacaomultiplascancelas")));
            _page.MarcarAcaoAbrir(Convert.ToBoolean(row.GetCell("abriroperacaomultiplascancelas")));
        }

        [Step("Preencher os campos da tela <tabela> [OperacaoDeMultiplasCancelasPageStep] [17278]")]
        public void PreencherOsCamposDaTelaOperacaodemultiplascancelaspagestep(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarOcorrencia(row.GetCell("nomeTipoDeOcorrenciaNasEstadias"));
            _page.PreencherJustificativa(row.GetCell("justificativaoperacaomultiplascancelas"));
        }

        [Step("Verificar campos da tela <tabela> [OperacaoDeMultiplasCancelasPageStep] [17278]")]
        public void VerificarCamposDaTelaOperacaoDeMultiplasCancelas17278(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarMarcarAcaoAbrir(true).Should().Be(Convert.ToBoolean(row.GetCell("abriroperacaomultiplascancelas")));
                _page.RetornarMarcarEntrada(true).Should().Be(Convert.ToBoolean(row.GetCell("entradaoperacaomultiplascancelas")));
                _page.RetornarMarcarPassagem(true).Should().Be(Convert.ToBoolean(row.GetCell("passagemoperacaomultiplascancelas")));
                _page.RetornarMarcarSaida(true).Should().Be(Convert.ToBoolean(row.GetCell("saidaoperacaomultiplascancelas")));
                _page.RetornarOcorrencia(true).Should().Be(row.GetCell("nomeTipoDeOcorrenciaNasEstadias"));
                _page.RetornarJustificativa(true).Should().Be(row.GetCell("justificativaoperacaomultiplascancelas"));
            }
        }

        [Step("Na seção Ação acionar o radiobutton Fechar <tabela> [OperacaoDeMultiplasCancelasPageStep]")]
        public void NaSecaoAcaoAcionarORadiobuttonFecharOperacaodemultiplascancelaspagestep(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.MarcarAcaoFechar(Convert.ToBoolean(row.GetCell("fecharoperacaomultiplascancelas")));
            _page.MarcarAcaoFechar(Convert.ToBoolean(row.GetCell("fecharoperacaomultiplascancelas")));
        }

        [Step("Preencher os campos da tela <tabela> [OperacaoDeMultiplasCancelasPageStep] [17279]")]
        public void PreencherOsCamposDaTelaOperacaodemultiplascancelaspagestep17279(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarOcorrencia(row.GetCell("nomeTipoDeOcorrenciaNasEstadias"));
            _page.PreencherJustificativa(row.GetCell("justificativaoperacaomultiplascancelas"));
        }

        [Step("Preencher os campos da tela <tabela> [OperacaoDeMultiplasCancelasPageStep] [17280]")]
        public void PreencherOsCamposDaTelaOperacaodemultiplascancelaspagestep17280(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.MarcarPassagem(Convert.ToBoolean(row.GetCell("passagemoperacaomultiplascancelas")));
            _page.MarcarEntrada(Convert.ToBoolean(row.GetCell("entradaoperacaomultiplascancelas")));
            _page.MarcarSaida(Convert.ToBoolean(row.GetCell("saidaoperacaomultiplascancelas")));
            _page.SelecionarOcorrencia(row.GetCell("nomeTipoDeOcorrenciaNasEstadias"));
        }

        [Step("Verificar campos da tela <tabela> [OperacaoDeMultiplasCancelasPageStep] [17279]")]
        public void VerificarCamposDaTelaOperacaoDeMultiplasCancelas17279(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarMarcarAcaoFechar(true).Should().Be(Convert.ToBoolean(row.GetCell("fecharoperacaomultiplascancelas")));
                _page.RetornarMarcarEntrada(true).Should().Be(Convert.ToBoolean(row.GetCell("entradaoperacaomultiplascancelas")));
                _page.RetornarMarcarPassagem(true).Should().Be(Convert.ToBoolean(row.GetCell("passagemoperacaomultiplascancelas")));
                _page.RetornarMarcarSaida(true).Should().Be(Convert.ToBoolean(row.GetCell("saidaoperacaomultiplascancelas")));
                _page.RetornarOcorrencia(true).Should().Be(row.GetCell("nomeTipoDeOcorrenciaNasEstadias"));
                _page.RetornarJustificativa(true).Should().Be(row.GetCell("justificativaoperacaomultiplascancelas"));
            }
        }

        [Step("Verificar mensagem de erro do campo <erro>, na seção de Equipamentos [OperacaoDeMultiplasCancelasPageStep]")]
        public void VerificarmensagemDoCampoNaSecaoEquipamentos(string erro)
        {
            _page.VerificarMensagemDeErroNoCampoNaSecaoEquipamentos(erro);
        }

        [Step("Verificar mensagem de erro do campo <erro>, na seção de Ação [OperacaoDeMultiplasCancelasPageStep]")]
        public void VerificarmensagemDoCampoNaSecaoAcao(string erro)
        {
            _page.VerificarMensagemDeErroNoCampoNaSecaoAcao(erro);
        }

    }
}