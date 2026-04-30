void ejercicio1()
{
    int num;
    bool seguimos = true;
    Console.WriteLine("Ingresa 0 o 1: ");
    while (seguimos)
    {
        num = Convert.ToInt32(Console.ReadLine());

        if (num == 0 || num == 1)
        {
            seguimos = false;
        }
        else if(num != 0 || num !=1)
        {
            Console.WriteLine("Ingreselo denuevo: ");
        }
    }
}
ejercicio1();


void ejercicio2()
{
    int num;
    bool seguimos = true;

    while (seguimos)
    {
        Console.WriteLine("Ingrese un numero de dos cifras: ");
        num = Convert.ToInt32(Console.ReadLine());

        if (num >= 10 && num <= 99)
        {

            seguimos = false;

        }
        else if (num < 10 || num > 99)
        { 
            Console.WriteLine("Ingreselo denuevo: ");
        }
    }
}
ejercicio2();