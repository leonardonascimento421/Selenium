# Parâmetros Gerais do Estacionamento [14254]
Criado pelo gerador 02/12/2019 10:12:53

## Alterar a tela de parâmetros gerais do estacionamento [16228]
* ST - Criar um bolsão de vagas <table:resources/AlterarATelaDeParametrosGeraisDoEstacionamento16228.csv> [16266]
TODO Criar um Produto Estadia Credenciado(falta fazer)
* ST - Alterar a tela de parâmetros gerais do estacionamento <table:resources/AlterarATelaDeParametrosGeraisDoEstacionamento16228.csv> [17883]
* Clicar no botão Salvar
* Verificar mensagem alteracao com sucesso
* Verificar os campos da tela <table:resources/AlterarATelaDeParametrosGeraisDoEstacionamento16228.csv> [ParametrosGeraisDoEstacionamentoPageStep] [16228]
Na seção Servidor Luminus o campo Endereço IP do servidor Luminus deve conter o valor "10.100.1.104"
Na seção Servidor Luminus o campo Porta IP do servidor Luminus deve conter o valor "4200"
Na seção Servidor Luminus o campo Tempo limite para execução de transações on-line (décimo de seg) deve conter o valor "55"
Na seção Servidor Luminus o campo tempo Limite Para Recebimento De Mensagens No Barramento (Milisegundos) deve conter o valor "22222"
Na seção Servidor Luminus o campo Tempo limite para envio de mensagens no barramento (milisegundos) deve conter o valor "30000"
Na seção Operação o combobox Idioma deve conter o valor "2 - Espanhõl (AL)"
Na seção Operação o campo Horário de virada operacional deve conter o valor "03:00"
Na seção Operação o checkbox Tratar cartões fantasmas deve conter o valor "true"
Na seção Operação o checkbox Tratar cartões fantasmas para escape deve conter o valor "true"
Na seção Operação o checkbox Operação com mídias com numeração fixa deve conter o valor "true"
Na seção Operação o checkbox Habilitar consulta on-line de validações deve conter o valor "true"
Na seção Operação o checkbox Permitir criação de regras de acesso especificas nos contratos de estadia deve conter o valor "true"
Na seção Operação o checkbox Arredondar valor estadia (unidade de centavo para baixo deve conter o valor "true"
Na seção Operação o checkbox Utilizar segundos nos cálculos de estadia deve conter o valor "true"
Na seção Operação o checkbox Permitir login de operador off_line deve conter o valor "true"
Na seção Operação o checkbox Permitir operação em contingência para mídia código de barras deve conter o valor "true"
Na seção Operação o checkbox Verificar gravação mifare deve conter o valor "true"
Na seção Selos de desconto o checkbox Habilitar apenas selos de descontos gerenciados deve conter o valor "true"
Na seção Selos de desconto o campo Data base para data impressa no selo de desconto deve conter o valor "27/08/2019"
Na seção Controle de vagas o campo Tempo entre verificações da ocupação do pátio (seg) deve conter o valor "3"
Na seção Controle de vagas o campo Quantidade de verificações para considerar off-line deve conter o valor "20"
Na seção Controle de vagas o combobox Comportamento se tempo excedido deve conter o valor "1 - Liberar acesso"
Na seção Configurações de acesso Osa o combobox Produto estadia deve conter o valor "produtoEstadiaParametrosGerais"
Na seção Configurações de acesso Osa o combobox Bolsão de Vagas deve conter o valor "Bolsão de vagas 10"
Na seção LPR o checkbox Bloquear placas diferentes na saída deve conter o valor "true"
Na seção LPR o campo Quantidade máxima de caracteres diferentes deve conter o valor "1"


## Validar campos obrigatórios da tela de parâmetros gerais do estacionamento [16229]
* Navegar para "UrlParametrosGeraisPage"
* Clicar no botão Alterar
* Preencher os campos da tela <table:resources/ValidarCamposObrigatoriosDaTelaDeParametrosGeraisDoEstacionamento16229.csv> [ParametrosGeraisDoEstacionamentoPageStep] [16229]
Na seção Operação apagar o campo Horário de virada operacional com o valor ""
Na seção Selos de desconto apagar o campo Data base para data impressa no selo de desconto com o valor ""
* Clicar no botão Salvar
* Verificar mensagem de erro do campo "O campo 'Endereço IP do servidor Luminus' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Idioma' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Horário de virada operacional' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Data base para data impressa no selo de desconto' é obrigatório"


## Validar range dos campos da tela de parâmetros gerais do estacionamento [16230]
* Navegar para "UrlParametrosGeraisPage"
* Clicar no botão Alterar
* Preencher os campos da tela <table:resources/ValidarRangeDosCamposDaTelaDeParametrosGeraisDoEstacionamento16230.csv> [ParametrosGeraisDoEstacionamentoPageStep] [16230]
Na seção Servidor Luminus preencher o campo Tempo limite para execução de transações on-line (décimo de seg) com o valor "0"
Na seção Servidor Luminus preencher o campo tempo Limite Para Recebimento De Mensagens No Barramento (Milisegundos) com o valor "0"
Na seção Servidor Luminus preencher o campo Tempo limite para envio de mensagens no barramento (milisegundos) com o valor "0"
Na seção Controle de vagas preencher o campo Tempo entre verificações da ocupação do pátio (seg) com o valor "0"
Na seção Controle de vagas preencher o campo Quantidade de verificações para considerar off-line com o valor "0"
* Clicar no botão Salvar
* Verificar mensagem de erro do campo "O campo 'Tempo limite para execução de transações on-line (décimo de seg)' deve ter um valor entre 1 e 200."
* Verificar mensagem de erro do campo "O campo 'Tempo limite para recebimento de mensagens no barramento (milisegundos)' deve ter um valor entre 1000 e 600000."
* Verificar mensagem de erro do campo "O campo 'Tempo limite para envio de mensagens no barramento (milisegundos)' deve ter um valor entre 3000 e 120000."
* Verificar mensagem de erro do campo "O campo 'Tempo entre verificações da ocupação do pátio (seg)' deve ter um valor entre 1 e 600."
* Verificar mensagem de erro do campo "O campo 'Quantidade de verificações para considerar off-line' deve ter um valor entre 1 e 600."


