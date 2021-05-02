
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Pages.Shared.Listagem;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.Implementation.Shared.Navegacao;
using Luminus.Selenium.specs.Shared.SsExecutarProcessadorDeMensagemM20126661;
using Luminus.Selenium.Utils.Barramento;

namespace Luminus.Selenium.specs.Shared.SsExecutarProcessadorDeMensagemM20126661
{
    public class SsExecutarProcessadorDeMensagemM20126661PageStep
    {
        private SsExecutarProcessadorDeMensagemM20126661Page _page = new SsExecutarProcessadorDeMensagemM20126661Page();
        private ListagemPage _listagemPage = new ListagemPage();
        private NavegacaoSpec _pageNavegacao = new NavegacaoSpec();
        private BotoesCRUDSpec _pageBotoes = new BotoesCRUDSpec();
        private MensagemSpec _pageMensagens = new MensagemSpec();

        [Step("SS - Executar Processador de mensagem M201 <tabela> [26661]")]
        public void SsExecutarProcessadorDeMensagemM20126661(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            new ProcessadorMensagem().Processar("specs/Shared/MensagensBarramento/M201NORMALENTRANCETICKET.json", new[]
            {
                new CamposAlterarMensagemDto(null, "data_entrada", DateTime.Now),
                new CamposAlterarMensagemDto(null, "id_entra", int.Parse(row.GetCell("idEntrada"))),
                new CamposAlterarMensagemDto("NumeroEquipamento", null , int.Parse(row.GetCell("idEntrada"))),
                new CamposAlterarMensagemDto("DataMensagem", null, DateTime.Now)
            });
        }

        [Step("Na seção 'Estadias abertas' na coluna 'Identificação da mídia' deve existir a mídia de numero <identificacaoMidia> [ExecutarProcessadorDeMensagemM201StepByStepPageStep]")]
        public void NaSecaoEstadiasAbertasNaColunaIdentificacaoDaMidiaDeveExistirAMidiaDeNumeroExecutarprocessadordemensagemm201stepbysteppagestep(Table tabela)
        {
            var row = tabela.GetTableRows()[0];

            _pageNavegacao.NavegarParaUrl("UrlEstadiasAbertas");
            _listagemPage.RetornarLinhaDaTabelaComValor(row.GetCell("identificacaoMidia")).Should().BeNullOrEmpty();



            // _pageNavegacao.NavegarParaUrl("UrlEstadiasAbertas");
            // _listagemPage.RetornarLinhaDaTabelaComValor(row.GetCell("identificacaoMidia")).Should().BeNullOrEmpty();
        }


    }
}