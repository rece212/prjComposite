using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Composite :IComponent
    {
        String name;
        public Composite(String name)
        {
            this.name = name;
        }
        List<IComponent> components = new List<IComponent>();

        public void addComponent(IComponent component)
        {
            components.Add(component);
        }
        public void removeComponent(IComponent component)
        {
            components.Remove(component);
        }
        public void getPart()
        {
            Console.WriteLine(name);
            foreach(IComponent iCom in components) 
            {
                iCom.getPart();
            }
        }
    }
}
