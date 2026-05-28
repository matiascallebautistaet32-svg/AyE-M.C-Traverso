
void ejercicio1()
{
    try
    {
        int[] numeros = new int[5];

        Console.WriteLine("Ingrese 5 numeros");
        for (int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Los numeros ingresados son: ");

        for (int x = 0; x < 5; x++)
        {
            Console.WriteLine(numeros[x]);
        }
    }
    catch(System.FormatException)
    {
        Console.WriteLine("Numero no valido");
    }
    catch(System.OverflowException)
    {
        Console.WriteLine("Numero ingresado muy grande");
    }
   
}
ejercicio1();


 void ejercicio2()
    {
        string[] frutas = { "pera", "manzana", "mandarina", "naranja", "pomelo", "banana", "kiwi", "sandia", "uva", "cereza" };
        Console.WriteLine("Ingrese el nombre de una fruta");
        string fruta = Console.ReadLine().ToLower();

        for (int i = 0; i < frutas.Length; i++)
        {
            if (frutas[i] == fruta)
            {
                Console.WriteLine($"La fruta esta en la lista y su posicion es {i}");
                return;
            }
        }
        Console.WriteLine("La fruta no fue encontrada");
    }
    ejercicio2();

