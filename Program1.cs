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


 // La busqueda binaria iterativa es la mas eficiente porque divide los datos a la mitad en cada paso.
 // Esto permite encontrar un elemento entre un millon de registros en un maximo de veinte intentos, mientras que los metodos secuenciales pueden usar un millon de operaciones.
 // Al ejecutarse mediante un bucle simple, ahorra mas memoria que la recursiva, teniendo como unico requisito que la lista este previamente ordenada.
 // Pero el resultado final de cual es la mas eficiente se define en:
 // Si tus datos ya estan ordenados en memoria ram, la busqueda binaria iterativa es la mejor opcion.
 // Si tus datos estan desordenados una busqueda secuencial optimizada suele ser mas eficiente





 // BURBUJA CLÁSICO
            // Explicación: Compara números que están juntos y los intercambia si están desordenados.
            // Condición: No necesita ninguna condición especial.
            // Complejidad algorítmica: O(n²).
            void Burbuja_clasico(int[] NumerosDesordenados)
            {
                // FOR ANIDADO QUE SIRVE PARA ORDENAR LA LISTA
                for (int j = 0; j < NumerosDesordenados.Length - 1; j++)
                {
                    for (int i = 0; i < NumerosDesordenados.Length - 1; i++)
                    {
                        if (NumerosDesordenados[i] > NumerosDesordenados[i + 1])
                        {
                            // CREO UN AUXILIAR YA QUE SI AL ASIGNARLE NUMEROSDESORDENADOS[I] A NUMEROSDESORDENADOS[I+1], TENDRIA 
                            // EL MISMO VALOR YA QUE ANTES HICE NumerosDesordenados[i] = NumerosDesordenados[i + 1];
                            int Aux = NumerosDesordenados[i];
                            NumerosDesordenados[i] = NumerosDesordenados[i + 1];
                            NumerosDesordenados[i + 1] = Aux;
                        }
                    }
                }
                // OTRO FOR QUE IMPRIME LA LISTA YA ORDENADA EN LA CONSOLA
                for (int x = 0; x < NumerosDesordenados.Length; x++)
                {
                    Console.WriteLine(NumerosDesordenados[x]);
                }
            }
            // BURBUJA OPTIMIZADO
            // Explicación: Funciona como la burbuja clásica, pero deja de ordenar
            // cuando detecta que ya no hubo ningún intercambio.
            // Condición: No necesita ninguna condición especial.
            // Complejidad algorítmica: O(n²) en el peor caso.
            void Burbuja_optimizado(int[] NumerosDesordenados)
            {
                // FOR ANIDADO QUE SIRVE PARA ORDENAR LA LISTA
                for (int j = 0; j < NumerosDesordenados.Length - 1; j++)
                {
                    // CREO UNA VARIABLE BOOLEANA LLAMADA ESTA DESORDENADA, LA CUAL EN CADA PASADA VA A VERIFICAR SI HUBO UN INTERCAMBIO
                    // SI HUBO UN INTERCAMBIO PASA A TRUE, SI NO SE QUEDA EN FALSE. AL FINAL DEL FOR, VERIFICA SI ESTAORDENADA ES FALSE, EN ESE CASO
                    // ROMPE EL FOR YA QUE SIGNIFICA QUE ESTA TODO ORDENADO
                    bool EstaDesordenado = false;
                    for (int i = 0; i < NumerosDesordenados.Length - 1; i++)
                    {
                        if (NumerosDesordenados[i] > NumerosDesordenados[i + 1])
                        {
                            // CREO UN AUXILIAR YA QUE SI AL ASIGNARLE NUMEROSDESORDENADOS[I] A NUMEROSDESORDENADOS[I+1], TENDRIA 
                            // EL MISMO VALOR YA QUE ANTES HICE NumerosDesordenados[i] = NumerosDesordenados[i + 1];
                            int Aux = NumerosDesordenados[i];
                            NumerosDesordenados[i] = NumerosDesordenados[i + 1];
                            NumerosDesordenados[i + 1] = Aux;
                            EstaDesordenado = true;
                        }
                    }
                    if (EstaDesordenado == false)
                    {
                        break;
                    }
                }
                // OTRO FOR QUE IMPRIME LA LISTA YA ORDENADA EN LA CONSOLA
                for (int x = 0; x < NumerosDesordenados.Length; x++)
                {
                    Console.WriteLine(NumerosDesordenados[x]);
                }

            }
            // SELECCIÓN
            // Explicación: Busca el número menor y lo coloca en la primera posición disponible.
            // Condición: No necesita que la lista esté ordenada.
            // Complejidad algorítmica: O(n²).
            void Seleccion(int[] NumerosDesordenados)
            {
                int[] numeros = { 5, 2, 8, 1, 3 };

                for (int i = 0; i < numeros.Length - 1; i++)
                {
                    int menor = i;

                    for (int j = i + 1; j < numeros.Length; j++)
                    {
                        if (numeros[j] < numeros[menor])
                        {
                            menor = j;
                        }
                    }

                    int aux = numeros[i];
                    numeros[i] = numeros[menor];
                    numeros[menor] = aux;
                }

                foreach (int numero in numeros)
                {
                    Console.WriteLine(numero);
                }

            }
            // INSERCIÓN
            // Explicación: Va tomando cada elemento y lo coloca en la posición correcta
            // dentro de la parte que ya está ordenada.
            // Condición: No necesita que la lista esté ordenada.
            // Complejidad algorítmica: O(n²) en el peor caso.
            void Insercion(int[] NumerosDesordenados)
            {
                for (int i = 1; i < NumerosDesordenados.Length - 1; i++)
                {
                    int Auxiliar = NumerosDesordenados[i]; // 7
                    for (int j = i; j >= 0; j--) // primera vuelta: j vale 1
                    {
                        if (Auxiliar > NumerosDesordenados[j])// 7 es mayor que 7?
                        {
                            NumerosDesordenados[j + 1] = NumerosDesordenados[j];
                        }
                        else if (Auxiliar < NumerosDesordenados[j] || NumerosDesordenados[j] == NumerosDesordenados[0])// va aca
                        {
                            NumerosDesordenados[j] = Auxiliar;
                            break;
                        }

                    }
                }
                for (int x = 0; x < NumerosDesordenados.Length - 1; x++)
                {
                    Console.WriteLine(NumerosDesordenados[x]);
                }
            }
            // QUICKSORT
            // Explicación: Elige un elemento llamado pivote y separa los números
            // en menores y mayores que él.
            // Condición: No necesita que la lista esté ordenada.
            // Complejidad algorítmica: O(n log n) en promedio.
            void QuickSort(int[] numeros, int inicio, int fin)
            {
                if (inicio >= fin)
                    return;

                int i = inicio;
                int j = fin;
                int pivote = numeros[(inicio + fin) / 2];

                while (i <= j)
                {
                    while (numeros[i] < pivote)
                        i++;

                    while (numeros[j] > pivote)
                        j--;

                    if (i <= j)
                    {
                        int aux = numeros[i];
                        numeros[i] = numeros[j];
                        numeros[j] = aux;

                        i++;
                        j--;
                    }
                }

                QuickSort(numeros, inicio, j);
                QuickSort(numeros, i, fin);
            }
            // BOGOSORT
            // Explicación: Mezcla los números al azar hasta que quedan ordenados.
            // Condición: No necesita que la lista esté ordenada.
            // Complejidad algorítmica: O(n × n!) aproximadamente.
            void Bogosort(int[] NumerosDesordenados)
            {
                Random random = new Random();

                while (true)
                {
                    // Mezclar
                    for (int i = 0; i < NumerosDesordenados.Length; i++)
                    {
                        int j = random.Next(NumerosDesordenados.Length);

                        int aux = NumerosDesordenados[i];
                        NumerosDesordenados[i] = NumerosDesordenados[j];
                        NumerosDesordenados[j] = aux;
                    }

                    // Comprobar si está ordenado
                    bool ordenado = true;

                    for (int i = 0; i < NumerosDesordenados.Length - 1; i++)
                    {
                        if (NumerosDesordenados[i] > NumerosDesordenados[i + 1])
                        {
                            ordenado = false;
                            break;
                        }
                    }

                    if (ordenado)
                        break;
                }
            }
            // STALINSORT
            // Explicación: Recorre la lista y elimina los elementos que están
            // fuera de orden respecto al anterior.
            // Condición: La lista puede estar desordenada.
            // Complejidad algorítmica: O(n).
            void Stalin(int[] numeros)
            {

                int anterior = numeros[0];

                for (int i = 1; i < numeros.Length; i++)
                {
                    if (numeros[i] >= anterior)
                    {
                        anterior = numeros[i];
                        Console.WriteLine(numeros[i]);
                    }
                }
            }
            // La búsqueda binaria, porque en cada paso descarta aproximadamente
            // la mitad de la lista. Su complejidad es O(log n).
            // De los ordenamientos que usamos, QuickSort suele ser el más eficiente
            // en promedio, con una complejidad de O(n log n).
            // Es una forma de medir cuánto tiempo o recursos necesita un algoritmo
            // a medida que aumenta la cantidad de elementos que tiene que procesar.
        }
    }
}
