using Microsoft.Playwright;

public class PageSupports
{
    public static async Task<string> GetTextContent(ILocator element)
    {
        if(element != null)
        {
            string textContent = await element.InnerTextAsync();
            return textContent;
        } else return String.Empty;
    }

    public static async Task<List<string>> GetTextArray(IPage page, string locator)
    {
        var elements = await page.QuerySelectorAllAsync(locator);
        var innerTexts = new List<string>();

        foreach (var element in elements)
        {
            var innerText = await element.InnerTextAsync();
            if(innerText.Length > 1)
                innerTexts.Add(innerText);
        }
        return innerTexts;
    }
}