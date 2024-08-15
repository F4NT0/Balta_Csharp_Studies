# Operadores

## Operadores Aritméticos

- `+` = Soma
- `-` = Subtração
- `*` = Multiplicação
- `/` = Divisão
- `%` = Resto da divisão

```csharp
int valor = 2 + 2; // 4
int valor = 2 - 2; // 0
int valor = 2 * 2; // 4
int valor = 2 / 2; // 1
int valor = 2 % 2; // 0
```

## Operadores de Atribuição

- `=` = Atribui um valor
- `+=` = Soma o mesmo valor com um novo valor
- `-=` = Subtrai o mesmo valor com um novo valor
- `*=` = Multiplica o mesmo valor com um novo valor
- `/=` = Divisão do mesmo valor com um novo valor

```csharp
int x = 0; //Atribui um valor a uma variável
x += 5; // mesmo que x = x + 5; e resulta em x = 5
x -= 1; // mesmo que x = x - 1; e resulta em x = 4 (5 - 1 = 4)
x *= 10; // mesmo que x = x * 10;  e resulta em 40 (4 * 10 = 40)
x /= 2; // mesmo que x = x / 2; e resulta em 20 (40 / 2 = 20)
```

## Operadores de Comparação

Retorna valores booleanos

- `==` = Igual que
- `!=` = Diferente de
- `>` = Maior que
- `<` = Menor que
- `>=` = Maior ou Igual a
- `<=` = Menor ou Igual a

```csharp
5 == 5; // True
4 != 3; // True
4 != 4; // False
6 > 5; // True
4 < 5; // True
4 <= 4; // True
5 >= 3; // True
```

## Operadores Lógicos

Retorna valores booleanos

Usado para operações condicionais

- `&&` = AND lógico
    - Todas as condições devem ser verdadeiras
- `||` = OR lógico
    - Se pelo menos uma for verdadeira
- `!` = NOT lógico
    - Nega o valor, se for true vira false e vice versa

```csharp
int x = 12;
bool valor = (x > 25) && (x < 40); // False
```