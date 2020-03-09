using System;
using System.Collections.Generic;
using System.Text;

namespace LearnV1
{
    public class rectangle
    {
        public double basis;
        public double height;

        public double area()
        {
            double area = this.basis * this.height;
            return area;
        }

        public double perimeter()
        {
            double perim = this.basis * 2 + this.height * 2;
            return perim;
        }

        public void grow(double quantity)
        {
            //NO RETURNO NADA PORQUE ES VOID, SOLO CAMBIA EL VALOR ACTUAL DE LAS VARIABLES
            this.basis = this.basis + quantity;
            this.height = this.height + quantity;
        }

        public double compare(rectangle rect)
        {
            return this.area() - rect.area();
        }



    }
}
