using Microsoft.VisualStudio.TestTools.UnitTesting;
using SDET_dotnet_MstestV2.POM;
using System.Collections.Generic;

namespace SDET_dotnet_MstestV2
{
    [TestClass]
    public class TestCases
    {
        HomePage homepage;
        ServicesPage servicesPage;
        AboutPage aboutPage;
        [TestInitialize]
        public void BeforeTest()
        {
            homepage = new HomePage();
            servicesPage = new ServicesPage();
            aboutPage = new AboutPage();
        }
        [TestMethod]
        public void Unosquare_GotoCareers()
        {
            homepage.GoToServicesAndPracticeAreas();
        }

        [TestMethod]
        public void AllElementsInServices()
        {
            /*
             * Your code goes here:
             * Create a new POM Page called: Services, implement Page Factory and add the following Test
             * Go to https://www.unosquare.com
             * Go to Services
             * Verify that this element is present: TRUSTED BY INDUSTRY LEADERS
             * Print How many Industry Leaders are being displayed
             * */
            servicesPage.GoToServices();
            Assert.IsTrue(servicesPage.isIndustyLeadersText());
            Assert.AreEqual(8, servicesPage.nmbIndustryLeadersLogos());
            System.Console.WriteLine(servicesPage.nmbIndustryLeadersLogos());
        }
        [TestMethod]
        public void ValidateOurMission()
        {
            /*
             * Your code goes here:
             * Create a new POM Page called: About, implement Page Factory and add the following Test
             * Go to https://www.unosquare.com
             * Go to About
             * Verify that 3 elements are present: Personal, Professional and Social
             * Scroll Down and verify element is present: LEADERSHIP TEAM
             * Print the name of each Leader and the corresponding Rol
             * */
            aboutPage.GoToAbout();
            Assert.IsTrue(aboutPage.areSubtitlesPresent());
            Assert.IsTrue(aboutPage.isLeadershipPresent());
            Dictionary<string, string> leadsRoles = aboutPage.LeadersList();
            foreach (var item in leadsRoles)
            {
                System.Console.WriteLine("Name: " + item.Key + " Role: " + item.Value);
            }
        }
    }
}
