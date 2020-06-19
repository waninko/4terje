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
            var r = new UserInputHandling("t");
           var result = r.UserInputRetrived();
            Assert.AreEqual("t", result);
        }

        [Test]
        public void doesItTranslate()
        {
            var r = new TranslateUserInput("leet");
            var result = r.makeLeet();
            Assert.AreEqual("1337", result);
        }
    }
}