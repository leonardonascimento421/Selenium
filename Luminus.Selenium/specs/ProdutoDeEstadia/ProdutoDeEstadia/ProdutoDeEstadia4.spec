# Produto de Estadia 4 [15923]
Criado pelo gerador 17/02/2020 17:29:06

 Carregar dependências Produto De Estadia <table:resources/CriarUmProdutoEstadiaDoTipoAvulso15924.csv>
ST - Criar um bolsão de vagas <table:resources/CriarUmProdutoEstadiaDoTipoAvulso15924.csv> [16266]
SS - Criar uma Estrutura de cobrança <table:resources/CriarUmProdutoEstadiaDoTipoAvulso15924.csv> [16003]
SS - Criar regras de cobrança <table:resources/CriarUmProdutoEstadiaDoTipoAvulso15924.csv> [16135]
SS - Criar tabelas de cobrança <table:resources/CriarUmProdutoEstadiaDoTipoAvulso15924.csv> [16091]
ST - Criar uma regra de acesso Entrada <table:resources/CriarUmProdutoEstadiaDoTipoAvulso15924.csv> [16330]
ST - Criar uma regra de acesso Passagem <table:resources/CriarUmProdutoEstadiaDoTipoAvulso15924.csv> [16331]
ST - Criar uma regra de acesso Saída <table:resources/CriarUmProdutoEstadiaDoTipoAvulso15924.csv> [16333]

,## Excluir um produto estadia do tipo credenciado com tipo de revalidação diarista [16257]
[FEITO] SS - Criar Produto estadia diarista <table:resources/ExcluirUmProdutoEstadiaDoTipoCredenciadoComTipoDeRevalidacaoDiarista16257.csv> [16341]
[FEITO] Clicar no menu de contexto (...) na linha contendo o valor "Produto Estadia 16257" na tabela
[FEITO] Clicar no botão Excluir na listagem
[FEITO] Clicar no botão Excluir
[FEITO] Verificar mensagem exclusao com sucesso

## Excluir um produto estadia do tipo pré-pago [16258]
* SS - Criar Produto de estadia - Pré-pago <table:resources/ExcluirUmProdutoEstadiaDoTipoPrePago16258.csv> [16395]
* Clicar no menu de contexto (...) na linha contendo o valor "Produto Estadia 16258" na tabela
* Clicar no botão Excluir na listagem
* Clicar no botão Excluir
* Verificar mensagem exclusao com sucesso

## Validar campos obrigatórios para um produto estadia do tipo credenciado com tipo de revalidação quantidade de dias [16259]
* Navegar para "UrlProdutoEstadiaPage"
* Clicar no botão Criar
* Preencher os campos da tela <table:resources/ValidarCamposObrigatoriosParaUmProdutoEstadiaDoTipoCredenciadoCom9.csv> [ProdutoDeEstadiaPageStep] [16259]
Na seção Informações gerais no combobox Tipo de usuário selecionar a opção "2 - Credenciado"
Na seção Informações gerais no combobox Tipo de revalidação selecionar a opção "1 - Quantidade de dias"
* Clicar no botão Salvar
* Verificar mensagem de erro do campo "O campo 'Nome' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Código do grupo' deve ter um valor entre 1 e 300."
* Clicar no botão adicionar na seção Regras de revalidação [ProdutoDeEstadiaPageStep]
* Preencher os campos do PopUp <table:resources/ValidarCamposObrigatoriosParaUmProdutoEstadiaDoTipoCredenciadoCom9.csv> [ProdutoDeEstadiaPageStep] [16259]
No popup com o título de Adicionar revalidação o campo Número da opção de revalidação deve estar selecionado com o valor ""
* Clicar no botão Salvar Pop Up
* Verificar mensagem de erro do campo "O campo 'Número da opção de revalidação' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Quantidade de dias' é obrigatório"

## Validar campos obrigatórios para um produto estadia do tipo credenciado com tipo de revalidação dia do mês [16260]
* Navegar para "UrlProdutoEstadiaPage"
* Clicar no botão Criar
* Preencher os campos da tela <table:resources/ValidarCamposObrigatoriosParaUmProdutoEstadiaDoTipoCredenciadoCom9.csv> [ProdutoDeEstadiaPageStep] [16260]
Na seção Informações gerais no combobox Tipo de usuário selecionar a opção "2 - Credenciado"
Na seção Informações gerais no combobox Tipo de revalidação selecionar a opção "1 - Quantidade de dias"
* Clicar no botão Salvar
* Verificar mensagem de erro do campo "O campo 'Nome' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Código do grupo' deve ter um valor entre 1 e 300."
* Clicar no botão adicionar na seção Regras de revalidação [ProdutoDeEstadiaPageStep]
* Preencher os campos do pop-up <table:resources/ValidarCamposObrigatoriosParaUmProdutoEstadiaDoTipoCredenciadoCom9.csv> [ProdutoDeEstadiaPageStep] [16260]
No popup com o título de Adicionar revalidação o campo Número da opção de revalidação deve estar selecionado com o valor ""
* Clicar no botão Salvar Pop Up
* Verificar mensagem de erro do campo "O campo 'Número da opção de revalidação' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Quantidade de dias' é obrigatório"
* Navegar para "UrlEstruturaTabelaCobrancaPage"
* Clicar no botão Excluir na listagem
* Clicar no botão Excluir
* Verificar mensagem exclusao com sucesso
* Navegar para "UrlTabelaDeCobrancaPage"
* Clicar no botão Excluir na listagem
* Clicar no botão Excluir
* Verificar mensagem exclusao com sucesso