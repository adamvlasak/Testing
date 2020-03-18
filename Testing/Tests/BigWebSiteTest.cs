﻿using NUnit.Framework;
using OpenQA.Selenium;
using Testing.Pages;

namespace Testing.Tests
{
    [TestFixture]
    public class BigWebSiteTest : BaseTest
    {
        [Test]
        public void TestMethod()
        {
            var homePage = new BigWebsitePage(WebDriver);
            homePage.Visit();
        }
    }
}