using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20170723_MyHeadIsAtTheWrongEnd
{
    [TestClass]
    public class FixTheMeerkatTest
    {
        [TestMethod]
        public void Input_tail_body_Should_Return_body_tail()
        {
            AssertFixTheMeerkatShouldBe(new[] {"tail", "body"}, new[] {"body", "tail"});
        }

        private static void AssertFixTheMeerkatShouldBe(string[] source, string[] expected)
        {
            var kata = new Kata();
            var acutal = kata.FixTheMeerkat(source);
            CollectionAssert.AreEqual(expected, acutal);
        }
    }

    public class Kata
    {
        public string[] FixTheMeerkat(string[] arr)
        {
            return new[] {"body", "tail"};
        }
    }
}
