# Plano de Testes de Usabilidade Movie Tunes:

Este plano tem como propósito a avaliação da eficácia da interface do usuário da aplicação Movie Tunes em dispositivos móveis e Web. Composto por diversos casos de teste, será executado tanto durante a implementação parcial quanto total do aplicativo. Utilizando o método de Medição e Avaliação, será possível aferir a facilidade de realização de ações, efetividade das tarefas, quantidade de erros ocorridos em cada ação, tempo gasto para finalização das tarefas e se a aparência da interface do sistema é adequada.

Ao final, será feito um comparativo dos resultados de cada usuário participante do teste, e sera analisado pela equipe quais mudanças serão necessárias para tornar experiência do usuário mais agradável e efetiva.

### Os requisitos para realização dos testes de software são:

- Url Movie Tunes publicado na Internet para acesso Web
- Aplicativo Movie Tunes instalado para acesso mobile
- Navegador da Internet - Chrome, Firefox ou Edge
- Conectividade de Internet para acesso às plataformas (APISs)

### Método Utilizado : Medição e Avaliação

- Facilidade em realizar a ação;
- Efetividade da tarefa realizada;
- Quantidade de erros ocorridos em cada ação;
- Tempo necessário para conclusão da tarefa;
- Outros fatores relevantes para a avaliação da interface do sistema.

Para cada tarefa e será possível medir:

| **Caso de Teste** 	| **CT-01 - Cadastro de usuário** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-001 - A aplicação deve permitir ao usuário cadastrar uma conta. |
| Objetivo do Teste 	| Verificar se o usuário consegue se cadastrar na aplicação. |
| Passos 	| - Acessar a aplicação <br> - Clicar em “Cadastro” no menu <br> - Preencher os campos obrigatórios <br> - Clicar em "Cadastrar" |
|Critério de Êxito | - O cadastro foi realizado com sucesso. |
|  	|  	|
| **Caso de Teste** 	| **CT-02 - Efetuar login** 	|
|	Requisito Associado 	| RF-002 - A aplicação deve permitir ao usuário cadastrado efetuar login em sua conta. |
| Objetivo do Teste 	| Verificar se o usuário consegue realizar o login. |
| Passos 	| - Acessar a aplicação <br> - Clicar em “Login” no menu <br> - Preencher os campos obrigatórios <br> - Clicar em "Entrar" |
|Critério de Êxito | - O login foi realizado com sucesso. |
|  	|  	|
| **Caso de Teste** 	| **CT-03 - Efetuar logout** 	|
|	Requisito Associado 	| RF-003 - A aplicação deve permitir ao usuário cadastrado fazer logout de sua conta. |
| Objetivo do Teste 	| Verificar se o usuário consegue realizar o logout. |
| Passos 	| - Acessar a aplicação <br> - Clicar em “Login” no menu <br> - Realizar o login <br> - Clicar em "Sair" |
|Critério de Êxito | - O logout foi realizado com sucesso. |
|  	|  	|
| **Caso de Teste** 	| **CT-04 - Visualizar Filmes** 	|
|	Requisito Associado 	| RF-004 - A aplicação deve permitir ao usuário acesse a lista de filmes. |
| Objetivo do Teste 	| Verificar se o usuário consegue visualizar a lista de filmes. |
| Passos 	| - Acessar a aplicação <br> - Clicar em “Login” no menu <br> - Realizar o login <br> - Acessar o "pagina inicial" <br> - Vizualizar Filmes <br>|
|Critério de Êxito | - O usuário conseguiu visualizar fimes com sucesso. |
|  	|  	|
| **Caso de Teste** 	| **CT-07 - Pesquisar Filmes** 	|
|	Requisito Associado 	| RF-007 - A aplicação deve permitir o usuário a pesquisar filmes através do campo pesquisar. |
| Objetivo do Teste 	| Verificar se o usuário  consegue localizar o filme pesquisado. |
| Passos 	| - Acessar a aplicação <br> - Clicar em “Login” no menu <br> - Realizar o login <br> - Digitar o nome do filme em “pesquisar”<br> - Clicar em “Pesquisar”<br> - Clicar no “Filme” |
|Critério de Êxito | - O usuário conseguiu visualizar o filme através da pesquisa. |
| **Caso de Teste** 	| **CT-08 - Avaliando Filme e Trilha Sonora** 	|
|	Requisito Associado 	| RF-008 - A aplicação deve permitir que o usuário visualize o Filme e a Trilha Sonora e faça uma avaliação de até 5 estrelas. |
| Objetivo do Teste 	| Verificar se o usuário consegue visualizar o campo de avaliações e fazer avaliação. |
| Passos 	| - Acessar a aplicação <br> - Clicar em “Login” no menu <br> - Realizar o login <br> - Clicar no “Filme” através do menu principal ou pesquisa <br> - Visualizar campo avalições <br> - Realizar avaliação |
|Critério de Êxito | - O usuário conseguiu fazer a avaliação corretamente. |
| **Caso de Teste** 	| **CT-09 - Retornar ao Menu Principal** 	|
|	Requisito Associado 	| RF-009 - A aplicação deve permitir que o usuário volte a página principal. |
| Objetivo do Teste 	|Verificar se o usuário retornou a página principal. |
| Passos 	| - Acessar a aplicação <br> - Clicar em “Login” <br> - Realizar o login <br> - Clicar no “Filme” <br> - Clicar em “Voltar” <br>|
|Critério de Êxito | - O usuário conseguiu retornar a página principal corretamente. |


