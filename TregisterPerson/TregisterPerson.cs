using PhoneNumber2;

namespace TregisterPerson

{
    [TestClass]
    public class TregisterPerson
    {
        [TestMethod]
        public void TestKonstrukt()
        {
            RegisteredPerson registerPerson = new RegisteredPerson("����", "�������");

            Assert.AreEqual("����", registerPerson.FirstName);
            Assert.AreEqual("�������", registerPerson.LastName);
        }
    }
}