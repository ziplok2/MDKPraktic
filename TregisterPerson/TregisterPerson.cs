using PhoneNumber2;

namespace TregisterPerson

{
    [TestClass]
    public class TregisterPerson
    {
        [TestMethod]
        /// REVIEW. a.boikov. 2024/10/08. ����������� �� ����. Construct, Konstrukt
        public void TestKonstrukt()
        {
            RegisteredPerson registerPerson = new RegisteredPerson("����", "�������");

            Assert.AreEqual("����", registerPerson.FirstName);
            Assert.AreEqual("�������", registerPerson.LastName);
        }
    }
}