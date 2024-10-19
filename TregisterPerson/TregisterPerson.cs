using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PhoneNumber2;

namespace TregisterPerson

{
    [TestClass]
    public class TregisterPerson
    {
        [TestMethod]
        /// REVIEW. a.boikov. 2024/10/08. Конструктор по англ. Construct, Konstrukt
        public void TestKonstrukt()
        {
            RegisteredPerson registerPerson = new RegisteredPerson("Иван", "Смирнов");

            Assert.AreEqual("Иван", registerPerson.FirstName);
            Assert.AreEqual("Смирнов", registerPerson.LastName);
        }


        [TestMethod]

        public void TestMath()
        {

            string firstName1 = "Иван";
            string lastName1 = "Наумов";
            string phoneNumber1 = "+79161234567";
            string address1 = "Москва, ул. Ленина, д. 1";
            DateTime registrationDate1 = DateTime.Now;

            string firstName2 = "Петр";
            string lastName2 = "Первый";
            string phoneNumber2 = "+79263456789";
            string address2 = "Санкт-Петербург, Невский проспект, д. 10";
            DateTime registrationDate2 = DateTime.Now;

            string firstName3 = "Алексей";
            string lastName3 = "Сидоров";
            string phoneNumber3 = "+79031234567";
            string address3 = "Казань, ул. Кремлевская, д. 5";
            DateTime registrationDate3 = DateTime.Now;



            PersonRepository repository = new PersonRepository();

            RegisteredPerson person1 = new RegisteredPerson(firstName1, lastName1, phoneNumber1, address1, registrationDate1);
            repository.AddPerson(person1);

            RegisteredPerson person2 = new RegisteredPerson(firstName2, lastName2, phoneNumber2, address2, registrationDate2);
            repository.AddPerson(person2);

            RegisteredPerson person3 = new RegisteredPerson(firstName3, lastName3, phoneNumber3, address3, registrationDate3);
            repository.AddPerson(person3);

            RegisteredPerson foundPerson1 = repository.FindPerson(firstName1, lastName1, phoneNumber1, address1, registrationDate1);
            Assert.IsNotNull(foundPerson1);
            Assert.AreEqual(firstName1, foundPerson1.FirstName);
            Assert.AreEqual(lastName1, foundPerson1.LastName);
            Assert.AreEqual(phoneNumber1, foundPerson1.PhoneNumber);
            Assert.AreEqual(address1, foundPerson1.Addres);

            RegisteredPerson foundPerson2 = repository.FindPerson(firstName2, lastName2, phoneNumber2, address2, registrationDate2);
            Assert.IsNotNull(foundPerson2);
            Assert.AreEqual(firstName2, foundPerson2.FirstName);
            Assert.AreEqual(lastName2, foundPerson2.LastName);
            Assert.AreEqual(phoneNumber2, foundPerson2.PhoneNumber);
            Assert.AreEqual(address2, foundPerson2.Addres);

            RegisteredPerson foundPerson3 = repository.FindPerson(firstName3, lastName3, phoneNumber3, address3, registrationDate3);
            Assert.IsNotNull(foundPerson3);
            Assert.AreEqual(firstName3, foundPerson3.FirstName);
            Assert.AreEqual(lastName3, foundPerson3.LastName);
            Assert.AreEqual(phoneNumber3, foundPerson3.PhoneNumber);
            Assert.AreEqual(address3, foundPerson3.Addres);
        }
    }
}
