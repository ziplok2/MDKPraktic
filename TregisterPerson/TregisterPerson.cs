using PhoneNumber2;

namespace TregisterPerson

{
    [TestClass]
    public class TregisterPerson
    {
        [TestMethod]
        public void TestKonstrukt()
        {
            RegisteredPerson registerPerson = new RegisteredPerson("Иван", "Смирнов");

            Assert.AreEqual("Иван", registerPerson.FirstName);
            Assert.AreEqual("Смирнов", registerPerson.LastName);
        }
    }
}