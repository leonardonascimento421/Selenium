using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luminus.Selenium.Utils
{
    public class EventHandlers
    {      
        public void Configure(EventHub hub, IEnumerable<IEventHandler> eventHandlers)
        {          
            foreach (var handler in eventHandlers)
            {
                handler.Configure(hub);
            }
        }
    }
}
