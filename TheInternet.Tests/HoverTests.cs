using NUnit.Framework;

namespace TheInternet.Tests;

public class HoverTests : BaseTests
{
    [Test]
    public void Hovering_over_each_thingy()
    {
        var homePage = new HomePage(driver);
        var hoversPage = new HoversPage(driver);

        homePage.clickHovers();
        
        Assert.True(hoversPage.hoverOveruserImage(1).isCaptionDisplayed());
        Assert.AreEqual("name: user1", hoversPage.hoverOveruserImage(1).getUsername());
        Assert.AreEqual("https://the-internet.herokuapp.com/users/1", hoversPage.hoverOveruserImage(1).getUserLink());

        Assert.True(hoversPage.hoverOveruserImage(2).isCaptionDisplayed());
        Assert.AreEqual("name: user2", hoversPage.hoverOveruserImage(2).getUsername());
        Assert.AreEqual("https://the-internet.herokuapp.com/users/2", hoversPage.hoverOveruserImage(2).getUserLink());

        Assert.True(hoversPage.hoverOveruserImage(3).isCaptionDisplayed());
        Assert.AreEqual("name: user3", hoversPage.hoverOveruserImage(3).getUsername());
        Assert.AreEqual("https://the-internet.herokuapp.com/users/3", hoversPage.hoverOveruserImage(3).getUserLink());

    }
}