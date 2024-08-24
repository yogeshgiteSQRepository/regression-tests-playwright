using Microsoft.Playwright;
using System.Reflection;

namespace PlaywrightSpecFlowPOM.Pages;

public class OnlineApplicationPage
{
    private readonly IPage _user;

    public OnlineApplicationPage(Hooks.Hooks hooks)
    {
        _user = hooks.User;
    }
    private ILocator ApplyNow => _user.Locator("input[id='search_form_input']");
    private ILocator heading => _user.Locator("h2[role='heading']");
    private ILocator elementByvisibleText(string text) => _user.Locator("//*[text()='" + text + "']");
    private ILocator currentPage => _user.Locator("tr.pBarHeader td.selected.currentPTab");
    private ILocator description => _user.Locator("label[elname='descFldLabel'] [id^='docs-internal-']");
    private ILocator page => _user.Locator("//ul[@elname='footer' and starts-with(@page_link_name, 'Page') and not(contains(@style,'display'))]//div[contains(@class, 'footerPgNum')]");
    private ILocator nextBtn => _user.Locator("//ul[@elname='footer' and starts-with(@page_link_name, 'Page') and not(contains(@style,'display'))]//button[@elname='next']");
    private string errorMessages => "p[elname='error']";
    private ILocator parentInfoHeading => _user.Locator("ul[page_no='2'] li:not([style*='display']) > h2:first-child");
    private ILocator firstName => _user.Locator("input[complink='Name_First']");
    private ILocator lastName => _user.Locator("input[complink='Name_Last']");
    private ILocator email => _user.Locator("input[name='Email']");
    private ILocator phone => _user.Locator("input[name='PhoneNumber']");
    private ILocator secondParentSpan => _user.Locator("li[compname='Dropdown'] span[role='combobox']");
    private ILocator secondParentOpt (string option) => _user.Locator("//li[text()='" + option + "']");
    private ILocator howDidYouHearCheck (string option) => _user.Locator("input[aria-label='" + option + "'] + label");
    private ILocator preferredStartDate => _user.Locator("input[id='Date-date']");

    private ILocator studentInfoHeading => _user.Locator("ul[page_no='3'] li[id='Section3-li']:not([style*='display']) > h2:first-child");


    public async Task AssertBeforeAppPageContent()
    {
        dynamic firstScreen = ((dynamic)GlobalVariables.BeforeApplication);
        await Assertions.Expect(heading).ToBeVisibleAsync();
        await Assertions.Expect(heading).ToHaveTextAsync(firstScreen.heading);
        await Assertions.Expect(currentPage).ToHaveTextAsync(firstScreen.index);
        await Assertions.Expect(description).ToHaveTextAsync(firstScreen.content);
        await Assertions.Expect(page).ToHaveTextAsync(firstScreen.page);
    }

    public async Task clickOnNextButton()
    {
        await nextBtn.First.ClickAsync();
    }

    public async Task AssertParentInfoPage()
    {
        dynamic parentInfo = ((dynamic)GlobalVariables.parentInfoPage);
        await Assertions.Expect(heading).ToHaveTextAsync(parentInfo.heading);
        await Assertions.Expect(parentInfoHeading).ToHaveTextAsync(parentInfo.content);
        await Assertions.Expect(currentPage).ToHaveTextAsync(parentInfo.index);
        await Assertions.Expect(page).ToHaveTextAsync(parentInfo.page);
    }

    public async Task VerifyErrorMessages()
    {
        Assertions.Equals(await PageSupports.GetTextArray(_user, errorMessages), GlobalVariables.mandatoryFieldErrors);
    }

    public async Task FillParentDetails(Table table)
    {
        // Fill out the form fields
        await firstName.FillAsync(GetValueByKey(table, "FirstName")); // First Name
        await lastName.FillAsync(GetValueByKey(table, "LastName")); // Last Name
        await email.FillAsync(GetValueByKey(table, "Email")); //  Email Address
        await phone.FillAsync(GetValueByKey(table, "Phone")); // Phone Number
        await secondParentSpan.ClickAsync();
        await secondParentOpt(GetValueByKey(table, "Secparent")).ClickAsync(); //Second Parent add
        await howDidYouHearCheck(GetValueByKey(table, "HowDidHear")).ClickAsync(); //   How did you hear
        await preferredStartDate.FillAsync(GetValueByKey(table, "Date")); // Preferred Date
    }

    private string GetValueByKey(Table table, string key)
    {
        // Find the row where the Key column matches the specified key and return the Value
        var row = table.Rows.FirstOrDefault(r => r["Key"] == key);
        return row?["Value"]!;
    }

    public async Task AssertStudentInfoPage()
    {
        dynamic studentInfo = ((dynamic)GlobalVariables.studentInfoPage);
        await Assertions.Expect(heading).ToHaveTextAsync(studentInfo.heading);
        await Assertions.Expect(studentInfoHeading).ToHaveTextAsync(studentInfo.content);
        await Assertions.Expect(currentPage).ToHaveTextAsync(studentInfo.index);
        await Assertions.Expect(page).ToHaveTextAsync(studentInfo.page);
    }
}