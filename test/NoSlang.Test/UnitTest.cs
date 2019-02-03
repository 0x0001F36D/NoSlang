
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
            //�ڷR�A
            var data = "ji394su3";
            var mustBe = "�����������z����";

            var junkProcessor = new Bopomofo();

            var result = Parser.From(data, junkProcessor);

            Assert.AreEqual(result.Value, mustBe);
            
        }

        [TestMethod]
        public void Test2()
        {
            //��ı�o����
            var data = "ji3rm,62k71j4vu/6";
            var mustBe = "���������������x�����t������������";

            var junkProcessor = new Bopomofo();

            var result = Parser.From(data, junkProcessor);

            Assert.AreEqual(result.Value, mustBe);

        }
    }
}
