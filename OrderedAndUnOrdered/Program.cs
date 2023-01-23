namespace OrderedAndUnOrdered
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OrderList order = new OrderList();

            Console.WriteLine("Enter word to search");
            string word = Console.ReadLine();
            order.Ordered(word);
        }
    }
}