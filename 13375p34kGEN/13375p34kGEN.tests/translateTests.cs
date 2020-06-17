using NUnit.Framework;

namespace _13375p34kGEN.tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void userInputAcquired()
        {
            var r = new UserInputHandling();
           var result = r.UserInputRetrived();
            Assert.AreEqual(true , result);
        }
    }
}