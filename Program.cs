using System.Security.Cryptography.X509Certificates;
using System.Text.Unicode;

namespace AreaOnCircle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            bool allDone = false;
            Console.WriteLine("Hej och välkommen till mitt uträckningsprogram! ");

            Console.WriteLine("blablabla");

            while (allDone == false)
            {


                MyMenu();

                int.TryParse(Console.ReadLine(), out i);
                switch (i)
                {
                    case 1:
                        Circle Circle1 = new Circle(5);
                        Circle1.Area();
                        Circle circle2 = new Circle(6);
                        circle2.Area();
                        break;
                    case 2:
                        Circle Circle3 = new Circle(5);
                        Circle3.circumference();
                        Circle Circle4 = new Circle(6);
                        Circle4.circumference();
                        break;
                    case 3:
                        Circle circle5 = new Circle(5);
                        circle5.volume();
                        Circle circle6 = new Circle(6);
                        circle6.volume();
                        break;
                    case 4:
                        Triangle TriangleOut = new Triangle(15, 10);
                        TriangleOut.AreaT();
                        break;
                        case 5:
                        Console.WriteLine("\nTack för att du spelade");
                        allDone = true;
                        break;

                 }

            }

            
           
                      Console.ReadKey();
        } 

        static void MyMenu() 
        {
            Console.WriteLine("\nRäkna ut arean av en circkel tryck 1: ");
            Console.WriteLine("Räkna ut omkretsen av en cirkel tryck 2: ");
            Console.WriteLine("Räkna ut volymen av en cirkel tryck 3: ");
            Console.WriteLine("Räkna ut arean av en triangel tryck 4: ");
            Console.WriteLine("Om du vill avbryta programmet tryck 5: \n");
        }



    }
}    
 

            
                


            
            
           
            
           
           

            
            

           
            
            

           

            
            

           

            
            


            

            
      
           

            
  