using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace MT
{
    public class Login:BaseClass
    {
        #region
        By loginButton = By.XPath("//*[@id='TopControl1_ancSignIn']");
        By Phone = By.CssSelector("#txtMobile");
        By Password=By.CssSelector("#txtPassword");
        By submitButton = By.XPath("//*[@id='btn_Submit']");
        By removeWarning = By.XPath("//*[@id='eTicketWarning']/div/div/div[1]/button");
        #endregion
        
        public void loginTest()
        { 
            maximizeWindow();
            implicitWait(10);
            Thread.Sleep(3000);

            myClick(loginButton);    
            
            myText(Phone, userMobile);
            myText(Password, userPassword);
            Thread.Sleep(10000);

            myClick(submitButton);
            Thread.Sleep(1000);
            
            myClick(removeWarning);
        }

        
    }
}
