void ejercicio1()
{
    int[,] matriz = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

    for (int f = 0; f < 3; f++)
    {
        for (int c = 0; c < 3; c++)
        {
            Console.Write(matriz[f, c] + " ");
        }
        Console.WriteLine();
    }
}
ejercicio1();

void ejercicio2()
{

    int[,] matriz = { { 10, 15, 20 }, { 25, 30, 35 }, { 40, 45, 50 } };
    int suma = 0;
   
    for (int f = 0; f < 3; f++)
    {
        for (int c = 0; c < 3; c++)
        {

           suma = suma + matriz[f, c];

        }
        Console.WriteLine();

    }
    Console.WriteLine("La suma de todos los numeros es: " + suma);
}
ejercicio2();


void ejercicio3()
{

    int[,] matriz = { { 10, 15, 20 }, { 25, 30, 35 }, { 40, 45, 50 } };

    Console.WriteLine("Ingrese el numero de la fila");
    int fila = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese el numero de la columna");
    int columna = int.Parse(Console.ReadLine());


    if(fila >= 0 && fila < 4 && columna >= 0 && columna < 4 )
    {
        Console.WriteLine($"El elemento en la cordenada {fila},{columna} es : {matriz[fila, columna]}");
    }
    else
    {
        Console.WriteLine("Cordenadas no validas");
    }
}
ejercicio3();