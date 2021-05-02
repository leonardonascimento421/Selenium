using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luminus.Selenium.Utils
{
    public interface IEventHandler
    {
        void Configure(EventHub hub);
    }
}
