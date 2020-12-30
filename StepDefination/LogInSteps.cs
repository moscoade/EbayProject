using EbayProject.PageObject;
using System;
using TechTalk.SpecFlow;

namespace EbayProject.StepDefination
{
    [Binding]
    public class LogInSteps
    {
        AutomationPage automationPage;
        public LogInSteps()
        {
            automationPage = new AutomationPage();
        }

        [Given(@"Click on SignIn")]
        public void GivenClickOnSignIn()
        {
            automationPage.ClickOnSignIn();
        }
        
        [Given(@"I enter User name")]
        public void GivenIEnterUserName()
        {
            automationPage.EnterUserName();
        }
        
        [Given(@"I click continue")]
        public void GivenIClickContinue()
        {
            automationPage.ClickContinue();
        }

        [Given(@"I click Sign In button")]
        public void GivenIClickSignInButton()
        {
            automationPage.SignInButton();
        }

        [Given(@"I should be signed In")]
        public void GivenIShouldBeSignedIn()
        {
            automationPage.ShouldBeSignedIn();
        }

        [Given(@"That i navigate to search and enter ""(.*)""")]
        public void GivenThatINavigateToSearchAndEnter(string Items)
        {
            automationPage.SearchAndEnterItems(Items);
        }


        [When(@"I click on search button")]
        public void WhenIClickOnSearchButton()
        {
            automationPage.SearchButton();
        }

        [Then(@"Cars should be display")]
        public void ThenCarsShouldBeDisplay()
        {
            automationPage.ItemsIsDisplayed();
        }

    }
}
