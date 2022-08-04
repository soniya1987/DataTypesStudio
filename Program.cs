using System;

namespace AreaOfCircle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a radius");

            string radius = Console.ReadLine();
            
           // int pi = (int)3.14;
            int radiusCircle = int.Parse(radius);
            while(radiusCircle<=0)
            {
                Console.WriteLine("Enter a radius");
                radiusCircle = int.Parse(Console.ReadLine());
            }
            int areaOfCircle = (int)(Math.PI *Math.Pow (radiusCircle, 2));
            Console.WriteLine("the area of circle is : " + areaOfCircle);

            int circumferenceOfCircle = (int)(2 * Math.PI * radiusCircle);
            int diameterOfCircle = (int)(2 * radiusCircle);
            Console.WriteLine("the circumference of the cirle is : " + circumferenceOfCircle);
            Console.WriteLine("the diameter of the circle is : " + diameterOfCircle);


            Console.WriteLine("how many miles per gallon does your car get?");

            string milesPerGallon = Console.ReadLine();
            int milesPerGallonNumber = int.Parse(milesPerGallon);
            int gallonsgasUsed = milesPerGallonNumber * circumferenceOfCircle;
            Console.WriteLine("you will use " + gallonsgasUsed + " to go around the circle.");


               

        }
    }
}
