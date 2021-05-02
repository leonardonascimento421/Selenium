
using Luminus.Selenium.Implementation.Pages;
using OpenQA.Selenium;
using Selenium.Utils;

namespace Luminus.Selenium.specs.ConfiguracoesDoEstacionamento.Estacionamento
{
    public class EstacionamentoPage : BasePage
    {
        public string RetornarNome()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='Nome']"));
        }

        public void PreencherNome(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='Nome']"), valor.ToString());
        }

        public void PreencherCor(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='Cor']"), valor.ToString());
        }

        public string RetornarCor()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='Cor']"));
        }

        public void EscolherArquivo(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='Arquivo']"), valor);
        }

        public string RetornarLote()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='Lote']"));
        }

        public string RetornarSublote()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='Sublote']"));
        }

        public string RetornartipoMidiaOperacaoEstacionamento()
        {
            return _driver.GetSelect(By.CssSelector("select[name='tipoMidiaOperacao']"));
        }


    }
}