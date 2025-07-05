namespace CarpetsCleaningServiceTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of small carpets: ");
            int smallCarpets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of large carpets: ");
            int largeCarpets = Convert.ToInt32(Console.ReadLine());
            int cost = (smallCarpets * 25) + (largeCarpets * 35);
            double tax = cost * 0.06;
            Console.WriteLine("Price per small room: $25");
            Console.WriteLine("Price per large room: $35");
            Console.WriteLine($"Cost: {cost:C}");
            Console.WriteLine($"Taxes: {tax:C}");
            Console.WriteLine("===============================");
            Console.WriteLine($"Total: {(cost + tax):C}");
            Console.WriteLine("This estimate is valid for 30 days");


        }
    }
}
