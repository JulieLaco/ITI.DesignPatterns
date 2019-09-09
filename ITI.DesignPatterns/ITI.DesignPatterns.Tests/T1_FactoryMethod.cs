using ITI.DesignPaterns.Correction.FactoryMethod;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ITI.DesignPatterns.Tests
{
    [TestClass]
    public class T1_FactoryMethod
    {
        [TestMethod]
        public void t1_create_character_with_FirstName_And_LastName()
        {
            Character c = new Character();
            var obj = c.CreateCharacter();
            Assert.AreEqual("Jeff", obj.FirstName());
            Assert.AreEqual("Dunham", obj.LastName());
        }

        [TestMethod]
        public void t2_get_heroes_stuff()
        {
            Character c = new Character();
            var obj = c.CreateCharacter();
            Assert.IsNotNull(obj.Stuff());
            Assert.AreEqual("Axe", obj.Stuff()[0]);
        }
    }
}
