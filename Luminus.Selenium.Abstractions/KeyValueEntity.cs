using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luminus.Selenium.Abstractions
{
    public class KeyValueEntity : IEntity
    {
        public string Id { get; set; }
        public object Value { get; set; }
    }
}
