using System;
using OpenQA.Selenium;

namespace TheInternet;

public class HomePage : BasePage
{
    public HomePage(IWebDriver driver): base(driver)
    {
        this.driver = driver;
    }

    private IWebElement formAuthentication => driver.FindElement(By.CssSelector("a[href='/login']"));

    public void clickFormAuthentication()
    {
        clickLink(formAuthentication);
    }
}