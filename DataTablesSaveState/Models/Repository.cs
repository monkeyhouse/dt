using FizzWare.NBuilder;
using System.Collections.Generic;

namespace Models
{
    public static class PersonRepository
    {
        public static IEnumerable<Person> Persons { get; private set; }

        static PersonRepository()
        {

            Persons = Builder<Person>.CreateListOfSize(20)
                .All()
                 .With(c => c.Name = Faker.Name.FullName())
                 .With(c => c.EmailAddress = Faker.Internet.Email())
                 .With(c => c.TelephoneNumber = Faker.Phone.Number())
                 .With(c => c.NumOne = Faker.RandomNumber.Next(0, 3))
                 .With(c => c.NumTwo = Faker.RandomNumber.Next(0, 3))
            .Build();
        }
    
    }
    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string TelephoneNumber { get; set; }
        public int NumOne { get; set; }
        public int NumTwo { get; set; }
    }
}