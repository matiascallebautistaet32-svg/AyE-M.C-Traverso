void ejercicio1()
{
    Console.WriteLine("Los multiplos de 3 son:");
    for (int x = 0; x < 100; x += 3)
    {
        Console.WriteLine(x);
    }
}


void ejercicio2()
{
    Console.WriteLine("Ingrese su edad:");
    int edad = Convert.ToInt32(Console.ReadLine());

    if (edad > 18)
    {
        Console.WriteLine("Usted es mayor de edad");
    }
    else if (edad < 18)
    {
        Console.WriteLine("Usted es menor de edad");
    }
    else
    {
        Console.WriteLine("Usted tiene 18 añitos");
    }
}


void ejercicio3()
{
    Console.WriteLine("Ingrese una palabra:");
    string palabra = Console.ReadLine();
    Console.WriteLine("La palabra tiene " + palabra.Length + " letras");
}


void ejercicio4()
{

    string contrasecret = "salmontre33";
    Console.WriteLine("Ingrese la contraseña:");

    for (int intentos = 5; intentos > 0; intentos--)
    {
        string contra = Console.ReadLine();

        if (intentos == 1)
        {
            Console.WriteLine("Intentos agotados,acceso denegado");
        }
        else if (contra == contrasecret)
        {
            Console.WriteLine("Contraseña correcta, acceso permitido");

        }
    }
}



void ejercicio5()
{
    Console.WriteLine("Ingresa 10 numeros:");
    int nummayor = 0;

    for (int i = 0; i < 10; i++)
    {
        int num = Convert.ToInt32(Console.ReadLine());

        if (num > nummayor)
        {
            nummayor = num;
        }
    }

    Console.WriteLine("El numero mas alto es: " + nummayor);
}


void ejercicio6()
{
    Console.Write("Ingresa su nombre: ");
    string entrada = Console.ReadLine();

    if (entrada.Length > 0)
    {
        string primeraLetra = entrada.Substring(0, 1).ToUpper();
        string restoDelNombre = entrada.Substring(1).ToLower();

        string nombreFormateado = primeraLetra + restoDelNombre;

        Console.WriteLine($"¡Hola {nombreFormateado}!");


    }
}


void ejercicio7()
{
    Console.WriteLine("Tabla del 7:");

    for (int i = 1; i <= 10; i++)
    {

        Console.WriteLine($"7 x {i} = {7 * i}");
    }
}


void ejercicio8()
{

    for (int i = 10; i > 0; i--)
    {

        Console.WriteLine(i);
    }
    Console.WriteLine("oa");
}


void ejercicio9()
{
    Console.WriteLine("Ingrese un numero");
    int num = Convert.ToInt32(Console.ReadLine());

    if (num % 2 == 0)
    {
        Console.WriteLine("El numero es par");
    }
    else
    {
        Console.WriteLine("El numero no es par");

    }
}


void ejercicio10()
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


void ejercicio11()
{

    Console.WriteLine("Ingrese un numero y te dare su tabla de multiplicar del 1 al 12");
    int num = Convert.ToInt32(Console.ReadLine());

    for (int i = 1; i < 13; i++)
    {
        Console.WriteLine($"{num} x {i} = {num * i}");
    }
}


void ejercicio12()
{
    Console.WriteLine("Ingrese numeros");

    int contador = 0;

    while (contador <= 100)
    {
        int num = Convert.ToInt32(Console.ReadLine());
        contador = contador + num;
    }
    Console.WriteLine("Supero el limite de 100 numeros acumulados");
}


void ejercicio13()
{
    Console.WriteLine("Ingresa una palabra");
    string palabra = Console.ReadLine();

    foreach (char letra in palabra)
    {
        Console.WriteLine(letra);
    }
}


void ejercicio14()
{
    Console.WriteLine("Ingrese su edad");
    int edad = Convert.ToInt32(Console.ReadLine());

    if (edad >= 16)
    {

        Console.WriteLine("Puedes votar");
    }
    if (edad >= 18)
    {

        Console.WriteLine("Puede manejar");

    }
    if (edad >= 18)
    {

        Console.WriteLine("Puedes votar y manejar");
    }
    if (edad <= 15)
    {

        Console.WriteLine("No puede votar ni manejar");
    }
}


void ejercicio15()
{
    for (int x = 50; x > -1; x -= 5)
    {
        Console.WriteLine(x);
    }
}


void ejercicio16()
{
    Console.WriteLine("Ingrese una contraseña: ");
    string contra = Console.ReadLine();
    Console.WriteLine("Ingresela nuevamente: ");
    string contra2 = Console.ReadLine();

    while (contra != contra2)
    {
        Console.WriteLine("Ingrese las contraseñas nuevamente: ");
        contra = Console.ReadLine();
        contra2 = Console.ReadLine();
    }
    Console.WriteLine("Acceso permitido");
}


void ejercicio17()
{
    Console.WriteLine("Ingrese nombres uno por uno si ingresa un nombre con mas de 10 caracteres termina");
    bool ejecutar = false;
    while (ejecutar = true)
    {
        string nombre = Console.ReadLine();
        ejecutar = false;
        if (nombre.Length > 10)
        {
            Console.WriteLine("Programa terminado");
            break;
        }
    }
}


void ejercicio18()
{

    Console.WriteLine("Ingrese una oracion: ");
    string letraa = ("a");
    string orac = Console.ReadLine();
    int contador = 0;

    foreach (char t in orac)
    {
        foreach (char letra in letraa)
        {
            if (t == letra)
                contador++;
        }
    }
    Console.WriteLine("El numero total de letras a es: " + contador);
}






Console.WriteLine("Elija un numero de ejercicio (1-18): ");
int x = Convert.ToInt32(Console.ReadLine());

switch (x)
{
    case 1:
        ejercicio1();
        break;


    case 2:
        ejercicio2();
        break;


    case 3:
        ejercicio3();
        break;


    case 4:
        ejercicio4();
        break;


    case 5:
        ejercicio5();
        break;


    case 6:
        ejercicio6();
        break;


    case 7:
        ejercicio7();
        break;


    case 8:
        ejercicio8();
        break;


    case 9:
        ejercicio9();
        break;


    case 10:
        ejercicio10();
        break;


    case 11:
        ejercicio11();
        break;


    case 12:
        ejercicio12();
        break;

    case 13:
        ejercicio13();
        break;

    case 14:
        ejercicio14();
        break;


    case 15:
        ejercicio15();
        break;


    case 16:
        ejercicio16();
        break;


    case 17:
        ejercicio17();
        break;


    case 18:
        ejercicio18();
        break;


    default: 
        Console.WriteLine("Ingrese un numero valido");
        break;
}

 


