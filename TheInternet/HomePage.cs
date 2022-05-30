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
}