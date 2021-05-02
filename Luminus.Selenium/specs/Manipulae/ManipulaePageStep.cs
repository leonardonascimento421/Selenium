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
        private ManipulaePage _page = new ManipulaePage();

        [Step("Clicar no botao cadastrar")]
        public void ClicarNoBotaoCadastrar()
        {
            _page.ClicarBotaoCadastrar();
        }

        [Step("Preencher os campos da tela de cadastro parte 1 <tabela>")]
        public void PreencherOsCamposDaTeladeCadastroParte1(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherEmail(row.GetCell("email"));
            _page.PreencherSenha(row.GetCell("senha"));
            _page.PreencherConfirmarSenha(row.GetCell("confirmarSenha"));
        }

        [Step("Clicar no botão proximo")]
        public void ClicarNoBotaoProximo()
        {
            _page.ClicarBotaoProximo();
        }

        [Step("Preencher os campos da tela de cadastro parte 2 <tabela>")]
        public void PreencherOsCamposDaTeladeCadastroParte2(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherNomeCompleto(row.GetCell("nomeCompleto"));
            _page.PreencherCelular(row.GetCell("celular"));
        }

        [Step("Clicar no botao cadastrar formulario")]
        public void ClicarNoBotaoCadastrarFormulario()
        {
            _page.ClicarBotaoCadastrarFormulario();
        }
    }
}
