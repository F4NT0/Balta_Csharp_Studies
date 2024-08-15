# Conversões de Tipos de dados

- É comum precisarmos transformar um dado de tipo X para um tipo Y
- Existem dois tipos de conversão, as __implícitas__ e __explicitas__

## Conversão Implícita

- São conversões que podem ser executadas apenas com passagem de dados
- Possuem tipos compatíveis

```csharp
floar valor = 25.8f;
int outro = 25;

valor = outro; // Podemos colocar um valor int dentro de um float
outro = valor // NÃO PODE, um ponto real não cabe um valor inteiro0
```

### Tabelas de tipos que podem ser convertidos implícitamente

- Sbyte pode receber:
    - short
    - int 
    - long 
    - float
    - double 
    - decimal
- byte pode receber:
    - short
    - ushort
    - int
    - uint
    - long
    - ulong
    - float
    - double
    - decimal
- short pode receber:
    - int
    - long
    - float
    - double
    - decimal
- ushort pode receber:
    - int
    - uint
    - long
    - ulong
    - float
    - double
    - decimal
- int pode receber:
    - long
    - float
    - double
    - decimal
- uint pode receber:
    - long
    - ulong
    - float
    - double
    - decimal
- long pode receber:
    - float
    - double
    - decimal
- ulong pode receber:
    - float
    - double
    - decimal
- char pode receber:
    - ushort
    - int
    - uint
    - long
    - ulong
    - float
    - double
    - decimal
- float pode receber:
    - double

## Conversão Explícita

- Ocorre quando os tipos não são compatíveis
- É dada pelo uso do tipo entre parênteses antes da atribuição

```csharp
int inteiro = 100;
uint inteiroSemSinal = (uint)inteiro;
```

## Usando Parse

- Método presente em todos os tipos primitivos
- Usado para converter um caractere ou string para um tipo qualquer
- Caso haja alguma incompatibilidade, gera um erro

```csharp
int inteiro = int.Parse("100");
```

## Usando Convert

- Similar ao parse
- É uma classe chamada Convert com todos os tipos primitivos
- Permite converter vários tipos de valores, não só String
- Devemos sempre informar o tipo na chamada da conversão

```csharp
int inteiro = Convert.ToInt32("100");
```





