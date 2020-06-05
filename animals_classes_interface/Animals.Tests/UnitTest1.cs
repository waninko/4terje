using animals_classes_interface;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Animals.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMakeMammal()
        {
            Mammals fox = new Mammals("Fox", "Hrrrr");

            Assert.AreEqual(fox.birth, "Live Birth");
        }
    }
}
