using BilletLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestBil
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestPrisBil()
        {
            //Arrange
            Bil bil = new Bil("nummerplade", System.DateTime.Now);

            //Act
            decimal Pris = bil.Pris();

            //Assert
            Assert.AreEqual(240, Pris);
        }

        [TestMethod]
        public void TestPrisMC()
        {
            //Arrange
            MC mc = new MC("nummerplade", System.DateTime.Now);

            //Act
            decimal Pris = mc.Pris();

            //Assert
            Assert.AreEqual(125, Pris);
        }

        
    }

}
