using System;

namespace BoxData
{
    public class Box
    {
        //        Volume = lwh
        //Lateral Surface Area = 2lh + 2wh
        //Surface Area = 2lw + 2lh + 2wh

        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public double Length 
        { 
            get => this.length; 
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }

                this.length = value;
            }
        }
        public double Width 
        { 
            get => this.width;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }

                this.width = value;
            }
        }
        public double Height
        {
            get => this.height;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }

                this.height = value;
            }
        }

        public double GetVolume()
        {
            return this.length * this.width * this.height;
        }

        public double GetSurfaceArea()
        {
            return (2 * this.length * this.width) 
                + (2 * this.length * this.height) 
                + (2 * this.width * this.height);
        }

        public double GetLateralSurfaceArea()
        {
            return (2 * this.length * this.height)
                + (2 * this.width * this.height);
        }
    }
}
