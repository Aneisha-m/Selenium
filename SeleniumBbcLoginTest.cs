using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace Eng24Selenium
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestFixture]
    public class SeleniumBbcLoginTest
    {
        [Test]
        public void SeleniumWalkthrough()
        {
            using( IWebDriver driver = new ChromeDriver())
            {
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("http://bbc.co.uk");
                IWebElement loginButton = driver.FindElement(By.Id("idcta-link"));
                loginButton.Click();
                IWebElement usernameField = driver.FindElement(By.Id("user-identifier-input"));
                usernameField.SendKeys("testing@gurney.com");
                IWebElement passwordField = driver.FindElement(By.Id("password-input"));
                passwordField.SendKeys("12345678");
                IWebElement submmitButton = driver.FindElement(By.Id("submit-button"));
                submmitButton.Click();
                IWebElement passwordError = driver.FindElement(By.Id("form-message-password"));
                Assert.AreEqual("Sorry, that password isn't valid. Please include a letter.", passwordError.Text);
            }
        }
    }
}
