using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02QA
{
    public class Rectangle
    {
        // private attributes
        private int length;
        private int width;
        private int height;

        //initialize attributes  default constructor
        public Rectangle()
        {
            this.length = 1;
            this.width = 1;
            this.height = 1;
        }

        //initialize attributes in non-default constructor provided value by user
        public Rectangle(int length, int width, int height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }

        // all attributes value get and set
        public int GetLength()
        {
            return this.length;
        }

        public int SetLength(int length)
        {
            this.length = length;
            return this.length;
        }

        public int GetWidth()
        {
            return this.width;
        }

        public int SetWidth(int width)
        {
            this.width = width;
            return this.width;
        }

        public int GetHeight()
        {
            return this.height;
        }

        public int SetHeight(int height)
        {
            this.height = height;
            return this.height;
        }


        // calculate volume of rectangle
        public int GetVolume()
        {
            return this.length * this.width * this.height;
        }
    }
}
