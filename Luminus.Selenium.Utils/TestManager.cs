using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luminus.Selenium.Utils
{
    public class TestManager
    {
        private List<IWebElement> _highlightedElements = new List<IWebElement>();
        private bool stepScreenshotTaked;

        public TestManager()
        {
            EventHubHelper.Subscribe(Events.BeginAfterStep, BeginAfterStep);
            EventHubHelper.Subscribe(Events.Highlighted, (x) => OnElementHighlighted((IWebElement)x));
            EventHubHelper.Subscribe(Events.BeforeClick, BeforeClick);
            EventHubHelper.Subscribe(Events.Navigated, Navigated);
        }

        private void Navigated(object element)
        {
            _highlightedElements.Clear();
        }

        private void BeforeClick(object element)
        {
            Screenshot.TakeScreenshot();
            stepScreenshotTaked = true;

            // Limpando os elementos antes de clicar porque pode vir um não ser possível depois
            ClearHighlightedElements();
        }

        private void BeginAfterStep(object context)
        {
            if (!stepScreenshotTaked)
                Screenshot.TakeScreenshot();

            ClearHighlightedElements();

            // preparing for next step
            stepScreenshotTaked = false;
        }

        private void OnElementHighlighted(IWebElement element)
        {
            _highlightedElements.Add(element);
        }

        private void ClearHighlightedElements()
        {
            foreach (var element in _highlightedElements)
            {
                element.ClearHighlight();
            }

            _highlightedElements.Clear();
        }
    }
}
