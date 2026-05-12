void ejercicio2()
{
     Console.WriteLine("Ingrese numeros");
     int num = Convert.ToInt32(Console.ReadLine());
     int contador = 0;
     while (num != 0)
     { 
       Console.WriteLine("Ingrese numeros");
        try
        {
            num = Convert.ToInt32(Console.ReadLine());
        }
        catch (System.FormatException)
        {
            Console.WriteLine("Error, ingrese un numero valido");
        }
        contador = contador + num;
     }
    Console.WriteLine("La suma de todos los numeros que ha ingresado es " + contador);
}

ejercicio2();

void ejercicio3()
{
    Console.WriteLine("Ingrese una palabra");
    string palabra = Console.ReadLine();
    try
    {
        palabra = Console.ReadLine();
    }
    catch (System.FormatException)
    {
        Console.WriteLine("Error, ingrese caracteres validos");
    }
    string vocales = ("aeiouAEIOU");
    int contador = 0;
    foreach (char p in palabra)
    {
        foreach (char vocal in vocales)
        {
            if (p == vocal)
            {
                contador++;

            }
        }
    }

 Console.WriteLine("La cantidad de vocales es " + contador);
}
ejercicio3();

void ejercicio4()
{
    Console.WriteLine("Ingrese una palabra");
    string palabra = Console.ReadLine().ToLower();
    try
    {
        palabra = Console.ReadLine().ToLower();
    }
    catch (System.FormatException)
    {
        Console.WriteLine("Error, ingrese caracteres valido");
    }

    string palabrainvert = "";


    for (int i = palabra.Length - 1; i >= 0; i--)
    {
        palabrainvert += palabra[i];

    }

    if (palabra == palabrainvert)
    {
        Console.WriteLine("Su palabra es un palindromo y es " + palabrainvert);
    }
    else
    {
       Console.WriteLine("No es un palindromo,ingrese otra palabra");
        return;
    }
}
ejercicio4();
