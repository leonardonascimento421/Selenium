
using Luminus.Selenium.Implementation.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Utils;

namespace Luminus.Selenium.specs.ProdutosDeEstadia.ProdutoDeEstadia
{
    public class ProdutoDeEstadiaPage : BasePage
    {
        public void MarcarImediatamente(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='Imediatamente']"), check);
        }

        public bool RetornarImediatamente()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='Imediatamente']"));
        }

        public void PreencherNome(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='Nome']"), valor.ToString());
        }

        public string RetornarNome()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='Nome']"));
        }

        public void SelecionarTipoDeUsuario(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='TipoUsuario']"), valor);
        }

        public string RetornarTipoDeUsuario()
        {
            return _driver.GetSelect(By.CssSelector("select[formcontrolname='TipoUsuario']"));
        }

        public void PreencherCodigoDoGrupo(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='CodigoGrupo']"), valor.ToString());
        }

        public string RetornarCodigoDoGrupo()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='CodigoGrupo']"));
        }

        public void SelecionarTipoRevalidacao(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='TipoRevalidacao']"), valor);
        }

        public string RetornarTipoRevalidacao()
        {
            return _driver.GetSelect(By.CssSelector("select[formcontrolname='TipoRevalidacao']"));
        }

        public void SelecionarBolsaoDeVagas(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='IdBolsaoVagas']"), valor);
        }

        public string RetornarBolsaoDeVagas()
        {
            return _driver.GetSelect(By.CssSelector("select[formcontrolname='IdBolsaoVagas']"));
        }

        public void SelecionarTabelaDeCobrancaPrincipal(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='IdTabelaCobrancaPrincipal']"), valor);
        }

        public string RetornarTabelaDeCobrancaPrincipal()
        {
            return _driver.GetSelect(By.CssSelector("select[formcontrolname='IdTabelaCobrancaPrincipal']"));
        }

        public void MarcarManterTabelaCobrancaPrincipal(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='ManterTabelaCobrancaPrincipal']"), check);
        }

        public bool RetornarManterTabelaCobrancaPrincipal()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='ManterTabelaCobrancaPrincipal']"));
        }

        public void SelecionarTabelaDeCobrancaSecundaria(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='IdTabelaCobrancaSecundaria']"), valor);
        }

        public string RetornarTabelaDeCobrancaSecundaria()
        {
            return _driver.GetSelect(By.CssSelector("select[formcontrolname='IdTabelaCobrancaSecundaria']"));
        }

        public void MarcarManterTabelaCobrancaSecundaria(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='ManterTabelaCobrancaSecundaria']"), check);
        }

        public bool RetornarManterTabelaCobrancaSecundaria()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='ManterTabelaCobrancaSecundaria']"));
        }

        public void MarcarEquipamentoPassagemMantemTabelaCobrancaEstadia(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='EquipamentoPassagemMantemTabelaCobrancaEstadia']"), check);
        }

        public bool RetornarEquipamentoPassagemMantemTabelaCobrancaEstadia()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='EquipamentoPassagemMantemTabelaCobrancaEstadia']"));
        }

        public void SelecionarTabelaDeCobrancaPrincipalTransitoExcedido(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='IdTabelaCobrancaPrincipalTransitoExcedido']"), valor);
        }

        public string RetornarTabelaDeCobrancaPrincipalTransitoExcedido()
        {
            return _driver.GetSelect(By.CssSelector("select[formcontrolname='IdTabelaCobrancaPrincipalTransitoExcedido']"));
        }

        public void MarcarManterTabelaCobrancaPrincipalTransitoExcedido(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='ManterTabelaCobrancaPrincipalTransitoExcedido']"), check);
        }

        public bool RetornarManterTabelaCobrancaPrincipalTransitoExcedido()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='ManterTabelaCobrancaPrincipalTransitoExcedido']"));
        }

        public void SelecionarTabelaDeCobrancaSecundariaTransitoExcedido(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='IdTabelaCobrancaSecundariaTransitoExcedido']"), valor);
        }

        public string RetornarTabelaDeCobrancaSecundariaTransitoExcedido()
        {
            return _driver.GetSelect(By.CssSelector("select[formcontrolname='IdTabelaCobrancaSecundariaTransitoExcedido']"));
        }

        public void MarcarManterTabelaCobrancaSecundariaTransitoExcedido(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='ManterTabelaCobrancaSecundariaTransitoExcedido']"), check);
        }

        public bool RetornarManterTabelaCobrancaSecundariaTransitoExcedido()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='ManterTabelaCobrancaSecundariaTransitoExcedido']"));
        }

        public void SelecionarRegrasAcessoEntrada(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='IdRegrasAcessoEntrada']"), valor);
        }

        public string RetornarRegrasAcessoEntrada()
        {
            return _driver.GetSelect(By.CssSelector("select[formcontrolname='IdRegrasAcessoEntrada']"));
        }

        public void SelecionarRegrasAcessoPassagem(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='IdRegrasAcessoPassagem']"), valor);
        }

        public string RetornarRegrasAcessoPassagem()
        {
            return _driver.GetSelect(By.CssSelector("select[formcontrolname='IdRegrasAcessoPassagem']"));
        }

        public void SelecionarRegrasAcessoSaida(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='IdRegrasAcessoSaida']"), valor);
        }

        public string RetornarRegrasAcessoSaida()
        {
            return _driver.GetSelect(By.CssSelector("select[formcontrolname='IdRegrasAcessoSaida']"));
        }

        public void PreencherTempoMinimoDeUtilizacaoprePago(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='TempoMinimoUtilizacao']"), valor.ToString());
        }

        public string RetornarTempoMinimoDeUtilizacaoprePago()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='TempoMinimoUtilizacao']"));
        }

        public void PreencherTempoMaximoDeUtilizacaoprePago(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='TempoMaximoUtilizacao']"), valor.ToString());
        }

        public string RetornarTempoMaximoDeUtilizacaoprePago()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='TempoMaximoUtilizacao']"));
        }

        public void PreencherQuantidadeDeDiasValidadeInicial(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='QtdeDiasValidadeInicial']"), valor.ToString());
        }

        public string RetornarQuantidadeDeDiasValidadeInicial()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='QtdeDiasValidadeInicial']"));
        }

        public void PreencherQuantidadeDeUtilizacaoDiaria(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='QdeUtilizacoesDiaria']"), valor.ToString());
        }

        public string RetornarQuantidadeDeUtilizacaoDiaria()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='QdeUtilizacoesDiaria']"));
        }

        public void PreencherQuantidadeDeDiasExtesaoDeValidade(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='QtdeDiasSugeridosExtensaoValidade']"), valor.ToString());
        }

        public string RetornarQuantidadeDeDiasExtesaoDeValidade()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='QtdeDiasSugeridosExtensaoValidade']"));
        }

        public void SelecionarNumeroOpcao(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='NumeroOpcao']"), valor);
        }        

        public void PreencherValorDaRevalicao(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='Valor']"), valor.ToString());
        }

        public string RetornarValorDaRevalicao()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='Valor']"));
        }

        public void PreencherValorDaRepeticao(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='Repeticao']"), valor.ToString());
        }

        public string RetornarValorDaRepeticao()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='Repeticao']"));
        }

        public void PreencherQuantidadeDeDias(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='QtdeDias']"), valor.ToString());
        }        

        public void PreencherQuantidadeDeDiasNoPopUp(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='QtdeDias']"), valor.ToString());
        }

        public string RetornarQuantidadeDeDiasNoPopUp()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='QtdeDias']"));
        }

        public IWebElement RetornarTabelaRevalidacao()
        {
            return _driver.GetElement(
                new ByChained(
                    By.XPath("//legend[contains(text(),'Regras de revalidação')]/.."),
                    By.CssSelector("table")));
        }


        public IWebElement RetornarTabelaRecarga()
        {
            return _driver.GetElement(
                new ByChained(
                    By.XPath("//legend[contains(text(),'Regras de recarga')]/.."),
                    By.CssSelector("table")));
        }

        public string RetornarNumeroOpcaoDeRevalidacao(IWebElement tabela, int numeroLinha)
        {
            return _driver.GetColumnText(tabela, "Número da opção de revalidação", numeroLinha);
        }

        public string RetornarNumeroOpcaoDeRecarga(IWebElement tabela, int numeroLinha)
        {
            return _driver.GetColumnText(tabela, "Número da opção de recarga", numeroLinha);
        }

        public string RetornarQuantidadeDeDias(IWebElement tabela, int numeroLinha)
        {
            return _driver.GetColumnText(tabela, "Quantidade de dias", numeroLinha);
        }

        public string RetornarValorDaRevalicao(IWebElement tabela, int numeroLinha)
        {
            return _driver.GetColumnText(tabela, "Valor", numeroLinha);
        }

        public void PreencherDiaDoMes(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='DiaMes']"), valor.ToString());
        }

        public string RetornarDiaDoMes()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='DiaMes']"));
        }

        public void PreencherQuantidadeMaximaDiarias(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='QuantidadeMaximaDiarias']"), valor.ToString());
        }

        public string RetornarQuantidadeMaximaDiarias()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='QuantidadeMaximaDiarias']"));
        }

        public void SelecionarTabelaCobrancaExcedente(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='IdTabelaCobrancaExcedente']"), valor);
        }

        public string RetornarTabelaCobrancaExcedente()
        {
            return _driver.GetSelect(By.CssSelector("select[formcontrolname='IdTabelaCobrancaExcedente']"));
        }

        public void MarcarPermitirVendaPrevia(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='PermitirVendaPrevia']"), check);
        }

        public bool RetornarPermitirVendaPrevia()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='PermitirVendaPrevia']"));
        }

        public void PreencherNivelMinimoOperadorReImpressaoTicket(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='NivelMinimoOperadorReImpressaoTicket']"), valor.ToString());
        }

        public string RetornarNivelMinimoOperadorReImpressaoTicket()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='NivelMinimoOperadorReImpressaoTicket']"));
        }

        public void PreencherValorRecarga(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='ValorRecarga']"), valor.ToString());
        }

        public string RetornarValorRecarga()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='ValorRecarga']"));
        }

        public void PreencherValorPagamento(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='ValorPagamento']"), valor.ToString());
        }

        public string RetornarValorPagamento()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='ValorPagamento']"));
        }

        public void PreencherQuantidadedeDiasExtensaoValidade(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='QtdeDiasExtensaoValidade']"), valor.ToString());
        }

        public string RetornarQuantidadedeDiasExtensaoValidade()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='QtdeDiasExtensaoValidade']"));
        }

        public void MarcarSugerirOpcaoRecargaMaxima(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='SugerirOpcaoRecargaMaxima']"), check);
        }

        public bool RetornarSugerirOpcaoRecargaMaxima()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='SugerirOpcaoRecargaMaxima']"));
        }

        public void PreencherSaldoMinimo(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='SaldoMinimo']"), valor.ToString());
        }

        public string RetornarSaldoMinimo()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='SaldoMinimo']"));
        }

        public void PreencherSaldoMaximo(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='SaldoMaximo']"), valor.ToString());
        }

        public string RetornarSaldoMaximo()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='SaldoMaximo']"));
        }

        public void PreencherSaldoNegativoLimite(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='SaldoNegativoLimite']"), valor.ToString());
        }

        public string RetornarSaldoNegativoLimite()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='SaldoNegativoLimite']"));
        }

        public void PreencherValorMaximoDiario(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='ValorMaximoDiario']"), valor.ToString());
        }

        public string RetornarValorMaximoDiario()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='ValorMaximoDiario']"));
        }

        public void MarcarHabilitarTempoBonus(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='HabilitarTempoBonus']"), check);
        }

        public void PreencherValorRecargaNoPopUp(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='ValorRecarga']"), valor.ToString());
        }

        public string RetornarValorRecargaNoPopUp(IWebElement tabela, int numeroLinha)
        {
            return _driver.GetColumnText(tabela, "Valor da recarga", numeroLinha);
        }

        public void PreencherValorPagamentoNoPopUp(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='ValorPagamento']"), valor.ToString());
        }

        public string RetornarValorPagamentoNoPopUp(IWebElement tabela, int numeroLinha)
        {
            return _driver.GetColumnText(tabela, "Valor do pagamento", numeroLinha);
        }

        public void PreencherQuantidadeDeDiasExtensaoValidadeNoPopUp(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='QtdeDiasExtensaoValidade']"), valor.ToString());
        }

        public string RetornarQuantidadeDeDiasExtensaoValidadeNoPopUp(IWebElement tabela, int numeroLinha)
        {
            return _driver.GetColumnText(tabela, "Quantidade de dias de extensão da validade", numeroLinha);
        }

        public bool RetornarHabilitarTempoBonus()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='HabilitarTempoBonus']"));
        }

        public void MarcarSugerirOpcaoDeRecargaParaAtingirSaldoMaximo(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='SugerirOpcaoRecargaSaldoMaximo']"), check);
        }

        public bool RetornarSugerirOpcaoDeRecargaParaAtingirSaldoMaximo()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='SugerirOpcaoRecargaSaldoMaximo']"));
        }

        public void SelecionarModoUtilizacaoTempoBonus(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='ModoUtilizacaoTempoBonus']"), valor);
        }

        public string RetornarModoUtilizacaoTempoBonus()
        {
            return _driver.GetSelect(By.CssSelector("select[formcontrolname='ModoUtilizacaoTempoBonus']"));
        }

        public void PreencherTempoBonusMaximo(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='TempoBonusMaximo']"), valor.ToString());
        }

        public string RetornarTempoBonusMaximo()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='TempoBonusMaximo']"));
        }

        public void ClicarNoBotaoAdicionarDeConfiguracaoPorEstacionamento()
        {
            _driver.Click(
                new ByChained(
                    By.XPath("//legend[contains(text(),'Configuração por estacionamento')]/.."),
                    By.CssSelector("button")));
        }

        public void ClicarNoBotaoAdicionarDeRegrasDeRevalidacao()
        {
            _driver.Click(
                new ByChained(
                    By.XPath("//legend[contains(text(),'Regras de revalidação')]/.."),
                    By.CssSelector("button")));
        }

        public void ClicarNoBotaoAdicionarDeRegrasDeRecarga()
        {
            _driver.Click(
                new ByChained(
                    By.XPath("//legend[contains(text(),'Regras de recarga')]/.."),
                    By.CssSelector("button")));
        }

    }
}