using NUnitTestLearn.Basic;

namespace NUnitTestLearnTest.BasicTest
{
    [TestFixture]
    public class MathsTest
    {
        private Maths _maths;

        [SetUp]
        public void SetUp() 
        {
            _maths = new Maths();
        }

        [Test]
        public void Add_WhenCalled_ReturnSum()
        {         
            var result = _maths.Add(1, 2);

            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        [TestCase(1, 2, 2)]
        [TestCase(4, 2, 4)]
        [TestCase(2, 2, 2)]
        public void Max_WhenCalled_ReturnMax(int a, int b, int expected)
        {
            var result = _maths.Max(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNumbersUpToLimit()
        {
            var result = _maths.GetOddNumbers(5);

            Assert.That(result, Is.EquivalentTo(new[] { 1, 3, 5 }));

        }
    }
}
