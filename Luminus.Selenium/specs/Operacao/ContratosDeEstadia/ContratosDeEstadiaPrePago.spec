# Contratos de estadia pré-pago [17346]
Criado pelo gerador 09/03/2020 10:35:42

 Carregar dependências Contratos De Estadia <table:resources/CriarDependenciasDeContratoDeEstadia.csv>
SS - Criar um bolsão de vagas <table:resources/CriarDependenciasDeContratoDeEstadia.csv> [16266]
SS - Criar uma Estrutura de cobrança <table:resources/CriarDependenciasDeContratoDeEstadia.csv> [16003]
SS - Criar regras de cobrança <table:resources/CriarDependenciasDeContratoDeEstadia.csv> [16135]
SS - Criar uma regra de acesso Entrada <table:resources/CriarDependenciasDeContratoDeEstadia.csv> [16330]
SS - Criar uma regra de acesso Passagem <table:resources/CriarDependenciasDeContratoDeEstadia.csv> [16331]
SS - Criar uma regra de acesso Saída <table:resources/CriarDependenciasDeContratoDeEstadia.csv> [16333]
SS - Criar tabelas de cobrança <table:resources/CriarDependenciasDeContratoDeEstadia.csv> [16091]
SS - Criar um produto estadia do tipo credenciado com tipo de revalidação quantidade de dias <table:resources/CriarDependenciasDeContratoDeEstadia.csv> [16346]

## Criar contrato de estadia Produto estadia 'Pré-pago' (Mifare) [17365]
* ST - Criar clientes do estacionamento <table:resources/CriarContratoDeEstadiaProdutoEstadiaPrePagoMifare17365.csv> [16128]
* SS - Criar contrato de estadia Produto estadia 'Pré-pago' <table:resources/CriarContratoDeEstadiaProdutoEstadiaPrePagoMifare17365.csv> [17948]
* SS - Incluir mídia Mifare em um contrato de estadia <table:resources/CriarContratoDeEstadiaProdutoEstadiaPrePagoMifare17365.csv> [17860]
* Clicar no botão Salvar
* Clicar no botão Salvar e Sair
* Clicar no menu de contexto (...) na linha contendo o valor "Contrato Cliente 17365" na tabela
* Clicar no botão Detalhar na listagem
* Na seção Informações gerais o campo Vigente a partir de deve conter a data de criação DateTime_now [ContratosDeEstadiaPageStep]
Na seção Informações gerais no campo Vigente a partir de deve constar a data do dia da gravação
* Verificar os campos da tela <table:resources/CriarContratoDeEstadiaProdutoEstadiaPrePagoMifare17365.csv> [ContratosDeEstadiaPageStep] [17365]
Na seção Informações gerais o cambobox Produto de estadia deve constar o valor "Contrato Produto De Estadia 17365"
Na seção Informações gerais o combobox Cliente do estacionamento deve constar o valor "Contrato Cliente Fisica"
Na seção Informações gerais no campo Válido até deve constar o valor em branco
Na seção Mídias de acesso no campo Tipo de midia de acesso deve conter "2 - Cartão mifare"
Na seção Aditamento deve conter o texto "Não há registros a serem exibidos"
* Clicar no botão Voltar

## Criar contrato de estadia Produto estadia 'Pré-pago' (Barcode) [17386]
* ST - Criar clientes do estacionamento <table:resources/CriarContratoDeEstadiaProdutoEstadiaPrePagoBarcode17386.csv> [16128]
* SS - Criar contrato de estadia Produto estadia 'Pré-pago' <table:resources/CriarContratoDeEstadiaProdutoEstadiaPrePagoBarcode17386.csv> [17948]
* SS - Incluir mídia Barcode em um contrato de estadia <table:resources/CriarContratoDeEstadiaProdutoEstadiaPrePagoBarcode17386.csv> [17845]
* Clicar no botão Salvar
* Clicar no botão Salvar e Sair
* Clicar no menu de contexto (...) na linha contendo o valor "Contrato Cliente 17386" na tabela
* Clicar no botão Detalhar na listagem
* Verificar os campos da tela <table:resources/CriarContratoDeEstadiaProdutoEstadiaPrePagoBarcode17386.csv> [ContratosDeEstadiaPageStep] [17386]
Na seção Informações gerais o cambobox Produto de estadia deve constar o valor ""
Na seção Informações gerais o combobox Cliente do estacionamento deve constar o valor "Selenium"
Na sessão Mídias de acesso deve apresentar na coluna Tipo da mídia de acesso deve apresentar "" coluna Identificação da mídia de acesso "1" na coluna Data da inclusão deve apresentar "a data de hoje" na coluna Data de expiração deve apresentar em branco na coluna Status da mídia de acesso deve apresentar 1 - Ativo
* Na seção Aditamento, na tabela deve apresentar a mensagem Não há registros a serem exibidos [ContratosDeEstadiaPageStep]
* Clicar no botão Voltar