using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace TheInternet;

public class HoversPage : BasePage
{
    IList<IWebElement> userImagesList => driver.FindElements(By.CssSelector("div [class = 'figure']"));
   
    public HoversPage(IWebDriver driver) : base(driver)
    {
        this.driver = driver;
    }

    public UserCaption hoverOveruserImage(int userNumber)
    {
        userNumber = userNumber - 1;
        Actions actions = new Actions(driver);
        IWebElement user = userImagesList.ElementAt(userNumber);

        actions.MoveToElement(user).Perform();
        return new UserCaption(user.FindElement(By.ClassName("figcaption")));
    }

    public class UserCaption
    {
        private By username = By.TagName("h5");
        private By userLink = By.TagName("a");
        private IWebElement caption;

        public UserCaption(IWebElement caption)
        {
            this.caption = caption;
        }

        public Boolean isCaptionDisplayed()
        {
            return caption.Displayed;
        }

        public String getUsername()
        {
            return caption.FindElement(username).GetAttribute("outerText");
        }

        public String getUserLink()
        {
            return caption.FindElement(userLink).GetAttribute("href");
        }
    }
}