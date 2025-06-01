/*
 * argo's command line pokemon battle simulator
 * version 0.0.2
 */

using System;
using System.IO;
using System.Text.Json;

namespace PokeSim {
    public class Program { 
        static void Main(string[] args) {
            string fileName = "bulbasaur.json";
            string jsonTest2 = File.ReadAllText(fileName);
            DexEntry? bulbasaur = JsonSerializer.Deserialize<DexEntry>(jsonTest2);

            Console.WriteLine("ARGO'S POKEMON BATTLE SIMULATOR");
            Console.WriteLine($"Name: {bulbasaur?.Name}");
            foreach (var stat in bulbasaur?.BaseStats) {
                Console.WriteLine($"{0}", stat);
            }
        }
    }
}

/*
 * so right now i'm trying to figure out the best way to read in SPECIFIC dex entries from a json file.
 * i really don't want to have to create an individual dex entry file for each pokemon, that'll get out
 * of hand very quickly. ideally, i want each generation to have a "pokedex" file, which i can search through
 * until i find the desired dex entry, then create a dexentry object from there. i'm not really sure this is
 * possible. the next best option would be to create an array or a list (iirc it has to be a list, i don't
 * think you can have arrays of objects?) that contains the entire pokedex, which i can then search through
 * to find the desired dex entry.
 */