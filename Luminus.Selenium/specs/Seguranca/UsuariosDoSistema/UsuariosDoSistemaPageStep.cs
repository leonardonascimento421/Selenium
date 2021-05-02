
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.specs.Seguranca.UsuariosDoSistema;
using Luminus.Selenium.specs.Shared.Listagem;

namespace Luminus.Selenium.specs.Seguranca.UsuariosDoSistema
{
    public class UsuariosDoSistemaPageStep
    {
        private UsuariosDoSistemaPage _page = new UsuariosDoSistemaPage();

        [Step("Preencher os campos da tela <tabela> [UsuariosDoSistemaPageStep] [16985]")]
        public void PreencherOsCamposDaTelaAlterarUsuariosDoSistema16985(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarnomeClienteDoEstacionamentoCNPJ(row.GetCell("nomeClienteDoEstacionamentoCNPJ"));
            _page.MarcarusuarioPodeAplicarMultiplosDescontosClienteDoEstacionamento(Convert.ToBoolean(row.GetCell("usuarioPodeAplicarMultiplosDescontosClienteDoEstacionamento")));
        }

        [Step("Preencher os campos da tela <tabela> [UsuariosDoSistemaPageStep] [17595]")]
        public void PreencherOsCamposDaTelaUsuariosDoSistema17595(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreenchernomeUsuarioSistema(row.GetCell("nomeUsuarioSistema"));
            _page.PreencheremailUsuarioSistema(row.GetCell("emailUsuarioSistema"));
            _page.PreencherloginUsuarioSistema(row.GetCell("loginUsuarioSistema"));
            _page.PreenchercelularUsuarioSistema(row.GetCell("celularUsuarioSistema"));
            _page.EscolherArquivoImagem(row.GetCell("caminhoArquivoUsuarioSistema") + row.GetCell("imagemUsuarioSistema"));
            _page.SelecionarnomePerfilPerfisAcessoSistema(row.GetCell("nomePerfilPerfisAcessoSistema"));
            _page.PreenchersenhaPrimeiroAcessoUsuarioSistema(row.GetCell("senhaPrimeiroAcessoUsuarioSistema"));
            _page.PreencherconfirmacaoSenhaUsuarioSistema(row.GetCell("confirmacaoSenhaUsuarioSistema"));
        }

        [Step("Preencher os campos da tela Usuários do sistema Adicionar Cartão Operador <tabela>")]
        public void PreencherOsCamposDaTelaUsuariosDoSistemaAdicionarCartaoOperador(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.Preenchercodigodocartaooperadorcartaooperador(row.GetCell("codigodocartaooperadorcartaooperadoralterar"));
            _page.Preenchersenhadocartaocartaooperador(row.GetCell("senhadocartaocartaooperadoralterar"));
            _page.Preencherconfirmacaodasenhacartaooperador(row.GetCell("confirmacaodasenhacartaooperadoralterar"));
            _page.Preencherniveloperadorcartaooperador(row.GetCell("niveloperadorcartaooperadoralterar"));
            _page.Preencherdataexpiracaocartaooperador(row.GetCell("dataexpiracaocartaooperadoralterar"));
        }

        [Step("Verificar os campos da tela Usuários do sistema <tabela> [16513]")]
        public void VerificarOsCamposDaTelaUsuariosDoSistema16513(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                 _page.RetornarnomeClienteDoEstacionamentoCNPJ().Should().Be(row.GetCell("nomeClienteDoEstacionamentoCNPJ"));
                 _page.RetornarusuarioPodeAplicarMultiplosDescontosClienteDoEstacionamento().Should().Be(Convert.ToBoolean(row.GetCell("usuarioPodeAplicarMultiplosDescontosClienteDoEstacionamento")));
            }
        }

        [Step("Verificar os campos da tela Usuários do sistema <tabela>")]
        public void VerificarOsCamposDaTelaUsuariosDoSistema(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarnomeUsuarioSistema().Should().Be(row.GetCell("nomeUsuarioSistema"));
                _page.RetornaremailUsuarioSistema().Should().Be(row.GetCell("emailUsuarioSistema"));
                _page.RetornarloginUsuarioSistema().Should().Be(row.GetCell("loginUsuarioSistema"));
                _page.RetornarcelularUsuarioSistema().Should().Be(row.GetCell("celularUsuarioSistema"));
                _page.RetornarnomePerfilPerfisAcessoSistema().Should().Be(row.GetCell("nomePerfilPerfisAcessoSistema"));
            }
        }                         

        [Step("Preencher os campos da tela <tabela> [UsuariosDoSistemaPageStep] [17152]")]
        public void AlterarConsultandoPorCampoTabelaNaListagem17152(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreenchernomeUsuarioSistema(row.GetCell("nomeusuariosdosistemaalterar"));
            _page.PreencheremailUsuarioSistema(row.GetCell("emailusuariosdosistemaalterar"));
            _page.PreencherloginUsuarioSistema(row.GetCell("loginusuariosdosistemaalterar"));
            _page.PreenchercelularUsuarioSistema(row.GetCell("celularusuariosdosistemaalterar"));
            _page.EscolherArquivoImagem(row.GetCell("caminhoarquivousuariosdosistemaalterar") + row.GetCell("imagemusuariosdosistemaalterar"));
            _page.PreenchersenhaPrimeiroAcessoUsuarioSistema(row.GetCell("senhaprimeiroacessousuariosdosistemaalterar"));
            _page.PreencherconfirmacaoSenhaUsuarioSistema(row.GetCell("confirmacaodesenhausuariosdosistemaalterar"));
        }

        [Step("Verificar os campos da tela Usuários do sistema <tabela> [17155]")]
        public void VerificarOsCamposDaTelaUsuariosDoSistema17155(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarnomeUsuarioSistema().Should().Be(row.GetCell("nomeusuariosdosistemaalterar"));
                _page.RetornaremailUsuarioSistema().Should().Be(row.GetCell("emailusuariosdosistemaalterar"));
                _page.RetornarloginUsuarioSistema().Should().Be(row.GetCell("loginusuariosdosistemaalterar"));
                _page.RetornarcelularUsuarioSistema().Should().Be(row.GetCell("celularusuariosdosistemaalterar"));
            }
        }          
               
    }
}