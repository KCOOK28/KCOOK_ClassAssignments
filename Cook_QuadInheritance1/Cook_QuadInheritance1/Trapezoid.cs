using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cook_QuadInheritance1
{
  public class Trapezoid :Quad
    {
      private float height;
      private float paraSides;

      public Trapezoid( float x1, float x2, float x3, float x4, float y1, float y2, float y3, float y4)
          :base(x1, x2, x3, x4, y1, y2, y3, y4)
      {
          height = getHeight();
          paraSides = TwoSidesSum();
      }

     public Trapezoid() : base()
      {
          height = Height;
          paraSides = ParaSides;
      }

      public float Height
     {
         get
         {
             return height;
         }
     }

      public float ParaSides
      {
          get
          {
              return paraSides;
          }
      }

      private float getHeight()
      {
          if (Y1 == Y2)

              return Math.Abs(Y2 - Y3);

          else
              return Math.Abs(Y1 - Y2);
      }

      public float Area()
      {
          return ParaSides * Height / 2.0F;
      }

      private float TwoSidesSum()
      {
          if (Y1 == Y2)
              return Math.Abs(X1 - X2) + Math.Abs(X3-X4);

          else
              return Math.Abs(X2 - X3) + Math.Abs(X4-X1);
      }

      public override string ToString()
      {
          return " Coordinates of Trapezoid are: " + printCoordinates() +"\n Height is : " + Height + "\n Aread is: " + Area(); 
      }

    }
}
