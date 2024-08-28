public class ArrayForEach
{
    public static void Main()
    {
        /**
            Testando as duas formas de declaração de arrays
            e testando o foreach
        **/
        int[] inventory = { 200, 450, 700, 175, 250 }; // Forma antiga
        int[] inventory2 = [ 200, 450, 700, 175, 250 ]; // Forma nova (.NET 8)

        int sum = 0;
        int sum2 = 0;
        int bin = 0;
        int bin2 = 0;

        foreach (int items in inventory)
        {
            sum += items;
            bin++;
            Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
        }
        Console.WriteLine($"We have {sum} items in inventory 1.");

        Console.WriteLine();

        foreach (int items in inventory2)
        {
            sum2 += items;
            bin2++;
            Console.WriteLine($"Bin {bin2} = {items} items (Running total: {sum2})");
        }
        Console.WriteLine($"We have {sum2} items in inventory 2.");

        // ===================================================================

        /**
            Pegando somente os elementos que possuem a letra "B" no início
        **/
        string[] elements = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];
        string name = "B";

        foreach(string element in elements)
        {
            if(element.StartsWith(name))
            {
               Console.WriteLine(element);
            }
       }
    }
}
