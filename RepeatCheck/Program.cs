namespace RepeatCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> nums = new HashSet<int>();

            int num;
            int answer;

            while (true) 
            {
                Console.Write("Введите число: ");

                if (int.TryParse(Console.ReadLine(), out answer))
                    num = answer;
                else
                    break;

                if (!nums.TryGetValue(num, out answer))
                {
                    nums.Add(num);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Число сохранено");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Число уже было добавлено");
                }

                Console.ResetColor();

                Console.WriteLine();
            }
        }
    }
}