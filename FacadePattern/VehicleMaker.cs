using System;

namespace FacadePattern
{

    public class VehicleMaker
    {
        private Vehicle car;
        private Vehicle truck;
        private Vehicle bus;

        public VehicleMaker()
        {
            car = new Car();
            truck = new Truck();
            bus = new Bus();
        }

        public void buildCar()
        {
            car.build();
        }
        public void buildTruck()
        {
            truck.build();
        }
        public void buildBus()
        {
            bus.build();
        }
    }
}