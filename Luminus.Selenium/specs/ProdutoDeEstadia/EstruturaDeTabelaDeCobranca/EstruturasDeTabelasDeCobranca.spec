# Estruturas de tabelas de cobrança [15990]
Criado pelo gerador 20/01/2020 14:46:35

## Criar uma Estrutura de cobrança [15991]
* SS - Criar uma Estrutura de cobrança <table:resources/CriarUmaEstruturaDeCobranca15991.csv> [16003]
* Clicar no menu de contexto (...) na linha contendo o valor "Estrutura 1" na tabela
* Clicar no botão Detalhar na listagem
* Verificar os campos da tela <table:resources/CriarUmaEstruturaDeCobranca15991.csv> [EstruturasDeTabelasDeCobrancaPageStep] [16003]
 Validar campo Nome está salvo com o valor "Estrutura 1" 
 Validar na seção Estruturas | Estrutura 1 com o rótulo Dias Válidos se os Checkbox Domingo, Segunda, Terca, Quarta, Quinta, Sexta, Sabado estão marcados 
 Validar na seção 'Período 1' se contém o valor "" 
 Validar na seção 'Período 1' se a Fração identificada com o valor '1' contém o valor de 'Duração' = "" 
 Validar na seção 'Período 1' se a Fração identificada com o valor '1' contém o valor de 'Repetição' = "" 
 Validar na seção 'Período 1' se a Fração identificada com o valor '2' contém o valor de 'Duração' = "" 
 Validar na seção 'Período 1' se a Fração identificada com o valor '2' contém o valor de 'Repetição' = "" 
 Validar na seção 'Período 1' no rótulo 'Intervalo das repetições neste período' o Combobox 'De' contém o valor "" 
 Validar na seção 'Período 1' no rótulo 'Intervalo das repetições neste período' o Combobox 'De' contém o valor "" 
 Validar na seção 'Período 2' se contém o valor "" 
 Validar na seção 'Período 2' se a Fração identificada com o valor '1' contém o valor de 'Duração' = "" 
 Validar na seção 'Período 2' se a Fração identificada com o valor '1' contém o valor de 'Duração' = "" 
 Validar na seção 'Período 2' no rótulo 'Intervalo das repetições neste período' o Combobox 'De' contém o valor "" 
 Validar na seção 'Período 2' no rótulo 'Intervalo das repetições neste período' o Combobox 'Até' contém o valor "" 
* Clicar no botão Voltar 
* Clicar no menu de contexto (...) na linha contendo o valor "Estrutura 1" na tabela
* Clicar no botão Excluir na listagem
* Clicar no botão Excluir

## Validar Campos obrigatórios [15992]
* Navegar para "UrlEstruturaTabelaCobrancaPage"
* Clicar no botão Criar
* Clicar no botão Adicionar estrutura
* Clicar no botão Salvar
* Verificar mensagem de erro do campo "O campo 'Nome' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Período 1 - Inicio:' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'De' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Até' é obrigatório"
* Clicar no botão Adicionar fração "1"
* Clicar no botão Salvar Pop Up
* Verificar mensagem de erro do campo "O campo 'Duração' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Repetição' é obrigatório"

## Validar campos com limite de valor [15993]
* Navegar para "UrlEstruturaTabelaCobrancaPage"
* Clicar no botão Criar
* Preencher o campo 'Nome' com o valor <table:resources/ValidarCamposComLimiteDeValor15993.csv> [EstruturasDeTabelasDeCobrancaPageStep] [15993]
* Clicar no botão Adicionar estrutura
* Na seção Período 1 - Preencher o campo 'Início': <table:resources/ValidarCamposComLimiteDeValor15993.csv> [EstruturasDeTabelasDeCobrancaPageStep] [15993]
* Verificar se o campo 'Inicio' esta vazio [EstruturasDeTabelasDeCobrancaPageStep]
* Clicar no botão Adicionar fração "1"
* Preencher o campo 'Duração' com o valor <table:resources/ValidarCamposComLimiteDeValor15993.csv> [EstruturasDeTabelasDeCobrancaPageStep] [15993]
* Verificar se o campo 'Duração' esta vazio [EstruturasDeTabelasDeCobrancaPageStep]
* Clicar no botão Fechar
* Clicar no botão Voltar

## Validar que só pode existir uma estrutura de cobrança [15996]
* SS - Criar uma Estrutura de cobrança <table:resources/ValidarQueSoPodeExistirUmaEstruturaDeCobranca15996.csv> [16003]
* Verificar se o botão Criar esta desabilitado [EstruturasDeTabelasDeCobrancaPageStep]
* Clicar no menu de contexto (...) na linha contendo o valor "Estrutura 3" na tabela
* Clicar no botão Excluir na listagem
* Clicar no botão Excluir

## Alterar uma Estrutura de cobrança [15997]
* SS - Criar uma Estrutura de cobrança <table:resources/AlterarUmaEstruturaDeCobranca15997.csv> [16003]
* Clicar no menu de contexto (...) na linha contendo o valor "Estrutura 4" na tabela
* Clicar no botão Alterar na listagem
* Na seção Informações gerais clicar no Checkbox Imediatamente <table:resources/AlterarUmaEstruturaDeCobranca15997.csv> [EstruturasDeTabelasDeCobrancaPageStep]
* Na seção Período 1 - Preencher o campo 'Início': <table:resources/AlterarUmaEstruturaDeCobranca15997.csv> [EstruturasDeTabelasDeCobrancaPageStep] [15997]
* Clicar no menu de contexto (...) na linha contendo o valor "01:00" na tabela
* Clicar no botão Alterar na listagem
* Preencher o campo 'Duração' com o valor <table:resources/AlterarUmaEstruturaDeCobranca15997.csv> [EstruturasDeTabelasDeCobrancaPageStep] [15997]
* Clicar no botão Salvar Pop Up
* Na Seção Período 1 - com o rótulo 'Intervalo das repetições neste período' selecionar no ComboBox a opção <table:resources/AlterarUmaEstruturaDeCobranca15997.csv> [EstruturasDeTabelasDeCobrancaPageStep] [15997]
* Clicar no menu de contexto (...) na linha contendo o valor "00:30" na tabela
* Clicar no botão Alterar na listagem
* Na seção Período 1 | Fração 2 - Preencher o campo 'Repetição' com o valor <table:resources/AlterarUmaEstruturaDeCobranca15997.csv> [EstruturasDeTabelasDeCobrancaPageStep] [15997]
* Clicar no botão Salvar Pop Up
* Clicar no botão Salvar
* Verificar mensagem alteracao com sucesso
* Navegar para "UrlEstruturaTabelaCobrancaPage"
* Clicar no menu de contexto (...) na linha contendo o valor "Estrutura 4" na tabela
* Clicar no botão Detalhar na listagem
* Verificar os campos da tela <table:resources/AlterarUmaEstruturaDeCobranca15997.csv> [EstruturasDeTabelasDeCobrancaPageStep] [17997]
 Validar campo Nome está salvo com o valor "Estrutura 4" 
 Validar na seção Estruturas | Estrutura 1 com o rótulo Dias Válidos se os Checkbox Domingo, Segunda, Terca, Quarta, Quinta, Sexta, Sabado estão marcados 
 Validar na seção 'Período 1' se contém o valor "" 
 Validar na seção 'Período 1' se a Fração identificada com o valor '1' contém o valor de 'Duração' = "" 
 Validar na seção 'Período 1' se a Fração identificada com o valor '1' contém o valor de 'Repetição' = "" 
 Validar na seção 'Período 1' se a Fração identificada com o valor '2' contém o valor de 'Duração' = "" 
 Validar na seção 'Período 1' se a Fração identificada com o valor '2' contém o valor de 'Repetição' = "" 
 Validar na seção 'Período 1' no rótulo 'Intervalo das repetições neste período' o Combobox 'De' contém o valor "" 
 Validar na seção 'Período 1' no rótulo 'Intervalo das repetições neste período' o Combobox 'De' contém o valor "" 
 Validar na seção 'Período 2' se contém o valor "" 
 Validar na seção 'Período 2' se a Fração identificada com o valor '1' contém o valor de 'Duração' = "" 
 Validar na seção 'Período 2' se a Fração identificada com o valor '1' contém o valor de 'Duração' = "" 
 Validar na seção 'Período 2' no rótulo 'Intervalo das repetições neste período' o Combobox 'De' contém o valor "" 
 Validar na seção 'Período 2' no rótulo 'Intervalo das repetições neste período' o Combobox 'Até' contém o valor "" 
* Clicar no botão Voltar 
* Clicar no menu de contexto (...) na linha contendo o valor "Estrutura 4" na tabela
* Clicar no botão Excluir na listagem
* Clicar no botão Excluir

## Excluir uma fração na criação de uma estrutura de cobrança [15998]
* SS - Criar uma Estrutura de cobrança <table:resources/ExcluirUmaFracaoNaCriacaoDeUmaEstruturaDeCobranca15998.csv> [16003]
* Clicar no menu de contexto (...) na linha contendo o valor "Estrutura 5" na tabela
* Clicar no botão Alterar na listagem
* Na seção Informações gerais clicar no Checkbox Imediatamente <table:resources/ExcluirUmaFracaoNaCriacaoDeUmaEstruturaDeCobranca15998.csv> [EstruturasDeTabelasDeCobrancaPageStep]
* Clicar no menu de contexto (...) na label contendo o valor "Período 2 - Inicio:"
* Clicar no botão Excluir na listagem
* Na Seção Período 1 - com o rótulo 'Intervalo das repetições neste período' selecionar no ComboBox a opção <table:resources/ExcluirUmaFracaoNaCriacaoDeUmaEstruturaDeCobranca15998.csv> [EstruturasDeTabelasDeCobrancaPageStep]
* Clicar no botão Salvar
* Verificar mensagem alteracao com sucesso
* Clicar no menu de contexto (...) na linha contendo o valor "Estrutura 5" na tabela
* Clicar no botão Excluir na listagem
* Clicar no botão Excluir
* Verificar mensagem exclusao com sucesso

## Excluir um período na criação de uma estrutura de cobrança [15999]
* SS - Criar uma Estrutura de cobrança <table:resources/ExcluirUmPeriodoNaCriacaoDeUmaEstruturaDeCobranca15999.csv> [16003]
* Navegar para "UrlEstruturaTabelaCobrancaPage"
* Clicar no menu de contexto (...) na linha contendo o valor "Estrutura 6" na tabela
* Clicar no botão Alterar na listagem
* Na seção Informações gerais clicar no Checkbox Imediatamente <table:resources/ExcluirUmPeriodoNaCriacaoDeUmaEstruturaDeCobranca15999.csv> [EstruturasDeTabelasDeCobrancaPageStep]
* Clicar no menu de contexto (...) na label contendo o valor "Período 2 - Inicio:"
* Clicar no botão Excluir na listagem
* Clicar no botão Salvar
* Verificar mensagem alteracao com sucesso
* Clicar no menu de contexto (...) na linha contendo o valor "Estrutura 6" na tabela
* Clicar no botão Excluir na listagem
* Clicar no botão Excluir
* Verificar mensagem exclusao com sucesso

## Excluir uma estrutura de cobrança [16224]
* SS - Criar uma Estrutura de cobrança <table:resources/ExcluirUmaEstruturaDeCobranca16224.csv> [16003]
* Clicar no menu de contexto (...) na linha contendo o valor "Estrutura 7" na tabela
* Clicar no botão Excluir na listagem
* Clicar no botão Excluir
* Verificar mensagem exclusao com sucesso

