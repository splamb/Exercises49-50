using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises49_50
{
    class Square
    {
        private int _sideLength;

        public int SideLength
        {
            get
            {
                return _sideLength;
            }
            set
            {
                _sideLength = value;
            }
        }

        private double _perimeter;

        public double Perimeter
        {
            get
            {
                return _perimeter;
            }
            set
            {
                _perimeter = value;
            }
        }

        private double _area;

        public double Area
        {
            get
            {
                return _area;
            }
            set {
                _area = value;
            }
        }

    }
}
