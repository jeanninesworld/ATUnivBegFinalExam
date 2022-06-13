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
        ChromeDriver driver;
        string startupPath = System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).
        Parent.Parent.FullName + @"\..\Framework\ExternalDrivers\";


        [Test]
        [TestCase(TestName = "1NavigateToHomepageTest")]
        [Category("Smoke Test")]
        public void HomePage()
        {
            driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://candidatex:qa-is-cool@qa-task.backbasecloud.com/");
            var title = driver.Title;
            Console.WriteLine(title);
            Assert.IsTrue(title.Contains("Conduit"));
            driver.Quit();
        }

        [Test]
        [TestCase(TestName = "2SignUpTest")]
        [Category("Smoke Test")]
        public void SignUp()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://candidatex:qa-is-cool@qa-task.backbasecloud.com");
            var username = "Jeannine" + DateTime.Now.ToString("yyyyMMddHHssff");
            var email = username +"@jk.com";
            var password = "whatever";
            driver.FindElement(By.XPath("//html/body//ul/li[3]/a")).Click();
            driver.FindElement(By.XPath("//*[@formcontrolname='username']")).SendKeys(username);
            driver.FindElement(By.XPath("//*[@formcontrolname='email']")).SendKeys(email);
            driver.FindElement(By.XPath("//input[@formcontrolname='password']")).SendKeys(password);
            driver.FindElement(By.XPath("//button")).Click();

            Assert.IsTrue(driver.FindElement(By.XPath("/html//nav/div/ul/li[1]/a")).Text=="Home");
            driver.Quit();
        }

        [Test]
        [TestCase(TestName = "3LoginTest")]
        [Category("Smoke Test")]
        public void Login()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://candidatex:qa-is-cool@qa-task.backbasecloud.com");
           
            var email = "j@j2.com";
            var password = "password";
            
            driver.FindElement(By.XPath("//html//nav/div/ul/li[2]/a")).Click();
            driver.FindElement(By.XPath("//input[@formcontrolname='email']")).SendKeys(email);
            driver.FindElement(By.XPath("//input[@formcontrolname='password']")).SendKeys(password);
            driver.FindElement(By.ClassName("nav-item")).Click();
            driver.FindElement(By.XPath("//div[1]/div/ul/li[2]/a")).Click();

            Assert.IsTrue(driver.FindElement(By.XPath("//h1")).Text.Contains("conduit"));


            //Assert.IsTrue(driver.FindElement(By.CssSelector("body > app-root > app-layout-header > nav > div > ul > li:nth-child(1) > a")).Displayed);
            driver.Quit();

            //Got stuck ^^^ here finding elements on this page and performing click operation.

        }
    }
    [TestFixture]
    public class AssemblySetup
    {

    }
}