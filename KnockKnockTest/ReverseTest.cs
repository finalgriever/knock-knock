using Microsoft.VisualStudio.TestTools.UnitTesting;
using KnockKnock.Extensions;

namespace KnockKnockTest
{
    [TestClass]
    public class ReverseTest
    {
        [TestMethod]
        public void ReversingStringsProducesTheExpectedResult()
        {
            Assert.AreEqual("?nam pu s'tahW", "What's up man?".Reverse());
            Assert.AreEqual("....gnoooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooool etiuq si sihT", "This is quite looooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooong....".Reverse());
            Assert.AreEqual("", "".Reverse());
        }
    }
}
