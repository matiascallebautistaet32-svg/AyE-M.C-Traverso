void Ejercicio1()
{
    Console.WriteLine("Ingrese una frase");
    string vocales = ("aeiouAEIOU");
    string texto = Console.ReadLine();
    int contador = 0;

    foreach (char t in texto)
    {

        foreach (char vocal in vocales)
        {

            if (t == vocal)
                contador++;

        }
    }
    Console.WriteLine("El numero total de vocales es: " + contador);
}
Ejercicio1();




void Ejercicio2()
{
    Console.WriteLine("Ingrese una palabra o frase");
    string texto = Console.ReadLine();

    for (int i = texto.Length - 1; i >= 0; i--)
    {

        char letrainvert = texto[i];
        Console.WriteLine(letrainvert);

    }

}
Ejercicio2();


void Ejercicio3()
{
    Console.WriteLine("Ingrese un numero entero");
    string texto = Console.ReadLine();
    int aux = 0;
    int aux2 = 0;

    foreach (char t in texto)
    {
        aux = Convert.ToInt32("" + t);

        aux2 = aux + aux2;

    }
    Console.WriteLine("La suma es: " + aux2);
}
Ejercicio3();



void Ejercicio4()
{
    string texto = ("Tres tristes tigres comian trigo en tres tristes platos sentados en un trigal.Sentados en un trigal en tres tristes platos comian trigo tres tristes tigres");
    Console.WriteLine(texto);
    Console.WriteLine("Ingrese una palabra prohibida");

    string textoprohibido = Console.ReadLine();

    Console.WriteLine("Ingrese una palabra de remplazo");

    string textoremplazo = Console.ReadLine();

    string textocambiado = texto.Replace(textoprohibido, textoremplazo);

    Console.WriteLine(textocambiado);

}
Ejercicio4();


void Ejercicio5()
{


    Console.WriteLine("Ingrese su nombre y apellido:");
    string nombrecompleto = Console.ReadLine();

    string[] partes = nombrecompleto.Split(' ');

    string nombre = partes[0];
    string apellido = partes[1];

    char inicialNombre = nombre[0];
    char inicialApellido = apellido[0];

    Console.WriteLine($"Iniciales: {inicialNombre}.{inicialApellido}.");
}
Ejercicio5();


void Ejercicio6()
{
    Console.WriteLine("Ingrese una palabra");
    string palabra = Console.ReadLine();
    string palabrainvert = "";

    for (int i = palabra.Length - 1; i >= 0; i--)
    {
     palabrainvert += palabra[i];
    }
     
    if (palabra == palabrainvert)
    {
      Console.WriteLine("Es un palindromo");
    }
    else
    {
      Console.WriteLine("No es un palindromo");
    }
    }
Ejercicio6();

