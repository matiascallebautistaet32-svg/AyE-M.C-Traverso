Console.WriteLine("Ingrese el codigo de su categoria");
string codigo = Console.ReadLine();
string resultado = ejercicio1(codigo);
Console.WriteLine(resultado);
string ejercicio1(string codigom)
{
    codigom = codigo.ToUpper();

    switch (codigom)
    {
        case "I":
            Console.WriteLine("Su categoria es infantil y su cuota es de 800");
        break;

        case "C":
            Console.WriteLine("Su categoria es cadete y su cuota es de $1000");
        break;

        case "J":
            Console.WriteLine("Su categoria es juvenil y su cuota es de $1200");
        break;

        case "A":
            Console.WriteLine("Su categoria es adulto y su cuota es de $900");
        break;

        default:
            Console.WriteLine("El codigo ingresado no es valido");
        break;
         
    }
    return codigom;
}


string ejercicio2(string tipo,string destino)
{
    Console.WriteLine("Ingrese el tipo de la encomienda");
    tipo = Console.ReadLine();

    Console.WriteLine("Ingrese el destino de la encomienda");
    destino = Console.ReadLine();

    if()





}