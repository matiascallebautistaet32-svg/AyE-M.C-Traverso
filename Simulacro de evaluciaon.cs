    Console.WriteLine  ("Ingrese su nombre");
    string nombre = Console.ReadLine();

    Console.WriteLine  ("Ingrese su promedio");
    double prom = (Convert.ToDouble(Console.ReadLine()));

    Console.WriteLine  ("Ingrese su distancia de su casa hasta la universidad (en Km)");
    int dist = (Convert.ToInt32(Console.ReadLine()));

    bool determinabeca(double prom, int dist)
{
    if (prom >= 8.5 || dist > 50)
    {
        return true;
    }
    else
    {
        return false;
    }
}
    bool resultado = determinabeca(prom, dist);

     if (resultado == true)
    {
        Console.Write("¡Felcidades! ");
        Console.Write(nombre);
        Console.Write(", ");
        Console.Write("tu beca a sido aprobado");
    }
    else
    {
     Console.WriteLine("Lo sentimos, no cumples con los requisitos minimos");
    }

