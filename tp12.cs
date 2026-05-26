void ejercicio1()
{
    string[] nombre = { "Lauti", "Luismi", "Fidel", "Hernandez", "Curima", "Ronaldo", "Messi", "Modric", "Lunita", "Andres" };

    string palabramas = "";

    foreach (string U in nombre)
    {
        if (U.Length > palabramas.Length)
        {
            palabramas = U;
        }
    }
    Console.WriteLine("La palabra con mas letras de la lista es: " + palabramas);
}
ejercicio1();

Console.WriteLine("");
void ejercicio2()
{
    int vocales1 = 0;

    string[] nombre = { "Lauti", "Luismi", "Fidel", "Hernandez", "Curima", "Ronaldo", "Messi", "Modric", "Lunita", "Andres" };

    string vocales = "aeiouAEIOU";

    foreach (string U in nombre)
    {
        foreach (char Y in U)
        {
            foreach (char E in vocales)
            {
                if (E == Y)
                {
                    vocales1++;
                }
            }
        }
    }
    Console.WriteLine($"La cantidad de vocales es: {vocales1}");
}
ejercicio2();

Console.WriteLine("");

try
{
    void ejercicio3()
    {
        int factor = 3;

        int[] num = new int[3];

        int[] result = new int[3];

        for (int i = 0; i < num.Length; i++)
        {
            Console.WriteLine($"Ingrese el numero {i + 1}");

            num[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Los numeros multiplicados por 3 son: ");

        for (int x = 0; x < num.Length; x++)
        {
            result[x] = num[x] * factor;
            Console.WriteLine(result[x]);
        }
    }
    ejercicio3();
}
catch (System.FormatException)
{
    Console.WriteLine("No ponga letras");
}


