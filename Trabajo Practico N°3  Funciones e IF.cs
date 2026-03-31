
string Ejercicio1(int n){

   string resultado;
    if (n > 0)
    {
        resultado = ("Positivo");
        return resultado;
    }
    else if (n == 0) {

        resultado = ("Es 0");
        return resultado;
    }
    else {

        resultado = ("Negativo");
        return resultado;
    }
}

Console.WriteLine(Ejercicio1(Convert.ToInt32(Console.ReadLine())));


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

Console.WriteLine(Ejercicio2(Convert.ToInt32(Console.ReadLine())));


string Ejercicio3(string contra){

    string resultado;

    if (contra == "phyton123" )
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

Console.WriteLine(Ejercicio3(Console.ReadLine()));


string Ejercicio4(int numpoip){

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


Console.WriteLine(Ejercicio4(Convert.ToInt32(Console.ReadLine())));


string Ejercicio5(int edad) {

    Console.WriteLine("¿Usted compro palomitas?");
    string palomitas = Console.ReadLine();


    string resultado;

    if (edad >= 65 && palomitas == "si" )
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

Console.WriteLine(Ejercicio5(Convert.ToInt32(Console.ReadLine())));

