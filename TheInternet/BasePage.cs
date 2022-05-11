using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace TheInternet;

public class BasePage
{
    // protected IWebDriver driver = new ChromeDriver();
    protected IWebDriver driver;

    public BasePage(IWebDriver driver)
    {
        this.driver = driver;
    }

    protected void clickLink(IWebElement link)
    {
        link.Click();
    }

    protected void enterText(IWebElement textBox, String text)
    {
        textBox.SendKeys(text);
    }
    
    protected SelectElement findDropdown(IWebElement dropdownElement)
    {
        return new SelectElement(dropdownElement);
    }

    protected void setDropdownOptionByValue(IWebElement dropdown, String optionValue)
    {
        // findDropdown(dropdown).SelectByIndex(optionIndex);
        findDropdown(dropdown).SelectByValue(optionValue);
    }

    protected String returnDropdownSelectedOptionText(IWebElement dropdownElement)
    {
        String selectedOptionText = dropdownElement.FindElement(By.CssSelector("option[selected]")).Text;
        return selectedOptionText;
    }
}