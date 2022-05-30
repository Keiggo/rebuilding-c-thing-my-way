using NUnit.Framework;

namespace TheInternet.Tests;

public class DropDownTests : BaseTests
{
    [Test]
    public void pointless_fucking_dropdown_rubbish()
    {
        var homePage = new HomePage(driver);
        var dropDownPage = new DropDownPage(driver);

        homePage.clickDropdown();
        Assert.AreEqual("Please select an option", dropDownPage.currentlySelectedOption());
        
        dropDownPage.selectDropdownOptionById(1);
        Assert.AreEqual("Option 1",dropDownPage.currentlySelectedOption());

        dropDownPage.selectDropdownOptionById(2);
        Assert.AreEqual("Option 2",dropDownPage.currentlySelectedOption());
    }
}