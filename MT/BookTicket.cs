using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace MT
{
    public class BookTicket
    {
        public void bookTicketViaLogin()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://pakrail.gov.pk/";
            
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id='TopControl1_ancSignIn']")).Click();
            driver.FindElement(By.CssSelector("#txtMobile")).SendKeys("923405619771");
            driver.FindElement(By.CssSelector("#txtPassword")).SendKeys("asharnasir0800");

            Thread.Sleep(10000);
            driver.FindElement(By.XPath("//*[@id='btn_Submit']")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id='eTicketWarning']/div/div/div[1]/button")).Click();

            driver.FindElement(By.CssSelector("#planYourJourney > div.col-md-12.col-lg-12 > div:nth-child(3) > div > button > span.filter-option.pull-left")).Click();
            driver.FindElement(By.XPath("//*[@id='planYourJourney']/div[1]/div[1]/div/div/ul/li[2]/a")).Click();

            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id='planYourJourney']/div[1]/div[2]/div/button/span[1]")).Click();
            driver.FindElement(By.XPath("//*[@id='planYourJourney']/div[1]/div[2]/div/div/ul/li[19]/a/span[1]")).Click();
            Thread.Sleep(1000);

            driver.FindElement(By.XPath("//*[@id='planYourJourney']/div[1]/div[3]/div/button/span[1]")).Click();
            driver.FindElement(By.XPath("//*[@id='planYourJourney']/div[1]/div[3]/div/div/ul/li[138]/a/span[1]")).Click();
            Thread.Sleep(1000);

            driver.FindElement(By.XPath("//*[@id='LeftPanel1_LeftPanelInternal1_btnPlanJourney']")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id='rptTrains_btnCheckSeats_0']")).Click();
            Thread.Sleep(1000);

            driver.FindElement(By.XPath("//*[@id='txtDepartureDate']")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("/html/body/div/div[1]/table/tbody/tr[5]/td[6]")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id='btnSearch']")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id='ACL48_seats']/span")).Click();
            Thread.Sleep(1000);
        }
    }
}

