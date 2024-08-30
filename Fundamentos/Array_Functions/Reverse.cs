public class Reverse
{
    public static void Main()
    {
        string[] pallets = { "B14", "A11", "B12", "A13" };

        Console.WriteLine("");
        Console.WriteLine("Reversed...");
        Array.Reverse(pallets);
        foreach (var pallet in pallets)
        {
            Console.WriteLine($"-- {pallet}");
        }

        /**
         * Output:
         * Reversed...
         * -- A13
         * -- B12
         * -- A11
         * -- B14
         */
    }
}