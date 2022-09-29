namespace AreaOnCircle
{
    class Circle
    {
        float _pi = 3.141f;
        int _Radius;

        public Circle(int newRadius)
        {
            this._Radius = newRadius;
        }


        public double Area()
        {
            
            double result = _Radius * _Radius * _pi;
            Console.WriteLine($" \nUträkning av area med {_Radius } blir:  " + result);
            
            return result;
        }

        public double circumference()
        {

            double result = _Radius * 2 * _pi;
            Console.WriteLine($" \nuträkning av omkrets med  {_Radius} blir:  " + result);
            
            return result;
        }

        public double volume()
        {
            double result = (4 * _pi * Math.Pow(_Radius, 3) / 3);
            Console.WriteLine($" \nuträkning av volym med {_Radius} blir:  " + result);
            
            return result;
        }
    }   
}