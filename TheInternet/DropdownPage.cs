using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TheInternet;

public class DropdownPage : BasePage
{
    private IWebElement exampleDropdown => driver.FindElement(By.CssSelector("select[id='dropdown']"));

    public DropdownPage(IWebDriver driver) : base(driver)
    {
        this.driver = driver;
    }

    public void setExampleDropdownOptionByValue(String optionValue)
    {
        setDropdownOptionByValue(exampleDropdown, optionValue);
    }

    public String getExampleDropdownSelectedOptionText()
    {
        return returnDropdownSelectedOptionText(exampleDropdown);
    }
}