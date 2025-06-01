/*
 * argo's command line pokemon battle simulator
 * version 0.0.1
 * current features:
 *      nothing
 * planned features:
 *      everything
 */

using System;
using System.Text.Json;

namespace PokeSim {
    public class Program { 
        static void Main(string[] args) {
            string jsonTest =
                """
                {
                    "ID": 1,
                    "Name": "Bulbasaur",
                    "Type1": "Grass",
                    "Type2": "Poison",
                    "Height": 0.7,
                    "Weight": 6.9
                }
                """;
            DexEntry? bulbasaur = JsonSerializer.Deserialize<DexEntry>(jsonTest);

            Console.WriteLine("ARGO'S POKEMON BATTLE SIMULATOR");
            Console.WriteLine("Now testing pulling multiple values from JSON string.");
            Console.WriteLine($"ID and Name: {bulbasaur?.ID} {bulbasaur?.Name}");
            Console.WriteLine($"Type(s): {bulbasaur?.Type1}/{bulbasaur?.Type2}");
            Console.WriteLine($"Height: {bulbasaur?.Height}. Weight: {bulbasaur?.Weight}");
        }
    }
}