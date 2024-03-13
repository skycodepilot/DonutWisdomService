namespace DonutWisdomManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            var client = new DonutWisdomService.Service1();
            while (exit == false)
            {
                Console.WriteLine("Enter a new donut wisdom quote (or type 'exit'):");
                string quote = Console.ReadLine();

                if (quote.ToLower() == "exit") break;

                client.AddWisdom(quote);
                Console.WriteLine("Quote added!");
            }
        }
    }
}