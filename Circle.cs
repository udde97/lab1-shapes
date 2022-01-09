using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
  
    public class Circle : Shape
    {
        public double Radius { get; set; }


        public Circle(double Radius)
        {
            this.Radius = Radius;
        }

   
        public override double GetArea()
        {
            return (Radius * Radius * Math.PI);
        }
     
        public override double GetPerimiter()
        {
            return (2 * Radius * Math.PI);
        }
        
        public override String ToString()
        {
            return "This is a circle with radius " + this.Radius + ". The area is " + this.GetArea() + " and the perimiter is " + this.GetPerimiter();
        }
    }
}
