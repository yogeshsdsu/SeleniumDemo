using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTest
{
    class LoginLogout
    {

        //Create the reference for our browser
        IWebDriver driver = new ChromeDriver();

        static void Main(string[] args)
        {
 
        }

        [SetUp]
        public void Inintialize()
        {
            //Navigate to google page
            driver.Navigate().GoToUrl("http://www.executeautomation.com/demosite/index.html?UserName=&Password=&Login=Login");
            Console.WriteLine("Open URL..");
        }

        [Test]
        public void ExecuteTest()
        {
            /*//EnterText(element, value, type)

            //Find the search test box UI Element
            IWebElement element = driver.FindElement(By.Name("q"));

            //Perform Operation
            element.SendKeys("executeautomation");
            Console.WriteLine("Execute Test..");*/

            //Title
            SeleniumSetMethods.SelectDropDown(driver, "TitleId", "Mr.", "Id");

            //Initial
            SeleniumSetMethods.EnterText(driver, "Initial", "executeautomation", "Name");

            //click
            SeleniumSetMethods.Click(driver, "Save", "Name");
        }

        [Test]
        public void NextTest()
        {
            Console.WriteLine("Next Method to execute..");
        }

        [TearDown]
        public void CleanUp()
        {
            //close the browser
            driver.Close();
            Console.WriteLine("Cleanup..");
        }
    }
}
