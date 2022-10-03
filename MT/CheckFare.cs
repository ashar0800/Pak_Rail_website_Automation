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
        By selectjourney = By.XPath("//*[@id='LeftPanel1_LeftPanelInternal1_ddlTripType']");

        By fromstation = By.XPath("//*[@id='LeftPanel1_LeftPanelInternal1_ddFromStation']");

        By tostation = By.XPath("//*[@id='LeftPanel1_LeftPanelInternal1_ddToStation']");


        By selecttrain = By.XPath("//*[@id='LeftPanel1_LeftPanelInternal1_ddFareTrains']");

        By fromstationdropdown = By.XPath("//*[@id='LeftPanel1_LeftPanelInternal1_ddFareFromStation']");

        By tostationdropdown = By.XPath("//*[@id='LeftPanel1_LeftPanelInternal1_ddFareToStation']");

        By submitButton = By.XPath("//*[@id='LeftPanel1_LeftPanelInternal1_btnPlanJourney']");
        By checkFareButton = By.XPath("//*[@id='rptTrains_btnCheckFare_0']");

        By checkFareValidity = By.XPath("//*[@id='form1']/div[3]/div[5]/div/div[2]/div[3]/div/table/tbody/tr[2]/td[2]");  

        By getfareButton = By.XPath("//*[@id='LeftPanel1_LeftPanelInternal1_btnGetFare']");
        By checkSeatFareValidity = By.XPath("//*[@id='form1']/div[3]/div[5]/div/div[2]/div[3]/div/table/tbody/tr[2]/td[3]");

        #endregion

        public void checkFareViaRoute()
        {
            
            maximizeWindow();
            implicitWait(10);

            new SelectElement(findElement(selectjourney)).SelectByIndex(1);

            Thread.Sleep(1000);

            new SelectElement(findElement(fromstation)).SelectByIndex(137);

            Thread.Sleep(1000);

            new SelectElement(findElement(tostation)).SelectByIndex(18);

            Thread.Sleep(1000);

            myClick(submitButton);
            Thread.Sleep(1000);

            myClick(checkFareButton);
            Thread.Sleep(1000);

            
            //Assert.AreEqual(findElement(checkFareValidity).Text, fare.ToString());
        }

        public void checkFareViaTrain()
        {

            maximizeWindow();
            implicitWait(10);


            new SelectElement(findElement(selecttrain)).SelectByIndex(1);

            Thread.Sleep(1000);

            new SelectElement(findElement(fromstationdropdown)).SelectByIndex(1);

            Thread.Sleep(1000);

            new SelectElement(findElement(tostationdropdown)).SelectByIndex(1);

            Thread.Sleep(1000);

            //int fare=1950;
            //Assert.AreEqual(findElement(checkSeatFareValidity).Text, fare.ToString());
        }
    }
}
