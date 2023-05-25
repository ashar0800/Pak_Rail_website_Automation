using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Edge;

namespace MT
{
    
    public class BaseClass
    {
       
       public static IWebDriver driver;
       public static string userMobile = "92**********";
       public static string userPassword = "*************";
        public BaseClass()
        {

        }
        public BaseClass(string browserName)
        {
            if (browserName == "Chrome")
                driver = new ChromeDriver();
            else if (browserName == "Firefox")
                driver = new FirefoxDriver();
            else if (browserName == "Edge")
                driver = new EdgeDriver();
            else
                driver = null;
        }
        public void URL (string url)
        {
            driver.Url = url;
        }

        public void implicitWait(int i)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(i);
        }

        public IWebElement findElement(By path)
            
        {
            return driver.FindElement(path);
        }
        
        public void myClick(By path)
        {
            findElement(path).Click();
        }

        public void myText(By path,string i)
        {
            findElement(path).SendKeys(i);
        }

        public void maximizeWindow()
        {
            driver.Manage().Window.Maximize();
        }

        
            
         //showTrainStops();
        public void showTrainStops()
        {
            
            driver.FindElement(By.XPath("//*[@id='AllTrains']/div/div/div[1]/div[2]/div[2]/a")).Click();
            Thread.Sleep(100);

            driver.FindElement(By.XPath("//*[@id='modalTitle']")).Click();
            Thread.Sleep(100);

            //for (int i = 0; i < 2000; i += 25)
            //{
            //    ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0," + i + ")");
            //    Thread.Sleep(60);
            //}
        }

        

        //*[@id="planYourJourney"]/div[3]/div/button/span[1]
        //*[@id="planYourJourney"]/div[3]/div/div/ul/li[2]/a/span[1] 11.1
        //*[@id="planYourJourney"]/div[4]/div/button/span[1]
        //*[@id="planYourJourney"]/div[4]/div/div/ul/li[1]/a/span[1] 12.1
        //*[@id="planYourJourney"]/div[5]/div/button/span[1]
        //*[@id="planYourJourney"]/div[5]/div/div/ul/li[1]/a/span[1] 13.1

        //*[@id="LeftPanel1_LeftPanelInternal1_btnGetFare"] #Check fare
    }

    
}
