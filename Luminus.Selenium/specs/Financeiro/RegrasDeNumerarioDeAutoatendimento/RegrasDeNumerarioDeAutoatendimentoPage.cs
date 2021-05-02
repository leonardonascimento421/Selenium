
using Luminus.Selenium.Implementation.Pages;
using Luminus.Selenium.Implementation.Pages.Shared.Form;
using Luminus.Selenium.Implementation.Shared.Form;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Utils;

namespace Luminus.Selenium.specs.Financeiro.RegrasDeNumerarioDeAutoatendimento
{
    public class RegrasDeNumerarioDeAutoatendimentoPage : BasePage


    {
        public void ClicarBotaoAdicionarCedulas()
        {
            var element = _driver.GetElement(By.XPath("//legend[contains(text(),'Cédulas')]/.."));
            new BotoesCRUDPage().ClicarBotaoAdicionar(element);
        }

        public void ClicarBotaoAdicionarMoedas()
        {
            var element = _driver.GetElement(By.XPath("//legend[contains(text(),'Moedas')]/.."));
            new BotoesCRUDPage().ClicarBotaoAdicionar(element);
        }        

        public IWebElement RetornarTabelaCedulas()
        {
            return _driver.GetElement(
                new ByChained(
                    By.XPath("//legend[contains(text(),'Cédulas')]/.."),
                    By.CssSelector("table")));
        }

        public IWebElement RetornarTabelaMoedas()
        {
            return _driver.GetElement(
                new ByChained(
                    By.XPath("//legend[contains(text(),'Moedas')]/.."),
                    By.CssSelector("table")));
        }

        public string RetornarmoedaCedulasRegrasDeNumerario(IWebElement tabela, int numeroLinha)
        {
            return _driver.GetColumnText(tabela, "Moeda", numeroLinha);
        }

        public string RetornarvalorCedulasRegrasDeNumerario(IWebElement tabela, int numeroLinha)
        {
            return _driver.GetColumnText(tabela, "Valor", numeroLinha);
        }

        public string RetornarquantidadeMximaNoDispensadorCedulasRegrasDeNumerario(IWebElement tabela, int numeroLinha)
        {
            return _driver.GetColumnText(tabela, "Quantidade máxima no dispensador", numeroLinha);
        }

        public string RetornarquantidadeMinimaNoDispensadorCedulasRegrasDeNumerario(IWebElement tabela, int numeroLinha)
        {
            return _driver.GetColumnText(tabela, "Quantidade mínima no dispensador", numeroLinha);
        }

        public string RetornaracaoParaQuantidadeMinimaNoDispensadorCedulasRegrasDeNumerario(IWebElement tabela, int numeroLinha)
        {
            return _driver.GetColumnText(tabela, "Ação para quantidade mínima no dispensador", numeroLinha);
        }

        public string RetornarquantidadeMinimaNoDispensadorParaAlertaCedulasRegrasDeNumerario(IWebElement tabela, int numeroLinha)
        {
            return _driver.GetColumnText(tabela, "Quantidade mínima no dispensador para alerta", numeroLinha);
        }

        public string RetornarMoedaMoedasRegrasDeNumerario(IWebElement tabela, int numeroLinha)
        {
            return _driver.GetColumnText(tabela, "Moeda", numeroLinha);
        }

        public string RetornarValorMoedasRegrasDeNumerario(IWebElement tabela, int numeroLinha)
        {
            return _driver.GetColumnText(tabela, "Valor", numeroLinha);
        }

        public string RetornarquantidadeMximaNoDispensadorMoedasRegrasDeNumerario(IWebElement tabela, int numeroLinha)
        {
            return _driver.GetColumnText(tabela, "Quantidade máxima no dispensador", numeroLinha);
        }

        public string RetornarquantidadeMinimaNoDispensadorMoedasRegrasDeNumerario(IWebElement tabela, int numeroLinha)
        {
            return _driver.GetColumnText(tabela, "Quantidade mínima no dispensador", numeroLinha);
        }

        public string RetornaracaoParaQuantidadeMinimaNoDispensadorMoedasRegrasDeNumerario(IWebElement tabela, int numeroLinha)
        {
            return _driver.GetColumnText(tabela, "Ação para quantidade mínima no dispensador", numeroLinha);
        }

        public string RetornarquantidadeMinimaNoDispensadorParaAlertaMoedasRegrasDeNumerario(IWebElement tabela, int numeroLinha)
        {
            return _driver.GetColumnText(tabela, "Quantidade mínima no dispensador para alerta", numeroLinha);
        }

        public void PreenchernomeRegrasDeNumerario(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='Nome']"), valor.ToString());
        }

        public string RetornarnomeRegrasDeNumerario()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='Nome']"));
        }

        public void SelecionarmodeloDoModuloFinanceiroRegrasDeNumerario(string valor)
        {
            _driver.SelecionarCombo(new ByChained(By.XPath("//label[contains(text(),'Modelo do módulo financeiro')]/.."), By.CssSelector("select")), valor.ToString());
        }

        public string RetornarmodeloDoModuloFinanceiroRegrasDeNumerario()
        {
            return _driver.GetSelect(new ByChained(By.XPath("//label[contains(text(),'Modelo do módulo financeiro')]/.."), By.CssSelector("select")));
        }

        public void MarcarsemLimitesRegrasDeNumerario(bool checkConsultarVeiculos)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='SemLimiteContravales']"), checkConsultarVeiculos);
        }

        public bool RetornarsemLimitesRegrasDeNumerario()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='SemLimiteContravales']"));
        }

        public void PreencherQuantidadeMaximaParaContraVales(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='QtdeMaximaContravales']"), valor.ToString());
        }

        public string RetornarQuantidadeMaximaParaContraVales()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='QtdeMaximaContravales']"));
        }

        public void PreenchervalorMaximoParaTrocoEmCedulasRegrasDeNumerario(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='ValorMaximoCedulasTroco']"), valor.ToString());
        }

        public string RetornarvalorMaximoParaTrocoEmCedulasRegrasDeNumerario()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='ValorMaximoCedulasTroco']"));
        }

        public void PreencherquantidadeMaximaDeCedulasNoRecicladorParaAlertaRegrasDeNumerario(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='QtdeMaximaCedulasRecicladorAlerta']"), valor.ToString());
        }

        public string RetornarquantidadeMaximaDeCedulasNoRecicladorParaAlertaRegrasDeNumerario()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='QtdeMaximaCedulasRecicladorAlerta']"));
        }

        public void PreencherquantidadeMaximaDeCedulasNoCofreParaAlertaRegrasDeNumerario(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='QtdeMaximaCedulasCofreAlerta']"), valor.ToString());
        }

        public string RetornarquantidadeMaximaDeCedulasNoCofreParaAlertaRegrasDeNumerario()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='QtdeMaximaCedulasCofreAlerta']"));
        }

        public void PreencherquantidadeMaximaDeCedulasNoRejeitadorRegrasDeNumerario(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='QtdeMaximaCedulasRejeitador']"), valor.ToString());
        }

        public string RetornarquantidadeMaximaDeCedulasNoRejeitadorRegrasDeNumerario()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='QtdeMaximaCedulasRejeitador']"));
        }

        public void SelecionarmoedaCedulasRegrasDeNumerario(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='MoedaId']"), valor.ToString());
        }

        public void SelecionarvalorCedulasRegrasDeNumerario(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='Valor']"), valor.ToString());
        }

        public void PreencherquantidadeMximaNoDispensadorCedulasRegrasDeNumerario(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='QtdeMaximaDispensador']"), valor.ToString());
        }

        public void PreencherquantidadeMinimaNoDispensadorCedulasRegrasDeNumerario(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='QtdeMinimaDispensador']"), valor.ToString());
        }

        public void SelecionaracaoParaQuantidadeMinimaNoDispensadorCedulasRegrasDeNumerario(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='IndexAcaoQtdeMinimaDispensador']"), valor.ToString());
        }

        public void PreencherquantidadeMinimaNoDispensadorParaAlertaCedulasRegrasDeNumerario(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='QtdeMinimaDispensadorAlerta']"), valor.ToString());
        }

        public void MarcaravulsoCedulasRegrasDeNumerario(bool checkConsultarVeiculos)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='AceitarAvulso']"), checkConsultarVeiculos);
        }

        public bool RetornaravulsoCedulasRegrasDeNumerario()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='AceitarAvulso']"));
        }

        public void PreenchervalorMaximoParaTrocoEmMoedasRegrasDeNumerario(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='ValorMaximoMoedasTroco']"), valor.ToString());
        }

        public string RetornarvalorMaximoParaTrocoEmMoedasRegrasDeNumerario()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='ValorMaximoMoedasTroco']"));
        }

        public void PreencherquantidadeMaximaDeMoedasNoRecicladorParaAlertaRegrasDeNumerario(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='QtdeMaximaMoedasRecicladorAlerta']"), valor.ToString());
        }

        public string RetornarquantidadeMaximaDeMoedasNoRecicladorParaAlertaRegrasDeNumerario()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='QtdeMaximaMoedasRecicladorAlerta']"));
        }

        public void PreencherquantidadeMaximaDeMoedasNoCofreParaAlertaRegrasDeNumerario(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='QtdeMaximaMoedasCofreAlerta']"), valor.ToString());
        }

        public string RetornarquantidadeMaximaDeMoedasNoCofreParaAlertaRegrasDeNumerario()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='QtdeMaximaMoedasCofreAlerta']"));
        }

        public void SelecionarmoedaMoedasRegrasDeNumerario(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='MoedaId']"), valor.ToString());
        }

        public void SelecionarvalorMoedasRegrasDeNumerario(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='Valor']"), valor.ToString());
        }

        public void PreencherquantidadeMximaNoDispensadorMoedasRegrasDeNumerario(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='QtdeMaximaDispensador']"), valor.ToString());
        }

        public void PreencherquantidadeMinimaNoDispensadorMoedasRegrasDeNumerario(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='QtdeMinimaDispensador']"), valor.ToString());
        }

        public void SelecionaracaoParaQuantidadeMinimaNoDispensadorMoedasRegrasDeNumerario(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='IndexAcaoQtdeMinimaDispensador']"), valor.ToString());
        }

        public void PreencherquantidadeMinimaNoDispensadorParaAlertaMoedasRegrasDeNumerario(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='QtdeMinimaDispensadorAlerta']"), valor.ToString());
        }

        public void MarcaravulsoMoedasRegrasDeNumerario(bool checkConsultarVeiculos)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='AceitarAvulso']"), checkConsultarVeiculos);
        }

        public bool RetornaravulsoMoedasRegrasDeNumerario()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='AceitarAvulso']"));
        }

        public void MarcarprePagoMonetarioCedulasRegrasNumerario(bool checkConsultarVeiculos)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='AceitarPrePago']"), checkConsultarVeiculos);
        }

        public bool RetornarprePagoMonetarioCedulasRegrasNumerario()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='AceitarPrePago']"));
        }

        public void MarcarcredenciadoMonetarioCedulasRegrasNumerario(bool checkConsultarVeiculos)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='AceitarCredenciado']"), checkConsultarVeiculos);
        }

        public bool RetornarcredenciadoMonetarioCedulasRegrasNumerario()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='AceitarCredenciado']"));
        }

        public void MarcarimediatamenteRegrasDeNumerario(bool checkConsultarVeiculos)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='Imediatamente']"), checkConsultarVeiculos);
        }

        public bool RetornarimediatamenteRegrasDeNumerario()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='Imediatamente']"));
        }
    }
}