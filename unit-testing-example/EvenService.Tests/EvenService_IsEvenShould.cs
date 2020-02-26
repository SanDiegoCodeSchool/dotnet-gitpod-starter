using Microsoft.VisualStudio.TestTools.UnitTesting;
using Even.Services;

namespace Even.UnitTests.Services
{
    [TestClass]
    public class EvenService_IsEvenShould
    {
        private readonly EvenService _EvenService;

        public EvenService_IsEvenShould()
        {
            _EvenService = new EvenService();
        }

        [TestMethod]
        public void IsEven_InputIs1_ReturnFalse()
        {
            var result = _EvenService.IsEven(1);

            Assert.IsFalse(result, "1 should not be even");
        }
    }
}