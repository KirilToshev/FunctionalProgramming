using System;

namespace FunctionalProgramming
{
    class FunctionalProgramming
    {
        static void Main()
        {
            Person person = GetById(-5);
            DisplayValue(person.Address.Street.Name);
        }

        private static void DisplayValue(string value)
        {
            throw new Exception();
        }

        private static Person GetById(int id)
        {
            if (id < 0)
            {
                return null;
            }

            return new Person(id, "Scarlett Johansson")
            {
            };
        }
    }

    internal class Person
    {
        public Person(int id, string fullname)
        {
            this.Id = id;
            this.FullName = fullname;
        }

        public int Id { get; set; }
        public string FullName { get; set; }
        public Address Address { get; set; }
    }

    public class Address
    {
        public Address(Street street)
        {
            this.Street = street;
        }

        public Street Street { get; set; }
        public int No { get; set; }
    }

    public class Street
    {
        public Street(string name)
        {
            this.Name = name;
            if (name == null)
            {
                this.Name = "No street name";
            }
        }

        public string Name { get; private set; }
    }
}
