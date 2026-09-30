namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int small = 25;
            int large = 35;
            double taxRate = 0.06;
            double Tax;
            int Cost;
            double TotalEstimate;

            Console.WriteLine("Estimate for carpet cleaning Service");

            Console.WriteLine($"Number of small Carpets: ");
           int numSmall=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Number of large Carpets: ");
           int numLarge=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Price per small Carpet: ${small}");
            Console.WriteLine($"Price per large Carpet: ${large}");

            Cost = (numSmall * small) + (numLarge * large);
            Tax = Cost * taxRate;
            Console.WriteLine($"Cost: ${Cost}");
            Console.WriteLine($"Tax: {Tax}");
            Console.WriteLine("========================================");
            TotalEstimate = Cost + Tax;
            Console.WriteLine($"Total Estimate: ${TotalEstimate}");
            Console.WriteLine($"This estimate is valid for 30 days");
        }
    }
}
