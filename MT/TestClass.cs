using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT
{
    [TestClass]
    public class UnitTest1
    {

        BaseClass b = new BaseClass("Chrome");
        public string url = "https://www.pakrail.gov.pk/";
        
        

        Login login=new Login();
        CalculateFare ticket = new CalculateFare();
        BookTicket bookTicket = new BookTicket();
        
        
        [TestMethod]
        public void test()
        {

            ticket.URL(url);
            ticket.checkFareViaRoute();
            //ticket.checkFareViaTrain();

            //login.URL(url);
            //login.logintest("923405619771","asharnasir0800");

            //bookTicket.URL(url);
            //bookTicket.bookTicketViaLogin();


        }
    }
}
