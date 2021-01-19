using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PersonalRegister.Test
{
    [TestClass]
    public class EmployeeTest
    {
        [TestMethod]
        public void TestPrint()
        {
            Employee emily = new Employee("Emily Rovaniemi", 1200);

            Assert.AreEqual("Emily Rovaniemi: 1 200,00 kr", emily.PrintEmployee());
        }
    }
}
