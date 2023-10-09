# Arquitetura da Solução

<span style="color:red">Pré-requisitos: <a href="3-Projeto de Interface.md"> Projeto de Interface</a></span>

Definição de como o software é estruturado em termos dos componentes que fazem parte da solução e do ambiente de hospedagem da aplicação.

![Arquitetura da Solução](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e4-proj-infra-t6-movietunes/blob/main/docs/img/arquitetura.png)

## Diagrama de Classes

![Banco de dados Relacional](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e4-proj-infra-t6-movietunes/blob/main/docs/img/Captura%20de%20tela%202023-10-03%20204639.png)

## Modelo ER

![Modelo ER](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e4-proj-infra-t6-movietunes/blob/main/docs/img/Captura%20de%20tela%202023-10-03%20204946.png)

## Esquema Relacional

O Esquema Relacional corresponde à representação dos dados em tabelas juntamente com as restrições de integridade e chave primária.

As referências abaixo irão auxiliá-lo na geração do artefato “Esquema Relacional”.

> - [Criando um modelo relacional - Documentação da IBM](https://www.ibm.com/docs/pt-br/cognos-analytics/10.2.2?topic=designer-creating-relational-model)

## Modelo Físico

Entregar um arquivo banco.sql contendo os scripts de criação das tabelas do banco de dados. Este arquivo deverá ser incluído dentro da pasta src\bd.

## Tecnologias Utilizadas

As tecnologias utilizada para banco de dados foi a tecnologia MongoDB. Para desenvolvermos a aplicação usaremos a linguagem C# com o Enty Framework, e também o Visual Studio 2022 para desenvolvimento da aplicação, para gerenciar os códigos e a documentação usamos o GitHub.

GitHub  - Um gerenciador de código aberto e gratuito para programadores

Mongo DB-  Um famoso Banco de dados orientados a documentos, composto por registro que não tem uma definição formal de suas estrutura. Na qual existem conceitos de coluna chaves estrangeiras e algumas outras formalidades que bancos de dados relacionais tem.

C Sharp -  Uma linguagem destinada a programação. Considerada uma linguagem multiparadigmas desenvolvida pela Microsoft

Visual Studio 2022- Lugar onde programadores codam uma aplicação sendo possível a instalação de diversos plug para facilitar no processo

## Hospedagem

> Ainda não foi pauta no grupo mas estamos pensando em escolher o próprio GitHub para fazer a hospedagem do projeto

## Qualidade de Software

Conceituar qualidade de fato é uma tarefa complexa, mas ela pode ser vista como um método gerencial que através de procedimentos disseminados por toda a organização, busca garantir um produto final que satisfaça às expectativas dos stakeholders.

No contexto de desenvolvimento de software, qualidade pode ser entendida como um conjunto de características a serem satisfeitas, de modo que o produto de software atenda às necessidades de seus usuários. Entretanto, tal nível de satisfação nem sempre é alcançado de forma espontânea, devendo ser continuamente construído. Assim, a qualidade do produto depende fortemente do seu respectivo processo de desenvolvimento.

A norma internacional ISO/IEC 25010, que é uma atualização da ISO/IEC 9126, define oito características e 30 subcaracterísticas de qualidade para produtos de software.
Com base nessas características e nas respectivas sub-características, identifique as sub-características que sua equipe utilizará como base para nortear o desenvolvimento do projeto de software considerando-se alguns aspectos simples de qualidade. Justifique as subcaracterísticas escolhidas pelo time e elenque as métricas que permitirão a equipe avaliar os objetos de interesse.

> **Links Úteis**:
>
> - [ISO/IEC 25010:2011 - Systems and software engineering — Systems and software Quality Requirements and Evaluation (SQuaRE) — System and software quality models](https://www.iso.org/standard/35733.html/)
> - [Análise sobre a ISO 9126 – NBR 13596](https://www.tiespecialistas.com.br/analise-sobre-iso-9126-nbr-13596/)
> - [Qualidade de Software - Engenharia de Software 29](https://www.devmedia.com.br/qualidade-de-software-engenharia-de-software-29/18209/)
