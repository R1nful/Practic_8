using System.Xml.Linq;

namespace Notebook_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Notebook> notebook = new List<Notebook>();

            string path = "data.xml";

            while (true)
            {
                WriteInfo(out string name, out string street, out int houseNum, out int flatNum, out string phone, out string flatPhone);

                notebook.Add(new Notebook(name, street, houseNum, flatNum, phone, flatPhone));

                Console.Write("Хотите продолжить? y/n: ");

                if (Console.ReadLine()!="y")
                {
                    break;
                }
            }

            XElement myNotebook = new XElement("Notebook");

            foreach (Notebook person in notebook)
            {
                myNotebook.Add(AddPersonXML(person));
            }

            myNotebook.Save(path);
        }

        private static void WriteInfo(out string name, out string street, 
            out int houseNum, out int flatNum, out string phone, out string flatPhone)
        {
            Console.Write("Введите ФИО контакта: ");
            name = Console.ReadLine();

            Console.Write("Введите улицу контакта: ");
            street = Console.ReadLine();

            Console.Write("Введите номер дома контакта: ");
            houseNum = int.Parse(Console.ReadLine());

            Console.Write("Введите номер квартиры контакта: ");
            flatNum = int.Parse(Console.ReadLine());

            Console.Write("Введите мобильный телефон контакта: ");
            phone = Console.ReadLine();

            Console.Write("Введите домашний телефон контакта: ");
            flatPhone = Console.ReadLine();
        }

        private static XElement AddPersonXML(Notebook notebook)
        {
            XElement myPerson = new XElement("Person");
            XElement myAdress = new XElement("Adress");
            XElement myStreet = new XElement("Street", notebook.Street);
            XElement myHouseNumber = new XElement("HouseNumber", notebook.HouseNumber);
            XElement myFlatNumber = new XElement("FlatNumber", notebook.FlatNumber);
            XElement myPhones = new XElement("Phones");
            XElement myMobilePhone = new XElement("MobilePhone", notebook.Phone);
            XElement myFlatPhone = new XElement("FlatPhone", notebook.FlatPhone);

            XAttribute meAtr = new XAttribute("name", notebook.Name);

            myAdress.Add(myStreet, myHouseNumber, myFlatNumber);

            myPhones.Add(myMobilePhone, myFlatPhone);

            myPerson.Add(meAtr);

            myPerson.Add(myAdress, myPhones);

            return myPerson;
        }
    }
}