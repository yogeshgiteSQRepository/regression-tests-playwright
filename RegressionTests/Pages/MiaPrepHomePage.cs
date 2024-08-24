using Microsoft.Playwright;
using NUnit.Framework;
using NUnit.Framework.Internal;
using System.Diagnostics;

namespace PlaywrightSpecFlowPOM.Pages;

public class MiaPrepHomePage
{
    private readonly IPage _user;

    public MiaPrepHomePage(Hooks.Hooks hooks)
    {
        _user = hooks.User;
    }

    private ILocator banner => _user.Locator("div[class*='mia-MiaPrepAnnouncement']");
    private string linkOnPage => "//a[text()='TEXT']";

    public ILocator getlinkElementByVisibleText(string visibleLinkText)
    {
        ILocator linkElement = _user.Locator(linkOnPage.Replace("TEXT", visibleLinkText));
        return linkElement;
    }

    public async Task AssertPageContent(string visibleLinkText)
    {
        await Assertions.Expect(_user).ToHaveURLAsync(GlobalVariables.baseUrl);
        await Assertions.Expect(banner).ToBeVisibleAsync();
        await Assertions.Expect(getlinkElementByVisibleText(visibleLinkText)).ToBeVisibleAsync();
    }

    public async Task clickLinkAndVerifyNavigation(string visibleLinkText, string url)
    {
        await getlinkElementByVisibleText(visibleLinkText).First.ClickAsync();
        // Get the current URL
        string currentUrl = _user.Url;
        Assert.IsTrue(currentUrl.Contains(url), $"The URL does not contain the expected substring. Current URL: {currentUrl}");
    }
}