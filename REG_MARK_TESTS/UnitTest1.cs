using NUnit.Framework;
using NUnit.Framework.Constraints;
using REG_LIB_MARK;
using REG_MARK;

namespace REG_MARK_TESTS
{
    public class Tests
    {
        private IRegMark _regMark;
        private string _mark;

        [SetUp]
        public void Setup()
        {
            _mark = "a999aa999";
            _regMark = new RegMark();
        }

        [Test]
        public void CheckTest()
        {
            bool result = _regMark.CheckMark(_mark);
            Assert.That(result, Is.True);
        }
    }
}