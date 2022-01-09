using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle (double Width, double Height)
        {
            this.Width = Width;
            this.Height = Height;
        }

   
        public Rectangle(double WidthAndHeight)
        {
            this.Width = WidthAndHeight;
            this.Height = WidthAndHeight;
        }
        public override double GetArea()
        {
            return (Width * Height);
        }

        public override double GetPerimiter()
        {
            return (Width + Height) * 2;
        }
        
        public override String ToString()
        {
            return "This is a rectangle with height " + this.Height + " and width " + this.Width + ". Area is " + this.GetArea() + " and perimiter is " + this.GetPerimiter();

        }
    }
}
