using OpenQA.Selenium;
using SDET_dotnet_MstestV2.Base;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace SDET_dotnet_MstestV2.POM
{
    public class Blog : UnoPages
    {
        [FindsBy(How = How.CssSelector, Using = "li > a[href='https://blog.unosquare.com']")]
        private IWebElement BlogLink { get; set; }
        [FindsBy(How = How.XPath, Using = "//h1[contains(text(),'DIGITAL TRANSFORMATION BLOG')]")]
        public IWebElement DigitalText { get; set; }
        [FindsBy(How = How.CssSelector, Using = "form>input")]
        public IWebElement SearchBox { get; set; }
        [FindsBy(How = How.CssSelector, Using = "button.search-submit")]
        public IWebElement SearchBoxClick { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Quality Assurance Questions to Ask in Agile Softwa')]")]
        public IWebElement QABlogPost { get; set; }
        public Blog() : base() {

        }

        public Blog GoToBlog() {
            browser.Click(BlogLink);
            return this;
        }

        public void SearchInBlog(string value) {
            browser.WriteInElement(SearchBox, value);
            browser.Click(SearchBoxClick);
        }
    }
}
