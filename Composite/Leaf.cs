using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Leaf :IComponent
    {
        String part;
        public Leaf(String part) 
        {
            this.part = part;
        }

        public void getPart()
        {
            Console.WriteLine(part);
        }
    }
}
