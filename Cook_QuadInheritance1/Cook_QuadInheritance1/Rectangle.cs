using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cook_QuadInheritance1
{
   public class Rectangle : Para
   {
       public Rectangle( float x1, float x2, float x3, float x4, float y1, float y2, float y3, float y4)
          :base(x1, x2, x3, x4, y1, y2, y3, y4)
      {
         
      }

       public Rectangle()
           : base()
       {

       }

       public override string ToString()
       {
           return " Coordinates of REctangle are: " + printCoordinates() + "\n Height is : " + Height + "\n Width is: " + Width + " \n Area is: " + Area();
       }
   }

}



