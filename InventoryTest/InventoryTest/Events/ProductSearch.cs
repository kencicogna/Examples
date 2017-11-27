using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryTest.Events
{
    public class ProductSearch : IApplicationEvent
    {
        public String SearchString { get; set; }
    }
}
