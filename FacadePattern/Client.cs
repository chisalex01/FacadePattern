using System;

namespace FacadePattern
{
    public class Client
    {
        public static void Main(String[] args)
        {
            VehicleMaker vehicleMaker = new VehicleMaker();

            vehicleMaker.buildCar();
            vehicleMaker.buildTruck();
            vehicleMaker.buildBus();
        }
    }
}
