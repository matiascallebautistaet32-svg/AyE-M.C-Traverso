void ejercicio1()
{
    string contra = "hola123";

    Console.WriteLine("Ingrese la contraseña :");

    string adivinar = Console.ReadLine();

    while (adivinar != contra)

    {
        Console.WriteLine("Intentalo denuevo");
        adivinar= Console.ReadLine();

    }
    
    Console.WriteLine("entrando");
}
ejercicio1();


void ejercicio2()
{
    int contador = 5;
    
    while (contador > 0)

    {
        Console.WriteLine(contador);
        contador--;
    }
    
    Console.WriteLine("¡Listo para despegar!");
    Console.WriteLine("¡Despegue!");
}
ejercicio2();

void ejercicio3()
{
    int secret = 7;

    Console.WriteLine("Adivina el numero del 1-10");

    int adivinar = Convert.ToInt32(Console.ReadLine());

    while (adivinar != secret)

    {
        Console.WriteLine("Incorrecto, tira otro numero");
        adivinar = Convert.ToInt32(Console.ReadLine());
    }
    
    Console.WriteLine("¡Felicidades! Adivinaste el numero");

}
ejercicio3();

void ejercicio4()
{
    int num = 1;

    int suma = 0;

    while (num != 0)

    {
        Console.WriteLine("Ingrese un numero ");
        num = Convert.ToInt32(Console.ReadLine());

        suma = suma + num;
    }
    Console.WriteLine("La suma total de los numeros ingresados es " + suma);
}
ejercicio4();


