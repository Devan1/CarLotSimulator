using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var chevy_impala = new Car(2012, "Chevy", "Impala", "Vroooooooom", "auuuuuuuggagaa", false);
            var toyota_tundra = new Car(2006, "Toyota", "Tundra", "brrrrrrr", "HONK,HONK", true);
            var honda_civic = new Car(2019, "Honda", "Civic", "buzzzzzzzz", "beepbeep", true);
            
            Console.WriteLine($"{chevy_impala.year}, {chevy_impala.make}, {chevy_impala.model}, {chevy_impala.isDriveable}");
            chevy_impala.MakeEngineNoise();
            chevy_impala.MakeHonkNoise();
            
            Console.WriteLine($"{toyota_tundra.year}, {toyota_tundra.make}, {toyota_tundra.model}, {toyota_tundra.isDriveable}");
            toyota_tundra.MakeEngineNoise();
            toyota_tundra.MakeHonkNoise();
            
            Console.WriteLine($"{honda_civic.year}, {honda_civic.make}, {honda_civic.model}, {honda_civic.isDriveable}");
            honda_civic.MakeEngineNoise();
            honda_civic.MakeHonkNoise();
        }

    }
}
