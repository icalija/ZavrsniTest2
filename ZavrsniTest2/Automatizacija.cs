using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;



namespace Test
{
    class ZavrsniTest2
    {
        IWebDriver driver;

        [SetUp]
        public void StartBrowser()
        {
            driver = new FirefoxDriver();

        }

        public void GoToURL(string url)
        {
            this.driver.Url = url;
        }

        public void Sleep(int seconds)
        {
            Thread.Sleep(TimeSpan.FromSeconds(seconds));
        }

        //public IWebElement WaitForElement(By by, int timeoutSeconds)
        //{
        //    if (timeoutSeconds > 0)
        //    {
        //        var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutSeconds));
        //        wait.Until(drv => drv.FindElement(by));
        //    }
        //    return driver.FindElement(by);
        //}


        [Test]
        public void Test()
        {
            GoToURL("https://www.qtptutorial.net/automation-practice/");
            Sleep(5);
            IWebElement clcBtn = driver.FindElement(By.Id("idExample"));
            clcBtn.Click();


            bool isSuccess = driver.FindElement(By.ClassName("main_title")).Displayed;
            string isDisplayed = Convert.ToString(isSuccess);
            System.IO.File.AppendAllText("C:\\Users\\GIMB\\Desktop\\selenium.txt", "Button succes se prikazao - " + isDisplayed + Environment.NewLine);
            Sleep(5);
        }

        [Test]
        public void Test2()
        {
            GoToURL("https://www.qtptutorial.net/automation-practice/");
            Sleep(5);
            IWebElement clcBtn2 = driver.FindElement(By.Name("NameExample"));
            clcBtn2.Click();


            bool isSuccess2 = driver.FindElement(By.ClassName("xh-highlight")).Displayed;
            string isDisplayed = Convert.ToString(isSuccess2);
            System.IO.File.AppendAllText("C:\\Users\\GIMB\\Desktop\\selenium.txt", "Button succes se prikazao - " + isDisplayed + Environment.NewLine);
            Sleep(5);
        }

        [Test]
        public void Test3()
        {
            GoToURL("https://www.qtptutorial.net/automation-practice/");
            Sleep(5);
            IWebElement clcBtn3 = driver.FindElement(By.ClassName("et_pb_newsletter_button"));

            bool isSuccess3 = clcBtn3.Displayed;
            string isDisplayed = Convert.ToString(isSuccess3);
            System.IO.File.AppendAllText("C:\\Users\\GIMB\\Desktop\\selenium.txt", "Email me button se prikazao - " + isDisplayed + Environment.NewLine);
            Sleep(5);
        }

        [Test]
        public void Test4()
        {
            GoToURL("https://www.qtptutorial.net/automation-practice/");
            Sleep(5);
            IWebElement clcBtn4 = driver.FindElement(By.XPath("//input[@value='Name']"));
            clcBtn4.SendKeys("Igor");

            IWebElement clcBtn5 = driver.FindElement(By.XPath("//input[@value='Email Address']"));
            clcBtn4.SendKeys("icalija@live.com");
            Sleep(5);
        }

        [Test]

             public void Test5()
        {
            GoToURL("https://www.qtptutorial.net/automation-practice/");
            Sleep(5);
            IWebElement table = driver.FindElement(By.Id("htmlTableId"));
            IWebElement uniqueId = table.FindElement(By.XPath("//td[contains(.,'$120, 000 + ')]"));

            Sleep(5);
        }

        [Test]
        public void Test6()
        {
            GoToURL("https://www.qtptutorial.net/automation-practice/");
            Sleep(5);
            IWebElement table = driver.FindElement(By.Id("htmlTableId"));
            IList<IWebElement> rows = table.FindElements(By.XPath("//tr[contains(.,'Automation Testing Architect')]"));

            foreach (var red in rows)
            {
                System.IO.File.AppendAllText("C:\\Users\\GIMB\\Desktop\\selenium.txt", red.Text.ToString() + Environment.NewLine);
            }
        }
     



    [TearDown]
        public void CloseBrowser()
        {
            driver.Close();
        }
    }
}
