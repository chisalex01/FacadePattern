using System;

namespace FacadePattern
{
    public class Car : Vehicle
   {
        public void build()
        {
            Console.WriteLine("Car has been built");
        }
    }
}
