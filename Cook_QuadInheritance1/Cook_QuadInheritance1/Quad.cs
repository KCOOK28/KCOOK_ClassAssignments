using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cook_QuadInheritance1
{
    public  class Quad
    {
        protected float x1;
        protected float x2;
        protected float x3;
        protected float x4;
        protected float y1;
        protected float y2;
        protected float y3;
        protected float y4;

        public Quad(float xx1, float xx2, float xx3, float xx4, float yy1, float yy2, float yy3, float yy4)
        {
            x1 = xx1;
            x2 = xx2;
            x3 = xx3;
            x4 = xx4;
            y1 = yy1;
            y2 = yy2;
            y3 = yy3;
            y4 = yy4;
        }

        public Quad()
        {
            x1 = x2 = x3 = x4 = 0;
            y1 = y2 = y3 = y4 = 0;
        }

        public float X1
        {
            get
            {
                return x1;
            }
        }

        public float X2
        {
            get
            {
                return x2;
            }
        }

        public float X3
        {
            get
            {
                return x3;
            }
        }

        public float X4
        {
            get
            {
                return x4;
            }
        }

        public float Y1
        {
            get
            {
                return y1;
            }
        }

        public float Y2
        {
            get
            {
                return y2;
            }
        }

        public float Y3
        {
            get
            {
                return y3;
            }
        }

        public float Y4
        {
            get
            {
                return y4;
            }
        }


        public string printCoordinates()
        {
            return
            
            String.Format("({0}, {1});({2}, {3});({4},{5});({6},{7});", X1, X2, X3, X4, Y1, Y2,Y3,Y4);
       
        }

        public override string ToString()
        {
            return "Coordinates are :" + printCoordinates();
        }

    }
}
