using System;

namespace Luminus.Selenium.Utils
{
    public static class EventHubHelper
    {
        private static Func<EventHub> _factoryHub;

        public static void Configure(Func<EventHub> factoryHub)
        {
            _factoryHub = factoryHub;
        }

        public static void Publish(string eventName, object obj)
        {
            _factoryHub?.Invoke().Publish(eventName, obj);
        }

        public static void Subscribe(string eventName, Action<object> callback)
        {
            _factoryHub?.Invoke().Subscribe(eventName, callback);
        }
    }
}
