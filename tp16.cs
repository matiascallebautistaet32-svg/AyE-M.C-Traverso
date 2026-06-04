void ejercicio1()
{
    int[,] matriz = { { 45, 14, 33, 12 }, { 41, 54, 43, 12 }, { 91, 13, 92, 11 }, { 23, 12, 77, 67} };
    int sumamatriz = 0;

    for (int f = 0; f < 4; f++)
    {
        for (int c = 0; c < 4; c++)
        {
            Console.Write(matriz[f, c] + " ");
        }
        Console.WriteLine();
    }

    sumamatriz = matriz[0, 0] + matriz[0, 3] + matriz[3, 0] + matriz[3, 3];

    Console.WriteLine("La suma de las esquinas de las matrices es: " + sumamatriz);

}
ejercicio1();

void ejercicio2()
{
    int[,] matriz = { { 45, 14, 33 }, { 41, 54, 43 }, { 91, 13, 92 } };
    int sumamatriz = 0;
    int diagonalprin = 0;
    int diagonalsecu = 0;
    int n = 3;

    for (int f = 0; f < 3; f++)
    {
        for (int c = 0; c < 3; c++)
        {
            Console.Write(matriz[f, c] + " ");
        }
        Console.WriteLine();
    }

    for(int i = 0; i < n; i++)
    {
        diagonalprin += matriz[i, i];
        diagonalsecu += matriz[i, n - 1 - i];
    }
    Console.WriteLine("La suma de la diagonal principal es:" + diagonalprin);
    Console.WriteLine("La suma de la diagonal secundaria es:" + diagonalsecu);

}
ejercicio2();

void ejercicio3()
{
 Console.Write("Ingrese el tamaño de la matriz: ");
 int n = int.Parse(Console.ReadLine());

 int[,] matriz = new int[n, n];

 for (int i = 0; i < n; i++)
 {
  for (int x = 0; x < n; x++)
  {
   if (i == x)
   {
    matriz[i, x] = 1;
   }
   else
   {
    matriz[i, x] = 0;
   }
  }
 }
 Console.WriteLine("Resultado:");
 for (int i = 0; i < n; i++)
 {
  for (int x= 0; x < n; x++)
  {
            Console.Write(matriz[i, x] + " ");
  }
  Console.WriteLine();
 }
}
ejercicio3();