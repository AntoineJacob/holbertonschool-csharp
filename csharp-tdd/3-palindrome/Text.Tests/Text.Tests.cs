using NUnit.Framework;
using Text;

namespace Text.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestTrue()
        {
			string test = "beeb";
			bool result = Str.IsPalindrome(test);
            Assert.IsTrue(result);
        }

        [Test]
        public void TestFalse()
        {
			string test = "Panama";
			bool result = Str.IsPalindrome(test);
            Assert.IsFalse(result);
		}

        [Test]
        public void TestEspecialCharacters()
        {
			string test = "A man, a plan, a canal: Panama.";
			bool result = Str.IsPalindrome(test);
            Assert.IsTrue(result);
		}

        [Test]
        public void TestEmptyString()
        {
			string test = "";
			bool result = Str.IsPalindrome(test);
            Assert.IsTrue(result);
		}

        [Test]
        public void TestUpperCase()
        {
			string test = "Racecar";
			bool result = Str.IsPalindrome(test);
            Assert.IsTrue(result);
		}

        [Test]
        public void TestNumber()
        {
			string test = "21012";
			bool result = Str.IsPalindrome(test);
            Assert.IsTrue(result);
		}

        [Test]
        public void TestNumberFalse()
        {
			string test = "1012";
			bool result = Str.IsPalindrome(test);
            Assert.IsFalse(result);
		}

        [Test]
        public void TestUpperCaseFalse()
        {
			string test = "HIjihJ";
			bool result = Str.IsPalindrome(test);
            Assert.IsFalse(result);
		}

        [Test]
        public void TestNumbersLetters()
        {
			string test = "HI44ih";
			bool result = Str.IsPalindrome(test);
            Assert.IsTrue(result);
		}
    }
}