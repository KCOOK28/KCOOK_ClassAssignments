using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cook_QuadInheritance1
{
 public class Para : Trapezoid
    {
     private float width;

     public Para( float x1, float x2, float x3, float x4, float y1, float y2, float y3, float y4)
          :base(x1, x2, x3, x4, y1, y2, y3, y4)
      {
          width = getWidth();
      }

     public Para() : base()
     {
         width = getWidth();
     }

     public float Width
     {
         get
         {
             return width;
         }
     }

     private float getWidth()
     {
         if (Y1== Y2)
             return Math.Abs(X1 -X2);

         else
             return Math.Abs(X2 -X3);
     }

        public override string ToString()
      {
          return " Coordinates of Parrallelogram are: " + printCoordinates() +"\n Height is : " + Height + "\n Width is: " + Width + " \n Area is: " + Area();
      }


     }
    
}
