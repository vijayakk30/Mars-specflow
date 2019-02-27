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
    public class Add_EducationSteps 
    {
        [Given(@"I clicked on the Education tab under Profile page")]
        public void GivenIClickedOnTheEducationTabUnderProfilePage()
        {
            //Wait
            Thread.Sleep(1500);

            // Click on Profile tab
            Driver.driver.FindElement(By.XPath("/ html[1] / body[1] / div[1] / div[1] / section[1] / div[1] / a[2]")).Click();
            Thread.Sleep(2000);
        }

        [When(@"I add  Education details")]
        public void WhenIAddEducationDetails()
        {
            //Click on Education Tab
            Driver.driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[1]/a[3]")).Click();
            Thread.Sleep(2000);
            //Click on Add New button
            Driver.driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/table[1]/thead[1]/tr[1]/th[6]/div[1]")).Click();
            Thread.Sleep(1000);
            //Enter College or University Name
            Driver.driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/input[1]")).SendKeys("Andhra University");
            Thread.Sleep(1000);
            //Select Country of College or University from dropdown
            Driver.driver.FindElement(By.XPath("//select[@name='country']")).Click();
            Thread.Sleep(1000);
            //Select Country
            IWebElement Education = Driver.driver.FindElements(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select/option"))[65];
            Education.Click();
            Thread.Sleep(1000);
            //Click on  Title dropdown
            Driver.driver.FindElement(By.XPath("//select[@name='title']")).Click();
            Thread.Sleep(1000);
            //Select Title
           IWebElement Title = Driver.driver.FindElements(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select/option"))[8];
            Title.Click();
            Thread.Sleep(1000);
            // Enter the Degree
            Driver.driver.FindElement(By.XPath("//input[@placeholder='Degree']")).SendKeys(" Masters");
            Thread.Sleep(1000);
            //Select year of Graduation 
            Driver.driver.FindElement(By.XPath("//select[@name='yearOfGraduation']")).Click();
            Thread.Sleep(1000);
            IWebElement Year = Driver.driver.FindElements(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select/option"))[4];
            Year.Click();
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath("//input[@value='Add']")).Click();
            Thread.Sleep(1000);
        }

        
        [Then(@"that Education details should be displayed on my listings")]
        public void ThenThatEducationDetailsShouldBeDisplayedOnMyListings()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Add Education details");
                Thread.Sleep(1000);
                string ExpectedValue = "MTech";
                string ActualValue = Driver.driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Added a Educationdetails Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "EducationdetailsAdded");
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
