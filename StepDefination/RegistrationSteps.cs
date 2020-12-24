using EbayProject.PageObject;
using System;
using TechTalk.SpecFlow;

namespace EbayProject.StepDefination
{
    [Binding]
    public class RegistrationSteps
    {
        AutomationPage automationPage;
        public RegistrationSteps()
        {
            automationPage = new AutomationPage();
        }

        [Given(@"that i navigate to the website ""(.*)""")]
        public void GivenThatINavigateToTheWebsite(string Url)
        {
            automationPage.NavigateToTheWebsite(Url);
        }
        
        [Given(@"Click on register")]
        public void GivenClickOnRegister()
        {
            automationPage.ClickOnRegister();
        }
        
        [Given(@"I enter my first name")]
        public void GivenIEnterMyFirstName()
        {
            automationPage.EnterMyFirstName();
        }
        
        [Given(@"I enter my surname")]
        public void GivenIEnterMySurname()
        {
            automationPage.EnterMySurname();
        }
        
        [Given(@"I enter my email address")]
        public void GivenIEnterMyEmailAddress()
        {
            automationPage.MyEmailAddress();
        }
        
        [Given(@"I enter my password")]
        public void GivenIEnterMyPassword()
        {
            automationPage.MyPassword();
        }
        
        [When(@"I click register")]
        public void WhenIClickRegister()
        {
            automationPage.ClickRegister();
        }
        
        [Then(@"I should be registerd")]
        public void ThenIShouldBeRegisterd()
        {
            
        }
    }
}
