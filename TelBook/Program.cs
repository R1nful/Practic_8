namespace TelBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> telBook = new Dictionary<string, string>();

            string name;
            string tel;
            string found;
            string answer;

            Console.WriteLine("Чтобы закончить ввод введите пустую строку");

            while (true)
            {
                Console.WriteLine();

                Console.Write("Введите ФИО контакта: ");
                name = Console.ReadLine();

                if (name.Trim() == "")
                    break;

                Console.Write("Введите телефон контакта: ");
                tel = Console.ReadLine();

                if (tel.Trim() == "")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Неправильный номер");
                    Console.ResetColor();
                    continue;
                }

                telBook.Add(tel, name);

            }

            Console.WriteLine();

            while (true)
            {
                Console.Write("Введите номер телефона контакта, которго хотите найти: ");
                found = Console.ReadLine();

                if (found.Trim() == "")
                    break;

                if(telBook.TryGetValue(found, out answer))
                    Console.WriteLine(answer);
                else
                    Console.WriteLine("Номера нет в записной книжке");

                Console.WriteLine();

            } 
        }
    }
}