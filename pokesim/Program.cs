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
                    "Name": "Bulbasaur"
                }
                """;
            DexEntry? bulbasaur = JsonSerializer.Deserialize<DexEntry>(jsonTest);

            Console.WriteLine("ARGO'S POKEMON BATTLE SIMULATOR");
            Console.WriteLine("Now testing pulling value from JSON string, with the DexEntry class in its own file.");
            Console.WriteLine($"Name pulled: {bulbasaur?.Name}");
        }
    }
}