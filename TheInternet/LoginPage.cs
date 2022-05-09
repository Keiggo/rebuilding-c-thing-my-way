using OpenQA.Selenium;

namespace TheInternet;

public class LoginPage : BasePage
{
    IWebElement usernameTextBox => driver.FindElement(By.CssSelector("input[id=username]"));
    IWebElement passwordTextBox => driver.FindElement(By.CssSelector("input[id='password']"));
    IWebElement loginButton => driver.FindElement(By.CssSelector("button[type='submit']"));
    
    public LoginPage(IWebDriver driver): base(driver)
    {
        this.driver = driver;
    }

    public void enterUsername(String username)
    {
        enterText(usernameTextBox, username);
    }

    public void enterPassword(String password)
    {
        enterText(usernameTextBox, password);
    }

    public void clickLoginButton()
    {
        loginButton.Click();
    }
}