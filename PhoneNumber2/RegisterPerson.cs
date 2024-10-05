using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneNumber2
{
    public class RegisteredPerson
    {
        public Guid ID { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNimber { get; set; }
        public string Addres { get; set; }
        public DateTime RegistrationDate { get; set; }


        public RegisteredPerson(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}, зарегистрирован: {RegistrationDate.ToShortDateString()}";
        }
    }
}