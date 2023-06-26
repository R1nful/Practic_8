using System.IO;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace Notebook_Project
{
    internal struct Notebook
    {
        public string Name { get; set; }
        public string Street { get; set; }
        public int HouseNumber { get; set; }
        public int FlatNumber { get; set; }
        public string Phone { get; set; }
        public string FlatPhone { get; set; }

        public Notebook(string name, string street, int houseNumber, int flatNumber, string phone, string flatPhone)
        {
            Name = name;
            Street = street;
            HouseNumber = houseNumber;
            FlatNumber = flatNumber;
            Phone = phone;
            FlatPhone = flatPhone;
        }
    }
}
