# Plano de Testes de Software
 
 ## Introdução 

 Este teste  tem como objetivo verificar uma ferramenta capaz de auxiliar usuários a selecionarem filmes de acordo com seu gosto em uma plataforma chamada MovieTunes. O usuário precisa realizar cadastro e inserir seus dados. Para isso, iremos criar e administrar um banco de dados que possibilitará armazenar todas as informações necessárias para o gerenciamento dos dados cadastrados como nome de usuário , senha e email assim como a lista de filmes selecionados. Os testes abrangerão os níveis de Unidade, de Aceitação e de Sistema. **O plano de teste de software sofrerá alterações ao longo do desenvolvimento do projeto** 

## Técnicas e tipos de testes 

### 1- Teste de unidade 

|*objetivo da técnica:*|*o objetivo do teste de unidade é garantir que o código esteja funcionando corretamente e que esteja fazendo o que é esperado dele.*|
|-------------------|--|
|**Técnica:**|O grupo , até o nomento, não tem nada automatizado. O teste será feito manualemnte pelos programadores, conferindo botões e a navegação pela plataforma 
passos :- conferir o funcionamento do entrar e cadastrar, -conferir o funcionamento do cadastro com email e senha , - confeir o nick name, - conferir o funcionamento da tela principal de filmes -conferir a tela individual do filme com sistema de comentários|
|**Ferramentas necessárias:**|será definido posteriormente|
|**Critérios de êxito:**|O teste será considerado com sucesso caso abranja todas as possibilidades de entradas de dados e o sistema esteja tratando todas as opções possíveis|
|**Considerações especiais:**|não se aplica|

### 2- Teste de Sistema

|*objetivo da técnica:*|*Realizar a navegação pelo sistema como usuário final*|
|-------------------|--|
|**Técnica:**|será utilizada o teste de usabilidade como complemento e o teste dos programadores simulando usuários|
|**Ferramentas necessárias:**|Apenas o sistema funcionando|
|**Critérios de êxito:**|O sistema realizar suas funções corretamente |
|**Considerações especiais:**|não se aplica |


### 3- Teste de Aceitação
|*objetivo da técnica:*|*Realizar o login/cadastro de um usuário*|
|-------------------|--|
|**Técnica:**|o usuário usa o sistema para logar e para inserir os seus dados para realizar operações dentro do aplicativo- clicar no botão entrar , - inserir senha e email,- entrar ou inserir o nick name em caso de cadastro |
|**Ferramentas necessárias:**|apenas o sistema funcionando|
|**Critérios de êxito:**|o usuário conseguir logar e fazer cadastro na plataforma|
|**Considerações especiais:**|não se aplica|

### 4- Teste de Integridade de Dados e de Banco de Dados 

|*objetivo da técnica:*|*verificar o funcionamento do banco de dados a fim de identificar possíveis erros ou dados e comando corrompidos*|
|-------------------|--|
|**Técnica:**||
|**Ferramentas necessárias:**| ferramenta a ser definida para o banco de dados pelo grupo e Banco de dados do sistema definido|
|**Critérios de êxito:**|O banco de daos estar de acordo com o esperado|
|**Considerações especiais:**|Não se aplica|

### 5- Teste de interface do Usuário 


|*objetivo da técnica:*|*Verificar a navegabilidade pelo aplicativo*|
|-------------------|--|
|**Técnica:**|Acessar as telas e verificar as funções de login, cadastrar, selecionar filme, adicionar comentario  e outros métodos de navegação pelo aplicativo|
|**Ferramentas necessárias:**|* navegador *sistema funcionando|
|**Critérios de êxito:**|As janelas estarem respondendo de acordo com o requisitado|
|*Considerações especiais:*|não se aplica|


### 6- Teste de Carga 
|*objetivo da técnica:*|*Testar o aplicativo na carga de trabalho para armazenamento dos filmes selecionados pelo cliente e o desempenho de dos dados no sistema*|
|-------------------|--|
|**Técnica:**| selecionar filme, adicionar e remover comentario  e adicionar avaliação com estrelas a fim de verificar a resposta do aplicativo várias vezes|
|**Ferramentas necessárias:**| O grupo até o momento não selecionou nenhuma ferramenta para teste automático|
|**Critérios de êxito:**| boa resposta do aplicativo para avaliar com estrelas e adicionar comentarios|
|**Considerações especiais:**| não se aplica|

### 7- Teste de Segurança e Controle de Acesso 

|*objetivo da técnica:*|*Verificar a segurança no aplicativo para o acesso ao login e ao inserir dados de cadastro , Respeitando a lei de Proteção Geral de Dados*|
|-------------------|--|
|**Técnica:**|* Identificar e listar tipos de usuários e suas funções ou os dados para os quias cada tipo tem permissão de acesso * Identificar falhas de segurança ou a tentativa de login em conta de outros usuários e se os usuários tem o acesso negado|
|**Ferramentas necessárias:**|* O sistema operacional |
|**Critérios de êxito:**|o sistema não for comprometido durante os testes|
|**Considerações especiais:**|não se aplica|


### 8- Teste de Instalação 

|*objetivo da técnica:*|Verificar se o sistema funciona em outras máquinas que nunca receberam ou acessaram o aplicativo|
|-------------------|--|
|**Técnica:**| * uma nova instalação , em uma nova máquina, que nunca fora anteriormente instalada. * começar os executar a instalação|
|**Ferramentas necessárias:**|* O sistema operacional|
