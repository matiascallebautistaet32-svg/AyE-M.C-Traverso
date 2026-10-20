using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static async Task Main()
        {
            string ruta = "invt.json";

         
            if (File.Exists(ruta))
            {
                File.Delete(ruta);
            }

            Console.WriteLine("Conectando a la base de datos y generando JSON");

            try
            {

                using (var context = new AppDbContext())
                {
                    var listSQL = context.pokemon.ToList();


                    string jsonBD = JsonSerializer.Serialize(listSQL, new JsonSerializerOptions { WriteIndented = true });
                    File.WriteAllText(ruta, jsonBD);

                    Console.WriteLine($"Se exportaron {listSQL.Count} pokemones");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se pudo conectar a la base de datos");
                Console.WriteLine(ex.Message);
                if (ex.InnerException != null)
                {
                    Console.WriteLine("Detalle: " + ex.InnerException.Message);
                }
                return;
            }
            string contJSON = File.ReadAllText(ruta);

            var opc = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                NumberHandling = JsonNumberHandling.AllowReadingFromString
            };

            try
            {
                List<pokemon>? pokemones = JsonSerializer.Deserialize<List<pokemon>>(contJSON, opc);

                if (pokemones != null && pokemones.Count > 0)
                {
                    Console.WriteLine("Mostrando datos desde el archivo JSON" + "");
                    foreach (var p in pokemones)
                    {
                        Console.WriteLine($"ID: {p.Id} - Nombre: {p.nombre} - Tipo 1: {p.tipo_1} - Tipo 2: {p.tipo_2} - HP: {p.hp} - Ataque: {p.ataque} - Defensa: {p.defensa}");
                    }
                }
            }
            catch (JsonException ex)
            {
                Console.WriteLine("Error al procesar el formato del JSON: " + ex.Message);
            }
        }
    }
}