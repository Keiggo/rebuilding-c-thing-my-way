using NUnit.Framework;

namespace TheInternet.Tests;

public class AddRemoveElementsTests : BaseTests
{
    [Test]

    public void adding_and_removing_thingies()
    {
        var homePage = new HomePage(driver);
        var addRemoveElementsPage = new AddRemoveElementsPage(driver);

        homePage.clickAddRemoveElements();
        Assert.That(addRemoveElementsPage.numberOfDeleteButtons() == 0);

        addRemoveElementsPage.clickAddElementButtonANumberOfTimes(5);
        Assert.That(addRemoveElementsPage.numberOfDeleteButtons() == 5);

        addRemoveElementsPage.clickSpecificDeleteButton(0);
        addRemoveElementsPage.clickSpecificDeleteButton(3);
        Assert.That(addRemoveElementsPage.numberOfDeleteButtons() == 3);
    }
}