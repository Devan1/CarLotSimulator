using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            var chevy_impala = new Car(2012, "Chevy", "Impala", "Vroooooooom", "auuuuuuuggagaa", false);
            CarLot.Cars.Add(chevy_impala);
            var toyota_tundra = new Car(2006, "Toyota", "Tundra", "brrrrrrr", "HONK,HONK", true);
            CarLot.Cars.Add(toyota_tundra);
            var honda_civic = new Car(2019, "Honda", "Civic", "buzzzzzzzz", "beepbeep", true);
            CarLot.Cars.Add(honda_civic);
            
            Console.WriteLine($"{chevy_impala.year}, {chevy_impala.make}, {chevy_impala.model}, {chevy_impala.isDriveable}");
            chevy_impala.MakeEngineNoise();
            chevy_impala.MakeHonkNoise();
            
            Console.WriteLine($"{toyota_tundra.year}, {toyota_tundra.make}, {toyota_tundra.model}, {toyota_tundra.isDriveable}");
            toyota_tundra.MakeEngineNoise();
            toyota_tundra.MakeHonkNoise();
            
            Console.WriteLine($"{honda_civic.year}, {honda_civic.make}, {honda_civic.model}, {honda_civic.isDriveable}");
            honda_civic.MakeEngineNoise();
            honda_civic.MakeHonkNoise();

            Console.WriteLine($"Number of cars created: {CarLot.numberOfCars} ");

            foreach (var car in CarLot.Cars)
            {
                Console.WriteLine($"Year: {car.year}\nMake: {car.make}\nMode: {car.model}\n");
            }
        }

    }
}
