void ejercicio1()
{
 for (int num = 1; num <= 10; num++)
 {
   Console.WriteLine(num);
 }
}
ejercicio1();



void ejercicio2()
{
 for (int num = 1; num <= 5; num++)
 {
   Console.WriteLine("¡Hola, Mundo!");
 }
}
ejercicio2();


void ejercicio3()
{
    for (int num = 2; num <= 21; num += 2) 
    {
        Console.WriteLine(num);
    }

}
ejercicio3();


void ejercicio4()
{
    for(int num =7; num <= 70; num += 7)
    {
        Console.WriteLine(num);
    }
}
ejercicio4();


void ejercicio5()
{
    int acumsuma = 0;
    for (int num = 1; num <= 5; num += 1)
    {
        Console.WriteLine(acumsuma += num);
    } 
}

ejercicio5();