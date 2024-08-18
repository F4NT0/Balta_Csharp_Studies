# Entendimento inicial de uma Função ou Método

Podemos segmentar nosso código em funções.

Funções e Métodos são a mesma coisa.

O __main__ é um método muito utilizado.

A estrutura possui as seguinte partes:
    - Possui um nome.
    - Possui um ou mais parâmetros (variáveis que podemos usar dentro do método).
    - Possui um retorno que deve ser apresentado na estrutura o tipo.

Todos os métodos começam com letras maiúsculas.

## Passos de um método

Primeiro criamos o nosso método passando as informações que queremos:

- Nome do método: MeuMetodo.
- Parâmetros do método: string parâmetro (sempre defina o tipo do parâmetro).
- Tipo de retorno: void (não retorna nada para o projeto).
- Retorno: Console.WriteLine(parametro).

```csharp
static void MeuMetodo(string parametro)
{
    Console.WriteLine(parametro);
}
```

__static__ é um modificador de acesso.

__void__ não retorna nada, mas deve ser explícito a saída.

## Chamando o método

Devemos chamar o método em outro método ou podemos chamar direto no método principal __main__.

```csharp
static void Main(string[] args)
{
    MeuMetodo("Hello World!");
}
```

## Pontos importantes

Podemos chamar quantos parâmetro quisermos, sempre definindo seu tipo.

Podemos definir o tipo de saída o tipo que quisermos.

Quando não é o tipo __void__ devemos sempre usar a palavra __return__ para retornar as informações para outros métodos. 

```csharp
static string RetornandoMetodo(string nome, int idade, boolean ativo)
{
    return nome + " " + idade + " " + ativo;
}
```

Quando um método tem um tipo, ele deve ser armazenado em uma variável, assim podemos usar a resposta do método no novo método onde ele foi invocado:

```csharp
static void Main(string[] args)
{
    var infos = RetornandoMetodo("Andre",12,true);
    Console.WriteLine(infos);
}
```