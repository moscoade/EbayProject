using EbayProject.Hooks;
using NUnit.Framework;
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
        IWebElement signIn => driver.FindElement(By.XPath("(//a[text()='Sign in'])[1]"));
        IWebElement userName => driver.FindElement(By.XPath("//input[@id='userid']"));
        IWebElement continueBtn => driver.FindElement(By.XPath("//button[@id='signin-continue-btn']"));
        IWebElement signInBtn => driver.FindElement(By.XPath("//button[@type='submit']"));
        IWebElement profilePage => driver.FindElement(By.XPath("//img[@alt='eBay logo']"));
        IWebElement searchItems => driver.FindElement(By.XPath("//input[@id='gh-ac']"));
        IWebElement searchBtn => driver.FindElement(By.XPath("//input[@value='Search']"));
        IWebElement allItems => driver.FindElement(By.XPath("//span[text()='All']"));

     
        public void ItemsIsDisplayed()
        {
            Assert.IsTrue(allItems.Displayed);
        }


        public void SearchButton()
        {
            searchBtn.Click();
        }
        public void SearchAndEnterItems(string Items)
        {
            searchItems.SendKeys(Items);
        }
        public void ShouldBeSignedIn()
        {
          if (profilePage.Displayed)
          {
                Assert.That(profilePage.Displayed, Is.True);
          }
        }

        public void SignInButton()
        {
            signInBtn.Click();
        }
      
        public void ClickContinue()
        {
            continueBtn.Click();
        }
        public void EnterUserName()
        {
            userName.SendKeys("adedoyin_ade");
        }
        public void ClickOnSignIn()
        {
            signIn.Click();
        }

        //Registration code
        public void ClickRegister()
        {
            registerButton.Click();
        }
        public void MyPassword()
        {
            password.SendKeys("Tolulope1");
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
