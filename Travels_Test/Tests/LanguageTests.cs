using NUnit.Framework;
using Travels_Test.Framework;
using Travels_Test.PageObjects;

namespace Travels_Test.Tests
{
    [TestFixture]
    public class LanguageTests : BaseTest
    {
        [TestCase("Arabic", "ARABIC")]
        [TestCase("Turkish", "TURKISH")]
        [TestCase("French", "FRENCH")]
        [TestCase("Spanish", "SPANISH")]
        [TestCase("Russian", "RUSSIAN")]
        [TestCase("English", "ENGLISH")]
        [Test]
            public void LanguageTest(string language, string expected)
            {
                var Language = new ToolBarObjects(Driver);
                Language.ChangeLanguage(language);
                Assert.AreEqual(expected, Language.LanguageDropdown.Text, "Language wasn't change to preffered on " + language);
            }
        }
    }
