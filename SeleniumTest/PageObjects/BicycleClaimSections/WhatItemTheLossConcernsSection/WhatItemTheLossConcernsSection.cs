﻿using OpenQA.Selenium;

namespace SeleniumTest.PageObjects.BicycleClaimSections.WhatItemTheLossConcernsSection
{
    public class WhatItemTheLossConcernsSection
    {
        private static IWebDriver _driver;
        private static IWebElement _section;

        public WhatItemTheLossConcernsSection(IWebDriver driver)
        {
            _driver = driver;
            _section = _driver.FindElement(_sectionLocator);
        }

        private By _sectionLocator = By.Id("bicycleCosts_section");
        private By _headerLocator = By.XPath("//*[contains(@class,'ecmt-details-summary iconbefore icon-arrowdown')]");


        public IWebElement Header
        {
            get
            {
                var element = _section.FindElement(_headerLocator);
                return element;
            }
        }
    }
}
