Console.WriteLine("1=Numero positivo  2=Mayor de edad  3=Contrasena secreta  4=Par o Impar  5= Entrada gratis");
    string Ejercicio1(int n)
    {

        string resultado;
        if (n > 0)
        {
            resultado = ("Positivo");
            return resultado;
        }
        else if (n == 0)
        {

            resultado = ("Es 0");
            return resultado;
        }
        else
        {

            resultado = ("Negativo");
            return resultado;
        }
    }

    string Ejercicio2(int edad)
    {

        string resultado;

        if (edad >= 18)
        {
            resultado = ("¡Bienvenido a la fiesta!");
            return resultado;
        }
        else
        {
            resultado = ("Lo siento, eres muy joven");
            return resultado;
        }

    }

    string Ejercicio3(string contra)
    {

        string resultado;

        if (contra == "phyton123")
        {
            resultado = ("¡Contraseña correcta! Acceso accedido");
            return resultado;
        }

        else
        {
            resultado = ("¡Contraseña incorrecta, Autodestruccion en 5 minutos!");
            return resultado;
        }
    }

    string Ejercicio4(int numpoip)
    {

        string resultado;

        if (numpoip % 2 == 0)
        {
            resultado = ("El numero es par");
            return resultado;
        }

        else
        {
            resultado = ("El numero es impar");
            return resultado;
        }
    }

    string Ejercicio5(int edad)
    {

        Console.WriteLine("¿Usted compro palomitas?");
        string palomitas = Console.ReadLine();


        string resultado;

        if (edad >= 65 && palomitas == "si")
        {
            resultado = ("¡Felicidades!Tienes entrada gratuita al cine");
            return resultado;
        }
        else
        {
            resultado = ("Compra la entrada o raja de aca");
            return resultado;
        }
    }


    Console.WriteLine("Ingrese un numero");
    int num = Convert.ToInt16(Console.ReadLine());

    switch (num)
    {
        case 1:
            Console.WriteLine("Ingrese un numero y yo te dire si es par o no");
            Console.WriteLine(Ejercicio1(Convert.ToInt32(Console.ReadLine())));
            break;

        case 2:
            Console.WriteLine("Ingrese su edad para ingresar a la fiesta");
            Console.WriteLine(Ejercicio2(Convert.ToInt32(Console.ReadLine())));
            break;

        case 3:
            Console.WriteLine("Ingrese la contrasea correcta");
            Console.WriteLine(Ejercicio3(Console.ReadLine()));
            break;

        case 4:
            Console.WriteLine("Ingrese un numero y yo te dire si es par o impar");
            Console.WriteLine(Ejercicio4(Convert.ToInt32(Console.ReadLine())));
            break;

        case 5:
            Console.WriteLine("Ingrese su edad e ingrese si usted a comprado palomitas");
            Console.WriteLine(Ejercicio5(Convert.ToInt32(Console.ReadLine())));
            break;

        case 0:
        break;
    }
