/*
 * argo's command line pokemon battle simulator
 * version 0.0.1
 */

using System;
using System.IO;
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
            string fileName = "bulbasaur.json";
            string jsonTest2 = File.ReadAllText(fileName);
            DexEntry? bulbasaur = JsonSerializer.Deserialize<DexEntry>(jsonTest2);

            Console.WriteLine("ARGO'S POKEMON BATTLE SIMULATOR");
            Console.WriteLine($"Current directory: {Environment.CurrentDirectory}");
        }
    }
}