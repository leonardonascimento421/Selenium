# Regras de acesso [15989]
Criado pelo gerador 11/12/2019 12:19:19

* Carregar dependências Regras de acesso <table:resources/CriarUmaRegraDeAcesso16085.csv>
ST - Criar um bolsão de vagas <table:resources/CriarUmaRegraDeAcesso16085.csv> [16266]

## Criar uma regra de acesso com a função de operação Entrada [16004]
* ST - Criar uma regra de acesso Entrada <table:resources/CriarUmaRegraDeAcessoComAFuncaoDeOperacaoEntrada16004.csv> [16330]
Na seção "Informações gerais" preencher o campo "Nome" com o valor "Entrada"
Na seção "Informações gerais" Clicar no Combobox "Função de operação do equipamento" e selecionar o valor "1 - Entrada"
* Clicar no menu de contexto (...) na linha contendo o valor "Entrada" na tabela
* Clicar no botão Detalhar na listagem
* Verificar os campos da tela <table:resources/CriarUmaRegraDeAcessoComAFuncaoDeOperacaoEntrada16004.csv> [RegrasDeAcessoPageStep] [16004]
Na seção informações gerais o campo "Nome" deve conter o valor "Entrada"
Na seção informações gerais o combobox "Função de operação do equipamento" deve conter o valor "1 - Entrada"
* Clicar no botão Voltar 

## Criar uma regra de acesso com a função de operação Passagem [16005]
* ST - Criar uma regra de acesso Passagem <table:resources/CriarUmaRegraDeAcessoComAFuncaoDeOperacaoPassagem16005.csv> [16331]
Na seção "Informações gerais" preencher o campo "Nome" com o valor "Passagem"
Na seção "Informações gerais" Clicar no Combobox "Função de operação do equipamento" e selecionar o valor "2 - Passagem"
* Clicar no menu de contexto (...) na linha contendo o valor "Passagem" na tabela
* Clicar no botão Detalhar na listagem
* Verificar os campos da tela <table:resources/CriarUmaRegraDeAcessoComAFuncaoDeOperacaoPassagem16005.csv> [RegrasDeAcessoPageStep] [16005]
Na seção informações gerais o campo "Nome" deve conter o valor "Passagem"
Na seção informações gerais o combobox "Função de operação do equipamento" deve conter o valor "2 - Passagem"
* Clicar no botão Voltar 

## Criar uma regra de acesso com a função de operação Saída [16006]
* ST - Criar uma regra de acesso Saída <table:resources/CriarUmaRegraDeAcessoComAFuncaoDeOperacaoSaida16006.csv> [16333]
Na seção "Informações gerais" preencher o campo "Nome" com o valor "Saída"
Na seção "Informações gerais" Clicar no Combobox "Função de operação do equipamento" e selecionar o valor "4 - Saída"
* Clicar no menu de contexto (...) na linha contendo o valor "Saída" na tabela
* Clicar no botão Detalhar na listagem
* Verificar os campos da tela <table:resources/CriarUmaRegraDeAcessoComAFuncaoDeOperacaoSaida16006.csv> [RegrasDeAcessoPageStep] [16006]
Na seção informações gerais o campo "Nome" deve conter o valor "Saída"
Na seção informações gerais o combobox "Função de operação do equipamento" deve conter o valor "4 - Saída"
* Clicar no botão Voltar 

## Validar campos obrigatórios da regra de acesso [16033]
* Navegar para "UrlRegraDeAcessoPage"
* Clicar no botão Criar
* Preencher os campos da tela <table:resources/ValidarCamposObrigatoriosDaRegraDeAcesso16033.csv> [RegrasDeAcessoPageStep] [16033]
Na seção Informações de acesso marcar o checkbox D em Dias válidos "domingo"
Na seção Bolsões de vagas precedentes válidos marcar o checkbox verificar bolsão precedente "true"
Na seção Bolsões de vagas precedentes válidos clicar no combobox Veículos permitidos e selecionar o valor Em Branco 
Na seção Bolsões de vagas precedentes válidos clicar no combobox Cartões vencidos e selecionar o valor Em Branco
Na seção Bolsões de vagas precedentes válidos clicar no combobox Permitir acesso de pré-pagos com saldo negativo e selecionar o valor Em Branco 
Na seção Tempo de trânsito preencher o campo Tempo de trânsito entre equipamentos apagar o valor '00:15' 
Na seção Tempo de trânsito clicar no combobox Calcula tempo de trânsito a partir e selecionar o valor Em Branco 
Na seção Tempo de trânsito clicar no combobox Se tempo de trânsito excedido e selecionar o valor Em Branco
Na seção Acesso assistido clicar no combobox Considerar veículos e selecionar o valor Em Branco
* Clicar no botão Salvar
* Verificar mensagem de erro do campo "O campo 'Nome' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Função de operação do equipamento' é obrigatório"
* Verificar mensagem de erro do campo "Ao menos um bolsão de vagas é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Veículos permitidos' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Cartões vencidos' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Permitir acesso de pré-pagos com saldo negativo' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Tempo de trânsito entre equipamentos' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Calcula tempo de trânsito a partir' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Se tempo de trânsito excedido' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Considerar veículos' é obrigatório"

## Criar uma Regra de acesso [16085]
* ST - Criar uma regra de acesso <table:resources/CriarUmaRegraDeAcesso16085.csv> [16271]
Na seção "Informações gerais" preencher o campo "Nome" com o valor "Regra de acesso"
Na seção "Informaçoes gerais" clicar no combobox "Função de operação do equipamento" e selecionar o valor "1 - Entrada"
Na seção "Informações de acesso" marcar o checkbox "dias válidos" "true"
Na seção "Informações de acesso" marcar o checkbox "Dias válidos" "true"
Na seção "Informações de acesso" marcar o checkbox "Dias válidos" "true"
Na seção "Informações de acesso" marcar o checkbox "Dias válidos" "true"
Na seção "Informações de acesso"marcar o checkbox "Dias válidos" "true"
Na seção "Informações de acesso"marcar o checkbox "Dias válidos" "true"
Na seção "Informações de acesso"marcar o checkbox "Dias válidos" "true"
Na seção "Informações de acesso" preencher o campo "das" do rótulo "Período válido durante o dia" com o valor "00:00"
Na seção "Informações de acesso" preencher o campo "das" do rótulo "Período válido durante o dia" com o valor "23:59"
Na seção "Bolsões de vagas precedentes válidos" marcar o checkbox "Verificar bolsão precedente" "true"
Na seção "Bolsões de vagas precedentes válidos" selecionar a opção "Bolsão de regras de acesso" clicar no botão  "Mover ( -> )" da dual listbox "Não selecionados"
Na seção "Bolsões de vagas precedentes válidos" clicar no combobox "Veículos permitidos" e selecionar o valor "1 - Carro"
Na seção "Bolsões de vagas precedentes válidos"clicar no combobox "Cartões vencidos" e selecionar o valor "1 - Recolhe"
Na seção "Bolsões de vagas precedentes válidos" preencher o campo "Tolerância em dias para cartões vencidos"com o valor "1"
Na seção "Bolsões de vagas precedentes válidos" preencher o campo "Tempo considerado para desistência (seg)" com o valor "1"
Na seção "Bolsões de vagas precedentes válidos" marcar o checkbox "Tratar cartões fantasmas" "true"
Na seção "Bolsões de vagas precedentes válidos" marcar o checkbox "Rejeitar cartões inconsistentes no dispensador" "true"
Na seção "Bolsões de vagas precedentes válidos" marcar o checkbox "Realizar validacao da estadia na entrada" "true"
Na seção "Bolsões de vagas precedentes válidos" marcar o checkbox "Permitir emissão de recibo em impressora remota" "true"
Na seção "Bolsões de vagas precedentes válidos" clicar no combobox "Permitir acesso de pré-pagos com saldo negativo" e selecionar o valor "1 - Recolhe"
Na seção "Tempo de trânsito" preencher o campo "Tempo de trânsito entre equipamentos" com o valor "00:01"
Na seção "Tempo de trânsito" clicar no combobox "Calcula tempo de trânsito a partir" e selecionar o valor "1 - Última passagem"
Na seção "Tempo de trânsito" clicar no combobox "Se tempo de trânsito excedido" e selecionar o valor "1 - Mudar tabela de cobrança"
Na seção "Acesso assistido" clicar no combobox "Considerar veículos" e selecionar o valor "0 - Sem diferenciação"
Na seção "Acesso assistido" marcar o checkbox "Informar prisma em operação de entrada" "true"
Na seção "Acesso assistido" marcar o checkbox "Informar placa em operação de entrada" "true"
Na seção "Acesso assistido" marcar o checkbox "Habilitar número do prisma igual ao ticket de entrada" "true"
Na seção "Acesso assistido" marcar o checkbox "Utilizar lista de veículos com modelo e marca" "true"
Na seção "Acesso assistido" marcar o checkbox "Permitir geração de ticket na entrada"  "true"
Na seção "Acesso assistido"marcar o checkbox "Reimprimir código de barras no informe de entrada de credenciado"  "true"
Na seção "Acesso assistido"marcar o checkbox "Reimprimir código de barras na chamada de veículo (impressora remota) para credenciado"  "true"
Na seção "Acesso assistido"  marcar o checkbox "Permitir validação da estadia na entrada" "true"
Na seção "Acesso assistido" marcar o checkbox "Permitir impressão remota de informativo para chamada de veículo sem realizar saída" "true"
Na seção "Acesso assistido" marcar o checkbox "Exibir informação de lotado no display secundário" "true"
Na seção "Acesso assistido" marcar o checkbox "Informar localização do veículo em operação de entrada" "true"
Clicar no menu de contexto de "Domingo" na tabela de "Gate mode" e selecionar a opção "alterar"
Na seção "Alterar gate mode por dia da semana" clicar no combobox "Carro"  e selecionar o valor "2 - Acesso secundário" do combobox
Na seção "Alterar gate mode por dia da semana" clicar no combobox "Moto" e selecionar o valor "2 - Acesso secundário"
Clicar no botão "alterar"
Clicar no botão "salvar"
* Verificar mensagem criacao com sucesso
* Clicar no menu de contexto (...) na linha contendo o valor "Regra de acesso" na tabela
* Clicar no botão Detalhar na listagem
* Verificar os campos da tela <table:resources/CriarUmaRegraDeAcesso16085.csv> [RegrasDeAcessoPageStep] [16085]
O campo "nome" deve conter o valor @nome_regrasdeacesso
A opção @funcaodeoperacao_regradeacesso deve constar no combobox "Função de operação do equipamento"
O checkbox @segunda_regrasdeacesso de dias válidos deve estar marcado
O checkbox @terca_regrasdeacesso de dias válidos deve estar marcado
O checkbox @quarta_regrasdeacesso de dias válidos deve estar marcado
O checkbox @quinta_regrasdeacesso de dias válidos deve estar marcado
O checkbox @sexta_regrasdeacesso de dias válidos deve estar marcado
O checkbox @sabado_regrasdeacesso de dias válidos deve estar marcado
O checkbox @domingo_regrasdeacesso de dias válidos deve estar marcado
O campo "das" deve constar o valor @das_regrasdeacesso do rótulo "Período válido durante o dia"
O campo "das" deve constar o valor @as_regrasdeacesso do rótulo "Período válido durante o dia"
O checkbox @verificarbolsaoprecedente "Verificar bolsão precedente" deve estar marcado
O bolsão @nomeBolsaoDeVagas deve constar na dualist "Selecionados" 
A opção @veiculospermitidos_regrasdeacesso  deve constar no combobox "Veículos permitidos"
A opção @cartoesvencidos_regrasdeacesso deve constar no combobox "Cartões vencidos"
o campo "Tolerância em dias para cartões vencidos" deve constar o valor @toleranciaemdiasparacartoesvencidos_regrasdeacesso
O campo "Tempo considerado para desistência (seg)" deve constar o valor  @tempoconsideradoparadesistenciaseg_regrasdeacesso
O checkbox "Tratar cartões fantasmas" @tratarcartoesfantasmas_regrasdeacesso deve estar marcado
O checkbox "Rejeitar cartões inconsistentes no dispensador" @rejeitarcartoesinconsistentesnodispensador_regrasdeacesso deve estar marcado
O checkbox "Realizar validacao da estadia na entrada" @realizarvalidacaodaestadiarnaentrada_regrasdeacesso deve estar marcado
O checkbox "Permitir emissão de recibo em impressora remota" @Permitiremissãodereciboemimpressoraremota_regrasdeacesso deve estar marcado
A opção @permitiracessodeprepagoscomsaldonegativo_regrasdeacesso  deve contar no combobox "Permitir acesso de pré-pagos com saldo negativo"
O campo "Tempo de trânsito entre equipamentos" deve constar o valor @tempodetransitoentreequipamentos_regrasdeacesso
A opção @calculatempodetransitoapartir_regrasdeacesso  deve contar no combobox "Calcula tempo de trânsito a partir"
A opção @setempodetransitoexcedido_regrasdeacesso  deve contar no combobox "Se tempo de trânsito excedido"
A opção @considerarveiculos_regrasdeacesso  deve contar no combobox "Considerar veículos"
O checkbox "Informar prisma em operação de entrada" deve constar o valor @Informarprismaemoperaçãodeentrada_regrasdeacesso
O checkbox "Informar placa em operação de entrada" deve constar o valor @Informarplacaemoperaçãodeentrada_regrasdeacesso
O checkbox "Habilitar número do prisma igual ao ticket de entrada" deve constar o valor @Habilitarnúmerodoprismaigualaoticketdeentrada_regrasdeacesso
O checkbox "Utilizar lista de veículos com modelo e marca" deve constar o valor @Utilizarlistadeveículoscommodeloemarca_regrasdeacesso
O checkbox "Permitir geração de ticket na entrada" deve constar o valor @Permitirgeraçãodeticketnaentrada_regrasdeacesso
O checkbox "Reimprimir código de barras no informe de entrada de credenciado" deve constar o valor @Reimprimircódigodebarrasnoinformedeentradadecredenciado_regrasdeacesso
O checkbox "Reimprimir código de barras na chamada de veículo (impressora remota) para credenciado" deve constar o valor @Reimprimircódigodebarrasnachamadadeveículo(impressoraremota)paracredenciado_regrasdeacesso
O checkbox "Permitir validação da estadia na entrada" deve constar o valor @Permitirvalidaçãodaestadianaentrada_regrasdeacesso
O checkbox "Permitir impressão remota de informativo para chamada de veículo sem realizar saída" deve constar o valor @Permitirimpressãoremotadeinformativoparachamadadeveículosemrealizarsaída_regrasdeacesso
O checkbox "Exibir informação de lotado no display secundário" deve constar o valor @Exibirinformaçãodelotadonodisplaysecundário_regrasdeacesso
O checkbox "Informar localização do veículo em operação de entrada" deve constar o valor @Informarlocalizaçãodoveículoemoperaçãodeentrada_regrasdeacesso
na linha "Domingo" na tabela de "Gate mode" deve constar os valores @Carro_regrasdeacesso e @Moto_regrasdeacesso
* Clicar no botão Voltar
 
## Alterar uma regra de acesso [16134]
* ST - Criar uma regra de acesso <table:resources/AlterarUmaRegraDeAcesso16134.csv> [16271]
* Clicar no menu de contexto (...) na linha contendo o valor "Regra de acesso para alterar" na tabela
* Clicar no botão Alterar na listagem
* Preencher os campos da tela <table:resources/AlterarUmaRegraDeAcesso16134.csv> [RegrasDeAcessoPageStep] [16134]
Na seção Informações gerais marcar o checkbox "true"
Na seção Informações gerais preencher o campo Nome com o valor "regra de acesso alterado"
Na seção Informaçoes gerais clicar no combobox Função de operação do equipamento e selecionar o valor "2 - passagem"
Na seção Informações de acesso preencher o campo das do rótulo Período válido durante o dia com o valor "00:01"
Na seção Informações de acesso preencher o campo das do rótulo Período válido durante o dia com o valor "23:24"
Na seção Bolsões de vagas precedentes válidos marcar o checkbox Verificar bolsão precedente "false"
Na seção Bolsões de vagas precedentes válidos clicar no combobox Veículos permitidos e selecionar o valor "2 - Moto"
Selecionar a opção "2 - Bloquear" do combobox Cartões vencidos
Na seção Bolsões de vagas precedentes válidosclicar no combobox Cartões vencidos e selecionar o valor "2 - Bloquear"
Na seção Bolsões de vagas precedentes válidos preencher o campo Tempo considerado para desistência (seg) com o valor "2"
Na seção Bolsões de vagas precedentes válidos marcar o checkbox Tratar cartões fantasmas "false"
Na seção Bolsões de vagas precedentes válidos marcar o checkbox Rejeitar cartões inconsistentes no dispensador "false"
Na seção Bolsões de vagas precedentes válidos marcar o checkbox Realizar validacao da estadia na entrada "false"
Na seção Bolsões de vagas precedentes válidos marcar o checkbox Permitir emissão de recibo em impressora remota "false"
Na seção Bolsões de vagas precedentes válidos clicar no combobox Permitir acesso de pré-pagos com saldo negativo e selecionar o valor "2 - Devolve"
Na seção Tempo de trânsito preencher o campo Tempo de trânsito entre equipamentos com o valor "00:15"
Na seção Tempo de trânsito clicar no combobox Calcula tempo de trânsito a partir e selecionar o valor "2 - Entrada"
Na seção Tempo de trânsito clicar no combobox Se tempo de trânsito excedido e selecionar o valor "2 - Bloquear"
Na seção Acesso assistido clicar no combobox Considerar veículos e selecionar o valor "1 - Moto"
Na seção Acesso assistido marcar o checkbox Informar prisma em operação de entrada "false"
Na seção Acesso assistido marcar o checkbox Informar placa em operação de entrada "false"
Na seção Acesso assistido marcar o checkbox Habilitar número do prisma igual ao ticket de entrada "false"
Na seção Acesso assistido marcar o checkbox Utilizar lista de veículos com modelo e marca "false"
Na seção Acesso assistido marcar o checkbox Permitir geração de ticket na entrada "false"
Na seção Acesso assistidomarcar o checkbox Reimprimir código de barras no informe de entrada de credenciado "false"
Na seção Acesso assistidomarcar o checkbox Reimprimir código de barras na chamada de veículo (impressora remota) para credenciado ""
Na seção Acesso assistido marcar o checkbox Permitir validação da estadia na entrada "false"
Na seção Acesso assistido marcar o checkbox Permitir impressão remota de informativo para chamada de veículo sem realizar saída "false"
Na seção Acesso assistido marcar o checkbox Exibir informação de lotado no display secundário "false"
Na seção Acesso assistido marcar o checkbox Informar localização do veículo em operação de entrada "false"
* Clicar no botão Salvar
* Verificar mensagem alteracao com sucesso
* Clicar no menu de contexto (...) na linha contendo o valor "Regra de acesso alterado" na tabela
* Clicar no botão Detalhar na listagem
* Verificar os campos da tela <table:resources/AlterarUmaRegraDeAcesso16134.csv> [RegrasDeAcessoPageStep] [16134]
O campo "nome" deve conter o valor @nome_regrasdeacesso
A opção @funcaodeoperacao_regradeacesso deve constar no combobox "Função de operação do equipamento"
O checkbox @segunda_regrasdeacesso de dias válidos deve estar marcado
O checkbox @terca_regrasdeacesso de dias válidos deve estar marcado
O checkbox @quarta_regrasdeacesso de dias válidos deve estar marcado
O checkbox @quinta_regrasdeacesso de dias válidos deve estar marcado
O checkbox @sexta_regrasdeacesso de dias válidos deve estar marcado
O checkbox @sabado_regrasdeacesso de dias válidos deve estar marcado
O checkbox @domingo_regrasdeacesso de dias válidos deve estar marcado
O campo "das" deve constar o valor @das_regrasdeacesso do rótulo "Período válido durante o dia"
O campo "das" deve constar o valor @as_regrasdeacesso do rótulo "Período válido durante o dia"
O checkbox @verificarbolsaoprecedente "Verificar bolsão precedente" deve estar desmarcado
A opção "2 - Moto" deve constar no combobox "Veículos permitidos"
A opção "2 - Bloquear" deve constar no combobox "Cartões vencidos"
o campo "Tolerância em dias para cartões vencidos" deve constar o valor "2 - Bloquear"
O campo "Tempo considerado para desistência (seg)" deve constar o valor  "2"
O checkbox "Tratar cartões fantasmas" @tratarcartoesfantasmas_regrasdeacesso deve estar desmarcado
O checkbox "Rejeitar cartões inconsistentes no dispensador" @rejeitarcartoesinconsistentesnodispensador_regrasdeacesso deve estar desmarcado
O checkbox "Realizar validacao da estadia na entrada" @realizarvalidacaodaestadiarnaentrada_regrasdeacesso deve estar desmarcado
O checkbox "Permitir emissão de recibo em impressora remota" @Permitiremissãodereciboemimpressoraremota_regrasdeacesso deve estar desmarcado
A opção "2 - Devolve" deve contar no combobox "Permitir acesso de pré-pagos com saldo negativo"
O campo "Tempo de trânsito entre equipamentos" deve constar o valor "00:15"
A opção "2 - Entrada" deve contar no combobox "Calcula tempo de trânsito a partir"
A opção "2 - Bloquear" deve contar no combobox "Se tempo de trânsito excedido"
A opção "1 - Moto" deve contar no combobox "Considerar veículos"
O checkbox "Informar prisma em operação de entrada" deve constar o valor "false"
O checkbox "Informar placa em operação de entrada" deve constar o valor "false"
O checkbox "Habilitar número do prisma igual ao ticket de entrada" deve constar o valor "false"
O checkbox "Utilizar lista de veículos com modelo e marca" deve constar o valor "false"
O checkbox "Permitir geração de ticket na entrada" deve constar o valor "false"
O checkbox "Reimprimir código de barras no informe de entrada de credenciado" deve constar o valor "false"
O checkbox "Reimprimir código de barras na chamada de veículo (impressora remota) para credenciado" deve constar o valor "false"
O checkbox "Permitir validação da estadia na entrada" deve constar o valor "false"
O checkbox "Permitir impressão remota de informativo para chamada de veículo sem realizar saída" deve constar o valor "false"
O checkbox "Exibir informação de lotado no display secundário" deve constar o valor "false"
O checkbox "Informar localização do veículo em operação de entrada" deve constar o valor "false"
* Clicar no botão Voltar

## Excluir uma regra de acesso [16251]
* ST - Criar uma regra de acesso <table:resources/ExcluirUmaRegraDeAcesso16251.csv> [16271]
Na seção "Informações gerais" preencher o campo "Nome" com o valor "Regra de acesso excluir"
Na seção "Informaçoes gerais" clicar no combobox "Função de operação do equipamento" e selecionar o valor "1 - Entrada"
Na seção "Informações de acesso" marcar o checkbox "dias válidos" "true"
Na seção "Informações de acesso" marcar o checkbox "Dias válidos" "true"
Na seção "Informações de acesso" marcar o checkbox "Dias válidos" "true"
Na seção "Informações de acesso" marcar o checkbox "Dias válidos" "true"
Na seção "Informações de acesso"marcar o checkbox "Dias válidos" "true"
Na seção "Informações de acesso"marcar o checkbox "Dias válidos" "true"
Na seção "Informações de acesso"marcar o checkbox "Dias válidos" "true"
Na seção "Informações de acesso" preencher o campo "das" do rótulo "Período válido durante o dia" com o valor "00:00"
Na seção "Informações de acesso" preencher o campo "das" do rótulo "Período válido durante o dia" com o valor "23:59"
Na seção "Bolsões de vagas precedentes válidos" marcar o checkbox "Verificar bolsão precedente" "true"
Na seção "Bolsões de vagas precedentes válidos" selecionar a opção "Bolsão de regras de acesso" clicar no botão  "Mover ( -> )" da dual listbox "Não selecionados"
Na seção "Bolsões de vagas precedentes válidos" clicar no combobox "Veículos permitidos" e selecionar o valor "1 - Carro"
Na seção "Bolsões de vagas precedentes válidos"clicar no combobox "Cartões vencidos" e selecionar o valor "1 - Recolhe"
Na seção "Bolsões de vagas precedentes válidos" preencher o campo "Tolerância em dias para cartões vencidos"com o valor "1"
Na seção "Bolsões de vagas precedentes válidos" preencher o campo "Tempo considerado para desistência (seg)" com o valor "1"
Na seção "Bolsões de vagas precedentes válidos" marcar o checkbox "Tratar cartões fantasmas" "true"
Na seção "Bolsões de vagas precedentes válidos" marcar o checkbox "Rejeitar cartões inconsistentes no dispensador" "true"
Na seção "Bolsões de vagas precedentes válidos" marcar o checkbox "Realizar validacao da estadia na entrada" "true"
Na seção "Bolsões de vagas precedentes válidos" marcar o checkbox "Permitir emissão de recibo em impressora remota" "true"
Na seção "Bolsões de vagas precedentes válidos" clicar no combobox "Permitir acesso de pré-pagos com saldo negativo" e selecionar o valor "1 - Recolhe"
Na seção "Tempo de trânsito" preencher o campo "Tempo de trânsito entre equipamentos" com o valor "00:01"
Na seção "Tempo de trânsito" clicar no combobox "Calcula tempo de trânsito a partir" e selecionar o valor "1 - Última passagem"
Na seção "Tempo de trânsito" clicar no combobox "Se tempo de trânsito excedido" e selecionar o valor "1 - Mudar tabela de cobrança"
Na seção "Acesso assistido" clicar no combobox "Considerar veículos" e selecionar o valor "0 - Sem diferenciação"
Na seção "Acesso assistido" marcar o checkbox "Informar prisma em operação de entrada" "true"
Na seção "Acesso assistido" marcar o checkbox "Informar placa em operação de entrada" "true"
Na seção "Acesso assistido" marcar o checkbox "Habilitar número do prisma igual ao ticket de entrada" "true"
Na seção "Acesso assistido" marcar o checkbox "Utilizar lista de veículos com modelo e marca" "true"
Na seção "Acesso assistido" marcar o checkbox "Permitir geração de ticket na entrada"  "true"
Na seção "Acesso assistido"marcar o checkbox "Reimprimir código de barras no informe de entrada de credenciado"  "true"
Na seção "Acesso assistido"marcar o checkbox "Reimprimir código de barras na chamada de veículo (impressora remota) para credenciado"  "true"
Na seção "Acesso assistido"  marcar o checkbox "Permitir validação da estadia na entrada" "true"
Na seção "Acesso assistido" marcar o checkbox "Permitir impressão remota de informativo para chamada de veículo sem realizar saída" "true"
Na seção "Acesso assistido" marcar o checkbox "Exibir informação de lotado no display secundário" "true"
Na seção "Acesso assistido" marcar o checkbox "Informar localização do veículo em operação de entrada" "true"
Clicar no menu de contexto de "Domingo" na tabela de "Gate mode" e selecionar a opção "alterar"
Na seção "Alterar gate mode por dia da semana" clicar no combobox "Carro"  e selecionar o valor "2 - Acesso secundário" do combobox
Na seção "Alterar gate mode por dia da semana" clicar no combobox "Moto" e selecionar o valor "2 - Acesso secundário"
Clicar no botão "alterar"
Clicar no botão "salvar"
* Clicar no menu de contexto (...) na linha contendo o valor "Regra de acesso excluir" na tabela
* Clicar no botão Excluir na listagem
* Clicar no botão Excluir
* Verificar mensagem exclusao com sucesso