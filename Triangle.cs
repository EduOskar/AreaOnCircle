namespace AreaOnCircle
{
    class Triangle  //Klassen triangle
    {
        //Declare variables
        float _Base;
        int _Height;

        public Triangle(int NewHeight, int NewBase)  //Konstruktor
        {
            
            _Height = NewHeight;
            _Base = NewBase;
        }
        public double AreaT()  //Method for calculations
        {
          
            double result = _Base * _Height / 2; //Calculations             
            Console.WriteLine($" \nuträkning av arean när höjden på triangeln är {_Height} och basen {_Base}: " + result); //printing it out
            return result;
        }
    }
}