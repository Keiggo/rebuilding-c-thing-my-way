using NUnit.Framework;

namespace TheInternet.Tests;

public class LoginTests : BaseTests
{
    private HomePage homePage;
    private LoginPage loginPage;
    private SecureAreaPage secureAreaPage;

    [Test]
    public void Logging_in_as_ya_boi()
    {
        homePage.clickFormAuthentication();
        loginPage.enterUsername("tomsmith");
        loginPage.enterPassword("SuperSecretPassword!");
        loginPage.clickLoginButton();
        
        Assert.That(secureAreaPage.getBannerDetails().ToArray()[0].Contains("You logged into a secure area!"), "The wrong message is displayed");
        Assert.That(secureAreaPage.getBannerDetails().ToArray()[1].Contains("flash success"), "The wrong class is being used");
    }

}