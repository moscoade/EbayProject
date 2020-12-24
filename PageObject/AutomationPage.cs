using EbayProject.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace EbayProject.PageObject
{
    class AutomationPage
    {
        IWebDriver driver;

        IWebElement register => driver.FindElement(By.XPath("//a[text()='register']"));
        IWebElement firstName => driver.FindElement(By.XPath("//input[@name='firstname']"));
        IWebElement surname => driver.FindElement(By.XPath("//input[@name='lastname']"));
        IWebElement email => driver.FindElement(By.XPath("//input[@id='email']"));
        IWebElement password => driver.FindElement(By.XPath("//input[@type='password']"));
        IWebElement registerButton => driver.FindElement(By.XPath("//button[@type='submit']"));

        public void ClickRegister()
        {
            registerButton.Click();
        }
        public void MyPassword()
        {
            password.SendKeys("Mysecurepass");
        }
        public void MyEmailAddress()
        {
            email.SendKeys("myade1@gmail.com");
        }
        public void EnterMySurname()
        {
            surname.SendKeys("Ade");
        }
        public void EnterMyFirstName()
        {
            firstName.SendKeys("Moses");
        }
        public void ClickOnRegister()
        {
            register.Click();
        }
        public void NavigateToTheWebsite(string Url)
        {
            driver.Navigate().GoToUrl(Url);  
        }


        public AutomationPage()
        {
            driver = Hook.driver;
        }


    }
}
