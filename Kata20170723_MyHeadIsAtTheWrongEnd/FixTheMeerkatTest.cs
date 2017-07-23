using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Security.Cryptography;

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

        [TestMethod]
        public void Input_sky_rainbow_ground_Return_ground_rainbow_sky()
        {
            AssertFixTheMeerkatShouldBe(new[] { "sky", "rainbow", "ground" }, new[] { "ground", "rainbow", "sky" });
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
            return new []{ arr[2], arr[1], arr[0] };
        }
    }
}