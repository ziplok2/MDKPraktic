using System;
using System.Collections.Generic;

namespace PhoneNumber2
{
    public class PersonRepository
    {
        private List<RegisteredPerson> persons = new List<RegisteredPerson>();


        public void AddPerson(RegisteredPerson person)//добавил нового сотрудника
        {
            persons.Add(person);
        }

        public void RemovePerson(RegisteredPerson person)//удаление сотрудника
        {
            persons.Remove(person);
        }

        public RegisteredPerson FindPerson(string firstName, string lastName, string phoneNumber, string address, System.DateTime registrationDate1)
        {
            foreach (var person in persons)
            {
                if (person.FirstName == firstName &&
                        person.LastName == lastName &&
                        person.PhoneNumber == phoneNumber &&
                        person.Addres == address)
                {
                    return person;
                }
            }
            return null;
        }
    }   
}

