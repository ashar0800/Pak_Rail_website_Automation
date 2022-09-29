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
        
        
        CheckFare ticket = new CheckFare();
        
        
        [TestMethod]
        public void test()
        {

            ticket.URL(url);
            ticket.checkFare(3200);
        }
    }
}
