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
            var r = new TranslateUserInput("leet af");
            var result = r.makeLeet();
            Assert.AreEqual("1337 4F", result);
        }


        //tall+symboler 
        [Test]
        public void doesItHandleSpecialSymbols()
        {
            var r = new TranslateUserInput("#leet#");
            var result = r.makeLeet();
            Assert.AreEqual("1337", result);
        }

        [Test]
        public void doesItHandleNumbers()
        {
            var r = new TranslateUserInput("2leet4you");
            var result = r.makeLeet();
            Assert.AreEqual("1337Y0U", result);
        }


        //noen ord kan byttes med tall!
        //[Test]
        //public void doesItNumberifyCertainWords()
        //{
        //    var r = new TranslateUserInput("too leet for you");
        //    var result = r.makeLeet();
        //    Assert.AreEqual("2 1337 4 Y0U", result);
        //}
    }
}