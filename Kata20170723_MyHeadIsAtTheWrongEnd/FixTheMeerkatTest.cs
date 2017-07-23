using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

        [TestMethod]
        public void Input_body_head_Should_Return_head_body()
        {
            AssertFixTheMeerkatShouldBe(new[] { "body", "head" }, new[] { "head", "body" });
        }

        [TestMethod]
        public void Input_tail_body_head_Should_Return_head_body_tail()
        {
            AssertFixTheMeerkatShouldBe(new[] { "tail", "body", "head" }, new[] { "head", "body", "tail" });
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
            var result = new List<string> { "body" };

            foreach (var item in arr.ToList())
            {
                if (item == "tail")
                {
                    result.Insert(1, "tail");
                }
                if (item == "head")
                {
                    result.Insert(0, "head");
                }
            }

            return result.ToArray();
        }
    }
}
