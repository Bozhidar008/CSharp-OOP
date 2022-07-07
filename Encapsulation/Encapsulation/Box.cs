using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBoxData
{
    public class Box
    {
        private double length;
        private double width;
        private double height;
        public Box(double lenght, double width, double height )
        {
            Length = lenght;
            Width = width;
            Height = height;
        }
        public double Length 
        { 
            get 
            { 
                return (double)this.length; 
            }
            set
            {
                this.ThrowException(value, nameof(this.Length));
                this.length = value;
            }
        }
        public double Width 
        {
            get
            {
                return (double)this.width;
            }
            set
            {
                this.ThrowException(value, nameof(this.Width));
                width = value;
            }
        }
        public double Height 
        {
            get
            {
                return (double)this.height;
            }
            set
            {
                this.ThrowException(value, nameof(this.Height));
                this.height = value;
            }
        }

        public double SurfaceArea()
        {
            return  2 * Length * Width + 2 * Length * Height + 2 * Width * Height;
            
        }

        public double LateralSurfaceArea()
        {
            return  2 * Length * Height + 2 * Width * Height;
            
        }

        public double Volume()
        {
            return  Length * Width * Height;
            
        }

        private void ThrowException(double value, string side)
        {
            if (value <= 0)
            {
                throw new ArgumentException($"{side} cannot be zero or negative.");
            }
        }
    }
}
