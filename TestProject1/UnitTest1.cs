using NUnit;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;



namespace TestProject1
{
    
    
    public class Tests
    {
#pragma warning disable NUnit1032 // An IDisposable field/property should be Disposed in a TearDown method
        IWebDriver driver;
#pragma warning restore NUnit1032 // An IDisposable field/property should be Disposed in a TearDown method

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            //driver = new EdgeDriver();
            driver.Manage().Window.Maximize();
            Thread.Sleep(5000);
        }

        [Test]
        public void LaunchBrowser()
        {
            driver.Navigate().GoToUrl("https://www.admlucid.com/");
            Assert.That(driver.Url, Is.EqualTo("https://www.admlucid.com/"));
            //Assert.That(driver.Title, Is.EqualTo("Home Page - Admlucid"));
            //Assert.Pass();
        }

        [Test]

        public void Button()
        {
            driver.Navigate().GoToUrl("https://www.admlucid.com/Home/WebElements");
            Thread.Sleep(1000);
            driver.FindElement(By.Id("Button1")).Click();
            Thread.Sleep(1000);
            driver.SwitchTo().Alert().Accept();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("Button4")).Click();
            Thread.Sleep(1000);
            driver.SwitchTo().Alert().Accept();
            Thread.Sleep(2000);

        }

        [Test]
        public void Choose_File()
        {
            driver.Navigate().GoToUrl("https://www.admlucid.com/Home/WebElements");
            //driver.FindElement(By.Id("File1")).SendKeys("C:\\Users\\nl3019\\OneDrive - Sandvik\\Pictures\\Screenshots\\Screenshot (60).png");
            //Thread.Sleep(2000);
            driver.FindElement(By.CssSelector("#File4")).SendKeys(@"C:\Users\nl3019\OneDrive - Sandvik\Pictures\Screenshots\Screenshot (59).png");
            Thread.Sleep(2000);
        }

        [Test]
        public void Text()
        {
            driver.Navigate().GoToUrl("https://www.admlucid.com/Home/WebElements");
            driver.FindElement(By.Id("Text1")).SendKeys("Welcome");
            driver.FindElement(By.ClassName("Text3")).SendKeys("Welcome to automation");

        }

        [Test]
        public void password()
        {
            driver.Navigate().GoToUrl("https://www.admlucid.com/Home/WebElements");
            driver.FindElement(By.Name("Password2")).SendKeys("#$FGT%^&mj5@!");

        }

        [Test]
        public void Text_Area()
        {
            driver.Navigate().GoToUrl("https://www.admlucid.com/Home/WebElements");
            driver.FindElement(By.CssSelector("#TextArea4")).SendKeys("Hi, Hello");
        }

        [Test]
        public void CheckBox()
        {
            driver.Navigate().GoToUrl("https://www.admlucid.com/Home/WebElements");
            Thread.Sleep(1000);
            driver.FindElement(By.Name("Checkbox2")).Click();
        }

        [Test]
        public void RadioButton()
        {
            driver.Navigate().GoToUrl("https://www.admlucid.com/Home/WebElements");
            Thread.Sleep(1000);
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(100, 0)");
            Thread.Sleep(1000);
            driver.FindElement(By.CssSelector("#Radio4")).Click();

        }
        [Test]
        public void ChildCareRegistration()
        {
            driver.Navigate().GoToUrl("https://www.admlucid.com/Home/WebElements");
            Thread.Sleep(1000);
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, 500)");
            Thread.Sleep(2000);
            driver.FindElement(By.Name("Name")).SendKeys("pitter");
            Thread.Sleep(1000);
            driver.FindElement(By.Name("EMail")).SendKeys("roy.17@roy.com");
            Thread.Sleep(1000);
            driver.FindElement(By.Name("Telephone")).SendKeys("009876575");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("/html/body/div/main/form/p[4]/input[1]")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("/html/body/div/main/form/p[5]/select")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("/html/body/div/main/form/p[5]/select/option[13]")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("/html/body/div/main/form/p[6]/select")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("/html/body/div/main/form/p[6]/select/option[4]")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.Name("Submit")).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().Alert().Accept();

        }

        [Test]
        public void SeleniumWaitForWebElement()
        {
            driver.Navigate().GoToUrl("https://www.admlucid.com/Home/WebElements");
            driver.FindElement(By.Id("Wait30")).Click();
        }

        [Test]
        public void SwitchWindow()
        {
            string originalWindow = driver.CurrentWindowHandle;
            driver.Navigate().GoToUrl("https://www.alberta.ca/child-care-subsidy#jumplinks-4");
            driver.FindElement(By.LinkText("Child Care Subsidy Application")).Click();

            foreach(string window in driver.WindowHandles)
            {
                if (originalWindow != window)
                {
                    driver.SwitchTo().Window(window);
                    break;
                }
            }

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            //Assert.That(wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"container\"]/header/div[1]/div/div[1]/a/svg/path")));





        }

        [Test]
        public void DragandDrop()
        {
            driver.Navigate().GoToUrl("https://www.globalsqa.com/demo-site/draganddrop/#Accepted%20Elements");
            Thread.Sleep(3000);
            driver.FindElement(By.Id("Accepted Elements")).Click();
            Thread.Sleep(2000);
            var element1 = driver.FindElement(By.CssSelector("#draggable-nonvalid > p"));
            Thread.Sleep(2000);
            var element2 = driver.FindElement(By.CssSelector("#droppable"));
            Thread.Sleep(2000);
            Actions actions = new Actions(driver);
            IAction dragAnddrop1 = actions.ClickAndHold(element1).MoveToElement(element2).Release(element2).Build();
            dragAnddrop1.Perform();
            Thread.Sleep(2000);
            //actions.DragAndDrop(from, to).Build().Perform();

        }


        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}