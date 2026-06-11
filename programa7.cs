void Programa7()
{
    char[,] matriz =
    {
        { '1', '2', '3' },
        { '4', '5', '6' },
        { '7', '8', '9' }
    };

    char jugadoract = 'X';
    int turnos = 0;
    bool juegoactivo = true;

    void DibujarTablero()
    {
        Console.Clear();
        for (int f = 0; f < 3; f++)
        {
            Console.WriteLine($" {matriz[f, 0]} {matriz[f, 1]} {matriz[f, 2]} ");
        }
        Console.WriteLine();
    }

    void PedirMovimiento()
    {
        bool movimientoValido = false;

        while (!movimientoValido)
        {
            Console.WriteLine($"Turno de la {jugadoract}: Elija una casilla del 1 al 9");
            string entrada = Console.ReadLine();

            if (int.TryParse(entrada, out int casilla) && casilla >= 1 && casilla <= 9)
            {
                int fila = (casilla - 1) / 3;
                int columna = (casilla - 1) % 3;

                int valorCelda = matriz[fila, columna] - '0';
                if (valorCelda >= 1 && valorCelda <= 9)
                {
                    matriz[fila, columna] = jugadoract;
                    movimientoValido = true;
                }
                else
                {
                    Console.WriteLine("Casilla ocupada intente de nuevo");
                }
            }
            else
            {
                Console.WriteLine("Numero no valido, intente de nuevo");
            }
        }
    }

    bool VerificarGanador()
    {
        for (int i = 0; i < 3; i++)
        {
            if (matriz[i, 0] == jugadoract && matriz[i, 1] == jugadoract && matriz[i, 2] == jugadoract)
                return true;

            if (matriz[0, i] == jugadoract && matriz[1, i] == jugadoract && matriz[2, i] == jugadoract)
                return true;
        }

        if (matriz[0, 0] == jugadoract && matriz[1, 1] == jugadoract && matriz[2, 2] == jugadoract) return true;
        if (matriz[0, 2] == jugadoract && matriz[1, 1] == jugadoract && matriz[2, 0] == jugadoract) return true;

        return false;
    }

    while (juegoactivo)
    {
        DibujarTablero();
        PedirMovimiento();
        turnos++;

        if (VerificarGanador())
        {
            DibujarTablero();
            Console.WriteLine($"La {jugadoract} ha ganado");
            juegoactivo = false;
        }
        else if (turnos == 9)
        {
            DibujarTablero();
            Console.WriteLine("Empate");
            juegoactivo = false;
        }
        else
        {
            jugadoract = (jugadoract == 'X') ? 'O' : 'X';
        }
    }
}
Programa7();
