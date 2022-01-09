using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    
    public abstract class Shape
    {
        public abstract double GetArea();
        public abstract double GetPerimiter();

        public void SayHello()
        {
            Console.WriteLine($"{this.GetType().Name} says hello!");
        }

        public virtual void ScreamHello()
        {
            Console.WriteLine($"{this.GetType().Name.ToUpper()} SCREAMS HELLO!");
        }
    }
}
