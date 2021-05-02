using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Utils;
using OpenQA.Selenium;

namespace Luminus.Selenium.Implementation
{
    public class ScreenGrabber : ICustomScreenshotGrabber
    {       
        public byte[] TakeScreenShot()
        {
            var takesScreenshot = DriverFactory.Driver as ITakesScreenshot;
            var screenshot = takesScreenshot?.GetScreenshot();

            ScreenshotHelper.SaveFile(screenshot);            
          
            return screenshot?.AsByteArray ?? Enumerable.Empty<byte>().ToArray();
        }
    }
}
