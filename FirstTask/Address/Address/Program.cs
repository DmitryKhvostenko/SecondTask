using System;

namespace ConsoleApp18
{
    class Address
    {
        public string Index { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Apartment { get; set; }
    }
    class Address2
    {
        static void Main()
        {
            Address address = new Address();
            address.Index = "02090";
            address.Country = "Ukraine";
            address.City = "Kiev";
            address.Street = "Lobachevskiy Street";
            address.House = "23";
            address.Apartment = "123";
            Console.WriteLine("Index: " + address.Index);
            Console.WriteLine("Country: " + address.Country);
            Console.WriteLine("City: " + address.City);
            Console.WriteLine("Street: " + address.Street);
            Console.WriteLine("House: " + address.House);
            Console.WriteLine("Apartment: " + address.Apartment);
        }
    }
}
