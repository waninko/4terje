using animals_classes_interface;
using NUnit.Framework;

namespace Nunit_Animals.Tests
{
    public class Tests
    {
       
        [Test]
        public void TestAddMammal()
        {
            Mammals fox = new Mammals("Fox", "rrrrr?");
            Assert.AreEqual( "Live Birth", fox.birth);
        }
    }
}