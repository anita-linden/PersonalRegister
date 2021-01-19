using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PersonalRegister.Test
{
    [TestClass]
    public class RegisterTest
    {
        [TestMethod]
        public void TestAdd()
        {
            PersonnelRegister register = new PersonnelRegister();

            register.AddEmployee("Emily Rovaniemi", "1200");

            Assert.AreEqual("Emily Rovaniemi: 1 200,00 kr",register.PrintEmployee(0));
        }

        [TestMethod]
        public void TestNameError()
        {
            PersonnelRegister register = new PersonnelRegister();

            register.AddEmployee("Emily", "1200");
            Assert.AreEqual(register.PrintEmployee(0),"null");
        }

        [TestMethod]
        public void TestSalaryError()
        {
            PersonnelRegister register = new PersonnelRegister();

            register.AddEmployee("Emily Rovaniemi", "Tolvhundra");
            Assert.AreEqual(register.PrintEmployee(0), "null");
        }
    }
}
