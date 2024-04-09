using System.Dynamic;

namespace Lab7ex1
{
    internal class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int YearOfManufacture { get; set; }
        public Engine Motor { get; set; }
        public Door Doors { get; set; }

        public string GetDescription()
        {
            return $"{Brand}, {Model}, {YearOfManufacture}, {Motor.Displacement},{Motor.FuelType}, {Motor.Power}, {Doors.NumberOfDoors} doors";
        }

        public string OpenCar()
        {
            return $"Car starts, {Doors.CloseDoor()}, {Motor.StartEngine()}";
            
        }

        public string StopCar()
        {
            return $"Car Stop, {Doors.OpenDoor()}, {Motor.StopEngine()}";

        }
    }
}
