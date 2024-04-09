namespace Lab7ex1
{
    internal class Door
    {
        public int NumberOfDoors { get; set; }

        public Door(int numberOfDoors)
        {
            NumberOfDoors = numberOfDoors;
        }

        public string OpenDoor()
        {
            return "click";
        }

        public string CloseDoor()
        {
            return "clack";
        }
    }
}