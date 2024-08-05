# Tipos Primitivos do C#

- nome em inglês: `built-in types`
- Armazenam o valor e não a referência para um item na memória
- São classificados em:
    - Tipos Simples (Simple Types)
    - Enumeradores (Enums)
    - Estruturas (Structs)
    - Tipos Nulos (Nullable Types)

## Byte

- O tipo `byte` são 8 bits, só aceita valores positivos
- O tipo `sbyte` permite valores negativos (quando possui o símbolo _-_ são chamados de signed)
- `byte` (8 bits) = de 0 até 255
- `sbyte` (8 bits) = de -128 até 127

```csharp
byte meuByte = 127;
```

## Números inteiros

- `short`
    - tem 16 bits
    - de -32768 até 32767
- `ushort` 
    - pega somente valores positivos
    - tem 16 bits
    - de 0 até 65535
- `int`
    - tem 32 bits
    - de -2147483648 até 2147483647
- `uint`
    - pega somente valores positivos
    - tem 32 bits
    - 0 até 4294967295
- `long`
    - tem 64 bits
    - de -9223372036854775808 até 9223372036854775807
- `ulong`
    - pega somente valores positivos
    - tem 64 bits
    - de 0 até 18446744073709551615

```csharp
uint idate = 25;
short idade = 25;
long idade = 25;
```

## Números reais

- `float`
    - Pode ser positivo ou negativo
    - 
