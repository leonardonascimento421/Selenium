using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luminus.Selenium.Utils
{
    public class EventHub
    {
        private Dictionary<string, List<Action<object>>> _subscribers = new Dictionary<string, List<Action<object>>>();

        public void Publish(string eventName, object obj)
        {
            if (!_subscribers.ContainsKey(eventName))
                return;

            var callbacks = _subscribers[eventName];

            foreach (Action<object> callback in callbacks)
            {
                callback(obj);
            }
        }

        public void Subscribe(string eventName, Action<object> callback)
        {
            lock (_subscribers)
            {
                List<Action<object>> callbacks;
                if (_subscribers.ContainsKey(eventName))
                    callbacks = _subscribers[eventName];
                else
                {
                    callbacks = new List<Action<object>>();
                    _subscribers.Add(eventName, callbacks);
                }

                callbacks.Add(callback);
            }
        }
    }
}
