namespace AreaOnCircle
{
    class Circle //Class for circle
    {
        //Declared variables to share with the methods inside this class
        float _pi = 3.141f;
        int _Radius;

        public Circle(int newRadius) //Constructor
        {
            this._Radius = newRadius;
        }


        public double Area() //Method to calculate area on the circle
        {
            
            double result = _Radius * _Radius * _pi; //Calculations
            Console.WriteLine($" \nUträkning av area med {_Radius } blir:  " + result); //printing it out
            
            return result;
        }

        public double circumference() //Method to calculate circumference 
        {

            double result = _Radius * 2 * _pi;//Calculations
            Console.WriteLine($" \nuträkning av omkrets med  {_Radius} blir:  " + result); //printing it out

            return result;
        }

        public double volume() //Method to calculate volume
        {
            double result = (4 * _pi * Math.Pow(_Radius, 3) / 3);//Calculations
            Console.WriteLine($" \nuträkning av volym med {_Radius} blir:  " + result); //printing it out

            return result;
        }
    }   
}