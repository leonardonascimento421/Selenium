# Contratos de estadia que depende de equipamento [17346]
Criado pelo gerador 09/03/2020 10:35:42

 Carregar dependências Contratos De Estadia <table:resources/CriarDependenciasDeContratoDeEstadia.csv>
SS - Criar um bolsão de vagas <table:resources/CriarContratoDeEstadiaProdutoEstadiaDiaDoMes17361.csv> [16266]
SS - Criar uma Estrutura de cobrança <table:resources/CriarContratoDeEstadiaProdutoEstadiaDiaDoMes17361.csv> [16003]
SS - Criar regras de cobrança <table:resources/CriarContratoDeEstadiaProdutoEstadiaDiaDoMes17361.csv> [16135]
SS - Criar uma regra de acesso Entrada <table:resources/CriarContratoDeEstadiaProdutoEstadiaDiaDoMes17361.csv> [16330]
SS - Criar uma regra de acesso Passagem <table:resources/CriarContratoDeEstadiaProdutoEstadiaDiaDoMes17361.csv> [16331]
SS - Criar uma regra de acesso Saída <table:resources/CriarContratoDeEstadiaProdutoEstadiaDiaDoMes17361.csv> [16333]
SS - Criar tabelas de cobrança <table:resources/CriarContratoDeEstadiaProdutoEstadiaDiaDoMes17361.csv> [16091]
SS - Criar produto estadia do tipo credenciado com tipo de revalidação dia do mês step by step <table:resources/CriarContratoDeEstadiaProdutoEstadiaDiaDoMes17361.csv> [16289]


## Criar contrato de estadia de produto de estadia 'Dia do mês' pelo equipamento de validação EAC (Credenciado) [17393]
* SS - Criar um Equipamentos de validação (EAC) <table:resources/CriarContratoDeEstadiaDeProdutoDeEstadiaDiaDoMesPeloEquipamentoDe3.csv> [16871]
* ST - Criar clientes do estacionamento <table:resources/CriarContratoDeEstadiaDeProdutoDeEstadiaDiaDoMesPeloEquipamentoDe3.csv> [16128]
* SS - Criar contrato de estadia Produto estadia 'Dia do mês' <table:resources/CriarContratoDeEstadiaDeProdutoDeEstadiaDiaDoMesPeloEquipamentoDe3.csv> [17885]
* SS - Incluir mídia Barcode em um contrato de estadia <table:resources/CriarContratoDeEstadiaDeProdutoDeEstadiaDiaDoMesPeloEquipamentoDe3.csv> [17845]
* Clicar no botão Salvar
* Clicar no botão Salvar e Sair
* Aditar contrato no caixa <table:resources/CriarContratoDeEstadiaDeProdutoDeEstadiaDiaDoMesPeloEquipamentoDe3.csv> [ContratosDeEstadiaPageStep] [17393]
* Clicar no menu de contexto (...) na linha contendo o valor "Contrato Cliente 17393" na tabela
* Clicar no botão Detalhar na listagem
* Verificar os campos da tela <table:resources/CriarContratoDeEstadiaDeProdutoDeEstadiaDiaDoMesPeloEquipamentoDe3.csv> [ContratosDeEstadiaPageStep] [17393]

,## Realizar aditamento no equipamento de validação EAC Mifare (Pré-pago) [17405] Depende de máquina
[FAZER] SS - Criar um bolsão de vagas <table:resources/RealizarAditamentoNoEquipamentoDeValidacaoEacMifarePrePago17405.csv> [16266]
[FAZER] SS - Criar uma Estrutura de cobrança <table:resources/RealizarAditamentoNoEquipamentoDeValidacaoEacMifarePrePago17405.csv> [16003]
[FAZER] SS - Criar regras de cobrança <table:resources/RealizarAditamentoNoEquipamentoDeValidacaoEacMifarePrePago17405.csv> [16135]
[FAZER] SS - Criar tabelas de cobrança <table:resources/RealizarAditamentoNoEquipamentoDeValidacaoEacMifarePrePago17405.csv> [16091]
[FAZER] SS - Criar uma regra de acesso Entrada <table:resources/RealizarAditamentoNoEquipamentoDeValidacaoEacMifarePrePago17405.csv> [16330]
[FAZER] SS - Criar uma regra de acesso Passagem <table:resources/RealizarAditamentoNoEquipamentoDeValidacaoEacMifarePrePago17405.csv> [16331]
[FAZER] SS - Criar uma regra de acesso Saída <table:resources/RealizarAditamentoNoEquipamentoDeValidacaoEacMifarePrePago17405.csv> [16333]
[FAZER] SS - Criar Produto de estadia - Pré-pago <table:resources/RealizarAditamentoNoEquipamentoDeValidacaoEacMifarePrePago17405.csv> [16395]
[FAZER] SS - Gravação de Pré-Pago de Carro na EAC [17989]
[FAZER] SS - Criar contrato de estadia 'Pré-pago' pelo equipamento de validação EAC (Pré-pago) -Step by Step <table:resources/RealizarAditamentoNoEquipamentoDeValidacaoEacMifarePrePago17405.csv> [18014]
[FAZER] SS - Venda de Pré-pago de uma mídia Mifare [18017]
[FAZER] SS - Recarga de Pré-Pago de Carro na EAC [18021]
[FAZER] Navegar para ""
[FAZER] Na seção Consultar contratos de estadia preencher o campo Pesquisa com o valor "1" [ContratosDeEstadiaPageStep]
[FAZER] Na seção Consultar contratos de estadia clicar no menu de contexto da coluna Produto de estadia com o valor "produto estadia Pré-pago" [ContratosDeEstadiaPageStep]
[FAZER] Clicar no botão Detalhar
[FAZER] Verificar os campos da tela <table:resources/RealizarAditamentoNoEquipamentoDeValidacaoEacMifarePrePago17405.csv> [ContratosDeEstadiaPageStep] [17405]
Na seção Informações gerais o combobox Produto de estadia deve conter o valor "produto estadia Pré-pago"
Na seção Informações gerais o combobox Cliente do estacionamento deve conter o valor "Selenium"
Na seção Informações gerais o campo Vigente a partir de deve conter o valor "16/07/2018"
Na seção Informações gerais o campo Valido até deve conter o valor "12/01/2019"
Na seção Informações gerais o campo Saldo crédito deve conter o valor "10,00"
Na seção Mídias de acesso na coluna Tipo da mídia de acesso deve conter o valor "2 - Cartão mifare"
Na seção Mídias de acesso na coluna Identificação da mídia de acesso deve conter o valor "7774"
Na seção Mídias de acesso na coluna Data da inclusão deve conter o valor "16/07/2018"
Na seção Mídia de acesso o campo Data de expiração deve conter o valor "12/01/2019"
Na seção Mídias de acesso na coluna Status da mídia de acesso deve conter o valor "1 - Ativo"
Na seção Aditamento na coluna Data validação deve conter o valor "16/07/2018"
Na seção Aditamento na coluna Valor da validação deve conter o valor "10,00"
Na seção Aditamento na coluna Meio de pagamento deve conter o valor "0 - Dinheiro"
Na seção Aditamento na coluna Valor recebido deve conter o valor "10,00"
Na seção Aditamento na coluna Valor crédito deve conter o valor "10,00"
Na seção Aditamento na coluna Validado até deve conter o valor "12/01/2019"
[FAZER] Clicar no botão Voltar

,## Realizar aditamento no equipamento de validação automática Nepos Mifare (Pré-pago) [17406] Depende de máquina
[FAZER] SS - Criar um bolsão de vagas <table:resources/RealizarAditamentoNoEquipamentoDeValidacaoAutomaticaNeposMifarePrePago17406.csv> [16266]
[FAZER] SS - Criar uma Estrutura de cobrança <table:resources/RealizarAditamentoNoEquipamentoDeValidacaoAutomaticaNeposMifarePrePago17406.csv> [16003]
[FAZER] SS - Criar regras de cobrança <table:resources/RealizarAditamentoNoEquipamentoDeValidacaoAutomaticaNeposMifarePrePago17406.csv> [16135]
[FAZER] SS - Criar tabelas de cobrança <table:resources/RealizarAditamentoNoEquipamentoDeValidacaoAutomaticaNeposMifarePrePago17406.csv> [16091]
[FAZER] SS - Criar uma regra de acesso Entrada <table:resources/RealizarAditamentoNoEquipamentoDeValidacaoAutomaticaNeposMifarePrePago17406.csv> [16330]
[FAZER] SS - Criar uma regra de acesso Passagem <table:resources/RealizarAditamentoNoEquipamentoDeValidacaoAutomaticaNeposMifarePrePago17406.csv> [16331]
[FAZER] SS - Criar uma regra de acesso Saída <table:resources/RealizarAditamentoNoEquipamentoDeValidacaoAutomaticaNeposMifarePrePago17406.csv> [16333]
[FAZER] SS - Criar clientes do estacionamento pessoa Física <table:resources/RealizarAditamentoNoEquipamentoDeValidacaoAutomaticaNeposMifarePrePago17406.csv> [16128]
[FAZER] SS - Criar Produto de estadia - Pré-pago <table:resources/RealizarAditamentoNoEquipamentoDeValidacaoAutomaticaNeposMifarePrePago17406.csv> [16395]
[FAZER] SS - Criar contrato de estadia Produto estadia 'Pré-pago' <table:resources/RealizarAditamentoNoEquipamentoDeValidacaoAutomaticaNeposMifarePrePago17406.csv> [17948]
[FAZER] SS - Incluir mídia Mifare em um contrato de estadia <table:resources/RealizarAditamentoNoEquipamentoDeValidacaoAutomaticaNeposMifarePrePago17406.csv> [17860]
[FAZER] SS - Recarga de Pré-Pago de Carro na EAP [17988]
[FAZER] Clicar no menu de contexto (...) na linha contendo o valor "Selenium" na tabela
[FAZER] Clicar no botão Detalhar
[FAZER] Verificar os campos da tela <table:resources/RealizarAditamentoNoEquipamentoDeValidacaoAutomaticaNeposMifarePrePago17406.csv> [ContratosDeEstadiaPageStep] [17406]
Na seção Informações gerais o cambobox Produto de estadia deve constar o valor ""
Na seção Informações gerais o combobox Cliente do estacionamento deve constar o valor "Selenium"
Na seção Informações gerais no campo Válido até deve constar o valor "a data atual"
Na seção Informações gerais no campo Saldo crédito deve constar o valor "10,00"
Na sessão Mídias de acesso deve apresentar na coluna Tipo da mídia de acesso deve apresentar "2 - Cartão mifare" na coluna Identificação da mídia de acesso "10" na coluna Data da inclusão deve apresentar "a data de hoje" na coluna Data de expiração deve apresentar em branco na coluna Status da mídia de acesso deve apresentar 1 - Ativo
Na seção Aditamento deve apresentar na coluna Data da validação deve constar o valor "a data de hoje" na coluna Valor da validação deve constar o valor "10,00" na coluna Meio de pagamento deve constar o valor "0 - Dinheiro" na coluna Valor recebido deve constar o valor "10,00" na coluna Validado até deve constar o valor "a data de hoje"
[FAZER] Clicar no botão Voltar

,## Realizar aditamento no equipamento de validação automática Perto Mifare (Pré-pago) [17407] TODO Depende de máquina
[FAZER] SS - Criar um bolsão de vagas <table:resources/RealizarAditamentoNoEquipamentoDeValidacaoAutomaticaPertoMifarePrePago17407.csv> [16266]
[FAZER] SS - Criar uma Estrutura de cobrança <table:resources/RealizarAditamentoNoEquipamentoDeValidacaoAutomaticaPertoMifarePrePago17407.csv> [16003]
[FAZER] SS - Criar regras de cobrança <table:resources/RealizarAditamentoNoEquipamentoDeValidacaoAutomaticaPertoMifarePrePago17407.csv> [16135]
[FAZER] SS - Criar tabelas de cobrança <table:resources/RealizarAditamentoNoEquipamentoDeValidacaoAutomaticaPertoMifarePrePago17407.csv> [16091]
[FAZER] SS - Criar uma regra de acesso Entrada <table:resources/RealizarAditamentoNoEquipamentoDeValidacaoAutomaticaPertoMifarePrePago17407.csv> [16330]
[FAZER] SS - Criar uma regra de acesso Passagem <table:resources/RealizarAditamentoNoEquipamentoDeValidacaoAutomaticaPertoMifarePrePago17407.csv> [16331]
[FAZER] SS - Criar uma regra de acesso Saída <table:resources/RealizarAditamentoNoEquipamentoDeValidacaoAutomaticaPertoMifarePrePago17407.csv> [16333]
[FAZER] SS - Criar clientes do estacionamento pessoa Física <table:resources/RealizarAditamentoNoEquipamentoDeValidacaoAutomaticaPertoMifarePrePago17407.csv> [16128]
[FAZER] SS - Criar Produto de estadia - Pré-pago <table:resources/RealizarAditamentoNoEquipamentoDeValidacaoAutomaticaPertoMifarePrePago17407.csv> [16395]
[FAZER] SS - Criar contrato de estadia Produto estadia 'Pré-pago' <table:resources/RealizarAditamentoNoEquipamentoDeValidacaoAutomaticaPertoMifarePrePago17407.csv> [17948]
[FAZER] SS - Incluir mídia Mifare em um contrato de estadia <table:resources/RealizarAditamentoNoEquipamentoDeValidacaoAutomaticaPertoMifarePrePago17407.csv> [17860]
[FAZER] SS - Recarga de Pré-Pago de Carro na EAP [17988]
[FAZER] Clicar no menu de contexto (...) na linha contendo o valor "Selenium" na tabela
[FAZER] Clicar no botão Detalhar
[FAZER] Verificar os campos da tela <table:resources/RealizarAditamentoNoEquipamentoDeValidacaoAutomaticaPertoMifarePrePago17407.csv> [ContratosDeEstadiaPageStep] [17407]
Na seção Informações gerais o cambobox Produto de estadia deve constar o valor ""
Na seção Informações gerais o combobox Cliente do estacionamento deve constar o valor "Selenium"
Na seção Informações gerais no campo Válido até deve constar o valor "a data atual"
Na seção Informações gerais no campo Saldo crédito deve constar o valor "10,00"
Na sessão Mídias de acesso deve apresentar na coluna Tipo da mídia de acesso deve apresentar "2 - Cartão mifare" na coluna Identificação da mídia de acesso "10" na coluna Data da inclusão deve apresentar "a data de hoje" na coluna Data de expiração deve apresentar em branco na coluna Status da mídia de acesso deve apresentar 1 - Ativo
Na seção Aditamento deve apresentar na coluna Data da validação deve constar o valor "a data de hoje" na coluna Valor da validação deve constar o valor "10,00" na coluna Meio de pagamento deve constar o valor "0 - Dinheiro" na coluna Valor recebido deve constar o valor "10,00" na coluna Validado até deve constar o valor "a data de hoje"
[FAZER] Clicar no botão Voltar

,## Criar contrato de estadia 'Pré-pago' pelo equipamento de validação EAC (Pré-pago) [17396] TODO Depende de máquina
[FAZER] SS - Criar um bolsão de vagas <table:resources/CriarContratoDeEstadiaPrePagoPeloEquipamentoDeValidacaoEacPrePago17396.csv> [16266]
[FAZER] SS - Criar uma Estrutura de cobrança <table:resources/CriarContratoDeEstadiaPrePagoPeloEquipamentoDeValidacaoEacPrePago17396.csv> [16003]
[FAZER] SS - Criar tabelas de cobrança <table:resources/CriarContratoDeEstadiaPrePagoPeloEquipamentoDeValidacaoEacPrePago17396.csv> [16091]
[FAZER] SS - Criar regras de cobrança <table:resources/CriarContratoDeEstadiaPrePagoPeloEquipamentoDeValidacaoEacPrePago17396.csv> [16135]
[FAZER] SS - Criar uma regra de acesso Entrada <table:resources/CriarContratoDeEstadiaPrePagoPeloEquipamentoDeValidacaoEacPrePago17396.csv> [16330]
[FAZER] SS - Criar uma regra de acesso Passagem <table:resources/CriarContratoDeEstadiaPrePagoPeloEquipamentoDeValidacaoEacPrePago17396.csv> [16331]
[FAZER] SS - Criar uma regra de acesso Saída <table:resources/CriarContratoDeEstadiaPrePagoPeloEquipamentoDeValidacaoEacPrePago17396.csv> [16333]
[FAZER] SS - Criar Produto de estadia - Pré-pago <table:resources/CriarContratoDeEstadiaPrePagoPeloEquipamentoDeValidacaoEacPrePago17396.csv> [16395]
[FAZER] SS - Adicionar aplicativo <table:resources/CriarContratoDeEstadiaPrePagoPeloEquipamentoDeValidacaoEacPrePago17396.csv> [16273]
[FAZER] SS - Detalhar aplicativo EAC -Step by Step <table:resources/CriarContratoDeEstadiaPrePagoPeloEquipamentoDeValidacaoEacPrePago17396.csv> [16941]
[FAZER] SS - Criar um Equipamentos de validação (EAC) <table:resources/CriarContratoDeEstadiaPrePagoPeloEquipamentoDeValidacaoEacPrePago17396.csv> [16871]
[FAZER] SS - Gravação de Pré-Pago de Carro na EAC [17989]
[FAZER] SS - Criar contrato de estadia 'Pré-pago' pelo equipamento de validação EAC (Pré-pago) -Step by Step <table:resources/CriarContratoDeEstadiaPrePagoPeloEquipamentoDeValidacaoEacPrePago17396.csv> [18014]

,## Realizar aditamento no equipamento de validação EAC Mifare (Credenciado) [17399] TODO Depende de máquina
[FAZER] SS - Criar um bolsão de vagas <table:resources/RealizarAditamentoNoEquipamentoDeValidacaoEacMifareCredenciado17399.csv> [16266]
[FAZER] SS - Criar clientes do estacionamento pessoa Física <table:resources/RealizarAditamentoNoEquipamentoDeValidacaoEacMifareCredenciado17399.csv> [16128]
[FAZER] SS - Criar uma regra de acesso Entrada <table:resources/RealizarAditamentoNoEquipamentoDeValidacaoEacMifareCredenciado17399.csv> [16330]
[FAZER] SS - Criar uma regra de acesso Passagem <table:resources/RealizarAditamentoNoEquipamentoDeValidacaoEacMifareCredenciado17399.csv> [16331]
[FAZER] SS - Criar uma regra de acesso Saída <table:resources/RealizarAditamentoNoEquipamentoDeValidacaoEacMifareCredenciado17399.csv> [16333]
[FAZER] SS - Criar uma Estrutura de cobrança <table:resources/RealizarAditamentoNoEquipamentoDeValidacaoEacMifareCredenciado17399.csv> [16003]
[FAZER] SS - Criar regras de cobrança <table:resources/RealizarAditamentoNoEquipamentoDeValidacaoEacMifareCredenciado17399.csv> [16135]
[FAZER] SS - Criar tabelas de cobrança <table:resources/RealizarAditamentoNoEquipamentoDeValidacaoEacMifareCredenciado17399.csv> [16091]
[FAZER] SS - Criar um produto estadia do tipo credenciado com tipo de revalidação quantidade de dias <table:resources/RealizarAditamentoNoEquipamentoDeValidacaoEacMifareCredenciado17399.csv> [16346]
[FAZER] SS - Gravação de credenciado Mifare de Carro em uma EAC [17980]
[FAZER] SS - Aditamento de contrato mifare de Carro em uma EAC - Credenciado [17981]
[FAZER] Navegar para ""
[FAZER] Na seção Consultar contratos de estadia preencher o campo Pesquisa com o valor "1" [ContratosDeEstadiaPageStep]
[FAZER] Na seção Consultar contratos de estadia clicar no menu de contexto da coluna Produto de estadia com o valor "Produto estadia quantidade de dias" [ContratosDeEstadiaPageStep]
[FAZER] Clicar no botão Detalhar
[FAZER] Verificar os campos da tela <table:resources/RealizarAditamentoNoEquipamentoDeValidacaoEacMifareCredenciado17399.csv> [ContratosDeEstadiaPageStep] [17399]
Na seção Informações gerais o combobox Produto de estadia deve conter o valor "Produto estadia quantidade de dias"
Na seção Informações gerais o combobox Cliente do estacionamento deve conter o valor "Selenium"
Na sessão Mídias de acesso deve apresentar na coluna Tipo da mídia de acesso deve apresentar "2 - Cartão mifare" na coluna Identificação da mídia de acesso "10" na coluna Data da inclusão deve apresentar "a data de hoje" na coluna Data de expiração deve apresentar em branco na coluna Status da mídia de acesso deve apresentar 1 - Ativo
Na seção Aditamento deve apresentar na coluna Data da validação deve constar o valor "Data atual" na coluna Valor da validação deve constar o valor "10,00" na coluna Meio de pagamento deve constar o valor "0 - Dinheiro" na coluna Valor recebido deve constar o valor "0,00" na coluna Validado até deve constar o valor "Data atual"
[FAZER] Clicar no botão Voltar

,## Realizar aditamento no equipamento de validação automática Nepos (Credenciado) [17401] TODO Depende de máquina
[FAZER] SS - Criar um bolsão de vagas <table:resources/RealizarAditamentoNoEquipamentoDeValidacaoAutomaticaNeposCredenciado17401.csv> [16266]
[FAZER] SS - Criar uma Estrutura de cobrança <table:resources/RealizarAditamentoNoEquipamentoDeValidacaoAutomaticaNeposCredenciado17401.csv> [16003]
[FAZER] SS - Criar regras de cobrança <table:resources/RealizarAditamentoNoEquipamentoDeValidacaoAutomaticaNeposCredenciado17401.csv> [16135]
[FAZER] SS - Criar tabelas de cobrança <table:resources/RealizarAditamentoNoEquipamentoDeValidacaoAutomaticaNeposCredenciado17401.csv> [16091]
[FAZER] SS - Criar uma regra de acesso Entrada <table:resources/RealizarAditamentoNoEquipamentoDeValidacaoAutomaticaNeposCredenciado17401.csv> [16330]
[FAZER] SS - Criar uma regra de acesso Passagem <table:resources/RealizarAditamentoNoEquipamentoDeValidacaoAutomaticaNeposCredenciado17401.csv> [16331]
[FAZER] SS - Criar uma regra de acesso Saída <table:resources/RealizarAditamentoNoEquipamentoDeValidacaoAutomaticaNeposCredenciado17401.csv> [16333]
[FAZER] SS - Criar clientes do estacionamento pessoa Física <table:resources/RealizarAditamentoNoEquipamentoDeValidacaoAutomaticaNeposCredenciado17401.csv> [16128]
[FAZER] SS - Criar produto estadia do tipo credenciado com tipo de revalidação dia do mês step by step <table:resources/RealizarAditamentoNoEquipamentoDeValidacaoAutomaticaNeposCredenciado17401.csv> [16289]
[FAZER] SS - Criar contrato de estadia Produto estadia 'Dia do mês' <table:resources/RealizarAditamentoNoEquipamentoDeValidacaoAutomaticaNeposCredenciado17401.csv> [17885]
[FAZER] SS - Incluir mídia Mifare em um contrato de estadia <table:resources/RealizarAditamentoNoEquipamentoDeValidacaoAutomaticaNeposCredenciado17401.csv> [17860]
[FAZER] SS - Gravação de credenciado Mifare de Carro em uma EAC [17980]
[FAZER] SS - Aditamento de contrato de Carro em uma EAP [17987]
[FAZER] Clicar no menu de contexto (...) na linha contendo o valor "" na tabela
[FAZER] Clicar no botão Detalhar
[FAZER] Verificar os campos da tela <table:resources/RealizarAditamentoNoEquipamentoDeValidacaoAutomaticaNeposCredenciado17401.csv> [ContratosDeEstadiaPageStep] [17401]
Na seção Informações gerais o cambobox Produto de estadia deve constar o valor ""
Na seção Informações gerais o combobox Cliente do estacionamento deve constar o valor "Selenium"
Na sessão Mídias de acesso deve apresentar na coluna Tipo da mídia de acesso deve apresentar "2 - Cartão mifare" na coluna Identificação da mídia de acesso "10" na coluna Data da inclusão deve apresentar "a data de hoje" na coluna Data de expiração deve apresentar em branco na coluna Status da mídia de acesso deve apresentar 1 - Ativo
Na seção Aditamento deve apresentar na coluna Data da validação deve constar o valor "a data atual" na coluna Valor da validação deve constar o valor "100" na coluna Meio de pagamento deve constar o valor "0 - Dinheiro" na coluna Valor recebido deve constar o valor "100" na coluna Validado até deve constar o valor "a data atual"
[FAZER] Clicar no botão Voltar

,## Realizar aditamento no equipamento de validação automática Perto (Credenciado) [17403] TODO Depende de máquina
[FAZER] SS - Criar um bolsão de vagas <table:resources/RealizarAditamentoNoEquipamentoDeValidacaoAutomaticaPertoCredenciado17403.csv> [16266]
[FAZER] SS - Criar uma Estrutura de cobrança <table:resources/RealizarAditamentoNoEquipamentoDeValidacaoAutomaticaPertoCredenciado17403.csv> [16003]
[FAZER] SS - Criar regras de cobrança <table:resources/RealizarAditamentoNoEquipamentoDeValidacaoAutomaticaPertoCredenciado17403.csv> [16135]
[FAZER] SS - Criar tabelas de cobrança <table:resources/RealizarAditamentoNoEquipamentoDeValidacaoAutomaticaPertoCredenciado17403.csv> [16091]
[FAZER] SS - Criar uma regra de acesso Entrada <table:resources/RealizarAditamentoNoEquipamentoDeValidacaoAutomaticaPertoCredenciado17403.csv> [16330]
[FAZER] SS - Criar uma regra de acesso Passagem <table:resources/RealizarAditamentoNoEquipamentoDeValidacaoAutomaticaPertoCredenciado17403.csv> [16331]
[FAZER] SS - Criar uma regra de acesso Saída <table:resources/RealizarAditamentoNoEquipamentoDeValidacaoAutomaticaPertoCredenciado17403.csv> [16333]
[FAZER] SS - Criar clientes do estacionamento pessoa Física <table:resources/RealizarAditamentoNoEquipamentoDeValidacaoAutomaticaPertoCredenciado17403.csv> [16128]
[FAZER] SS - Criar produto estadia do tipo credenciado com tipo de revalidação dia do mês step by step <table:resources/RealizarAditamentoNoEquipamentoDeValidacaoAutomaticaPertoCredenciado17403.csv> [16289]
[FAZER] SS - Criar contrato de estadia Produto estadia 'Dia do mês' <table:resources/RealizarAditamentoNoEquipamentoDeValidacaoAutomaticaPertoCredenciado17403.csv> [17885]
[FAZER] SS - Incluir mídia Mifare em um contrato de estadia <table:resources/RealizarAditamentoNoEquipamentoDeValidacaoAutomaticaPertoCredenciado17403.csv> [17860]
[FAZER] SS - Gravação de credenciado Mifare de Carro em uma EAC [17980]
[FAZER] SS - Aditamento de contrato de Carro em uma EAP [17987]
[FAZER] Clicar no menu de contexto (...) na linha contendo o valor "Selenium" na tabela
[FAZER] Clicar no botão Detalhar
[FAZER] Verificar os campos da tela <table:resources/RealizarAditamentoNoEquipamentoDeValidacaoAutomaticaPertoCredenciado17403.csv> [ContratosDeEstadiaPageStep] [17403]
Na seção Informações gerais o cambobox Produto de estadia deve constar o valor ""
Na seção Informações gerais o combobox Cliente do estacionamento deve constar o valor "Selenium"
Na sessão Mídias de acesso deve apresentar na coluna Tipo da mídia de acesso deve apresentar "2 - Cartão mifare" na coluna Identificação da mídia de acesso "10" na coluna Data da inclusão deve apresentar "a data de hoje" na coluna Data de expiração deve apresentar em branco na coluna Status da mídia de acesso deve apresentar 1 - Ativo
Na seção Aditamento deve apresentar na coluna Data da validação deve constar o valor "a data atual" na coluna Valor da validação deve constar o valor "100" na coluna Meio de pagamento deve constar o valor "0 - Dinheiro" na coluna Valor recebido deve constar o valor "100" na coluna Validado até deve constar o valor "a data atual"
[FAZER] Clicar no botão Voltar

,## Criar contrato de estadia de produto de estadia 'Quantidade de dias' pelo equipamento de validação EAC (Credenciado) [17395] TODO:Depende de Maquina.
[FAZER] SS - Gravação de credenciado Mifare de Carro em uma EAC [17980]
[FAZER] Navegar para ""
[FAZER] Na seção Consultar contratos de estadia preencher o campo Pesquisa com o valor "1" [ContratosDeEstadiaPageStep]
[FAZER] Na seção Consultar contratos de estadia clicar no menu de contexto da coluna Produto de estadia com o valor "Produto estadia quantidade de dias" [ContratosDeEstadiaPageStep]
[FAZER] Clicar no botão Detalhar
[FAZER] Verificar os campos da tela <table:resources/CriarContratoDeEstadiaDeProdutoDeEstadiaQuantidadeDeDiasPeloEquip5.csv> [ContratosDeEstadiaPageStep] [17395]
Na seção Informações gerais o combobox Produto de estadia deve conter o valor "Produto estadia quantidade de dias"
Na sessão Mídias de acesso deve apresentar na coluna Tipo da mídia de acesso deve apresentar "2 - Cartão mifare" na coluna Identificação da mídia de acesso "10" na coluna Data da inclusão deve apresentar "a data de hoje" na coluna Data de expiração deve apresentar em branco na coluna Status da mídia de acesso deve apresentar 1 - Ativo
[FAZER] Clicar no botão Voltar