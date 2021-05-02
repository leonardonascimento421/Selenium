# Regras de cobrança [15947]
Criado pelo gerador 15/01/2020 11:58:14

## Criar uma regras de cobrança [15949]
* SS - Criar regras de cobrança <table:resources/CriarUmaRegrasDeCobranca15949.csv> [16135]
Na seção Informações gerais preencher o campo Nome com o valor "Regra de Cobrança 1"
Na seção Limites de cobrança marcar o checkbox  “Valor máximo diário” referente ao horário de entrada "True"
Na seção Limites de cobrança preencher o campo Valor máximo da estadia sem aprovação com o valor o "9999,99"
Na seção Limites de cobrança marcar o checkbox Usar “valor máximo de estadia” após mudança de dia (operacional) "true"
Na seção Limites de cobrança preencher o campo Quantidade de dias antecedência de permitida para revalidação de credenciados com o valor "1"
Na seção Configurações de cálculo marcar o checkbox Manter do campo Próxima fração de período após mudança de dia (operacional) "True"
Na seção Configurações de cálculo clicar no campo Método de cálculo, selecionar o valor "0 - Mantém fração após virada de período"
Na seção Configurações de cálculo clicar no campo Método de cálculos para repagamentos, selecionar o valor "2 - Diferencial"
Na seção Configurações de cálculo marcar o checkbox Cobrar usando apenas valores do período da entrada "True"
Na seção Configurações de cálculo marcar o checkbox Interromper fração do período na mudança de período "True"
Na seção Configurações de cálculo marcar o checkbox Interromper fração do período na mudança de dia (operacional) "True"
Na seção Configurações de cálculo marcar o checkbox Interromper fração do período na mudança de estrutura "True"
Na seção Configurações de cálculo marcar o checkbox Permitir avanço de estadia para validação (tecla UP) "True"
Na seção Configurações de cálculo marcar o checkbox Permitir operador alterar campos de recarga "True"
Na seção Configurações de cálculo marcar o checkbox Habilitar opção de recarga manual de pré-pago "True"
Na seção Configurações de cálculo marcar o checkbox Permitir retrocesso de estadia para validação (tecla DN) "True"
Na seção Configurações de cálculo marcar o checkbox Habilitar pagamento avulso com cartão Pré-Pago "True"
Na seção Configurações de cálculo marcar o checkbox Habilitar transferência avulso para pré-pago "True"
Na seção Configurações de cálculo marcar o checkbox Sem Limite do campo Bloquear transferência do avulso com mais de "True"
Na seção Configurações de cálculo preencher o campo Tempo adicional antes da mudança de fração do período com o valor "00:00"
Na seção Configurações de cálculo preencher o campo Nível do operador mínimo para editar extensão validade com o valor "1"
Na seção Configurações de cálculo clicar no campo Modo de otimização de cobrança, selecionar o valor "0 - Fração atual"
Na seção Configurações de cálculo clicar no campo Bolsão de acesso a revalidação, selecionar o valor "0 - Perguntar"
Na seção Configurações de cálculo clicar no campo Bloquear validação de estadia zerada, selecionar o valor "1 - Total (zero)"
Na seção Configurações de cálculo clicar no campo Comportamento de revalidação de credenciados vencidos, selecionar o valor "0 - Soma a partir da validade final do cartão"
Na seção Configurações de cálculo para entradas off-line preencher o campo Quantidade de tempo suposta da entrada em dias com o valor "1"
Na seção Configurações de cálculo para entradas off-line preencher o campo Quantidade de tempo suposta da entrada em horas com o valor "1"
Na seção Configurações de cálculo para entradas off-line preencher o campo Quantidade de tempo suposta da entrada em minutos com o valor "1"
Na seção Configurações de cálculo clicar no campo Formas de pagamento, selecionar o valor "2 - Dinheiro ou cartão"
Na seção Bolsões de vagas precedentes válidos marcar o checkbox Não se aplica "True"
* Verificar mensagem criacao com sucesso
* Clicar no menu de contexto (...) na linha contendo o valor "Regra de Cobrança" na tabela
* Clicar no botão Detalhar na listagem
* Verificar os campos da tela <table:resources/CriarUmaRegrasDeCobranca15949.csv> [RegrasDeCobrancaPageStep] [16135]
* Clicar no botão Voltar

## Validar campos obrigatórios para regras de cobrança [15950]
* Navegar para "UrlRegraDeCobrancaPage"
* Clicar no botão Criar
* Preencher os campos da tela <table:resources/ValidarOsCamposObrigatoriosRegrasDeCobranca15950.csv> [RegrasDeCobrancaPageStep] [15950]
Na seção Informações gerais deixar o campo Nome com valor vazio 
Na seção Informações gerais apagar o dado padrão 9999,99 do campo Valor máximo diário 
Na seção Informações gerais apagar o dado padrão 9999,99 do campo Valor máximo da estadia 
Na seção Informações gerais apagar o dado padrão 9999,99 do campo Valor máximo da estadia sem aprovação 
Na seção Informações gerais apagar o dado padrão 7 do campo Nível do operador minimo para aprovação 
Na seção Configurações de cálculo apagar o dado padrão 1 do campo Próxima fração do período após mudança de dia (operacional) 
Na seção Configurações de cálculo deixar o campo Bloquear transferência do avulso com mais de com o conteúdo vazio 
Na seção Configurações de cálculo apagar o dado padrão 00:00 do campo Tempo adicional antes da mudança de fração do período 
Na seção Configurações de cálculo o campo Nível operador minimo para editar extensão validade deve conter o valor padrão 0 
* Clicar no botão Salvar
* Verificar mensagem de erro do campo "O campo 'Nome' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Valor máximo diário' deve ter um valor entre 0,01 e 9999,99."
* Verificar mensagem de erro do campo "O campo 'Valor máximo da estadia' deve ter um valor entre 0,01 e 9999,99."
* Verificar mensagem de erro do campo "O campo 'Valor máximo da estadia sem aprovação' deve ter um valor entre 0,01 e 9999,99."
* Verificar mensagem de erro do campo "O campo 'Nível do operador mínimo para aprovação' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Próxima fração do período após mudança de dia (operacional)' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Bloquear transferência do avulso com mais de' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Tempo adicional antes da mudança de fração do período' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Nível operador mínimo para editar extensão validade' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Quantidade de tempo suposta da entrada em dias' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Quantidade de tempo suposta da entrada em horas' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Quantidade de tempo suposta da entrada em minutos' é obrigatório"

## Validar campos com limites de valores numéricos na regras de cobrança [15951]
* Navegar para "UrlRegraDeCobrancaPage"
* Clicar no botão Criar
* Preencher os campos da tela <table:resources/ValidarCamposComLimitesDeValoresNumericosNaRegrasDeCobranca15951.csv> [RegrasDeCobrancaPageStep] [15951]
Na seção Limites de cobrança preencher o campo Valor máximo diário com o valor "0"
Na seção Limites de cobrança preencher o campo Valor máximo da estadia com o valor "0"
Na seção Limites de cobrança preencher o campo Valor máximo da estadia sem aprovação com o valor "0"
Na seção Limites de cobrança preencher o campo Nivel do operador mínimo para aprovação com o valor "0"
Na seção Configurações de cálculo preencher o campo Próxima fração do período após mudança de dia (operacional)  com o valor "0"
Na seção Configurações de cálculo preencher o campo Nivel operador mínimo para editar extensão validade com o valor "0"
* Clicar no botão Salvar
* Verificar mensagem de erro do campo "O campo 'Valor máximo diário' deve ter um valor entre 0,01 e 9999,99."
* Verificar mensagem de erro do campo "O campo 'Valor máximo da estadia' deve ter um valor entre 0,01 e 9999,99."
* Verificar mensagem de erro do campo "O campo 'Valor máximo da estadia sem aprovação' deve ter um valor entre 0,01 e 9999,99."
* Verificar mensagem de erro do campo "O campo 'Nível do operador mínimo para aprovação' deve ter um valor entre 1 e 10."
* Verificar mensagem de erro do campo "O campo 'Próxima fração do período após mudança de dia (operacional)' deve ter um valor entre 1 e 48."
* Verificar mensagem de erro do campo "O campo 'Nível operador mínimo para editar extensão validade' deve ter um valor entre 1 e 10."


## Alterar uma regras de cobrança [15952]
* ST - Criar um bolsão de vagas <table:resources/AlterarUmaRegrasDeCobranca15952.csv> [16266]
* SS - Criar uma Estrutura de cobrança <table:resources/AlterarUmaRegrasDeCobranca15952.csv> [16003]
* SS - Criar regras de cobrança <table:resources/AlterarUmaRegrasDeCobranca15952.csv> [16135]
* SS - Criar tabelas de cobrança <table:resources/AlterarUmaRegrasDeCobranca15952.csv> [16091]
* Navegar para "UrlRegraDeCobrancaPage"
* Clicar no menu de contexto (...) na linha contendo o valor "Regra de Cobrança para alterar" na tabela
* Clicar no botão Alterar na listagem
* Preencher os campos da tela <table:resources/AlterarUmaRegrasDeCobranca15952.csv> [RegrasDeCobrancaPageStep] [15952]
Na seção informações gerais marcar o checkbox Imediatamente em Vigente a partir de "true"
Na seção Informações gerais alterar campo Nome com o valor "regras de cobrança alterada"
Na seção Limites de cobrança desmarcar o checkbox  “Valor máximo diário” referente ao horário de entrada "8888,99"
Na seção Limites de cobrança desmarcar o checkbox  “Valor máximo diário” referente ao horário de entrada "false"
Na seção Limites de cobrança alterar o campo Valor máximo da estadia com o valor "8888,99"
Na seção Limites de cobrança alterar o campo Valor máximo da estadia sem aprovação com o valor o "8888,00"
Na seção Limites de cobrança alterar o campo Nível do operador mínimo para aprovação com o valor "5"
Na seção Limites de cobrança desmarcar o checkbox Usar “valor máximo de estadia” após mudança de dia (operacional) "false"
Na seção Limites de cobrança alterar o campo Quantidade de dias antecedência de permitida para revalidação de credenciados com o valor "2"
Na seção Configurações de cálculo marcar o checkbox Manter do campo Próxima fração de período após mudança de dia (operacional) "false"
Na seção Configurações de cálculo clicar no campo Método de cálculo, selecionar o valor "2 - Avança fração após virada de período"
Na seção Configurações de cálculo clicar no campo Método de cálculos para repagamentos, selecionar o valor "1 - Pagamento tipo como nova entrada"
Na seção Configurações de cálculo desmarcar o checkbox Cobrar usando apenas valores do período da entrada "false"
Na seção Configurações de cálculo desmarcar o checkbox Interromper fração do período na mudança de período "false"
Na seção Configurações de cálculo desmarcar o checkbox Interromper fração do período na mudança de dia (operacional) "false"
Na seção Configurações de cálculo desmarcar o checkbox Interromper fração do período na mudança de estrutura "false"
Na seção Configurações de cálculo desemarcar o checkbox Permitir avanço de estadia para validação (tecla UP) "false"
Na seção Configurações de cálculo desmarcar o checkbox Permitir operador alterar campos de recarga "false"
Na seção Configurações de cálculo desmarcar o checkbox Habilitar opção de recarga manual de pré-pago "false"
Na seção Configurações de cálculo desmarcar o checkbox Permitir retrocesso de estadia para validação (tecla DN) "false"
Na seção Configurações de cálculo desmarcar o checkbox Habilitar pagamento avulso com cartão Pré-Pago "false"
Na seção Configurações de cálculo desmarcar o checkbox Habilitar transferência avulso para pré-pago "false"
Na seção Configurações de cálculo marcar o checkbox Sem Limite do campo Bloquear transferência do avulso com mais de "false"
Na seção Configurações de cálculo alterar o campo Bloquear transferência do avulso com mais de com o valor "00:15"
Na seção Configurações de cálculo alterar o campo Tempo adicional antes da mudança de fração do período com o valor "00:05"
Na seção Configurações de cálculo alterar o campo Nível operador mínimo para editar extensão validade com o valor "5"
Na seção Configurações de cálculo clicar no campo Modo de otimização de cobrança, selecionar o valor "2 - Otimizado"
Na seção Configurações de cálculo clicar no campo Bolsão de acesso a revalidação, selecionar o valor "3 - Última"
Na seção Configurações de cálculo clicar no campo Bloquear validação de estadia zerada, selecionar o valor ""
Na seção Configurações de cálculo clicar no combobox Tabela de cobrança suposta da entrada e selecionar o valor "3 - Estadia (zero)"
Na seção Configurações de cálculo clicar no campo Comportamento de revalidação de credenciados vencidos, selecionar o valor "1 - Soma a partir da data atual"
Na seção Configurações de cálculo para entradas off-line alterar o campo Quantidade de tempo suposta da entrada em dias com o valor "1"
Na seção Configurações de cálculo para entradas off-line alterar o campo Quantidade de tempo suposta da entrada em horas com o valor "2"
Na seção Configurações de cálculo para entradas off-line alterar o campo Quantidade de tempo suposta da entrada em minutos com o valor "3"
Na seção Configurações de cálculo clicar no campo Formas de pagamento, selecionar o valor "3 - dinheiroe/ou cartão"
Na seção Tabelas de cobrança inibidas para a validação de avulsos selecionar a opção "tabela de cobrança 1" clicar no botão Mover (>) da dual listbox Tabelas de cobrança
Na seção Tabelas de cobrança inibidas para a validação de pré-pago selecionar a opção "tabela de cobrança 1" clicar no botão Mover ( >> ) da dual listbox Tabelas de cobrança
Na seção Bolsões de vagas precedentes válidos desmarcar o checkbox Não se aplica "true"
* Clicar no botão Salvar
* Verificar mensagem alteracao com sucesso
* Clicar no menu de contexto (...) na linha contendo o valor "regras de cobrança alterada" na tabela
* Clicar no botão Detalhar na listagem
* Verificar os campos da tela <table:resources/AlterarUmaRegrasDeCobranca15952.csv> [RegrasDeCobrancaPageStep] [15952]
* Clicar no botão Voltar

## Excluir uma regras de cobrança [15953]
* SS - Criar regras de cobrança <table:resources/ExcluirUmaRegrasDeCobranca15953.csv> [16135]
* Clicar no menu de contexto (...) na linha contendo o valor "Regra de Cobrança para excluir" na tabela
* Clicar no botão Excluir na listagem
* Clicar no botão Excluir
* Verificar mensagem exclusao com sucesso
* Navegar para "UrlEstruturaTabelaCobrancaPage"
* Clicar no menu de contexto (...) na linha contendo o valor "estrutura tabela de cobrança 1" na tabela
* Clicar no botão Excluir na listagem
* Clicar no botão Excluir
* Verificar mensagem exclusao com sucesso 
