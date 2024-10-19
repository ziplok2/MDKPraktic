using System;

namespace PhoneNumber2
{
    public class RegisteredPerson
    {
        private string firstName2;
        private string lastName2;
        private string phoneNumber2;
        private string address2;
        private string registrationDate2;

        public Guid ID { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Addres { get; set; }
        public DateTime RegistrationDate { get; set; }


        public RegisteredPerson(string firstName, string lastName, string phoneNumber, string address, DateTime registrationDate)
        {
            ID = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Addres = address;
            RegistrationDate = registrationDate;
        }

        public RegisteredPerson(string v1, string v2)
        {
        }

        public RegisteredPerson(string firstName, string lastName, string phoneNumber, string address)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public RegisteredPerson(string firstName2, string lastName2, string phoneNumber2, string address2, string registrationDate2)
        {
            this.firstName2 = firstName2;
            this.lastName2 = lastName2;
            this.phoneNumber2 = phoneNumber2;
            this.address2 = address2;
            this.registrationDate2 = registrationDate2;
        }

        public override string ToString()
        {
            return $"ID: {ID}\nИндефикатор: {FirstName}\nФамилия: {LastName}\nИмя: {PhoneNumber}\nТелефон, {Addres}\nАдрес: Зарегистрирован: {RegistrationDate.ToShortDateString()}";
        }
    }
}