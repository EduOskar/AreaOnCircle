namespace AreaOnCircle
{
    class Triangle 
    {
        float _Base;
        int _Height;

        public Triangle(int NewHeight, int NewBase) 
        {
            
            _Height = NewHeight;
            _Base = NewBase;
        }
        public double AreaT() 
        {
          
            double result = _Base * _Height / 2;                    
            Console.WriteLine($" \nuträkning av arean när höjden på triangeln är {_Height} och basen {_Base}: " + result);
            return result;
        }
    }
}