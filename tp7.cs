void Ejercicio1()
{
    Console.WriteLine("Ingresa un numero entero:");
    int num = Convert.ToInt32(Console.ReadLine());

    bool primo = true;

    if (num < 2)
    {
        primo = false;
    }
    else
    {

        for (int i = 2; i < num; i++)
        {
            if (num % i == 0)
            {
                primo = false;
                break;
            }
        }
    }

    if (primo)
    {
        Console.WriteLine(num + " es primo");
    }
    else
    {
        Console.WriteLine(num + " no es primo");
    }
}
Ejercicio1();

void Ejercicio2()
{
    Console.WriteLine("Ingresa un numero entero no negativo:");
    int num = Convert.ToInt32(Console.ReadLine());

    int factorial = 1;

    if (num < 0)
    {
        Console.WriteLine("El numero es negativo.");
    }
    else
    {
        for (int i = 1; i <= num; i++)
        {
            factorial = factorial * i;
        }
        Console.WriteLine("El factorial de " + num + " es " + factorial);
    }
}
Ejercicio2();

void Ejercicio3()
{
    Console.WriteLine("Ingrese un numero");
    int num = Convert.ToInt32(Console.ReadLine());

    int a = 0;
    int b = 1;
    int c;

    for (int i = 0; i < num; i++)
    {
        Console.WriteLine(a);

        if (b > num)
        {
            break;
        }

        c = a;
        a = b;
        b = c + a;
    }
}
Ejercicio3();

void Ejercicio4()
{
    int opcion = 0;

    while (opcion != 3)
    {
        Console.WriteLine("Seleccione 1 para hola, dos para chau y 3 para finalizar el programa");
        opcion = Convert.ToInt32(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.WriteLine("hola");
                break;

            case 2:
                Console.WriteLine("chau");
                break;

            case 3:
                break;


        }
    }
}
Ejercicio4();
