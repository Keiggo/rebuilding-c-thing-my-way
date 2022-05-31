using OpenQA.Selenium;

namespace TheInternet;

public class AddRemoveElementsPage : BasePage
{
    private IWebElement addElementButton => driver.FindElement(By.CssSelector("button[onclick='addElement()']"));
    private IList<IWebElement> deleteButtonList => driver.FindElements(By.CssSelector("button[class='added-manually']"));

    public AddRemoveElementsPage(IWebDriver driver) : base(driver)
    {
        this.driver = driver;
    }

    public void clickAddElementButtonANumberOfTimes(int numberOfClicks)
    {
        for (int i = 0; i < numberOfClicks; i++)
            {
                 clickButton(addElementButton);
            }
    }

    public int numberOfDeleteButtons()
    {
        return deleteButtonList.Count();
    }

    public void clickSpecificDeleteButton(int indexOfButton)
    {
        deleteButtonList.ElementAt(indexOfButton).Click();
    }

}