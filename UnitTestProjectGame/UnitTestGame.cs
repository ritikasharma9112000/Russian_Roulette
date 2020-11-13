using Microsoft.VisualStudio.TestTools.UnitTesting;
using Russian_Roulette;
namespace UnitTestProjectGame
{
    [TestClass]
    public class UnitTestGame
    {
        ClassGame Class_obj = new ClassGame();

        [TestMethod]
        public void TestMethod1()
        {
            int spin_unit_data = Class_obj.spin();
            Assert.AreNotEqual(0, spin_unit_data);
        }
        [TestMethod]
        public void test_spin_neg2()
        {
            int spin_unit_data = Class_obj.spin();
            Assert.AreNotEqual(7, spin_unit_data);
        }
    }
}
