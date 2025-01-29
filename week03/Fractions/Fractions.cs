using System;


    public class Fraction
    {
        private int _top;
        private int _bottom;
    
        // To create the contructor 1, set default to 0
        public Fraction()
        {
            _top = 1;
            _bottom = 1;
        }

         public Fraction(int topnumber)
        {
            _top = topnumber;
            _bottom = 1;
        }

         public Fraction(int topnumber, int bottomnumber)
        {
            _top = topnumber;
            _bottom = bottomnumber;
        }

        public string GetFractionString()
        {
            return _top +"/" + _bottom;
        }

        public double GetDecimalValue()
        {
            // double = _top/_bottom;
            return (double)_top/_bottom;
        }
    }