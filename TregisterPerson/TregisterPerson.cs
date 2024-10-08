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
    }
}