//Exercitii – partea 1
//    • Un autoturism detine un motor
//    precum si un numar de usi. De
//    asemenea autovehiculul este
//caracterizat de marca, model si an
//de fabricatie
//    • Motorul
//     este caracterizat de
//     Capacitate cilindrica
//     Putere
//     Tipul combustibilului
//    • Autoturismul va avea urmatoarele
//metode/proprietati
//     GetDescription
//     Va returna descrierea completa a
//    autovehicolului sub forma unui sir de
//    caractere
//         “Marca, model, anDeFabricatie,
//capacitate cilindrica, combustibil,
//    putere motor, numar de usi
//    In metoda Main, creati autoturisme si
//afisati-le descrierea
//    Creati diagrama UML si salvati-o in
//git, alaturi de proiect


using Lab7ex1;

Car car1 = new Car
{
    Brand = "Toyota",
    Model = "Corolla",
    YearOfManufacture = 2022,
    Motor = new Engine { Displacement = 2000, Power = 150, FuelType = "Gasoline" },
    Doors = new Door(2)
};

Car car2 = new Car
{
    Brand = "Tesla",
    Model = "Model S",
    YearOfManufacture = 2023,
    Motor = new Engine { Displacement = 0, Power = 600, FuelType = "Electric" },
    Doors = new Door(4)
};

Console.WriteLine("Car 1: " + car1.GetDescription());
Console.WriteLine($"Car1 start: {car1.OpenCar()}");
Console.WriteLine($"Car1 start: {car1.StopCar()}");

Console.WriteLine("Car 2: " + car2.GetDescription());
Console.WriteLine($"Car2 start: {car2.OpenCar()}");
Console.WriteLine($"Car2 start: {car2.StopCar()}");


