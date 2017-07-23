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
        public void Input_tail_body_head_Should_Return_head_body_tail()
        {
            AssertFixTheMeerkatShouldBe(new[] { "tail", "body", "head" }, new[] { "head", "body", "tail" });
        }

        [TestMethod]
        public void Input_tails_body_heads_Should_Return_heads_body_tails()
        {
            AssertFixTheMeerkatShouldBe(new[] { "tails", "body", "heads" }, new[] { "heads", "body", "tails" });
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
                if (item.StartsWith("tail"))
                {
                    result.Insert(1, item);
                }

                if (item.StartsWith("head"))
                {
                    result.Insert(0, item);
                }
            }

            return result.ToArray();
        }
    }
}
