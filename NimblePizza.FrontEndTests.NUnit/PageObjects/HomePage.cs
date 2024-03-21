namespace NimblePizza.FrontEndTests.NUnit.PageObjects;

using Microsoft.Playwright;

public class HomePage : PageObjectBase
{
    private readonly IPage _page;
    private readonly string _pageUrl;

    public HomePage(IPage page)
    {
        _page = page;
        _pageUrl = $"{SITE_BASE}/";
    }

    public async Task NavigateToHomePage()
    {
        await _page.GotoAsync(_pageUrl);
    }

    public async Task<string> GetPageTitle()
    {
        return await _page.TitleAsync();
    }

    public async Task<string?> GetHeaderText()
    {
        var headerElement = _page.Locator("h1");
        return await headerElement.TextContentAsync();
    }

    public async Task<string?> GetComingSoonText()
    {
        var comingSoonText = _page.GetByRole(AriaRole.Status);
        return await comingSoonText.TextContentAsync();
    }

    public async Task ClickOrderNowButton()
    {
        await _page.GetByRole(AriaRole.Button).ClickAsync();
    }
    // Other methods to interact with elements on the home page
}
