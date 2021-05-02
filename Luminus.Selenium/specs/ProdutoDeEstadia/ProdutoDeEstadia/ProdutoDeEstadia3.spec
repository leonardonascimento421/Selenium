# Produto de Estadia 3 [15923]
Criado pelo gerador 17/02/2020 17:29:06

 Carregar dependências Produto De Estadia <table:resources/CriarUmProdutoEstadiaDoTipoAvulso15924.csv>
ST - Criar um bolsão de vagas <table:resources/CriarUmProdutoEstadiaDoTipoAvulso15924.csv> [16266]
SS - Criar uma Estrutura de cobrança <table:resources/CriarUmProdutoEstadiaDoTipoAvulso15924.csv> [16003]
SS - Criar regras de cobrança <table:resources/CriarUmProdutoEstadiaDoTipoAvulso15924.csv> [16135]
SS - Criar tabelas de cobrança <table:resources/CriarUmProdutoEstadiaDoTipoAvulso15924.csv> [16091]
ST - Criar uma regra de acesso Entrada <table:resources/CriarUmProdutoEstadiaDoTipoAvulso15924.csv> [16330]
ST - Criar uma regra de acesso Passagem <table:resources/CriarUmProdutoEstadiaDoTipoAvulso15924.csv> [16331]
ST - Criar uma regra de acesso Saída <table:resources/CriarUmProdutoEstadiaDoTipoAvulso15924.csv> [16333]

,## Alterar um produto estadia do tipo credenciado com tipo de revalidação diarista [16250]
[FEITO] SS - Criar Produto estadia diarista <table:resources/AlterarUmProdutoEstadiaDoTipoCredenciadoComTipoDeRevalidacaoDiarista16250.csv> [16341]
[FEITO] Clicar no menu de contexto (...) na linha contendo o valor "Produto Estadia 16250 Alterar" na tabela
[FEITO] Clicar no botão Alterar na listagem
[FEITO] Preencher os campos da tela <table:resources/AlterarUmProdutoEstadiaDoTipoCredenciadoComTipoDeRevalidacaoDiarista16250.csv> [ProdutoDeEstadiaPageStep] [16250]
Na seção Informações gerais marcar o checkbox Imediatamente "true"
Na seção Informações gerais alterar o campo Nome com o valor "Produto de estadia Diarista alterado"
[FEITO] Clicar no botão Alterar na listagem
[FEITO] Preencher os campos do PopUp <table:resources/AlterarUmProdutoEstadiaDoTipoCredenciadoComTipoDeRevalidacaoDiarista16250.csv> [ProdutoDeEstadiaPageStep] [16250]
Na seção Tabelas de cobrança marcar o checkbox Manter a tabela de cobrança(principal) "true"
Na seção Tabelas de cobrança desmarcar o checkbox Manter a tabela de cobrança(secundária) "false"
Na seção Tabelas de cobrança clicar no combobox Tabela de cobrança secundária e selecionar o valor "Tabela 1"
Na seção Tabelas de cobrança desmarcar o checkbox Equipamentos de passagem mantém tabela de cobrança da estadia "true"
Na seção Tabelas de cobrança para tempo de transito excedido desmarcar o checkbox Manter a tabela de cobrança(principal) "false"
Na seção Tabelas de cobrança para tempo de transito excedido clicar no combobox Tabela de cobrança principal e selecionar o valor "Tabela 1"
Na seção Tabelas de cobrança para tempo de transito excedido desmarcar o checkbox Manter a tabela de cobrança(secundária) "false"
Na seção Tabelas de cobrança para tempo de transito excedido clicar no combobox Tabela de cobrança secundária e selecionar o valor "Tabela 1"
[FEITO] Clicar no botão Salvar Pop Up
[FEITO] Preencher os campos da tela Revalidação <table:resources/AlterarUmProdutoEstadiaDoTipoCredenciadoComTipoDeRevalidacaoDiarista16250.csv> [ProdutoDeEstadiaPageStep] [16250]
Na seção Regras de revalidação alterar o campo Valor com o valor "100,00"
Na seção Regras de revalidação alterar o campo Quantidade máxima de diária por validação com o valor "5"
Na seção Regras de revalidação desmarcar o checkbox Permitir venda prévia de diária "true"
Na seção Regras de revalidação alterar o campo Nível mínimo do operador para reimpressão do ticket com o valor "7"
[FEITO] Clicar no botão Salvar
[FEITO] Verificar mensagem alteracao com sucesso
[FEITO] Clicar no menu de contexto (...) na linha contendo o valor "Produto Estadia 16250 Alterado" na tabela
[FEITO] Clicar no botão Detalhar na listagem
[FEITO] Verificar os campos da tela <table:resources/AlterarUmProdutoEstadiaDoTipoCredenciadoComTipoDeRevalidacaoDiarista16250.csv> [ProdutoDeEstadiaPageStep] [16250]
Na seção Informações gerais o checkbox Imediatamente deve constar o valor "true"
Na seção Informações gerais o campo Nome com o valor "Produto de estadia Diarista alterado"
[FEITO] Clicar no botão Detalhar na listagem
[FEITO] Verificar os campos do PopUp <table:resources/AlterarUmProdutoEstadiaDoTipoCredenciadoComTipoDeRevalidacaoDiarista16250.csv> [ProdutoDeEstadiaPageStep] [16250]
Na seção Tabelas de cobrança o checkbox Manter a tabela de cobrança(principal) deve constar o valor "true"
Na seção Tabelas de cobrança o checkbox Manter a tabela de cobrança(secundária) deve constar o valor "true"
Na seção Tabelas de cobrança o combobox Tabela de cobrança secundária deve constar o valor@Nome_tabelasdecobranca
Na seção Tabelas de cobrança o checkbox Equipamentos de passagem mantém tabela de cobrança da estadia deve constar o valor "true"
Na seção Tabelas de cobrança para tempo de transito excedido o checkbox Manter a tabela de cobrança(principal) deve constar o valor "true"
Na seção Tabelas de cobrança para tempo de transito excedido o combobox Tabela de cobrança principal deve constar o valor@Nome_tabelasdecobranca 
Na seção Tabelas de cobrança para tempo de transito excedido o checkbox Manter a tabela de cobrança(secundária) deve constar o valor "true" 
Na seção Tabelas de cobrança para tempo de transito excedido o combobox Tabela de cobrança secundária deve constar o valor@Nome_tabelasdecobranca 
[FEITO] Clicar no botão Fechar
[FEITO] Verificar os campos da tela Revalidação <table:resources/AlterarUmProdutoEstadiaDoTipoCredenciadoComTipoDeRevalidacaoDiarista16250.csv> [ProdutoDeEstadiaPageStep] [16250]
Na seção Regras de revalidação o campo Valor com o valor "100,00" 
Na seção Regras de revalidação o campo Quantidade máxima de diária por validação com o valor "5"
Na seção Regras de revalidação o checkbox Permitir venda prévia de diária deve constar o valor "true"
Na seção Regras de revalidação o campo Nível mínimo do operador para reimpressão do ticket com o valor "7"
[FEITO] Clicar no botão Voltar

## Alterar um produto estadia do tipo pré-pago [16252]
* SS - Criar Produto de estadia - Pré-pago <table:resources/AlterarUmProdutoEstadiaDoTipoPrePago16252.csv> [16395]
* Clicar no menu de contexto (...) na linha contendo o valor "Produto Estadia 16252 Alterar" na tabela
* Clicar no botão Alterar na listagem
* Preencher os campos da tela <table:resources/AlterarUmProdutoEstadiaDoTipoPrePago16252.csv> [ProdutoDeEstadiaPageStep] [16252]
Na seção Informações gerais marcar o checkbox Imediatamente "true"
Na seção Informações gerais alterar o campo Nome com o valor "Pré pago alterado"
* Clicar no menu de contexto (...) na linha contendo o valor "Bolsão Produto Estadia" na tabela
* Clicar no botão Alterar na listagem
* Preencher os campos da tela PopUp <table:resources/AlterarUmProdutoEstadiaDoTipoPrePago16252.csv> [ProdutoDeEstadiaPageStep] [16252]
Na seção Tabelas de cobrança marcar o checkbox Manter a tabela de cobrança(principal) "true"
Na seção Tabelas de cobrança desmarcar o checkbox Manter a tabela de cobrança(secundária) "false"
Na seção Tabelas de cobrança clicar no combobox Tabela de cobrança secundária e selecionar o valor "Tabela 1"
Na seção Tabelas de cobrança desmarcar o checkbox Equipamentos de passagem mantém tabela de cobrança da estadia "false"
Na seção Tabelas de cobrança para tempo de transito excedido desmarcar o checkbox Manter a tabela de cobrança(principal) "false"
Na seção Tabelas de cobrança para tempo de transito excedido clicar no combobox Tabela de cobrança principal e selecionar o valor "Tabela 1"
Na seção Tabelas de cobrança para tempo de transito excedido desmarcar o checkbox Manter a tabela de cobrança(secundária) "false"
Na seção Tabelas de cobrança para tempo de transito excedido clicar no combobox Tabela de cobrança secundária e selecionar o valor "Tabela 1"
* Clicar no botão Salvar Pop Up
* Clicar no menu de contexto (...) na linha contendo o valor "1" na tabela
* Clicar no botão Alterar na listagem
* Preencher os campos da tela PopUp Recarga <table:resources/AlterarUmProdutoEstadiaDoTipoPrePago16252.csv> [ProdutoDeEstadiaPageStep] [16252]
No popup Adicionar regra de recarga preencher o campo Valor da recarga com o valor "100,00"
No popup Adicionar regra de recarga preencher o campo Valor do pagamento com o valor "200,00"
No popup Adicionar regra de recarga preencher o campo Quantidade de dias de extensão de validade com o valor "5"
* Clicar no botão Salvar Pop Up
* Preencher os campos da tela Regras Recarga <table:resources/AlterarUmProdutoEstadiaDoTipoPrePago16252.csv> [ProdutoDeEstadiaPageStep] [16252]
Na seção Regras de recarga marcar o checkbox Sugerir opção de recarga máxima "false"
Na seção Regras de recarga preencher o campo Quantidade de dias de validade inicial com o valor "2"
Na seção Regras de recarga preencher o campo Saldo mínimo com o valor "3,00"
Na seção Regras de recarga preencher o campo Saldo máximo com o valor "3000,00"
Na seção Regras de recarga preencher o campo Saldo negativo limite ( - ) com o valor "0,01"
Na seção Regras de recarga preencher o campo Valor máximo diário com o valor "500,00"
Na seção Regras de recarga preencher o campo Quantidade de utilizações diárias com o valor "3"
Na seção Regras de recarga preencher o campo Tempo mínimo de utilização com o valor "00:25"
Na seção Regras de recarga preencher o campo Tempo máximo de utilização com o valor "2325"
Na seção Regras de recarga preencher o campo Quantidade de dias sugerido para extensão da validade manual com o valor "15"
Na seção Regras de recarga marcar o checkbox Sugerir opção de recarga para atingir saldo máximo "false"
Na seção Regras de recarga marcar o checkbox Habilitar tempo de bônus "false"
Na seção Regras de recarga selecionar o combobox Modo de utilização do tempo bônus com o valor "1 - Renova a cada acesso"
Na seção Regras de recarga preencher o campo Tempo de bônus máximo "2000"
* Clicar no botão Salvar
* Verificar mensagem alteracao com sucesso
* Clicar no menu de contexto (...) na linha contendo o valor "Produto Estadia 16252 Alterado" na tabela
* Clicar no botão Detalhar na listagem
* Verificar os campos da tela <table:resources/AlterarUmProdutoEstadiaDoTipoPrePago16252.csv> [ProdutoDeEstadiaPageStep] [16252]
Na seção Informações gerais o checkbox Imediatamente deve constar o valor "true" 
Na seção Informações gerais o campo Nome com o valor "Pré pago alterado" 
* Clicar no menu de contexto (...) na linha contendo o valor "Bolsão Produto Estadia" na tabela
* Clicar no botão Detalhar na listagem
* Verificar os campos da tela PopUp <table:resources/AlterarUmProdutoEstadiaDoTipoPrePago16252.csv> [ProdutoDeEstadiaPageStep] [16252]
Na seção Tabelas de cobrança o checkbox Manter a tabela de cobrança(principal) deve constar o valor "true"
Na seção Tabelas de cobrança o checkbox Manter a tabela de cobrança(secundária) deve constar o valor "true"
Na seção Tabelas de cobrança o combobox Tabela de cobrança secundária deve constar o valor "Tabela 1"
Na seção Tabelas de cobrança o checkbox Equipamentos de passagem mantém tabela de cobrança da estadia deve constar o valor "false"
Na seção Tabelas de cobrança para tempo de transito excedido o checkbox Manter a tabela de cobrança(principal) deve constar o valor "true"
Na seção Tabelas de cobrança para tempo de transito excedido o combobox Tabela de cobrança principal deve constar o valor "Tabela 1"
Na seção Tabelas de cobrança para tempo de transito excedido o checkbox Manter a tabela de cobrança(secundária) deve constar o valor "true" 
Na seção Tabelas de cobrança para tempo de transito excedido o combobox Tabela de cobrança secundária deve constar o valor "Tabela 1"
* Clicar no botão Fechar
* Verificar os campos da tela Regras Recarga <table:resources/AlterarUmProdutoEstadiaDoTipoPrePago16252.csv> [ProdutoDeEstadiaPageStep] [16252]
Na seção regras de recarga deve permanecer os valores na tabela Numero da opção de recarga "1" , Valor da recargar "100,00" Valor do pagamento "200,00" e Quantidade de dias de extensão de validade "5"
Na seção Regras de recarga o checkbox Sugerir opção de recarga máxima deve constar o valor "false"
Na seção Regras de recarga o campo Quantidade de dias de validade inicial deve constar o valor "2"
Na seção Regras de recarga o campo Saldo mínimo deve constar o valor "3,00"
Na seção Regras de recarga o campo Saldo máximo deve constar o valor "3000,00"
Na seção Regras de recarga o campo Saldo negativo limite ( - ) deve constar o valor "0,01"
Na seção Regras de recarga o campo Valor máximo diário deve constar o valor "500,00"
Na seção Regras de recarga o campo Quantidade de utilizações diárias deve constar o valor "3"
Na seção Regras de recarga o campo Tempo mínimo de utilização deve constar o valor "00:25"
Na seção Regras de recarga o campo Tempo máximo de utilizaçãodeve constar o valor "2325"
Na seção Regras de recarga o campo Quantidade de dias sugerido para extensão da validade manual deve constar o valor "15"
Na seção Regras de recarga o checkbox Sugerir opção de recarga para atingir saldo máximo deve constar o valor "false"
Na seção Regras de recarga o checkbox Habilitar tempo de bônus deve constar o valor "false"
Na seção Regras de recarga o combobox Modo de utilização do tempo bônus deve constar o valor "1 - Renova a cada acesso"
Na seção Regras de recarga o campo Tempo de bônus máximo deve constar o valor "2000"
* Clicar no botão Voltar

## Excluir um produto estadia do tipo avulso [16253]
* SS - Criar um produto estadia do tipo avulso <table:resources/ExcluirUmProdutoEstadiaDoTipoAvulso16253.csv> [16343]
* Clicar no menu de contexto (...) na linha contendo o valor "Produto Estadia 16253" na tabela
* Clicar no botão Excluir na listagem
* Clicar no botão Excluir
* Verificar mensagem exclusao com sucesso

,## Validar campos obrigatórios para um produto estadia do tipo credenciado com tipo de revalidação diária [16254]
[FEITO] Navegar para "UrlProdutoEstadiaPage"
[FEITO] Clicar no botão Criar
[FEITO] Clicar no botão Salvar
[FEITO] Verificar mensagem de erro do campo "O campo 'Nome' é obrigatório"
[FEITO] Verificar mensagem de erro do campo "O campo 'Tipo de usuário' é obrigatório"
[FEITO] Na seção Informações gerais clicar no combobox Tipo de usuário e selecionar o valor '2 - Credenciado' <table:resources/ValidarCamposObrigatoriosParaUmProdutoEstadiaDoTipoCredenciadoCom4.csv> [ProdutoDeEstadiaPageStep] [16254]
[FEITO] Clicar no botão Salvar
[FEITO] Verificar mensagem de erro do campo "O campo 'Nome' é obrigatório"
[FEITO] Verificar mensagem de erro do campo "O campo 'Código do grupo' deve ter um valor entre 1 e 300."
[FEITO] Verificar mensagem de erro do campo "O campo 'Tipo de revalidação' é obrigatório"
[FEITO] Na seção Informações gerais clicar no combobox Tipo de revalidação e selecionar o valor '3 - Diarista' <table:resources/ValidarCamposObrigatoriosParaUmProdutoEstadiaDoTipoCredenciadoCom4.csv> [ProdutoDeEstadiaPageStep] [16254]
[FEITO] Clicar no botão Salvar
[FEITO] Verificar mensagem de erro do campo "O campo 'Nome' é obrigatório"
[FEITO] Verificar mensagem de erro do campo "O campo 'Código do grupo' deve ter um valor entre 1 e 300."
[FEITO] Verificar mensagem de erro do campo "O campo 'Quantidade máxima de diária por validação' é obrigatório"
[FEITO] Verificar mensagem de erro do campo "O campo 'Tabela de cobrança para excedente' é obrigatório"
[FEITO] Verificar mensagem de erro do campo "O campo 'Nível mínimo do operador para reimpressão do ticket' é obrigatório"

## Excluir um produto estadia do tipo credenciado com tipo de revalidação dia do mês [16255]
* SS - Criar produto estadia do tipo credenciado com tipo de revalidação dia do mês step by step <table:resources/ExcluirUmProdutoEstadiaDoTipoCredenciadoComTipoDeRevalidacaoDiaDoMes16255.csv> [16289]
* Clicar no menu de contexto (...) na linha contendo o valor "Produto Estadia 16255" na tabela
* Clicar no botão Excluir na listagem
* Clicar no botão Excluir
* Verificar mensagem exclusao com sucesso

## Excluir um produto estadia do tipo credenciado com tipo de revalidação quantidade de dias [16256]
* SS - Criar um produto estadia do tipo credenciado com tipo de revalidação quantidade de dias <table:resources/ExcluirUmProdutoEstadiaDoTipoCredenciadoComTipoDeRevalidacaoQuant6.csv> [16346]
* Clicar no menu de contexto (...) na linha contendo o valor "Produto Estadia 16256" na tabela
* Clicar no botão Excluir na listagem
* Clicar no botão Excluir
* Verificar mensagem exclusao com sucesso