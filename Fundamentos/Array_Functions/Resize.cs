public class Resize
{
    public static void Main()
    {
        string[] pallets = { "B14", "A11", "B12", "A13" };
        Console.WriteLine("");

        Array.Resize(ref pallets, 6);
        Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

        pallets[4] = "C01";
        pallets[5] = "C02";

        foreach (var pallet in pallets)
        {
            Console.WriteLine($"-- {pallet}");
        }
    }
}