using OpenQA.Selenium;

namespace TheInternet;

public class SecureAreaPage : BasePage
{
    private IWebElement banner => driver.FindElement(By.CssSelector("div[id=flash-messages]"));

    public SecureAreaPage(IWebDriver driver) : base(driver)
    {
        this.driver = driver;
    }

    public List<string> getBannerDetails()
    {
        String bannerText = banner.Text.ToString();
        String bannerType = banner.GetCssValue("div[class]").ToString();

        var bannerDetails = new List<string>{bannerText, bannerType};

        return bannerDetails;

    }
}