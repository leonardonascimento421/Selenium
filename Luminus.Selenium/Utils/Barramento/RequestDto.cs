using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luminus.Selenium.Utils.Barramento
{
    public class ProcessarAlterandoMensagemDto
    {
        public object Mensagem { get; set; }
        public IEnumerable<CamposAlterarMensagemDto> Campos { get; set; }
    }

    public class AlterarMensagemDto
    {
        public object Mensagem { get; set; }
        public IEnumerable<CamposAlterarMensagemDto> Campos { get; set; }
    }

    public class CamposAlterarMensagemDto
    {
        public CamposAlterarMensagemDto()       {        }

        public CamposAlterarMensagemDto(string campoCardData, string campoMensagem, object valor)
        {
            CampoCardData = campoCardData;
            CampoMensagem = campoMensagem;
            Valor = valor;
        }

        public string CampoCardData { get; set; }
        public string CampoMensagem { get; set; }
        public object Valor { get; set; }
    }
}
