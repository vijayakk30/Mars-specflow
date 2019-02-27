using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using SpecflowPages;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using static SpecflowPages.CommonMethods;

namespace SpecflowTests.AcceptanceTest
{
    [Binding]
    public class Add_SkillsSteps 
    {
        [Given(@"I clicked on the Skills tab under Profile page")]
        public void GivenIClickedOnTheSkillsTabUnderProfilePage()
        {
            //Wait
            Thread.Sleep(1500);

            // Click on Profile tab
            Driver.driver.FindElement(By.XPath(" / html[1] / body[1] / div[1] / div[1] / section[1] / div[1] / a[2]")).Click();

        }

        [When(@"I add  Skills")]
        public void WhenIAddSkills()
        {
            //Click on Skills tab
            Driver.driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[1]/a[2]")).Click();
            Thread.Sleep(2000);
            //Click on Add New Button
            Driver.driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/thead[1]/tr[1]/th[3]/div[1]")).Click();
            //Add Skill
            Driver.driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/div[1]/div[1]/input[1]")).SendKeys("Selenium Using C#");
            Thread.Sleep(2000);
            //Click on Choose Skill Level Dropdown
            Driver.driver.FindElement(By.XPath("//select[@name='level']")).Click();
            Thread.Sleep(2000);

            IWebElement Skill = Driver.driver.FindElements(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option"))[1];
            Skill.Click();
            Thread.Sleep(1000);

            //Click on Add 
            Driver.driver.FindElement(By.XPath("//input[@value='Add']")).Click();
            Thread.Sleep(2000);
        }
        
        [Then(@"that Skills should be displayed on my listings")]
        public void ThenThatSkillsShouldBeDisplayedOnMyListings()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Add a Skill");
                Thread.Sleep(500);
                Thread.Sleep(1000);
                string ExpectedValue = "Selenium using C#";
                string ActualValue = Driver.driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Added a Skill Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "SkillAdded");
                }

                else
                    CommonMethods.test.Log(LogStatus.Fail, "Test Failed");

            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
            }

        }
    }
}
        
    

