using OpenQA.Selenium;
using SDET_dotnet_MstestV2.Base;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace SDET_dotnet_MstestV2.POM
{
    public class ServicesPage : UnoPages
    {
        [FindsBy(How = How.XPath, Using = "//a[.= 'Services' and @class = 'nav-link']")]
        private IWebElement ServicesMenu { get; set; }
        [FindsBy(How = How.XPath, Using = "//h3[contains(text(),'Trusted by industry leaders')]")]
        public IWebElement IndustryLeadersText { get; set; }
        [FindsBy(How = How.XPath, Using = "//body/main[1]/div[2]/div[4]/div[1]/div[2]")]
        public IWebElement IndustryLeadersContainer { get; set; }

        //[FindsBy(How = How.XPath, Using = "//a[.= 'Practice Areas' and @class = 'nav-link']")]
        //private IWebElement PracticeAreas { get; set; }
        public ServicesPage() : base()
        {
            
        }

        public ServicesPage GoToServices()
        {
            browser.Click(ServicesMenu);
            //browser.Click(PracticeAreas);
            return this;
        }

        public bool isIndustyLeadersText()
        {
            bool isIndustyLeaders = IndustryLeadersText.Displayed;
            return isIndustyLeaders;
        }

        public int nmbIndustryLeadersLogos()
        {
            var nmb = IndustryLeadersContainer.FindElements(By.TagName("div"));
            return nmb.Count;
        }
    }
}
