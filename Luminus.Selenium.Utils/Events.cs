using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luminus.Selenium.Utils
{
    public static class Events
    {
        public static readonly string Highlighted = "Highlighted";
        public static readonly string Unhighlighted = "Unhighlighted";
        public static readonly string BeforeClick = "BeforeClick";
        public static readonly string AfterClick = "AfterClick";
        public static readonly string Navigated = "Navigated";
        public static readonly string BeginAfterStep = "BeginAfterStep";
        public static readonly string BeginAfterSpec = "BeginAfterSpec";
    }
}
