using VIN_LIB;
using NUnit.Framework;

namespace VIN_LIB_TESTS
{
    public class IVINPaserTests
    {
        private IVINParser _parser;
        private string _vin;

        [SetUp]
        public void Setup()
        {
            _vin    = "JHMCM56557C404453";
            _parser = new VINParserBase();
        }

        [Test]
        public void CheckVINTest()
        {
            bool result = _parser.CheckVIN(_vin);
            Assert.That(result, Is.True);
        }

        [Test]
        public void GetTransportYearTest()
        {
            int result  = _parser.GetTransportYear(_vin);
            int expected = 2007;
            Assert.AreEqual(expected, result);
        }


        [Test]
        public void GetVINCoutryTest()
        {
            string result = _parser.GetVINCountry(_vin);
            string expected = "Япония";
            Assert.AreEqual(expected, result);
        }
    }
}