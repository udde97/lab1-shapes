using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
  
    public  class Square : Shape
    {
        public double SideLength { get; set; }

        public Square(double SideLength)
        {
            this.SideLength = SideLength;
        }
        public override double GetArea()
        {
            return (SideLength * SideLength);
        }

        public override double GetPerimiter()
        {
            return (SideLength * 4);
        }

        
        public override String ToString()
        {
            return "This is a square with sidelength " + this.SideLength + ", area " + this.GetArea() + " and perimiter length " + this.GetPerimiter();
        }
    }
}
