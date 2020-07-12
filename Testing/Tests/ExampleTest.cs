﻿using NUnit.Framework;
using Testing.Pages;

namespace Testing.Tests
{
    [TestFixture]
    public class ExampleTest : BaseTest
    {
        [Test]
        public void TestMethod()
        {
            var p = new ExamplePage(WebDriver);
            p.Visit("https://example.org");
            Assert.That(p.title.Displayed, Is.True);
            Assert.That(p.paragraph.Displayed, Is.True);
        }
    }
}