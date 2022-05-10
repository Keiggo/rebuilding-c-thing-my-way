using System.IO;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TheInternet.Tests;

public class BaseTests
{
    protected IWebDriver driver;

    [SetUp]
    public void Setup()
    {
        driver = new ChromeDriver(Path.GetFullPath(@"../../../../" + "_drivers"));
        driver.Url = "https://the-internet.herokuapp.com/";
        driver.Manage().Window.Maximize();
    }

    [TearDown]
    public void TearDown()
    {
        driver.Quit();
    }

}