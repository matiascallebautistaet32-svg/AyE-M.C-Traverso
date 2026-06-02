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
    catch (System.FormatException)
    {
        Console.WriteLine("Numero no valido");
    }
    catch (System.OverflowException)
    {
        Console.WriteLine("Numero ingresado muy grande");
    }

}
ejercicio1();

Console.WriteLine("");

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

Console.WriteLine("");

void ejercicio3()
    {
        double[] notas = { 14.5, 18.0, 11.2, 15.0, 20.0, 13.4, 16.1, 12.0, 19.8, 17.0 };
        double sumaTotal = 0;

        foreach (double nota in notas)
        {
            sumaTotal += nota;
        }

        double promedio = sumaTotal / notas.Length;

        Console.WriteLine($"Suma total de las notas: {sumaTotal:F2}");
        Console.WriteLine($"Promedio de las notas: {promedio:F2}");
    }
ejercicio3();

Console.WriteLine("");

 void ejercicio4()
    {
        double[] temperaturas = { 12.5, 18.2, 24.0, 8.5, -2.1, 15.6, 21.3 };

        double max = temperaturas[0];
        double min = temperaturas[0];

        foreach (double temp in temperaturas)
        {
            if (temp > max)
            {
                max = temp; 
            }
            if (temp < min)
            {
                min = temp; 
            }
        }

        Console.WriteLine($"Temperatura maxima registrada: {max}°C");
        Console.WriteLine($"Temperatura minima registrada: {min}°C");
    }
ejercicio4();

Console.WriteLine("");

void ejercicio5()
    {
        int[] numeros = { 45, 12, 89, 5, 23, 7, 61, 34 };

        Console.WriteLine("Lista original: " + string.Join(", ", numeros));

        Array.Sort(numeros);

        Console.WriteLine("Lista de forma ascendente: " + string.Join(", ", numeros) + "");
    }
ejercicio5();

Console.WriteLine("");

void ejercicio6()
    {
        int[] numeros = { 12, 7, 23, 44, 55, 68, 91, 100, 3, 14, 22, 37, 8, 19, 50 };

        int contadorPares = 0;
        int contadorImpares = 0;

        foreach (int num in numeros)
        {
            if (num % 2 == 0)
            {
                contadorPares++; 
            }
            else
            {
                contadorImpares++; 
            }
        }

    Console.WriteLine($"Cantidad de numeros pares: {contadorPares}");
    Console.WriteLine($"Cantidad de numeros impares: {contadorImpares}");
    Console.WriteLine($"Conteo de todos los numeros: {numeros.Length}");

    }
ejercicio6();


