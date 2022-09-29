using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Edge;

namespace MT
{
    public class CheckFare:BaseClass
    {
        #region
        By showdropdown1 = By.CssSelector("#planYourJourney > div.col-md-12.col-lg-12 > div:nth-child(3) > div > button > span.filter-option.pull-left");
        By clickdropdown1 = By.XPath("//*[@id='planYourJourney']/div[1]/div[1]/div/div/ul/li[2]/a");

        By showdropdown2 = By.XPath("//*[@id='planYourJourney']/div[1]/div[2]/div/button/span[1]");
        By clickdropdown2 = By.XPath("//*[@id='planYourJourney']/div[1]/div[2]/div/div/ul/li[19]/a/span[1]");

        By showdropdown3 = By.XPath("//*[@id='planYourJourney']/div[1]/div[3]/div/button/span[1]");
        By clickdropdown3 = By.XPath("//*[@id='planYourJourney']/div[1]/div[3]/div/div/ul/li[138]/a/span[1]");

        By submitButton = By.XPath("//*[@id='LeftPanel1_LeftPanelInternal1_btnPlanJourney']");
        By checkFareButton = By.XPath("//*[@id='rptTrains_btnCheckFare_0']");

        By checkFareValidity = By.XPath("//*[@id='form1']/div[3]/div[5]/div/div[2]/div[3]/div/table/tbody/tr[2]/td[2]");
        #endregion
        public void checkFare(int fare)
        {
            
            maximizeWindow();
            implicitWait(10);


            myClick(showdropdown1);
            myClick(clickdropdown1);

            Thread.Sleep(1000);

            myClick(showdropdown2);
            myClick(clickdropdown2);
            
            Thread.Sleep(1000);

            myClick(showdropdown3);
            myClick(clickdropdown3);
                Thread.Sleep(1000);

            myClick(submitButton);
            Thread.Sleep(1000);

            myClick(checkFareButton);
            Thread.Sleep(1000);

            
            Assert.AreEqual(findElement(checkFareValidity).Text, fare.ToString());
        }
    }
}
