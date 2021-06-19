using RestWithASPNET.Controllers.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNET.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
            return;
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();

            for (int i = 0; i < 8; i++)
            {
                persons.Add(new Person
                {
                    Id = i + 1,
                    FirstName = "Name",
                    LastName = "Person Last Name " + i,
                    Address = "Porto Canoa - Serra",
                    Gender = "Male"
                });
            }

            return persons;
        }

        public Person FindByID(long id)
        {
            return new Person
            {
                Id = 1,
                FirstName = "Rodrigo",
                LastName = "Pereira",
                Address = "Porto Canoa - Serra",
                Gender = "Male"
            };
        }

        public Person Update(Person person)
        {
            return person;
        }
    }
}
