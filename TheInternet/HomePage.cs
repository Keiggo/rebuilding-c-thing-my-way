using System;
using OpenQA.Selenium;

namespace TheInternet;

public class HomePage : BasePage
{
    public HomePage(IWebDriver driver): base(driver)
    {
        this.driver = driver;
    }

    private IWebElement formAuthenticationLink => driver.FindElement(By.CssSelector("a[href='/login']"));
    private IWebElement hoversLink => driver.FindElement(By.CssSelector("a[href='/hovers']"));
    private IWebElement dropdownLink => driver.FindElement(By.CssSelector("a[href='/dropdown']"));
    private IWebElement addRemoveElementsLink => driver.FindElement(By.CssSelector("a[href='/add_remove_elements/'"));

    public void clickFormAuthentication()
    {
        clickLink(formAuthenticationLink);
    }

    public void clickHovers()
    {
        clickLink(hoversLink);
    }

    public void  clickDropdown()
    {
        clickLink(dropdownLink);
    }

    public void clickAddRemoveElements()
    {
        clickLink(addRemoveElementsLink);
    }
}