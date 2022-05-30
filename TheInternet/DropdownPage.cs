using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TheInternet;

public class DropDownPage : BasePage
{
    private SelectElement dropdown => new SelectElement(driver.FindElement(By.Id("dropdown")));
    private By currentlySelectedOptionBy = By.CssSelector("option [selected='selected']");

    public DropDownPage(IWebDriver driver): base(driver)
    {
        this.driver = driver;
    }

    public void selectDropdownOptionById(int optionId)
    {
        dropdown.SelectByIndex(optionId);
    }

    public String currentlySelectedOption()
    {
        return dropdown.SelectedOption.Text;
    }
    
}