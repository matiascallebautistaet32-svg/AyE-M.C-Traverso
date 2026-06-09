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

void ejercicio4()
{

    int[,] matriz = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };
    int acum = 2;

    for (int i = 0; i < 4; i++)
    {
        for (int x = 0;x < 4; x++)
        {
           
            if (matriz[x,i] > acum)
            {
                acum = matriz[x, i];
            }
        }

    }
    Console.WriteLine("El numero mas grande es: " + acum);
}
ejercicio4();
void ejercicio5()
{
    int[,] matriz = {
        { 1, 2, 3, 4 }, 
        { 5, 6, 7, 8 }, 
        { 9, 10, 11, 12 }, 
        { 13, 14, 15, 16 } };
    int sumafila = 0;
    int sumafila2 = 0;
    int sumafila3 = 0;
    int sumafila4 = 0;
    int sumacolumna = 0;
    int sumacolumna2 = 0;
    int sumacolumna3 = 0;
    int sumacolumna4 = 0;
    for (int i = 0; i < 4; i++)
    {
    sumacolumna += matriz[i, 0];
    sumacolumna2 += matriz[i, 1];
    sumacolumna3 += matriz[i, 2];
    sumacolumna4 += matriz[ i,3];
       
    sumafila += matriz[0, i];
    sumafila2 += matriz[1, i];
    sumafila3 += matriz[2, i];
    sumafila4 += matriz[3, i];
        
    }
    Console.WriteLine("La suma de la primera columna es de: " + sumacolumna);
    Console.WriteLine("La suma de la segunda columna es de: " + sumacolumna2);
    Console.WriteLine("La suma de la tercer columna es de: " + sumacolumna3);
    Console.WriteLine("La suma de la cuarta columna es de: " + sumacolumna4);
    Console.WriteLine("La suma de la primer fila es de: " + sumafila);
    Console.WriteLine("La suma de la segunda fila es de: " + sumafila2);
    Console.WriteLine("La suma de la tercer fila es de: " + sumafila3);
    Console.WriteLine("La suma de la cuarta fila es de: " + sumafila4);
}
ejercicio5();
void ejercicio6()
{
    int[,] matriz = {
        { 1, 2, 3, 4 },
        { 5, 6, 7, 8 },
        { 9, 10, 11, 12 },
        { 13, 14, 15, 16 } };
    int[,] matrizaux = new int[4, 4];
    for (int i = 0; i < 4; i++)
    {
        for (int x = 0; x < 4; x++)
        {
            matrizaux[i,x] = matriz[x, i];
     
        }
    }
    for (int i = 0; i < 4; i++)
    {
        for (int x = 0; x < 4; x++)
        {

            Console.Write(matrizaux[i, x]);

        }
        Console.WriteLine();

    }
}
ejercicio6();

void ejercicio7()
{
    int[,] matriz = {
        {1, 5, 3, 5 },
   { 8, 5, 9, 2},
   { 4, 5, 6, 7} };
    Console.WriteLine("Ingrese un numero y le digo cuantas veces aparece en la matriz");
    int eleccion = int.Parse(Console.ReadLine());
    int acum = 0;
    for (int i = 0; i < 3; i++)
    {
        for (int x = 0; x<4; x++)
        {
            if (eleccion == matriz[i, x])
            {
                acum++;
            }
        }
    }
    Console.WriteLine("La cantidad de veces que aparece ese numero es: " + acum);
}
ejercicio7();
