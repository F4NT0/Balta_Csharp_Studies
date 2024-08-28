namespace MeuApp
{

    // ENUM
    enum EEstadoCivil
    {
        Solteiro = 1,
        Casado = 2,
        Divorciado = 3
    }

    // STRUCT
    struct Cliente
    {
        public string Nome;
        public EEstadoCivil EstadoCivil;

        public Cliente(string nome, EEstadoCivil estadoCivil)
        {
            Nome = nome;
            EstadoCivil = estadoCivil;
        }
    }

    // CLASS
    class Program
    {
      public static void Main(string[] args)
      {
        var cliente = new Cliente("João", EEstadoCivil.Casado);

        Console.WriteLine($"Nome: {cliente.Nome}");
        Console.WriteLine($"Estado Civil: {cliente.EstadoCivil}");
        Console.WriteLine($"Estado Civil Numero: {(int)cliente.EstadoCivil}");
      }
    }
}