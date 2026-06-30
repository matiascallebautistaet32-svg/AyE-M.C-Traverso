bool continuar= true;
int selec = 0;
Random aleatorio = new Random();

string[] palos = ["Picas", "Corazones", "Treboles", "Diamantes"];
string[] valores = ["A", "2", "3", "4", "5", "6", "7", "8", "9", "10","J","Q","K"];
string[,] cartas = new string[8, 2];
while (continuar)
{
    Console.WriteLine("1. Repartir nueva mano");
    Console.WriteLine("2. Cambiar/Descartar cartas");
    Console.WriteLine("3. Finalizar partida");
    Console.Write("Seleccione una opcion: ");

    selec = Convert.ToInt32(Console.ReadLine());
    switch (selec)
    {
        case 1:
            Console.WriteLine("Pidiendo cartas");
            nuevamano();
            break;
        case 2:
            Console.WriteLine("Preparando descarte");
            descarte();
            break;
        case 3:
            Console.WriteLine("Juego finalizado");
            continuar = false;
            break;
        default:
            Console.WriteLine("Opcion incorrecta. Intente nuevamente.");
            break;
    }
}

void nuevamano()
{
    int totalCartas = cartas.GetLength(0);
    for (int i = 0; i < totalCartas; i++)
    {
        cartas[i, 0] = palos[aleatorio.Next(0, palos.Length)];
        cartas[i, 1] = valores[aleatorio.Next(0, valores.Length)];
    }

    manoactual(cartas);
}

void descarte()
{
    int cartasto = cartas.GetLength(0);
    Console.Write($"¿Cuantas cartas desea cambiar? (1 al {cartasto}): ");
    int limitedesc = Convert.ToInt32(Console.ReadLine());

    for (int i = 1; i <= limitedesc; i++)
    {
        Console.Write($"[{i}/{limitedesc}] Ingrese el numero de la carta a descartar (1 al {cartasto}): ");
        int posicioncarta = Convert.ToInt32(Console.ReadLine());

        if (posicioncarta >= 1 && posicioncarta <= cartasto)
        {
            int indice = posicioncarta - 1;

 
            cartas[indice, 0] = palos[aleatorio.Next(0, palos.Length)];
            cartas[indice, 1] = valores[aleatorio.Next(0, valores.Length)];
        }
        else
        {
            Console.WriteLine("Posición invalida");
        }
    }

    Console.WriteLine("Cambios completados");
    manoactual(cartas);
}

void manoactual(string[,] juegoact)
{
    int limite = juegoact.GetLength(0);
    Console.WriteLine(" Tus cartas actuales");
    for (int i = 0; i < limite; i++)
    {
        Console.WriteLine($"{i + 1}- {juegoact[i, 1]} de {juegoact[i, 0]}");
    }
}

