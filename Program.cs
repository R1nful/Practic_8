namespace Practic_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> digre = new List<int>();

            for (int i = 1; i <= 100; i++)
            {
                digre.Add(i);
                Console.WriteLine(i);

                if (i >= 25 && i <= 50)
                {
                    digre.Remove(i);
                }
            }

            Console.WriteLine(new String('-', 20));
            Console.ReadKey();

            foreach (int i in digre)
            {
                Console.WriteLine(i);
            }
        }
    }
}