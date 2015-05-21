using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Spoon_RnD_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            FirefoxProfile profile = new FirefoxProfile();
            Proxy proxy = new Proxy();
            proxy.IsAutoDetect = true;
            profile.SetProxyPreferences(proxy);

            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://www.google.com";

        }
    }
}
