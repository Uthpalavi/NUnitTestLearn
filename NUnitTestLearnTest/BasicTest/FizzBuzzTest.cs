using NUnitTestLearn.Basic;

namespace NUnitTestLearnTest.BasicTest
{
    [TestFixture]
    public class FizzBuzzTest
    {
        private FizzBuzz _fizzBuzz;

        [SetUp]
        public void SetUp()
        {
            _fizzBuzz = new FizzBuzz();
        }

        [Test]
        public void GetOutput_DevideBy3N5_ReturnFizzBuzz()
        {
            var result = _fizzBuzz.GetOutput(15);
            
            Assert.That(result, Is.EqualTo("FizzBuzz").IgnoreCase);

        }

        [Test]
        public void GetOutput_DevideBy3_ReturnFizz()
        {
            var result = _fizzBuzz.GetOutput(3);

            Assert.That(result, Is.EqualTo("Fizz").IgnoreCase);

        }

        [Test]
        public void GetOutput_DevideBy5_ReturnBuzz()
        {
            var result = _fizzBuzz.GetOutput(5);

            Assert.That(result, Is.EqualTo("Buzz").IgnoreCase);

        }

        [Test]
        public void GetOutput_NotDevideBy3N5_ReturnNumber()
        {
            var result = _fizzBuzz.GetOutput(1);

            Assert.That(result, Is.EqualTo("1").IgnoreCase);

        }
    }
}
