using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace ATUnivBugFinalExam
{
    [TestFixture]
    public class TestClass
    {

    }

    public class Tests
    {
        [Test]
        [Category("Smoke Test")]
        public void LoginSuccessful()
        {
            ChromeDriver driver;
            driver = new ChromeDriver(@"\\drivers\\chromedriver.exe");
            driver.Navigate().GoToUrl("https://candidatex:qa-is-cool@qa-task.backbasecloud.com/");
            var title = driver.Title;
            Console.WriteLine(title);
            Assert.IsTrue(title.Contains("Conduit"));
            driver.Quit();
        }

        [Test]
        [Category("Smoke Test")]
        public void SignUp()
        {
            ChromeDriver driver;
            driver = new ChromeDriver(@"C:\Users\Jeannine.Kwasnik\source\repos\ATUnivBegFinalExam\ATUnivBegFinalExam\Drivers");
            driver.Navigate().GoToUrl("https://candidatex:qa-is-cool@qa-task.backbasecloud.com/");
            var username = "Jeannine" + DateTime.Now.ToString("yyyyMMddHHssff");
            var email = username +"@jk.com";
            var password = "whatever";
            driver.FindElement(By.CssSelector("body > app-root > app-layout-header > nav > div > ul > li:nth-child(3) > a")).Click();
            driver.FindElement(By.CssSelector("body > app-root > app-auth-page > div > div > div > div > form > fieldset > fieldset:nth-child(1) > input")).SendKeys(username);
            driver.FindElement(By.XPath("/html/body/app-root/app-auth-page/div/div/div/div/form/fieldset/fieldset[2]/input")).SendKeys(email);
            driver.FindElement(By.XPath("//input[@formcontrolname='password']")).SendKeys(password);
            driver.FindElement(By.XPath("//button")).Click();

            Assert.IsTrue(driver.FindElement(By.CssSelector("body > app-root > app-layout-header > nav > div > ul > li:nth-child(1) > a")).Displayed);
            driver.Quit();
        }

        [Test]
        [Category("Smoke Test")]
        public void Login()
        {
            ChromeDriver driver;
            driver = new ChromeDriver(@"Drivers");
            driver.Navigate().GoToUrl("https://candidatex:qa-is-cool@qa-task.backbasecloud.com/");
            var username = "Jeannine" + DateTime.Now.ToString("yyyyMMddHHssff");
            var email = username + "@jk.com";
            var password = "whatever";
            driver.FindElement(By.CssSelector("body > app-root > app-layout-header > nav > div > ul > li:nth-child(2) > a")).Click();
            driver.FindElement(By.XPath("//input[@formcontrolname='email']")).SendKeys("jeannine20211015224889@jk.com");
            driver.FindElement(By.XPath("//input[@formcontrolname='password']")).SendKeys(password);
            driver.FindElement(By.CssSelector("body > app-root > app-auth-page > div > div > div > div > form > fieldset > button")).Click();
            
            Assert.IsTrue(driver.FindElement(By.CssSelector("body > app-root > app-layout-header > nav > div > ul > li:nth-child(1) > a")).Displayed);
            driver.Quit();

            //Got stuck ^^^ here finding elements on this page and performing click operation.

        }
    }
    [TestFixture]
    public class AssemblySetup
    {

    }
}