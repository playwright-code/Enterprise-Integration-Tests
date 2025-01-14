using System.Text.RegularExpressions;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;

public class smokeTests
{
    [SetUp]
    public void setup()
    {
    }

    [Test]
    public async Task Test1()
    {
        var playwright = await Playwright.CreateAsync();
        var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
        var page = await browser.NewPageAsync();
        await page.GotoAsync("https://www.saucedemo.com/");
        await page.FillAsync("id=user-name", "standard_user");
        await page.FillAsync("id=password", "secret_sauce");
        await page.ClickAsync("id=login-button");
        await browser.CloseAsync();
    }
}