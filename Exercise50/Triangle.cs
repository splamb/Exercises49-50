using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise50
{
    class Triangle
    {
        private int _sideA;

        public int SideA
        {
            get
            {
                return _sideA;
            }
            set
            {
                _sideA = value;
            }
        }

        private int _sideB;

        public int SideB
        {
            get
            {
                return _sideB;
            }
            set
            {
                _sideB = value;
            }
        }

        private int _sideC;

        public int SideC
        {
            get
            {
                return _sideC;
            }
            set
            {
                _sideC = value;
            }
        }

        private double _area;

        public double Area
        {
            get
            {
                return _area;
            }
            set
            {
                _area = value;
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
    }
}
