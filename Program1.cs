namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 34, 12, 45, 7, 21, 49, 3, 18, 30, 26, 8, 41, 15, 33, 50, 2, 29, 11, 47, 5, 22, 37, 14, 46, 1, 39, 9, 24, 43, 17, 31, 10, 48, 4, 28, 35, 19, 44, 13, 40, 25, 6, 38, 23, 42, 16, 32, 27, 20, 36 };

            // Búsqueda secuencial simple.
            Console.WriteLine("Ingrese un numero a buscar:");
            int buscar = Convert.ToInt32(Console.ReadLine());

            int valor = Busqueda_Secuencial_Simple(numeros, buscar);

            if (valor != -1)
            {
                Console.WriteLine($"Se encontro el número en la posicion: {valor}");
            }
            else
            {
                Console.WriteLine("No se encontro el numero");
            }

            // Búsqueda secuencial optimizada (corte temprano).
            Console.WriteLine("Ingrese un numero a buscar:");
            int buscar1 = Convert.ToInt32(Console.ReadLine());

            int valor1 = Busqueda_Secuencial_Optimizada(numeros, buscar);

            if (valor != -1)
            {
                Console.WriteLine($"Se encontro el número en la posicion: {valor}");
            }
            else
            {
                Console.WriteLine("No se encontro el numero");
            }



            // Búsqueda binaria (iterativa y recursiva).
            Console.WriteLine("Ingrese un numero a buscar:");
            int buscar2 = Convert.ToInt32(Console.ReadLine());

            int valorIterativo = Busqueda_Binaria_Iterativa(numeros, buscar);

            int valorRecursivo = Busqueda_Binaria_Recursiva(numeros, buscar, 0, numeros.Length - 1);

            if (valorIterativo != -1)
            {
                Console.WriteLine($"[Iterativa] Se encontro el número en la posicion ordenada: {valorIterativo}");
                Console.WriteLine($"[Recursiva] Se encontro el número en la posicion ordenada: {valorRecursivo}");
            }
            else
            {
                Console.WriteLine("No se encontro el numero");
            }
        }

















       
        //La busqueda secuencial no tiene condiciciones: el arreglo puede estar completamente desordenado porque el algoritmo revisa los elementos uno por uno.
        static int Busqueda_Secuencial_Simple(int[] numeros, int buscar)
        {
            for (int x = 0; x < numeros.Length; x++)
            {
                if (numeros[x] == buscar)
                {
                    return x; 
                }
            }
            return -1; 
        }
        // La busqueda secuencial optimizada usa break para detener el ciclo inmediatamente (corte temprano) cuando encuentra el elemento, evitando revisar el resto del arreglo.
        static int Busqueda_Secuencial_Optimizada(int[] numeros, int buscar)
        {
            int posicion = -1;

            for (int x = 0; x < numeros.Length; x++)
            {
                if (numeros[x] == buscar)
                {
                    posicion = x; 
                    break;        
                }
            }

            return posicion; 
        }


        // La busqueda binaria iterativa utiliza un ciclo while para dividir el arreglo a la mitad sucesivamente.
        static int Busqueda_Binaria_Iterativa(int[] numeros, int buscar)
        {
            int izquierda = 0;
            int derecha = numeros.Length - 1;

            while (izquierda <= derecha)
            {
                int medio = izquierda + (derecha - izquierda) / 2;

              
                if (numeros[medio] == buscar)
                    return medio;

          
                if (numeros[medio] < buscar)
                    izquierda = medio + 1;
               
                else
                    derecha = medio - 1;
            }

            return -1; // 
        }

        // Busqueda binaria recursiva: La funcion se llama a si misma con nuevos limites hasta encontrar el valor.
        static int Busqueda_Binaria_Recursiva(int[] numeros, int buscar, int izq, int der)
        {
           
            if (izq > der)
                return -1;

            int med = izq + (der - izq) / 2;

            if (numeros[med] == buscar)
                return med;

            if (numeros[med] < buscar)
                return Busqueda_Binaria_Recursiva(numeros, buscar, med + 1, der);

            return Busqueda_Binaria_Recursiva(numeros, buscar, izq, med - 1);
        }





















    }
}
        