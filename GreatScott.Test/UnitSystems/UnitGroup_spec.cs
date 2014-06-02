
using GreatScott.Model;
using GreatScott.UnitSystems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace GreatScott.Test.UnitSystems
{
    [TestClass]
    public class UnitGroup_spec : UnitGroup
    {
        public UnitGroup_spec() : base(String.Empty) { }

        [TestMethod]
        public void AddUnitBody_NoRange_ElementAtIndex()
        {
            int index = 3;
            string expected = "km";
            string actual = AddUnitBody("m", index, index)[0].Symbol;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddUnitBody_ValidRange_LengthsAreEqual()
        {
            List<unit> expected = new List<unit>(){
            new unit(1.0, "m"),
            new unit(10.0, "dm"),
            new unit(100.0, "cm"),
            new unit(1000.0, "mm"),
            new unit(1000000.0, "μm")
            };
            List<unit> actual = AddUnitBody("m", 6, 10);

            Assert.AreEqual(expected.Count, actual.Count);
        }

        [TestMethod]
        public void AddUnitBody_ValidRange_ListFromSpecifiedRange()
        {
            List<unit> expected = new List<unit>(){
            new unit(1.0, "m"),
            new unit(10.0, "dm"),
            new unit(100.0, "cm"),
            new unit(1000.0, "mm"),
            new unit(1000000.0, "μm")
            };
            List<unit> actual = AddUnitBody("m", 6, 10);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddUnitBody_ReversedRange_EmptyList()
        {
            int expected = 0;
            int actual = AddUnitBody("m", 12, 0).Count;
            Assert.AreEqual(expected, actual);
        }
    }
}
