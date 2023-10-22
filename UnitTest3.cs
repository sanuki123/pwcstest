using Microsoft.Playwright.NUnit;
using Microsoft.Playwright;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class Tests3 : PageTest
{


    [Test]
    public async Task MyTest()
    {
        await Page.GotoAsync("https://www.yahoo.co.jp/");

        await Page.GetByLabel("天気・災害へ遷移する").ClickAsync();

        await Page.Locator("#searchText").ClickAsync();

        await Page.Locator("#searchText").FillAsync("北海道");

        await Page.Locator("#yjw_button_search").ClickAsync();

        await Page.GetByRole(AriaRole.Row, new() { Name = "北海道札幌市中央区", Exact = true }).GetByRole(AriaRole.Link).ClickAsync();

    }
}
