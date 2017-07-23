using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

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

        [TestMethod]
        public void Input_bottom_middle_top_Should_Return_top_middle_bottom()
        {
            AssertFixTheMeerkatShouldBe(new[] { "bottom", "middle", "top" }, new[] { "top", "middle", "bottom" });
        }

        [TestMethod]
        public void Input_lowerlegs_torso_upperlegs_Should_Return_upperlegs_torso_lowerlegs()
        {
            AssertFixTheMeerkatShouldBe(new[] { "lower legs", "torso", "upper legs" }, new[] { "upper legs", "torso", "lower legs" });
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
            var middleContext = new[] { "body", "middle", "torso" };
            var topContext = new[] { "head", "top", "upper" };
            var botttomContext = new[] { "tail", "bottom", "lower" };

            var result = arr.Where(a => middleContext.Contains(a)).ToList();

            foreach (var item in arr.ToList())
            {
                if (topContext.Any(a => item.StartsWith(a)))
                {
                    result.Insert(0, item);
                }

                if (botttomContext.Any(a => item.StartsWith(a)))
                {
                    result.Insert(1, item);
                }
            }
            
            return result.ToArray();
        }
    }
}