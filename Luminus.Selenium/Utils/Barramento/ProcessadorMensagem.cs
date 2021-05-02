using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Luminus.Selenium.Utils.Barramento
{
    public class ProcessadorMensagem
    {
        public static string UrlBarramento;

        public object Processar(string caminhoArquivoMsgJson, IEnumerable<CamposAlterarMensagemDto> camposAlteracao)
        {
            string request = MontarRequest(caminhoArquivoMsgJson, camposAlteracao);

            return ChamarApiProcessarAlterandoMensagem(request);
        }

        private static object ChamarApiProcessarAlterandoMensagem(string request)
        {
            string url = UrlBarramento + "api/processadormensagem/v1/processarAlterandoMensagem";

            using (HttpClient client = new HttpClient())
            {
                var content = new StringContent(request, Encoding.UTF8, "application/json");

                var result = client.PostAsync(url, content).Result;

                if (!result.IsSuccessStatusCode)
                    throw new Exception($"Erro ao chamar api do socketspacenet. Mensagem: {result.ReasonPhrase} - Corpo: {result.Content.ReadAsStringAsync().Result}");

                return JsonConvert.DeserializeObject(result.Content.ReadAsStringAsync().Result);
            }
        }

        private static string MontarRequest(string caminhoArquivoMsgJson, IEnumerable<CamposAlterarMensagemDto> camposAlteracao)
        {
            if (caminhoArquivoMsgJson == null)
                throw new ArgumentNullException(nameof(caminhoArquivoMsgJson));

            if (!File.Exists(caminhoArquivoMsgJson))
                throw new FileNotFoundException("Arquivo json contendo a mensagem não foi encontrado", caminhoArquivoMsgJson);

            var requestDto = new ProcessarAlterandoMensagemDto()
            {
                Campos = camposAlteracao
            };

            string request = JsonConvert.SerializeObject(requestDto);
            request = request.Replace("\"Mensagem\":null",
                "\"mensagem\": " + File.ReadAllText(caminhoArquivoMsgJson, Encoding.Default));
            return request;
        }
    }
}
