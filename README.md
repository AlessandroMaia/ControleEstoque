#                Controle de Estoque
> Sistema de controle de estoque em Desenvolvimento

## Configurações necessárias para compilação do projeto

#### Criando o Banco de Dados:
* Ao abrir o Projeto no Visual Studio, terá a pasta "ADO.NET"
* Selecione-a e aperte CTRL + SHIFT + A
* Do Lado esquerdo da tela clique em "Dados" e selecione "Banco de Dados baseado em serviço"
* Nomeie para "ADO_NETDatabase" na parte inferior da tela e clique em "Adicionar"

#### Criando as Tabelas:
* Aperte CTRL + ALT + S, irá aparecer a coluna de Gerenciador de serviços
* Expanda "Conexões de Dados", irá aparecer o Banco de dados criado
* Expanda-o e Clique com o botão direito do mouse em "Nova consulta"
* Cole o código a baixo:

```
CREATE TABLE [dbo].[Fornecedores] (
    [Id]   BIGINT        IDENTITY (1, 1) NOT NULL,
    [Cnpj] NCHAR (20)    NULL,
    [Nome] NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Produtos] (
    [Id]           BIGINT        IDENTITY (1, 1) NOT NULL,
    [Descricao]    NVARCHAR (50) NULL,
    [PrecoDeCusto] FLOAT (53)    NULL,
    [PrecoDeVenda] FLOAT (53)    NULL,
    [Estoque]      FLOAT (53)    NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[NotaDeEntrada] (
    [Id]           BIGINT        IDENTITY (1, 1) NOT NULL,
    [IdFornecedor] BIGINT        NOT NULL,
    [Numero]       NVARCHAR (20) NULL,
    [DataEmissao]  DATE          NULL,
    [DataEntrada]  DATE          NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_NotaDeEntrada_ToFornecedores] FOREIGN KEY ([IdFornecedor]) REFERENCES [dbo].[Fornecedores] ([Id])
);

CREATE TABLE [dbo].[ProdutoNotaDeEntrada] (
    [Id]                 BIGINT     IDENTITY (1, 1) NOT NULL,
    [IdProduto]          BIGINT     NOT NULL,
    [IdNotaDeEntrada]    BIGINT     NOT NULL,
    [PrecoCustoCompra]   FLOAT (53) NOT NULL,
    [QuantidadeComprada] FLOAT (53) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_ProdutoNotaDeEntrada_ToProdutos] FOREIGN KEY ([IdProduto]) REFERENCES [dbo].[Produtos] ([Id]),
    CONSTRAINT [FK_ProdutoNotaDeEntrada_ToNotaDeEntrada] FOREIGN KEY ([IdNotaDeEntrada]) REFERENCES [dbo].[NotaDeEntrada] ([Id])
);
```
#### Configurando o App.config do projeto
* Selecione o Banco de Dados Criado e aperte ALT + ENTER
* Abrirá a coluna de propriedades
* Nela terá o "Caminho do arquivo", copie e cole do local indicado do código a baixo
  * Exemplo do caminho: C:\Users\alessandro\Desktop\ControleEstoque\ControleEstoque\ADO_NET\ADO_NETDatabase.mdf
```
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
    <startup> 
        <supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.7.2" />
    </startup>
  <connectionStrings>
    <add name="DbProjeto"
         connectionString="Data Source=(LocalDB)\MSSQLLocalDB;
         AttachDbFilename= COLE O CAMINHO AQUI;
         Integrated Security=True"
         providerName="System.Data.SqlClient"/>
  </connectionStrings>
</configuration>

```
