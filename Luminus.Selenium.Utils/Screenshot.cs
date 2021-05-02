using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luminus.Selenium.Utils
{
    public static class Screenshot
    {
        public static Action<bool> _takeScreenshotDelegate;

        public static void Configure(Action<bool> takeScreenshotDelegate)
        {
            _takeScreenshotDelegate = takeScreenshotDelegate;
        }

        public static void TakeScreenshot(bool traceScreenshot = true)
        {
            _takeScreenshotDelegate?.Invoke(traceScreenshot);
        }
    }
}
