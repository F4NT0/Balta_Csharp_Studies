public class Sort
{
    public static void Main()
    {
        string[] pallets = { "B14", "A11", "B12", "A13" };

        Console.WriteLine("Sorted...");
        Array.Sort(pallets); // Sorts the array in place
        foreach (var pallet in pallets)
        {
            Console.WriteLine($"-- {pallet}");
        }

        /**
         * Output:
         * Sorted...
         * -- A11
         * -- A13
         * -- B12
         * -- B14
         */
    }
}