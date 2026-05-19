bool recursiva(int n)
{

    if (n == 0)
    {

        return false;
    }
    else
    {
        recursiva(n - 1);
        Console.WriteLine(n);
        return true;
    }

}
recursiva(10);

Console.WriteLine("");

bool recursiva2(int n)
{

    if (n == 0)
    {

        return false;
    }
    else
    {

        Console.WriteLine("¡Hola mundo!");
        recursiva2(n - 1);
        return true;
    }
}
recursiva2(5);

Console.WriteLine("");

bool recursiva3(int n)
{

    if (n > 20)
    {

        return false;
    }
    else
    {

        Console.WriteLine(n);
        recursiva3(n + 2);
        return true;
    }
}
recursiva3(2);

Console.WriteLine("");
bool recursiva4(int n)
{
    if (n > 70)
    {
        return false;
    }
    else
    {
        Console.WriteLine(n);
        recursiva4(n + 7);
        return true;
    }
}

recursiva4(7);
int aux = 0;

Console.WriteLine("");
int recursiva5(int n)
{
    if (n == 0)
    {
        return aux;
    }
    else
    {
        aux = aux + n;
        recursiva5(n - 1);
        return aux;
    }
}

aux = recursiva5(5);
Console.WriteLine(aux);

Console.WriteLine("");
string recursiva6(string contra2)
{
    string contra = "lm221";

    if (contra == contra2)
    {
        Console.WriteLine("La contraseña es correcta");
        return contra2;
    }
    else
    {
        Console.WriteLine("Intentelo de nuevo");
        recursiva6(Console.ReadLine());
        return contra2;

    }
}
recursiva6(Console.ReadLine());

Console.WriteLine("");
int recursiva7(int x)
{
    if (x == 0)
    {
        Console.WriteLine("Listos para despegar");
        Console.WriteLine("Despegue");
        return x;
    }
    else
    {
        x = x - 1;
        Console.WriteLine(x);
        recursiva7(x);
        return x;
    }
}
recursiva7(6);

Console.WriteLine("");
int recursiva8(int secreto)
{
    Console.WriteLine("Adivine el numero");
    int adivinar = Convert.ToInt32(Console.ReadLine());
    if (adivinar == secreto)
    {
        Console.WriteLine("¡Felicidades! Adivinaste el numero");
        return secreto;
    }
    else
    {
        Console.WriteLine("intentelo de nuevo");
        recursiva8(secreto);
        return secreto;
    }
}
recursiva8(7);
int acum = 0;

Console.WriteLine("");
int recursiva9()
{
    Console.WriteLine("Ingrese un numero");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num == 0)
    {
        Console.WriteLine("La suma de los numeros ingresados es de: " + acum);
        return acum;
    }
    else
    {
        acum = acum + num;
        Console.WriteLine("Ingrese otro numero");
        recursiva9();
    }
    return acum;

}
recursiva9();
