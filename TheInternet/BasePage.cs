using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TheInternet;

public class BasePage
{
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

    protected void clickButton(IWebElement button)
    {
        button.Click();
    }
}