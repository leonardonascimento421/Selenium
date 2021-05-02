
using Gauge.CSharp.Lib;
using Luminus.Selenium.Implementation.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Utils;

namespace Luminus.Selenium.specs.Operacao.ClientesDoEstacionamento
{
    public class ClientesDoEstacionamentoPage : BasePage
    {
        public void PreenchernomeClienteDoEstacionamentoCNPJ(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname=Nome]"), valor.ToString());
        }

        public string RetornarnomeClienteDoEstacionamentoCNPJ()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname=Nome]"));
        }

        public void PreencheremailClienteDoEstacionamentoCNPJ(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname=Email]"), valor.ToString());
        }

        public string RetornaremailClienteDoEstacionamentoCNPJ()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname=Email]"));
        }

        public void SelecionardocumentoClienteDoEstacionamentoCNPJ(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname=Documento1]"), valor);
        }
       
        public string RetornardocumentoClienteDoEstacionamentoCNPJ()
        {
            return _driver.GetSelect(By.CssSelector("select[formcontrolname=Documento1]"));
        }

        public void PreenchernumeroDocumentoClienteDoEstacionamentoCNPJ(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname=NumeroDocumento1]"), valor.ToString());
        }

        public string RetornarnumeroDocumentoClienteDoEstacionamentoCNPJ()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname=NumeroDocumento1]"));
        }

        public void PreenchertelefoneClienteDoEstacionamentoCNPJ(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname=Telefone]"), valor.ToString());
        }

        public string RetornartelefoneClienteDoEstacionamentoCNPJ()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname=Telefone]"));
        }

        public void PreencherlogradouroClienteDoEstacionamentoCNPJ(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname=Logradouro]"), valor.ToString());
        }

        public string RetornarlogradouroClienteDoEstacionamentoCNPJ()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname=Logradouro]"));
        }

        public void PreenchernumeroClienteDoEstacionamentoCNPJ(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname=Numero]"), valor.ToString());
        }

        public string RetornarnumeroClienteDoEstacionamentoCNPJ()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname=Numero]"));
        }

        public void PreenchercepClienteDoEstacionamentoCNPJ(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname=CEP]"), valor.ToString());
        }

        public string RetornarcepClienteDoEstacionamentoCNPJ()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname=CEP]"));
        }

        public void PreenchercidadeClienteDoEstacionamentoCNPJ(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname=Cidade]"), valor.ToString());
        }

        public string RetornarcidadeClienteDoEstacionamentoCNPJ()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname=Cidade]"));
        }

        public void PreencherufClienteDoEstacionamentoCNPJ(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname=UF]"), valor.ToString());
        }

        public string RetornarufClienteDoEstacionamentoCNPJ()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname=UF]"));
        }

        public void PreenchernomeClienteDoEstacionamento(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname=Nome]"), valor.ToString());
        }

        public string RetornarnomeClienteDoEstacionamento()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname=Nome]"));
        }

        public void PreencheremailClienteDoEstacionamento(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname=Email]"), valor.ToString());
        }

        public string RetornaremailClienteDoEstacionamento()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname=Email]"));
        }

        public void SelecionardocumentoClienteDoEstacionamento(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname=Documento1]"), valor);
        }

        public string RetornardocumentoClienteDoEstacionamento()
        {
            return _driver.GetSelect(By.CssSelector("select[formcontrolname=Documento1]"));
        }

        public void PreenchernumeroDocumentoClienteDoEstacionamento(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname=NumeroDocumento1]"), valor.ToString());
        }

        public string RetornarnumeroDocumentoClienteDoEstacionamento()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname=NumeroDocumento1]"));
        }

        public void Selecionardocumento2ClienteDoEstacionamento(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname=Documento2]"), valor);
        }

        public string Retornardocumento2ClienteDoEstacionamento()
        {
            return _driver.GetSelect(By.CssSelector("select[formcontrolname=Documento2]"));
        }

        public void PreenchernumeroDocumento2ClienteDoEstacionamento(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname=NumeroDocumento2]"), valor.ToString());
        }

        public string RetornarnumeroDocumento2ClienteDoEstacionamento()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname=NumeroDocumento2]"));
        }                

        public void PreenchertelefoneClienteDoEstacionamento(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname=Telefone]"), valor.ToString());
        }

        public string RetornartelefoneClienteDoEstacionamento()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname=Telefone]"));
        }

        public void PreencherlogradouroClienteDoEstacionamento(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname=Logradouro]"), valor.ToString());
        }

        public string RetornarlogradouroClienteDoEstacionamento()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname=Logradouro]"));
        }

        public void PreenchernumeroClienteDoEstacionamento(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname=Numero]"), valor.ToString());
        }

        public string RetornarnumeroClienteDoEstacionamento()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname=Numero]"));
        }

        public void PreenchercepClienteDoEstacionamento(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname=CEP]"), valor.ToString());
        }

        public string RetornarcepClienteDoEstacionamento()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname=CEP]"));
        }

        public void PreenchercidadeClienteDoEstacionamento(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname=Cidade]"), valor.ToString());
        }

        public string RetornarcidadeClienteDoEstacionamento()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname=Cidade]"));
        }

        public void PreencherufClienteDoEstacionamento(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname=UF]"), valor.ToString());
        }

        public string RetornarufClienteDoEstacionamento()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname=UF]"));
        }      

        public void PreenchercelularClienteDoEstacionamento(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname=Celular]"), valor.ToString());
        }

        public string RetornarcelularClienteDoEstacionamento()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname=Celular]"));
        }

        public void PreenchercomplementoClienteDoEstacionamento(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname=Complemento]"), valor.ToString());
        }

        public string RetornarcomplementoClienteDoEstacionamento()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname=Complemento]"));
        }

        public void Preencherobservacao1ClienteDoEstacionamento(string valor)
        {
            _driver.SetText(By.CssSelector("textarea[formcontrolname=Observacao1]"), valor.ToString());
        }

        public string Retornarobservacao1ClienteDoEstacionamento()
        {
            return _driver.GetText(By.CssSelector("textarea[formcontrolname=Observacao1]"));
        }

        public void Preencherobservacao2ClienteDoEstacionamento(string valor)
        {
            _driver.SetText(By.CssSelector("textarea[formcontrolname=Observacao2]"), valor.ToString());
        }

        public string Retornarobservacao2ClienteDoEstacionamento()
        {
            return _driver.GetText(By.CssSelector("textarea[formcontrolname=Observacao2]"));
        }

        public void PreencherplacaClienteDoEstacionamento(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname=Placa]"), valor.ToString());
        }

        public IWebElement RetornarTabelaVeiculos()
        {
            return _driver.GetElement(
                new ByChained(
                    By.XPath("//legend[contains(text(),'Veículos')]/.."),
                    By.CssSelector("table")));
        }

        public string RetornarplacaClienteDoEstacionamento(IWebElement tabela, int numeroLinha)
        {
            return _driver.GetColumnText(tabela, "Placa", numeroLinha);         
        }

        public void SelecionarmodeloClienteDoEstacionamento(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='Modelo.Id']"), valor);
        }

        public string RetornarmodeloClienteDoEstacionamento(IWebElement tabela, int numeroLinha)
        {
            return _driver.GetColumnText(tabela, "Modelo", numeroLinha);
        }

        public void SelecionarcorClienteDoEstacionamento(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='Cor.Id']"), valor); 
        }

        public string RetornarcorClienteDoEstacionamento(IWebElement tabela, int numeroLinha)
        {
            return _driver.GetColumnText(tabela, "Cor", numeroLinha);
        }
    }
}