namespace TrxerTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DeploymentItem(@"Examples")]
        public void TestMethod1()
        {
            TrxerConsole.Trxer.Transform(@"exapmle.trx");
            Assert.IsTrue(System.IO.File.Exists(@"exapmle.trx.html"));
        }
    }
}