using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Calculator.test
{
    public class LoginPageTests
    {

        [Test]
        public void All_Unvalid_Data_Test()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://localhost:64177/Login";
            driver.FindElement(By.Id("login")).SendKeys("Test");
            driver.FindElement(By.Id("password")).SendKeys("NewYork1");
            driver.FindElements(By.Id("login"))[1].Click();

            string actualError = driver.FindElement(By.Id("errorMessage")).Text;

            Assert.AreEqual("'Test' user doesn't exist!", actualError);
            driver.Quit();
        }
    }
}