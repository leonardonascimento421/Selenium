# Contratos de estadia dia do mês [17346]
Criado pelo gerador 09/03/2020 10:35:42

* Carregar dependências Contratos De Estadia <table:resources/CriarDependenciasDeContratoDeEstadia.csv>
SS - Criar um bolsão de vagas <table:resources/CriarDependenciasDeContratoDeEstadia.csv> [16266]
SS - Criar uma Estrutura de cobrança <table:resources/CriarDependenciasDeContratoDeEstadia.csv> [16003]
SS - Criar regras de cobrança <table:resources/CriarDependenciasDeContratoDeEstadia.csv> [16135]
SS - Criar uma regra de acesso Entrada <table:resources/CriarDependenciasDeContratoDeEstadia.csv> [16330]
SS - Criar uma regra de acesso Passagem <table:resources/CriarDependenciasDeContratoDeEstadia.csv> [16331]
SS - Criar uma regra de acesso Saída <table:resources/CriarDependenciasDeContratoDeEstadia.csv> [16333]
SS - Criar tabelas de cobrança <table:resources/CriarDependenciasDeContratoDeEstadia.csv> [16091]
SS - Criar um produto estadia do tipo credenciado com tipo de revalidação quantidade de dias <table:resources/CriarDependenciasDeContratoDeEstadia.csv> [16346]

## Criar contrato de estadia Produto estadia 'Dia do mês' [17361]
* ST - Criar clientes do estacionamento <table:resources/CriarContratoDeEstadiaProdutoEstadiaDiaDoMes17361.csv> [16128]
* SS - Criar contrato de estadia Produto estadia 'Dia do mês' <table:resources/CriarContratoDeEstadiaProdutoEstadiaDiaDoMes17361.csv> [17885]
* Clicar no botão Salvar
* Clicar no botão Salvar e Sair
* Clicar no menu de contexto (...) na linha contendo o valor "Contrato Cliente 17361" na tabela
* Clicar no botão Detalhar na listagem
* Verificar os campos da tela <table:resources/CriarContratoDeEstadiaProdutoEstadiaDiaDoMes17361.csv> [ContratosDeEstadiaPageStep] [17361]
* Na seção Informações gerais o campo Vigente a partir de deve conter a data de criação DateTime_now [ContratosDeEstadiaPageStep]
* Na seção Mídia de acesso, na tabela deve apresentar a mensagem Não há registros a serem exibidos [ContratosDeEstadiaPageStep]
Na seção Informações gerais o cambobox Produto de estadia deve constar o valor "Contrato Produto Estadia Dia do mês"
Na seção Informações gerais o combobox Cliente do estacionamento deve constar o valor "Contrato Cliente 17361"
Na seção Informações gerais no campo Válido até deve constar o valor "a data atual"
Na seção Aditamento deve apresentar na coluna Data da validação deve constar o valor "a data atual" na coluna Valor da validação deve constar o valor "100" na coluna Meio de pagamento deve constar o valor "0 - Dinheiro" na coluna Valor recebido deve constar o valor "100" na coluna Validado até deve constar o valor "a data atual"
* Clicar no botão Voltar

## Criar contrato de estadia Produto estadia 'Dia do mês' com Mídia Mifare [17366]
* ST - Criar clientes do estacionamento <table:resources/CriarContratoDeEstadiaProdutoEstadiaDiaDoMesComMidiaMifare17366.csv> [16128]
* SS - Criar contrato de estadia Produto estadia 'Dia do mês' <table:resources/CriarContratoDeEstadiaProdutoEstadiaDiaDoMesComMidiaMifare17366.csv> [17885]
* SS - Incluir mídia Mifare em um contrato de estadia <table:resources/CriarContratoDeEstadiaProdutoEstadiaDiaDoMesComMidiaMifare17366.csv> [17860]
* Clicar no botão Salvar
* Clicar no botão Salvar e Sair
* Clicar no menu de contexto (...) na linha contendo o valor "Contrato Cliente 17366" na tabela
* Clicar no botão Detalhar na listagem
* Verificar os campos da tela <table:resources/CriarContratoDeEstadiaProdutoEstadiaDiaDoMesComMidiaMifare17366.csv> [ContratosDeEstadiaPageStep] [17366]
Na seção Informações gerais o cambobox Produto de estadia deve conter o valor "Contrato Produto Estadia Dia do mês"
Na seção Informações gerais o combobox Cliente do estacionamento deve conter o valor "Contrato Cliente 17366"
* Na seção Informações gerais o campo Vigente a partir de deve conter a data de criação DateTime_now [ContratosDeEstadiaPageStep]
Na seção Mídia de acesso deve apresentar uma tabela com as colunas:Tipo da mídia de acesso, Identificação da mídia de acesso, Data da inclusão, Data de expiração e Status da mídia de acesso
* Na seção Aditamento, na tabela deve apresentar a mensagem Não há registros a serem exibidos [ContratosDeEstadiaPageStep]
* Clicar no botão Voltar

## Criar contrato de estadia Produto estadia 'Dia do mês' com Mídia Barcode [17371]
* ST - Criar clientes do estacionamento <table:resources/CriarContratoDeEstadiaProdutoEstadiaDiaDoMesComMidiaBarcode17371.csv> [16128]
* SS - Criar contrato de estadia Produto estadia 'Dia do mês' <table:resources/CriarContratoDeEstadiaProdutoEstadiaDiaDoMesComMidiaBarcode17371.csv> [17885]
* SS - Incluir mídia Barcode em um contrato de estadia <table:resources/CriarContratoDeEstadiaProdutoEstadiaDiaDoMesComMidiaBarcode17371.csv> [17845]
* Clicar no botão Salvar
* Clicar no botão Salvar e Sair
* Clicar no menu de contexto (...) na linha contendo o valor "Contrato Cliente 17371" na tabela
* Clicar no botão Detalhar na listagem
* Verificar os campos da tela <table:resources/CriarContratoDeEstadiaProdutoEstadiaDiaDoMesComMidiaBarcode17371.csv> [ContratosDeEstadiaPageStep] [17371]
Na seção Informações gerais o cambobox Produto de estadia deve conter o valor "Contrato Produto Estadia Dia do mês"
Na seção Informações gerais o combobox Cliente do estacionamento deve conter o valor "Contrato Cliente 17371"
Na seção Informações gerais o campo Vigente a partir de deve conter a data de criação DateTime_now 
Na seção Mídia de acesso deve apresentar uma tabela com as colunas:Tipo da mídia de acesso, Identificação da mídia de acesso, Data da inclusão, Data de expiração e Status da mídia de acesso 
Na seção Aditamento deve apresentar na coluna Data da validação deve constar o valor "" na coluna Valor da validação deve constar o valor "" na coluna Meio de pagamento deve constar o valor "" na coluna Valor recebido deve constar o valor "" na coluna Validado até deve constar o valor datetime_now 
* Clicar no botão Voltar

,## Criar contrato de estadia Produto estadia 'Dia do mês' com Mídia ConnectCar [17375]
[FEITO] ST - Criar clientes do estacionamento <table:resources/CriarContratoDeEstadiaProdutoEstadiaDiaDoMesComMidiaConnectcar17375.csv> [16128]
[FEITO] SS - Criar contrato de estadia Produto estadia 'Dia do mês' <table:resources/CriarContratoDeEstadiaProdutoEstadiaDiaDoMesComMidiaConnectcar17375.csv> [17885]
[FEITO] SS - Incluir mídia Barcode em um contrato de estadia <table:resources/CriarContratoDeEstadiaProdutoEstadiaDiaDoMesComMidiaConnectcar17375.csv> [17845]
[FEITO] SS - Incluir mídia ConnectCar em um contrato de estadia <table:resources/CriarContratoDeEstadiaProdutoEstadiaDiaDoMesComMidiaConnectcar17375.csv> [17920]
[FEITO] Clicar no botão Salvar
[FEITO] Clicar no botão Salvar e Sair
[FEITO] Clicar no menu de contexto (...) na linha contendo o valor "Contrato Cliente 17375" na tabela
[FEITO] Clicar no botão Detalhar na listagem
[FEITO] Verificar os campos da tela <table:resources/CriarContratoDeEstadiaProdutoEstadiaDiaDoMesComMidiaConnectcar17375.csv> [ContratosDeEstadiaPageStep] [17375]
[FEITO] Na seção Informações gerais o campo Vigente a partir de deve conter a data de criação DateTime_now [ContratosDeEstadiaPageStep]
Na seção Informações gerais o cambobox Produto de estadia deve conter o valor "Contrato Produto Estadia Dia do mês"
Na seção Informações gerais o combobox Cliente do estacionamento deve conter o valor "Contrato Cliente 17375"
[FEITO] Verificar os campos da tela <table:resources/CriarContratoDeEstadiaProdutoEstadiaDiaDoMesComMidiaConnectcar17375.csv> [ContratosDeEstadiaPageStep] [17375]
Na sessão Mídias de acesso deve apresentar na coluna Tipo da mídia de acesso deve apresentar "" coluna Identificação da mídia de acesso "" na coluna Data da inclusão deve apresentar datetime_now na coluna Data de expiração deve apresentar em branco na coluna Status da mídia de acesso deve apresentar 1 - Ativo
Na seção Aditamento deve apresentar na coluna Data da validação deve constar o valor "" na coluna Valor da validação deve constar o valor "" na coluna Meio de pagamento deve constar o valor "" na coluna Valor recebido deve constar o valor "" na coluna Validado até deve constar o valor datetime_now 
[FEITO] Clicar no botão Voltar

## Incluir Mídia Proximity em um contrato de estadia Produto estadia 'Dia do mês' [17376]
* ST - Criar clientes do estacionamento <table:resources/IncluirMidiaProximityEmUmContratoDeEstadiaProdutoEstadiaDiaDoMes17376.csv> [16128]
* SS - Criar contrato de estadia Produto estadia 'Dia do mês' <table:resources/IncluirMidiaProximityEmUmContratoDeEstadiaProdutoEstadiaDiaDoMes17376.csv> [17885]
* SS - Incluir mídia Barcode em um contrato de estadia <table:resources/IncluirMidiaProximityEmUmContratoDeEstadiaProdutoEstadiaDiaDoMes17376.csv> [17845]
* SS - Incluir mídia Proximity em um contrato de estadia <table:resources/IncluirMidiaProximityEmUmContratoDeEstadiaProdutoEstadiaDiaDoMes17376.csv> [17995]
* Clicar no botão Salvar
* Clicar no botão Salvar e Sair
* Clicar no menu de contexto (...) na linha contendo o valor "Contrato Cliente 17376" na tabela
* Clicar no botão Detalhar na listagem
* Verificar os campos da tela <table:resources/IncluirMidiaProximityEmUmContratoDeEstadiaProdutoEstadiaDiaDoMes17376.csv> [ContratosDeEstadiaPageStep] [17376]
Na seção Informações gerais o cambobox Produto de estadia deve conter o valor "Contrato Produto Estadia Dia do mês"
Na seção Informações gerais o combobox Cliente do estacionamento deve conter o valor "Contrato Cliente 17376"
Na seção Informações gerais o campo Vigente a partir de deve conter a data de criação DateTime_now 
Na seção Mídia de acesso deve apresentar uma tabela com as colunas:Tipo da mídia de acesso, Identificação da mídia de acesso, Data da inclusão, Data de expiração e Status da mídia de acesso
Na seção Aditamento deve apresentar na coluna Data da validação deve constar o valor "" na coluna Valor da validação deve constar o valor "" na coluna Meio de pagamento deve constar o valor "" na coluna Valor recebido deve constar o valor "" na coluna Validado até deve constar o valor datetime_now
* Clicar no botão Voltar

[DESATIVADO]
[DESATIVADO] Criar contrato de estadia Produto estadia 'Dia do mês' com Mídia Tag Nepos [17377]
[DESATIVADO] ST - Criar clientes do estacionamento <table:resources/CriarContratoDeEstadiaProdutoEstadiaDiaDoMesComMidiaTagNepos17377.csv> [16128]
[DESATIVADO] SS - Criar contrato de estadia Produto estadia 'Dia do mês' <table:resources/CriarContratoDeEstadiaProdutoEstadiaDiaDoMesComMidiaTagNepos17377.csv> [17885]
[DESATIVADO] SS - Incluir mídia Barcode em um contrato de estadia <table:resources/CriarContratoDeEstadiaProdutoEstadiaDiaDoMesComMidiaTagNepos17377.csv> [17845]
[DESATIVADO] SS - incluir mídia Tag Nepos em um contrato de estadia de um produto 'Dia do mês' <table:resources/CriarContratoDeEstadiaProdutoEstadiaDiaDoMesComMidiaTagNepos17377.csv> [17925]
[DESATIVADO] Clicar no botão Salvar
[DESATIVADO] Clicar no botão Salvar e Sair
[DESATIVADO] Clicar no menu de contexto (...) na linha contendo o valor "Contrato Cliente 17377" na tabela
[DESATIVADO] Clicar no botão Detalhar na listagem
[DESATIVADO] Verificar os campos da tela <table:resources/CriarContratoDeEstadiaProdutoEstadiaDiaDoMesComMidiaTagNepos17377.csv> [ContratosDeEstadiaPageStep] [17377]
Na seção Informações gerais o cambobox Produto de estadia deve conter o valor "Contrato Produto Estadia Dia do mês"
Na seção Informações gerais o combobox Cliente do estacionamento deve conter o valor "Contrato Cliente 17377"
Na seção Informações gerais o campo Vigente a partir de deve conter a data de criação DateTime_now 
Na seção Mídia de acesso deve apresentar uma tabela com as colunas:Tipo da mídia de acesso, Identificação da mídia de acesso, Data da inclusão, Data de expiração e Status da mídia de acesso
Na seção Aditamento deve apresentar na coluna Data da validação deve constar o valor "" na coluna Valor da validação deve constar o valor "" na coluna Meio de pagamento deve constar o valor "" na coluna Valor recebido deve constar o valor "" na coluna Validado até deve constar o valor datetime_now
[DESATIVADO] Clicar no botão Voltar

## Criar contrato de estadia Produto estadia 'Dia do mês' com Mídia Tag Genérica [17379]
* ST - Criar clientes do estacionamento <table:resources/CriarContratoDeEstadiaProdutoEstadiaDiaDoMesComMidiaTagGenerica17379.csv> [16128]
* SS - Criar contrato de estadia Produto estadia 'Dia do mês' <table:resources/CriarContratoDeEstadiaProdutoEstadiaDiaDoMesComMidiaTagGenerica17379.csv> [17885]
* SS - Incluir mídia Barcode em um contrato de estadia <table:resources/CriarContratoDeEstadiaProdutoEstadiaDiaDoMesComMidiaTagGenerica17379.csv> [17845]
* SS - Incluir mídia Tag genérica em um contrato de estadia <table:resources/CriarContratoDeEstadiaProdutoEstadiaDiaDoMesComMidiaTagGenerica17379.csv> [17937]
* Clicar no botão Salvar
* Clicar no botão Salvar e Sair
* Clicar no menu de contexto (...) na linha contendo o valor "Contrato Cliente 17379" na tabela
* Clicar no botão Detalhar na listagem
* Verificar os campos da tela <table:resources/CriarContratoDeEstadiaProdutoEstadiaDiaDoMesComMidiaTagGenerica17379.csv> [ContratosDeEstadiaPageStep] [17379]
Na seção Informações gerais o cambobox Produto de estadia deve conter o valor "Contrato Produto Estadia Dia do mês"
Na seção Informações gerais o combobox Cliente do estacionamento deve conter o valor "Contrato Cliente 17379"
Na seção Informações gerais o campo Vigente a partir de deve conter a data de criação DateTime_now 
Na seção Mídia de acesso deve apresentar uma tabela com 2 itens (1 - Cartão código de barras sem horário de entrada e 7 - Tag genérica ), com as colunas:Tipo da mídia de acesso, Identificação da mídia de acesso, Data da inclusão, Data de expiração e Status da mídia de acesso
Na seção Aditamento deve apresentar na coluna Data da validação deve constar o valor "" na coluna Valor da validação deve constar o valor "" na coluna Meio de pagamento deve constar o valor "" na coluna Valor recebido deve constar o valor "" na coluna Validado até deve constar o valor datetime_now 
* Clicar no botão Voltar

## Criar contrato de estadia Produto estadia 'Dia do mês' com Mídia Placa Veículo [17381]
* ST - Criar clientes do estacionamento <table:resources/CriarContratoDeEstadiaProdutoEstadiaDiaDoMesComMidiaPlacaVeiculo17381.csv> [16128]
* SS - Criar contrato de estadia Produto estadia 'Dia do mês' <table:resources/CriarContratoDeEstadiaProdutoEstadiaDiaDoMesComMidiaPlacaVeiculo17381.csv> [17885]
* SS - Incluir mídia Placa em um contrato de estadia <table:resources/CriarContratoDeEstadiaProdutoEstadiaDiaDoMesComMidiaPlacaVeiculo17381.csv> [17881]
* Clicar no botão Salvar
* Clicar no botão Salvar e Sair
* Clicar no menu de contexto (...) na linha contendo o valor "Contrato Cliente 17381" na tabela
* Clicar no botão Detalhar na listagem
* Verificar os campos da tela <table:resources/CriarContratoDeEstadiaProdutoEstadiaDiaDoMesComMidiaPlacaVeiculo17381.csv> [ContratosDeEstadiaPageStep] [17381]
Na seção Informações gerais o cambobox Produto de estadia deve conter o valor "Contrato Produto Estadia Dia do mês"
Na seção Informações gerais o combobox Cliente do estacionamento deve conter o valor "Contrato Cliente 17381"
Na seção Informações gerais o campo Vigente a partir de deve conter a data de criação DateTime_now 
Na seção Mídia de acesso deve apresentar uma tabela com 2 itens (1 - Cartão código de barras sem horário de entrada e 7 - Tag genérica ), com as colunas:Tipo da mídia de acesso, Identificação da mídia de acesso, Data da inclusão, Data de expiração e Status da mídia de acesso
Na seção Aditamento deve apresentar na coluna Data da validação deve constar o valor "" na coluna Valor da validação deve constar o valor "" na coluna Meio de pagamento deve constar o valor "" na coluna Valor recebido deve constar o valor "" na coluna Validado até deve constar o valor datetime_now 
* Clicar no botão Voltar

## Criar contrato de estadia Produto estadia 'Dia do mês' com Mídia Customizado [17383]
* ST - Criar clientes do estacionamento <table:resources/CriarContratoDeEstadiaProdutoEstadiaDiaDoMesComMidiaCustomizado17383.csv> [16128]
* SS - Criar contrato de estadia Produto estadia 'Dia do mês' <table:resources/CriarContratoDeEstadiaProdutoEstadiaDiaDoMesComMidiaCustomizado17383.csv> [17885]
* SS - Incluir mídia customizada em um contrato de estadia <table:resources/CriarContratoDeEstadiaProdutoEstadiaDiaDoMesComMidiaCustomizado17383.csv> [17952]
* Clicar no botão Salvar
* Clicar no botão Salvar e Sair
* Clicar no menu de contexto (...) na linha contendo o valor "Contrato Cliente 17383" na tabela
* Clicar no botão Detalhar na listagem
* Verificar os campos da tela <table:resources/CriarContratoDeEstadiaProdutoEstadiaDiaDoMesComMidiaCustomizado17383.csv> [ContratosDeEstadiaPageStep] [17383]
* Na seção Informações gerais o campo Vigente a partir de deve conter a data de criação DateTime_now [ContratosDeEstadiaPageStep]
Na seção Informações gerais o cambobox Produto de estadia deve conter o valor "Contrato Produto Estadia Dia do mês"
Na seção Informações gerais o combobox Cliente do estacionamento deve conter o valor "Contrato Cliente 17383"
Na sessão Mídias de acesso deve apresentar na coluna Tipo da mídia de acesso deve apresentar "" coluna Identificação da mídia de acesso "1000" na coluna Data da inclusão deve apresentar datetime_now na coluna Data de expiração deve apresentar em branco na coluna Status da mídia de acesso deve apresentar 1 - Ativo
Na seção Aditamento deve apresentar na coluna Data da validação deve constar o valor "" na coluna Valor da validação deve constar o valor "" na coluna Meio de pagamento deve constar o valor "" na coluna Valor recebido deve constar o valor "" na coluna Validado até deve constar o valor datetime_now
* Clicar no botão Voltar

## Aditamento de contrato de estadia de Produto de estadia 'Dia do mês' (Mifare) [17385]
* ST - Criar clientes do estacionamento <table:resources/AditamentoDeContratoDeEstadiaDeProdutoDeEstadiaDiaDoMesMifare17385.csv> [16128]
* SS - Criar contrato de estadia Produto estadia 'Dia do mês' <table:resources/AditamentoDeContratoDeEstadiaDeProdutoDeEstadiaDiaDoMesMifare17385.csv> [17885]
* SS - Incluir mídia Mifare em um contrato de estadia <table:resources/AditamentoDeContratoDeEstadiaDeProdutoDeEstadiaDiaDoMesMifare17385.csv> [17860]
* SS - Aditamento de contrato de estadia de Produto de estadia <table:resources/AditamentoDeContratoDeEstadiaDeProdutoDeEstadiaDiaDoMesMifare17385.csv> [17930]
* Clicar no botão Salvar
* Clicar no botão Salvar e Sair
* Clicar no menu de contexto (...) na linha contendo o valor "Contrato Cliente 17385" na tabela
* Clicar no botão Detalhar na listagem
* Verificar os campos da tela <table:resources/AditamentoDeContratoDeEstadiaDeProdutoDeEstadiaDiaDoMesMifare17385.csv> [ContratosDeEstadiaPageStep] [17385]
* Na seção Informações gerais o campo Vigente a partir de deve conter a data de criação DateTime_now [ContratosDeEstadiaPageStep]
Na seção Informações gerais o cambobox Produto de estadia deve constar o valor "Contrato Produto Estadia Dia do mês"
Na seção Informações gerais o combobox Cliente do estacionamento deve constar o valor "Contrato Cliente 17385"
Na seção Informações gerais no campo Válido até deve constar o valor "a data atual"
Na seção Aditamento deve apresentar
* Clicar no botão Voltar

## Aditamento de contrato de estadia de Produto de estadia 'Dia do mês' (Barcode) [17389]
* ST - Criar clientes do estacionamento <table:resources/AditamentoDeContratoDeEstadiaDeProdutoDeEstadiaDiaDoMesBarcode17389.csv> [16128]
* SS - Criar contrato de estadia Produto estadia 'Dia do mês' <table:resources/AditamentoDeContratoDeEstadiaDeProdutoDeEstadiaDiaDoMesBarcode17389.csv> [17885]
* SS - Incluir mídia Barcode em um contrato de estadia <table:resources/AditamentoDeContratoDeEstadiaDeProdutoDeEstadiaDiaDoMesBarcode17389.csv> [17845]
* SS - Realizar aditamento em um contrato de estadia de produto estadia 'Dia do mês' <table:resources/AditamentoDeContratoDeEstadiaDeProdutoDeEstadiaDiaDoMesBarcode17389.csv> [17954]
* Clicar no botão Salvar
* Clicar no botão Salvar e Sair
* Verificar mensagem alteracao com sucesso
* Clicar no menu de contexto (...) na linha contendo o valor "Contrato Cliente 17389" na tabela
* Clicar no botão Detalhar na listagem
* Verificar os campos da tela <table:resources/AditamentoDeContratoDeEstadiaDeProdutoDeEstadiaDiaDoMesBarcode17389.csv> [ContratosDeEstadiaPageStep] [17389]
Na seção Informações gerais o cambobox Produto de estadia deve constar o valor "Contrato Produto Estadia Dia do mês"
Na seção Informações gerais o combobox Cliente do estacionamento deve conter o valor "Contrato Cliente 17389"
Na seção Informações gerais o campo Vigente a partir de deve conter a data de criação DateTime_now 
Na seção Aditamento deve apresentar na coluna Data da validação deve constar o valor "" na coluna Valor da validação deve constar o valor "" na coluna Meio de pagamento deve constar o valor "" na coluna Valor recebido deve constar o valor "" na coluna Validado até deve constar o valor datetime_now
* Clicar no botão Voltar

## Incluir mais de uma mídia em um contrato de estadia [17397]
* ST - Criar clientes do estacionamento <table:resources/IncluirMaisDeUmaMidiaEmUmContratoDeEstadia17397.csv> [16128]
* SS - Criar contrato de estadia Produto estadia 'Dia do mês' <table:resources/IncluirMaisDeUmaMidiaEmUmContratoDeEstadia17397.csv> [17885]
* SS - Incluir mídia Barcode em um contrato de estadia <table:resources/IncluirMaisDeUmaMidiaEmUmContratoDeEstadia17397.csv> [17845]
* SS - Incluir mídia Proximity em um contrato de estadia <table:resources/IncluirMaisDeUmaMidiaEmUmContratoDeEstadia17397.csv> [17995]
[DESATIVADO] SS - incluir mídia Tag Nepos em um contrato de estadia de um produto 'Dia do mês' <table:resources/IncluirMaisDeUmaMidiaEmUmContratoDeEstadia17397.csv> [17925]
* Clicar no botão Salvar
* Clicar no botão Salvar e Sair
* Clicar no menu de contexto (...) na linha contendo o valor "Contrato Cliente 17397" na tabela
* Clicar no botão Detalhar na listagem
* Verificar os campos da tela <table:resources/IncluirMaisDeUmaMidiaEmUmContratoDeEstadia17397.csv> [ContratosDeEstadiaPageStep] [17397]
 Na sessão Mídias de acesso deve apresentar "1 - Cartão código de barras sem horário de entrada"
 Na sessão Mídias de acesso deve apresentar "6 - Tag Nepos"
* Clicar no botão Voltar

## Remover uma mídia de um contrato de estadia [17408]
* ST - Criar clientes do estacionamento <table:resources/RemoverUmaMidiaDeUmContratoDeEstadia17408.csv> [16128]
* SS - Criar contrato de estadia Produto estadia 'Dia do mês' <table:resources/RemoverUmaMidiaDeUmContratoDeEstadia17408.csv> [17885]
* SS - Incluir mídia Mifare em um contrato de estadia <table:resources/RemoverUmaMidiaDeUmContratoDeEstadia17408.csv> [17860]
* Clicar no botão Salvar
* Clicar no botão Salvar e Sair
* Clicar no menu de contexto (...) na linha contendo o valor "Contrato Cliente 17408" na tabela
* Clicar no botão Alterar na listagem
* Clicar no menu de contexto (...) na linha contendo o valor "2 - Cartão mifare" na tabela
* Clicar no botão Excluir na listagem
* Clicar no botão Excluir
* Verificar mensagem alteracao com sucesso
* Clicar no botão Salvar
* Clicar no botão Salvar e Sair
* Verificar mensagem alteracao com sucesso

## Regravar uma mídia mifare de um contrato de estadia (Credenciado) [17409]
* ST - Criar clientes do estacionamento <table:resources/RegravarUmaMidiaMifareDeUmContratoDeEstadiaCredenciado17409.csv> [16128]
* SS - Criar contrato de estadia Produto estadia 'Dia do mês' <table:resources/RegravarUmaMidiaMifareDeUmContratoDeEstadiaCredenciado17409.csv> [17885]
* SS - Incluir mídia Mifare em um contrato de estadia <table:resources/RegravarUmaMidiaMifareDeUmContratoDeEstadiaCredenciado17409.csv> [17860]
* Clicar no botão Salvar
* Clicar no botão Salvar e Sair
* Clicar no menu de contexto (...) na linha contendo o valor "Contrato Cliente 17409" na tabela
* Clicar no botão Alterar na listagem
* Clicar no menu de contexto (...) na linha contendo o valor "2 - Cartão mifare" na tabela
* Clicar no botão gravar cartão na listagem
* Clicar no botão Gravar Pop Up
* Clicar no botão Fechar Pop Up
* Clicar no botão Salvar
* Clicar no botão Salvar e Sair
* Clicar no menu de contexto (...) na linha contendo o valor "Contrato Cliente 17409" na tabela
* Clicar no botão Detalhar na listagem
* Verificar os campos da tela <table:resources/RegravarUmaMidiaMifareDeUmContratoDeEstadiaCredenciado17409.csv> [ContratosDeEstadiaPageStep] [17409]
Na seção Informações gerais o cambobox Produto de estadia deve constar o valor "Contrato Produto Estadia Dia do mês"
Na seção Informações gerais o combobox Cliente do estacionamento deve constar o valor "Contrato Cliente 17409"
Na seção Informações gerais no campo Válido até deve constar o valor "a data atual"
Na sessão Mídias de acesso deve apresentar na coluna Tipo da mídia de acesso deve apresentar "2 - Cartão mifare" na coluna Identificação da mídia de acesso "10" na coluna Data da inclusão deve apresentar "a data de hoje" na coluna Data de expiração deve apresentar em branco na coluna Status da mídia de acesso deve apresentar 1 - Ativo
* Clicar no botão Voltar

## Validar campos obrigatórios de um contrato de estadia [17417]
* ST - Criar clientes do estacionamento <table:resources/ValidarCamposObrigatoriosDeUmContratoDeEstadia17417.csv> [16128]
* Navegar para "UrlContratosDeEstadiaPage"
* Clicar no botão Criar
* Clicar no botão Salvar
* Clicar no botão Salvar e Continuar
* Verificar mensagem de erro do campo "O campo 'Produto de estadia' é obrigatório"
* Preencher os campos da tela <table:resources/ValidarCamposObrigatoriosDeUmContratoDeEstadia17417.csv> [ContratosDeEstadiaPageStep] [17417]
Na seção Informações gerais clicar no combobox Produto de estadia e selecionar o valor "Produto estadia dia do mês"
Na seção Informações gerais clicar no combobox Cliente do estacionamento e selecionar o valor "Selenium"
* Clicar no botão Salvar
* Clicar no botão Salvar e Continuar
* Clicar no botão adicionar na seção Mídias de acesso [ProdutoDeEstadiaPageStep]
* Clicar no botão Salvar e Fechar Pop Up
* Verificar mensagem de erro do campo "O campo 'Tipo da mídia de acesso' é obrigatório"
* No pop-up selecionar o combobox Tipo da mídia de acesso com o valor 1 - Cartão código de barras sem horário de entrada <table:resources/ValidarCamposObrigatoriosDeUmContratoDeEstadia17417.csv> [ContratosDeEstadiaPageStep] [17417]
* Clicar no botão Salvar e Fechar Pop Up
* Verificar mensagem de erro do campo "O campo 'Código do cartão' é obrigatório"
* No pop-up selecionar o combobox Tipo da mídia de acesso com o valor 2 - Cartão mifare <table:resources/ValidarCamposObrigatoriosDeUmContratoDeEstadia17417.csv> [ContratosDeEstadiaPageStep] [17417]
* Clicar no botão Salvar e Fechar Pop Up
* Verificar mensagem de erro do campo "O campo 'Código do cartão' é obrigatório"
* No pop-up selecionar o combobox Tipo da mídia de acesso com o valor 4 - ConectCar <table:resources/ValidarCamposObrigatoriosDeUmContratoDeEstadia17417.csv> [ContratosDeEstadiaPageStep] [17417]
* Clicar no botão Salvar e Fechar Pop Up
* Verificar mensagem de erro do campo "O campo 'Placa do veículo' é obrigatório"
[DESATIVADO] No pop-up selecionar o combobox Tipo da mídia de acesso com o valor 6 - Tag Nepos <table:resources/ValidarCamposObrigatoriosDeUmContratoDeEstadia17417.csv> [ContratosDeEstadiaPageStep] [17417]
[DESATIVADO] Clicar no botão Salvar e Fechar Pop Up
[DESATIVADO] Verificar mensagem de erro do campo "O campo 'Número serial da tag' é obrigatório"
* Preencher os campos do PopUp <table:resources/ValidarCamposObrigatoriosDeUmContratoDeEstadia17417.csv> [ContratosDeEstadiaPageStep] [17417]
No pop-up selecionar o combobox Tipo da mídia de acesso com o valor "1 - Cartão código de barras sem horário de entrada"
No pop-up preencher o campo Código do cartão com o valor "1"
* Clicar no botão Salvar e Fechar Pop Up
* Clicar no botão adicionar na seção Mídias de acesso [ProdutoDeEstadiaPageStep]
* No pop-up selecionar o combobox Tipo da mídia de acesso com o valor 7 - Tag genérica <table:resources/ValidarCamposObrigatoriosDeUmContratoDeEstadia17417.csv> [ContratosDeEstadiaPageStep] [17417]
* Clicar no botão Salvar e Fechar Pop Up
* Verificar mensagem de erro do campo "O campo 'Código do cartão' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Número serial da tag' é obrigatório"
* No pop-up selecionar o combobox Tipo da mídia de acesso com o valor 8 - Placa do veículo <table:resources/ValidarCamposObrigatoriosDeUmContratoDeEstadia17417.csv> [ContratosDeEstadiaPageStep] [17417]
* Clicar no botão Salvar e Fechar Pop Up
* Verificar mensagem de erro do campo "O campo 'Placa do veículo' é obrigatório"
* Clicar no botão Fechar Pop Up
* Clicar no botão adicionar na seção Aditamento [ProdutoDeEstadiaPageStep]
* Clicar no botão Salvar Pop Up
* Verificar mensagem de erro do campo "O campo 'Opção de revalidação' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Meio de pagamento' é obrigatório"
* Clicar no botão Fechar Pop Up
* Clicar no botão Voltar