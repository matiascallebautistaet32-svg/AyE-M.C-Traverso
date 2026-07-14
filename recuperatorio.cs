bool seguir = true;
int horastrabajadas = 0;

Console.WriteLine("Ingrese las horas que trabaja");

while (seguir)
{
    try
    {
        horastrabajadas = Convert.ToInt32(Console.ReadLine());
        seguir = false;
    }
    catch (FormatException)
    {
        Console.WriteLine("Ingreso no valido, intente de nuevo");
    }
    catch (OverflowException)
    {
        Console.WriteLine("Numero muy grande, intente de nuevo");
    }
}
int salariosem(int horastrabajadas)
{
    int salario = 0;
    int horasextra = 0;

    if (horastrabajadas <= 40)
    {
        salario = horastrabajadas * 16;
    }
    else
    {
        horasextra = horastrabajadas - 40;
        salario = (horastrabajadas * 16) + (horasextra * 20);
    }
    return salario;
}
int salariototal = salariosem(horastrabajadas);
Console.WriteLine($"El salario semanal es de: {salariototal}");

int ejercicio2()
{
    bool seguir = true;
    int num = 0;
    int sum = 0;

    Console.WriteLine("Ingrese numeros");

    while(seguir)
    {
        try
        {
            num = Convert.ToInt32(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("Ingreso no valido, intente de nuevo");
        }
        catch(OverflowException)
        {
            Console.WriteLine("Numero muy grande, intente de nuevo");
        }

        if(num == 0)
        {
            seguir = false;
        }
        else
        {
            sum = sum + num;
        }
    }
    return sum;
}
int sumatotal = ejercicio2();
Console.WriteLine("La suma de todos los numeros es: " + sumatotal);

int ejercicio3()
{
    Console.WriteLine("Ingrese una palabra");
    string palabra = Console.ReadLine();
    string vocales = ("AEIOUaeiou");
    int cont = 0;

    foreach(char p in palabra)
    {
        foreach(char v in vocales)
        {
            if(p == v)
            {
                cont++;
            }
        }
    }
    return cont;
}
int vocalestotales = ejercicio3();
Console.WriteLine("La cantidad de vocales son: " + vocalestotales);


string palindromo = ejercicio4();
string ejercicio4()
{
    bool seguir = true;
    string palabra = "";
    string palabrainvert = "";

    Console.WriteLine("Ingrese una palabra");

    while (seguir)
    {
        palabra = Console.ReadLine();

        for (int i = palabra.Length - 1; i >= 0; i--)
        {
            palabrainvert += palabra[i];
        }

        if (palabra == palabrainvert)
        {
            Console.WriteLine($"La palabra {palabra} es un palindromo");
            seguir = false;
            break;
        }
        else
        {
            Console.WriteLine($"La palabra {palabra} no es un palindromo, intente con otra palabra");
        }
    }
    return palabrainvert;
}
