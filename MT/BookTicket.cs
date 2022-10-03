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
using OpenQA.Selenium.Support.UI;

namespace MT
{
    public class BookTicket:BaseClass
    {

        #region
        By selectjourney = By.XPath("//*[@id='LeftPanel1_LeftPanelInternal1_ddlTripType']");

        By fromstation = By.XPath("//*[@id='LeftPanel1_LeftPanelInternal1_ddFromStation']");
        
        By tostation = By.XPath("//*[@id='LeftPanel1_LeftPanelInternal1_ddToStation']");

        By submitButton = By.XPath("//*[@id='LeftPanel1_LeftPanelInternal1_btnPlanJourney']");
        
        By checkSeats = By.XPath("//*[@id='rptTrains_btnCheckSeats_0']");
        By departureDate = By.XPath("//*[@id='txtDepartureDate']");
        By selectDate = By.XPath("/html/body/div/div[1]/table/tbody/tr[6]/td[6]");

        By searchTrains = By.XPath("//*[@id='btnSearch']");
        By searchSeats = By.XPath("//*[@id='ACL49_seats']/span");

        #endregion
        public void bookTicketViaLogin()
        {

            implicitWait(10);
            Thread.Sleep(3000);
            
            
            Login log=new Login();
            
            log.loginTest();
            implicitWait(10);

            new SelectElement(findElement(selectjourney)).SelectByIndex(1);
            implicitWait(10);
            Thread.Sleep(1000);

            new SelectElement(findElement(fromstation)).SelectByIndex(137);
            implicitWait(10);
            Thread.Sleep(1000);

            new SelectElement(findElement(tostation)).SelectByIndex(18);
            implicitWait(10);
            Thread.Sleep(1000);

            myClick(submitButton);
            implicitWait(10);
            Thread.Sleep(1000);

            myClick(checkSeats);
            implicitWait(10);
            Thread.Sleep(1000);

            myClick(departureDate);
            implicitWait(10);
            Thread.Sleep(1000);

            myClick(selectDate);
            implicitWait(10);
            Thread.Sleep(1000);
            
            myClick(searchTrains);
            implicitWait(10);
            Thread.Sleep(1000);
            
            myClick(searchSeats);
            implicitWait(10);
            Thread.Sleep(1000);
        }
    }
}

