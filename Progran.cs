using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ConsoleApp3;

namespace ConsoleApp3
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using var db = new AppDbContext();
            Tree arbol = new Tree();

            AppDbContext context = new AppDbContext();

            List<Agentes> agentli = context.agentes_valorant.ToList();

            foreach (Agentes ag in agentli)
            {
                arbol.Inserto(ag);
            }

            int decision = 0;

            while (decision != 5)
            {
                Console.WriteLine("1- Agregar");
                Console.WriteLine("2- Eliminar");
                Console.WriteLine("3- Actualizar");
                Console.WriteLine("4- Buscar");
                Console.WriteLine("5- Finalizar");

                string inp = Console.ReadLine();
                if (!int.TryParse(inp, out decision))
                {
                    Console.WriteLine("Por favor, ingrese un numero valido.");
                    continue;
                }

                switch (decision)
                {
                    case 1:
                        Console.WriteLine("Ingrese el nombre:");
                        string nombreingresa = Console.ReadLine();

                        Console.WriteLine("Ingrese el tipo:");
                        string tipoingresa = Console.ReadLine();

                        Console.WriteLine("Ingrese el pais:");
                        string nacionalidadngresa = Console.ReadLine();

                        Console.WriteLine("Ingrese la fecha de lanzamiento:");
                        string fecha_lanzamientoingresa = Console.ReadLine();


                        var agentingresado = new Agentes(0, nombreingresa, tipoingresa, nacionalidadngresa, fecha_lanzamientoingresa);

                        context.agentes_valorant.Add(agentingresado);
                        await context.SaveChangesAsync();

                        agentli = context.agentes_valorant.ToList();
                        arbol = new Tree();
                        foreach (var j in agentli) arbol.Inserto(j);

                        Console.WriteLine("Agente agregado");
                        break;



                    case 2:
                        Console.WriteLine("Ingrese el id del jugador que quiera eliminar:");
                        int id = int.Parse(Console.ReadLine());

                        var datoBus = await context.agentes_valorant.FindAsync(id);

                        if (datoBus != null)
                        {
                            context.agentes_valorant.Remove(datoBus);
                            await context.SaveChangesAsync();

                            agentli = context.agentes_valorant.ToList();
                            arbol = new Tree();
                            foreach (var j in agentli) arbol.Inserto(j);

                            Console.WriteLine("Agente eliminado");
                        }
                        else
                        {
                            Console.WriteLine($"No hay agente con el ID {id}.");
                        }
                        break;



                    case 3:
                        int modi = 0;
                        string modifs = "";

                        Console.WriteLine("Ingrese el id del agente que quiera cambiar:");
                        int id2 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Que quiere cambiar?");
                        Console.WriteLine("1- Nombre");
                        Console.WriteLine("2- Tipo");
                        Console.WriteLine("3- Pais");
                        Console.WriteLine("4- Fecha de lanzamiento");

                        int decision2 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Ingrese el nuevo valor:");

                        if (decision2 >= 1 && decision2 <= 4)
                        {
                            modifs = Console.ReadLine();
                        }
                        else
                        {
                            modi = int.Parse(Console.ReadLine());
                        }

                        var agenteBus = await context.agentes_valorant.FindAsync(id2);

                        if (agenteBus != null)
                        {
                            switch (decision2)
                            {
                                case 1: agenteBus.nombre_agente = modifs; break;

                            }

                            await context.SaveChangesAsync();

                            agentli = context.agentes_valorant.ToList();
                            arbol = new Tree();
                            foreach (var j in agentli) arbol.Inserto(j);

                            Console.WriteLine("Agente modificado");
                        }
                        else
                        {
                            Console.WriteLine($"No hay ningun agente con el ID {id2}.");
                        }
                        break;



                    case 4:
                        Console.WriteLine("Ingrese el id del agente a buscar:");
                        int idBus1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(arbol.Buscar(idBus1));
                        break;



                    case 5:
                        Console.WriteLine("Cerrando el programa");
                        break;



                    default:
                        Console.WriteLine("Opcion no valida.");
                        break;
                }
            }




            ordenamientoBurbuja();

            void ordenamientoBurbuja()
            {
                for (int j = 0; j < agentli.Count - 1; j++)
                {
                    for (int i = 0; i < agentli.Count - 1; i++)
                    {
                        if (agentli[i].nombre_agente.CompareTo(agentli[i + 1].nombre_agente) > 0)
                        {
                            Agentes bur = agentli[i];
                            agentli[i] = agentli[i + 1];
                            agentli[i + 1] = bur;
                        }
                    }
                }

                Console.WriteLine("Orden Alfabetico");
                foreach (var a in agentli)
                {
                    Console.WriteLine(a.nombre_agente);
                }
            }


        }
    }
}