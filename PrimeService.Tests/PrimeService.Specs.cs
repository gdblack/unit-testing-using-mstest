using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PrimeService.Tests
{
    [TestClass]
    // Establish a naming convention - the test should show it's intent
    // Worth mentioning MS used this naming convention we can use something that make more sense to us!
    public class PrimeService_IsPrime_Should
    {
        private readonly PrimeService _primeService;

        public PrimeService_IsPrime_Should()
        {
            _primeService = new PrimeService();
        }

        [TestMethod]
        public void IsPrime_InputIs1_ReturnFalse()
        {
            Assert.IsFalse(_primeService.IsPrime(1));
        }

        [DataTestMethod]
        [DataRow(-1)]
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(3)]
        public void IsPrime_ValuesLessThan2_ReturnFalse(int value)
        {
            var result = _primeService.IsPrime(value);

            Assert.IsFalse(result, $"{value} should not be prime");
        }
        
    }
}
