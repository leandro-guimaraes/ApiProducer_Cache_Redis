# ApiProducer_Cache_Redis
![Design sem nome (6)](https://github.com/leandro-guimaraes/MassTransitAllog/assets/85081592/ba9f0f79-3f64-4fb5-bc11-fe6b21d1dc97)


# API de Cotação com Cache Redis e Mensageria MassTransit

Este é um projeto de uma API de cotação desenvolvida em C# usando o framework ASP.NET Core. A API tem como objetivo fornecer funcionalidades relacionadas a cotações de produtos ou serviços, além de utilizar recursos avançados como cache Redis e mensageria MassTransit.

## Tecnologias Utilizadas

- ASP.NET Core 7.0: Framework de desenvolvimento web utilizado para criar a API.
- AutoMapper 12.0.1: Biblioteca para mapeamento de objetos.
- MassTransit 8.0.16: Framework para implementação de mensageria em aplicações distribuídas.
- MassTransit.Extensions.DependencyInjection 7.3.1: Extensão do MassTransit para uso com a injeção de dependência do ASP.NET Core.
- MassTransit.RabbitMQ 8.0.16: Implementação do MassTransit para uso com o RabbitMQ, um sistema de mensageria.
- Microsoft.AspNetCore.OpenApi 7.0.4: Biblioteca para gerar a documentação Swagger/OpenAPI da API.
- Microsoft.EntityFrameworkCore 7.0.5: Biblioteca para acesso e gerenciamento de banco de dados utilizando o Entity Framework Core.
- Npgsql.EntityFrameworkCore.PostgreSQL 7.0.4: Driver para utilizar o PostgreSQL como banco de dados da aplicação.
- StackExchange.Redis 2.6.122: Cliente para se conectar e utilizar o Redis como serviço de cache.
- Swashbuckle.AspNetCore 6.4.0: Biblioteca para integração do Swagger com o ASP.NET Core para documentação interativa da API.

## Configurações

- A conexão com o banco de dados PostgreSQL é feita utilizando o usuário "postgres" e senha "123456", e acessando o banco de dados "allog_cotacao" no servidor local "localhost".
- A conexão com o serviço de mensageria RabbitMQ é realizada através do host "jackal-01.rmq.cloudamqp.com" na porta 5671, com autenticação usando o usuário "orxcfbhg" e a senha "Sn0ws-oL3UwS2hW76Bo6Bby-Yhl2MDKD", e utilizando o protocolo de segurança SSL/TLS versão 1.2 (Tls12).
- O serviço de cache Redis é acessado através do host "redis-16293.c308.sa-east-1-1.ec2.cloud.redislabs.com" na porta 16293, utilizando a senha "TYBXhsGEBphN89wCBpmsHkbxDkWRjk1Q".

## Funcionalidades

A API possui endpoints para realizar operações de cotação, permitindo criar, atualizar, consultar e excluir cotações de produtos ou serviços. Além disso, a API utiliza o cache Redis para armazenar resultados de cotações previamente consultadas, a fim de melhorar o desempenho e reduzir a carga no banco de dados.

Também, a API faz uso da mensageria MassTransit para realizar a comunicação assíncrona com outros sistemas ou serviços, possibilitando integrações e escalabilidade da aplicação.

## Executando o Projeto

Para executar o projeto, certifique-se de ter todas as dependências instaladas e configuradas corretamente. Recomenda-se utilizar o Visual Studio ou o Visual Studio Code com a extensão do .NET Core.

Após configurar o ambiente, execute a API e acesse a documentação interativa da API no endpoint "/swagger", onde poderá explorar e testar os diferentes endpoints disponíveis.

## Contribuições

Contribuições são bem-vindas! Sinta-se à vontade para enviar pull requests, abrir issues ou propor melhorias para o projeto.

Espero que essa API de cotação com recursos avançados de cache e mensageria seja útil para o seu projeto e inspire novas soluções inovadoras!

[License]: <Inserir licença aqui, se aplicável>
