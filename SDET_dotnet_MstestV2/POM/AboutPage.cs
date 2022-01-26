using OpenQA.Selenium;
using SDET_dotnet_MstestV2.Base;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace SDET_dotnet_MstestV2.POM
{
    public class AboutPage : UnoPages
    {
        [FindsBy(How = How.XPath, Using = "//a[.= 'About' and @class = 'nav-link']")]
        private IWebElement AboutMenu { get; set; }
        [FindsBy(How = How.XPath, Using = "//h5[contains(text(),'Personal')]")]
        private IWebElement PersonalText { get; set; }
        [FindsBy(How = How.XPath, Using = "//h5[contains(text(),'Professional')]")]
        private IWebElement ProfText { get; set; }
        [FindsBy(How = How.XPath, Using = "//h5[contains(text(),'Social')]")]
        private IWebElement SocialText { get; set; }
        [FindsBy(How = How.XPath, Using = "//h3[contains(text(),'Leadership Team')]")]
        private IWebElement LeadershipTeamText { get; set; }
        //[FindsBy(How = How.CssSelector, Using = "div.lead-card")]
        //private List<IWebElement> LeaderCards { get; set; }

        public AboutPage() : base()
        {
            
        }

        public AboutPage GoToAbout()
        {
            browser.Click(AboutMenu);
            return this;
        }

        public bool areSubtitlesPresent()
        {
            if (PersonalText.Displayed && ProfText.Displayed && SocialText.Displayed)
                return true;
            else return false;
        }

        public bool isLeadershipPresent()
        {
            return LeadershipTeamText.Displayed;
        }

        public Dictionary<string, string> LeadersList()
        {
            Dictionary<string, string> leadCards = new Dictionary<string, string>();
            var htmlLeadCards = driver.FindElements(By.CssSelector("div.lead-card"));
            foreach (var item in htmlLeadCards)
            {
                string[] nameAndRole = item.Text.Split("\n");
                string name = nameAndRole[0];
                string role = nameAndRole[1];
                leadCards.Add(name, role);
            }
            return leadCards;
        }
    }
}
