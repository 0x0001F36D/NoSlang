
namespace NoSlang.Test
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NoSlang.Models;

    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void Test1()
        {
            //我愛你
            var data = "ji394su3";
            var mustBe = "ㄨㄛˇㄞˋㄋㄧˇ";

            var junkProcessor = new Bopomofo();

            var result = Parser.From(data, junkProcessor);

            Assert.AreEqual(result.Value, mustBe);
            
        }

        [TestMethod]
        public void Test2()
        {
            //我覺得不行
            var data = "ji3rm,62k71j4vu/6";
            var mustBe = "ㄨㄛˇㄐㄩㄝˊㄉㄜ˙ㄅㄨˋㄒㄧㄥˊ";

            var junkProcessor = new Bopomofo();

            var result = Parser.From(data, junkProcessor);

            Assert.AreEqual(result.Value, mustBe);

        }
    }
}
