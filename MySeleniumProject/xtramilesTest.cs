using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public class BaseTest : IDisposable
{
    protected IWebDriver driver;

    public BaseTest()
    {
        driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://computer-database.gatling.io/computers");
    }

    public void Dispose()
    {
        driver.Close();
        driver.Quit();
    }
}

[CollectionDefinition("BaseTest")]
public class BaseTestCollection : ICollectionFixture<BaseTest>
{
    public BaseTestCollection(BaseTest baseTest)
    {
    }
}

[Collection("BaseTest")]
public class xtramilesTest : BaseTest
{
    [Fact]
    public void AccessMainPage()
    {
        Assert.Equal("Computers database", driver.Title);
    }

    [Fact]
    public void AddNewComputer()
    {
        driver.FindElement(By.Id("add")).Click();
        Assert.Contains("Add a computer", driver.PageSource);
        driver.FindElement(By.Id("name")).SendKeys("Test Computer");
        driver.FindElement(By.Id("introduced")).SendKeys("2022-01-01");
        driver.FindElement(By.Id("discontinued")).SendKeys("2022-12-31");
        driver.FindElement(By.Id("company")).SendKeys("Sanyo");
        driver.FindElement(By.XPath("//input[@value='Create this computer']")).Click();
        Assert.Contains("Computer Test Computer has been created", driver.PageSource);
    }
}