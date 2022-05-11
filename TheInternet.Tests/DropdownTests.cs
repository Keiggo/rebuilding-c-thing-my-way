using NUnit.Framework;

namespace TheInternet.Tests;

public class DropdownTests : BaseTests
{
    private HomePage homePage;
    private DropdownPage dropdownPage;

    [Test]
    public void pointless_dropdown_test()
    {
        var homePage = new HomePage(driver);
        var dropdownPage = new DropdownPage(driver);

        homePage.clickDropdown();
        dropdownPage.setExampleDropdownOptionByValue("2");

        //assert that dropdown inner text matches Option 1 or whatever
        Assert.AreEqual("Option 2", dropdownPage.getExampleDropdownSelectedOptionText());
    }
}