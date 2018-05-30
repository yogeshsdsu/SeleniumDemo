﻿using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace BasicTest
{
    class SeleniumSetMethods
    {
        //Enter Text 
        // Since it is a library we will write it as a static method
        public static void EnterText(IWebDriver driver, string element, string value, string elementtype)
        {
            if (elementtype == "id")
            {
                driver.FindElement(By.Id(element)).SendKeys(value);
            }
            if (elementtype == "Name")
            {
                driver.FindElement(By.Name(element)).SendKeys(value);
            }
        }
            //Click into a button, CheckBox, option etc
            public static void Click(IWebDriver driver, string element, string elementtype)
            {
                if(elementtype == "Id")
                {
                    driver.FindElement(By.Id(element)).Click();
                }
                if(elementtype == "Name")
                {
                    driver.FindElement(By.Name(element)).Click();
                }
            }

        // Selecting a drop down control
        public static void SelectDropDown(IWebDriver driver, string element, string value, string elementtype)
        {
            if (elementtype == "Id")
            {
                new SelectElement(driver.FindElement(By.Id(element))).SelectByText(value);
            }
            if (elementtype == "Name")
            {
                new SelectElement(driver.FindElement(By.Name(element))).SelectByText(value);
            }
        
        }
    }
}
