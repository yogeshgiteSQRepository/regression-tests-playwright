using Microsoft.Playwright;
using PlaywrightSpecFlowPOM.Pages;

namespace PlaywrightSpecFlowPOM.Steps;

[Binding]
public class ApplyOnlineHighSchoolSteps
{
    private readonly IPage _user;
    private readonly MiaPrepHomePage _MiaPrepHomePage;
    private readonly OnlineApplicationPage _OnlineAppPage;

    public ApplyOnlineHighSchoolSteps(Hooks.Hooks hooks, MiaPrepHomePage MiaPrepHomePage, OnlineApplicationPage onlineAppPage)
    {
        _user = hooks.User;
        _MiaPrepHomePage = MiaPrepHomePage;
        _OnlineAppPage = onlineAppPage;
    }

    [Given(@"parent user is on the miaprep online high school website")]
    public async Task GivenTheUserIsOnTheMiaPrepHomepage()
    {
        //Go to the MiaPrep homepage
        await _user.GotoAsync(GlobalVariables.baseUrl);

        //Assert the page
        await _MiaPrepHomePage.AssertPageContent("Online High School");
    }

    [When(@"user click on '(.*)' and verify partial url '(.*)'")]
    public async Task WhenParentUserNavigateToMOHS(string visibleLinkText, string partialUrl)
    {
        //User click by visible text and verify partial url
        await _MiaPrepHomePage.clickLinkAndVerifyNavigation(visibleLinkText, partialUrl);
    }

    [Then(@"user verify before application page")]
    public async Task ThenUserVerifyBeforeAppPage()
    {
        await _OnlineAppPage.AssertBeforeAppPageContent();
    }

    [When(@"user click on Next button")]
    public async Task WhenUserClickOnNextButton()
    {
        await _OnlineAppPage.clickOnNextButton();
    }

    [Then(@"user verify parent information page")]
    public async Task ThenUserVerifyParentInfoPage()
    {
        await _OnlineAppPage.AssertParentInfoPage();
    }

    [Then(@"user verify errors on page")]
    public async Task ThenUserVerifyErrorMessages()
    {
        await _OnlineAppPage.VerifyErrorMessages();
    }
    
    [When(@"user fill parent details into form using below given data")]
    public async Task WhenUserFillTheirDetails(Table table)
    {
        await _OnlineAppPage.FillParentDetails(table);
    }

    [Then(@"user verify student information page")]
    public async Task ThenUserVerifyStudentInfoPage()
    {
        await _OnlineAppPage.AssertStudentInfoPage();
    }
}