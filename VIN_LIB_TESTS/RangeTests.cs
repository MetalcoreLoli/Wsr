using Microsoft.VisualStudio.TestPlatform.ObjectModel.DataCollection;
using NUnit.Framework;
using VIN_LIB;

namespace VIN_LIB_TESTS
{
    [TestFixture]
    public class RangeTests
    {
        private MyRange _range;

        [SetUp]
        public void SetUp()
        {
            _range = new MyRange(1, 5);
        }

        [Test]
        public void IsInTest()
        {
            bool result = _range.IsIn(4);
            Assert.That(result, Is.True);
        }
    }
}
