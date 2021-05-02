# Produto de Estadia 1 [15923]
Criado pelo gerador 17/02/2020 17:29:06

* Carregar dependências Produto De Estadia <table:resources/CriarUmProdutoEstadiaDoTipoAvulso15924.csv>
ST - Criar um bolsão de vagas <table:resources/CriarUmProdutoEstadiaDoTipoAvulso15924.csv> [16266]
SS - Criar uma Estrutura de cobrança <table:resources/CriarUmProdutoEstadiaDoTipoAvulso15924.csv> [16003]
SS - Criar regras de cobrança <table:resources/CriarUmProdutoEstadiaDoTipoAvulso15924.csv> [16135]
SS - Criar tabelas de cobrança <table:resources/CriarUmProdutoEstadiaDoTipoAvulso15924.csv> [16091]
ST - Criar uma regra de acesso Entrada <table:resources/CriarUmProdutoEstadiaDoTipoAvulso15924.csv> [16330]
ST - Criar uma regra de acesso Passagem <table:resources/CriarUmProdutoEstadiaDoTipoAvulso15924.csv> [16331]
ST - Criar uma regra de acesso Saída <table:resources/CriarUmProdutoEstadiaDoTipoAvulso15924.csv> [16333]

## Criar um produto estadia do tipo avulso [15924]
* SS - Criar um produto estadia do tipo avulso <table:resources/CriarUmProdutoEstadiaDoTipoAvulso15924.csv> [16343]
* Clicar no menu de contexto (...) na linha contendo o valor "Produto Estadia 15924" na tabela
* Clicar no botão Detalhar na listagem
* Verificar os campos da tela <table:resources/CriarUmProdutoEstadiaDoTipoAvulso15924.csv> [ProdutoDeEstadiaPageStep] [15924]
Na seção Informações gerais o campo Nome deve conter o valor "Produto Estadia Avulso"
Na seção Informações gerais o campo Tipo de usuário deve conter o valor "1 - Avulso"
Na seção Configuração por estacionamento a tabela Configuração por bolsão de vagas deve conter o valor "Bolsão Produto Estadia"
* Clicar no menu de contexto (...) na linha contendo o valor "Bolsão Produto Estadia" na tabela
* Clicar no botão Detalhar na listagem
* Verificar os campos do PopUp <table:resources/CriarUmProdutoEstadiaDoTipoAvulso15924.csv> [ProdutoDeEstadiaPageStep] [15924]
Na seção Tabelas de cobrança o combox Tabela de cobrança principal deve conter o valor "Tabela 1"
Na seção Tabelas de cobrança o combox Tabela de cobrança secudária deve conter o valor "Tabela 1"
Na seção Tabelas de cobrança o checkbox Equipamentos de passagem mantém tabela de cobrança da estadia deve apresentar conforme o valor "false"
Na seção Tabelas de cobrança para tempo de transito excedido o combobox Tabela de cobrança principal deve conter o valor "Tabela 1"
Na seção Tabelas de cobrança para tempo de transito excedido o combobox Tabela de cobrança secundária deve conter o valor "Tabela 1"
Na seção Regras de acesso o combobox Entrada deve conter o valor "Entrada"
Na seção Regras de acesso o combobox Passagem deve conter o valor "Passagem"
Na seção Regras de acesso o combobox Saída deve conter o valor "Saída"
* Clicar no botão Fechar
* Clicar no botão Voltar

## Validar se código do grupo para pré-pago único [16231]
* Navegar para "UrlProdutoEstadiaPage"
* Clicar no botão Criar
* Preencher os campos da tela <table:resources/ValidarSeCodigoDoGrupoParaPrePagoUnico16231.csv> [ProdutoDeEstadiaPageStep] [16231]
Na seção Informações gerais preencher o campo Nome com o valor "produto estadia pré pago"
Na seção Informações gerais clicar no combobox Tipo de usuário e selecionar o valor "3 - Pré-pago"
Na seção Informações gerais preencher o campo Código do grupo com o valor "6"
Na seção Regras de recarga preencher o campo Tempo mínimo de utilização com o valor "00:15"
Na seção Regras de recarga preencher o campo Tempo máximo de utilização com o valor "23:59"
Na seção Regras de recarga preencher o campo Quantidade de dias de validade inicial com o valor "365"
Na seção Regras de recarga preencher o campo Quantidade de utilizações diárias com o valor "2"
Na seção Regras de recarga preencher o campo Quantidade de dias sugerido para extensão da validade manual com o valor "365"
* Clicar no botão Salvar
* Verificar mensagem criacao com sucesso
* Clicar no botão Criar
* Preencher os campos da tela <table:resources/ValidarSeCodigoDoGrupoParaPrePagoUnico16231.csv> [ProdutoDeEstadiaPageStep] [16231]
Na seção Informações gerais preencher o campo Nome com o valor "produto estadia pré pago"
Na seção Informações gerais clicar no combobox Tipo de usuário e selecionar o valor "3 - Pré-pago"
Na seção Informações gerais preencher o campo Código do grupo com o valor "6"
Na seção Regras de recarga preencher o campo Tempo mínimo de utilização com o valor "00:15"
Na seção Regras de recarga preencher o campo Tempo máximo de utilização com o valor "23:59"
Na seção Regras de recarga preencher o campo Quantidade de dias de validade inicial com o valor "365"
Na seção Regras de recarga preencher o campo Quantidade de utilizações diárias com o valor "2"
Na seção Regras de recarga preencher o campo Quantidade de dias sugerido para extensão da validade manual com o valor "365"
* Clicar no botão Salvar
* Validar mensagem "O código do grupo deve ser único por tipo de usuário."

## Validar se código do grupo para credenciado é único [16232]
* SS - Criar um produto estadia do tipo credenciado com tipo de revalidação quantidade de dias <table:resources/ValidarSeCodigoDoGrupoParaCredenciadoEUnico16232.csv> [16346]
* Clicar no botão Criar
* Preencher os campos da tela <table:resources/ValidarSeCodigoDoGrupoParaCredenciadoEUnico16232.csv> [ProdutoDeEstadiaPageStep] [16232]
Na seção Informações gerais preencher o campo Nome com o valor "Produto de estadia dia do mês"
Na seção Informações gerais clicar no combobox Tipo de usuário e selecionar o valor "2 - Credenciado"
Preencher o campo Código do grupo com o valor "1"
Na seção Informações gerais clicar no combobox Tipo de revalidação e selecionar o valor "2 - Dia do mês"
* Clicar no botão Salvar
* Validar mensagem "O código do grupo deve ser único por tipo de usuário."

## Validar range do código do grupo (1 -8) para pré-pago [16234]
* Navegar para "UrlProdutoEstadiaPage"
* Clicar no botão Criar
* Preencher os campos da tela <table:resources/ValidarRangeDoCodigoDoGrupo18ParaPrePago16234.csv> [ProdutoDeEstadiaPageStep] [16234]
Na seção Informações gerais preencher o campo Nome com o valor "produto estadia pré pago"
Na seção Informações gerais clicar no combobox Tipo de usuário e selecionar o valor "3 - Pré-pago"
Na seção Informações gerais preencher o campo Código do grupo com o valor "6"
Na seção Regras de recarga preencher o campo Tempo mínimo de utilização com o valor "0015"
Na seção Regras de recarga preencher o campo Tempo máximo de utilização com o valor "2359"
* Clicar no botão Salvar
* Verificar mensagem de erro do campo "O campo 'Quantidade de dias de validade inicial' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Quantidade de utilizações diárias' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Quantidade de dias sugerido para extensão da validade manual' é obrigatório"
* Na seção Informações gerais preencher o campo Código do grupo com o valor <table:resources/ValidarRangeDoCodigoDoGrupo18ParaPrePago16234.csv> [ProdutoDeEstadiaPageStep] [16234]
* Clicar no botão Salvar
* Verificar mensagem de erro do campo "O campo 'Código do grupo' deve ter um valor entre 1 e 8."

## Validar range do código do grupo (1 - 300) para credenciado [16236]
* Navegar para "UrlProdutoEstadiaPage"
* Clicar no botão Criar
* Preencher os campos da tela <table:resources/ValidarRangeDoCodigoDoGrupo1300ParaCredenciado16236.csv> [ProdutoDeEstadiaPageStep] [16236]
Na seção Informações gerais preencher o campo Nome com o valor "Produto Estadia"
Na seção Informações gerais no combobox Tipo de usuário selecionar o valor "2 - Credenciado"
Na seção Informações gerais no combobox Tipo de revalidação selecionar o valor "2 - Dia do mês"
* Clicar no botão Salvar
* Verificar mensagem de erro do campo "O campo 'Código do grupo' deve ter um valor entre 1 e 300."
* Verificar mensagem de erro do campo "O campo 'Dia do mês' é obrigatório"

## Validar campos obrigatórios para um produto estadia do tipo pré-pago [16238]
* Navegar para "UrlProdutoEstadiaPage"
* Clicar no botão Criar
* Preencher os campos da tela <table:resources/ValidarCamposObrigatoriosParaUmProdutoEstadiaDoTipoPrePago16238.csv> [ProdutoDeEstadiaPageStep] [16238]
Na seção Informações gerais clicar no combobox Tipo de usuário e selecionar o valor "3 - Pré-pago"
* Clicar no botão Salvar
* Verificar mensagem de erro do campo "O campo 'Nome' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Código do grupo' deve ter um valor entre 1 e 8."
* Verificar mensagem de erro do campo "O campo 'Quantidade de dias de validade inicial' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Quantidade de utilizações diárias' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Tempo mínimo de utilização' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Tempo máximo de utilização' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Quantidade de dias sugerido para extensão da validade manual' é obrigatório"


## Criar um produto estadia do tipo credenciado com tipo de revalidação dia do mês [16239]
* SS - Criar produto estadia do tipo credenciado com tipo de revalidação dia do mês step by step <table:resources/CriarUmProdutoEstadiaDoTipoCredenciadoComTipoDeRevalidacaoDiaDoMes16239.csv> [16289]
* Clicar no menu de contexto (...) na linha contendo o valor "Produto Estadia 16239" na tabela
* Clicar no botão Detalhar na listagem
* Verificar os campos da tela <table:resources/CriarUmProdutoEstadiaDoTipoCredenciadoComTipoDeRevalidacaoDiaDoMes16239.csv> [ProdutoDeEstadiaPageStep] [16239]
Na seção Informações gerais o campo Nome deve conter o valor "Produto de estadia dia do mês"
Na seção Informações gerais o campo Tipo de usuário deve conter o valor "2 - Credenciado"
Na seção Informações gerais o campo Código do grupo deve conter o valor "1"
Na seção Informações gerais o campo Tipo de revalidação deve conter o valor "2 - Dia do mês"
Na seção Configuração por estacionamento dentro do painel Estacionamento deve conter o valor "30" na seção Regras de revalidação
Na seção Configuração por estacionamento dentro do painel Estacionamento deve conter o valor "100" na seção Regras de revalidação na coluna Valor
* Clicar no botão Detalhar na listagem
* Verificar os campos do PopUp <table:resources/CriarUmProdutoEstadiaDoTipoCredenciadoComTipoDeRevalidacaoDiaDoMes16239.csv> [ProdutoDeEstadiaPageStep] [16239]
Na seção Tabelas de cobrança no combobox Tabela de cobrança principal deve conter o valor "Tabela 1"
Na seção Tabelas de cobrança o checkbox Manter a tabela de cobrança(secundária) deve conter o valor "true"
Na seção Tabelas de cobrança o checkbox Equipamentos de passagem mantém tabela de cobrança da estadia deve conter o valor "true"
Na seção Tabelas de cobrança para tempo de transito excedido o checkbox Manter a tabela de cobrança(principal) deve conter o valor "true"
Na seção Tabelas de cobrança para tempo de transito excedido o checkbox Manter a tabela de cobrança(secundária) deve conter o valor "true"
Na seção Regras de acesso o combobox Entrada deve conter o valor "Entrada"
Na seção Regras de acesso o combobox Passagem deve conter o valor "Passagem"
Na seção Regras de acesso o combobox Saída deve conter o valor "Saída"
* Clicar no botão Fechar
