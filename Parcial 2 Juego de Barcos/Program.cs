using System;
using System.ComponentModel.Design.Serialization;
using System.Security.Cryptography;

int[,] tablero = new int[8, 8];

Console.WriteLine("HOLA BIENVENIDOS AL JUEGO DE ENCUENTRA LOS 5 BARCOS TITANIC");

Console.WriteLine("         /|");
Console.WriteLine("        / |");
Console.WriteLine("       /__|");
Console.WriteLine("          |");
Console.WriteLine("          |");
Console.WriteLine(" -----------------");
Console.WriteLine(" |                |");
Console.WriteLine("  |    TITANIC   |");
Console.WriteLine("   |            |");
Console.WriteLine("    ------------    ");

Console.WriteLine("¿Listo para comenzar?");

void paso1_crear_tablero()
{
    for (int f = 0; f < tablero.GetLength(0); f++)
    {
        for (int c = 0; c < tablero.GetLength(1); c++)
        {
            tablero[f, c] = 0;
        }
    }
}

void paso2_colocar_barcos()
{
    tablero[2, 2] = 1;
    tablero[1, 1] = 1;
    tablero[4, 4] = 1;
    tablero[3, 3] = 1;
    tablero[5, 5] = 1;
}

void paso3_imprimir_tablero()
{
    String caracter_a_imprimir = "";
    for (int f = 0; f < tablero.GetLength(0); f++)
    {
        for (int c = 0; c < tablero.GetLength(1); c++)
        {
            switch (tablero[f, c])
            {
                case 0:
                    caracter_a_imprimir = " ~ ";
                    break;
                case 1:
                    caracter_a_imprimir = " ~ ";
                    break;
                case -1:
                    caracter_a_imprimir = " # ";
                    break;
                case -2:
                    caracter_a_imprimir = " X ";
                    break;
                default:
                    caracter_a_imprimir = " ~ ";
                    break;
            }
            Console.Write(caracter_a_imprimir + " ");
        }
        Console.WriteLine();

    }

}

void paso_4_5_6_7_8_ingreso_cordenadas()
{
    {
        int fila, columna = 0, intentos = 1;


        do
        {

            Console.Write("Ingrese la fila:");
            fila = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese la columna:");
            columna = Convert.ToInt32(Console.ReadLine());


            if (tablero[fila, columna] == 1)
            {
                Console.Beep();
                tablero[fila, columna] = -1;
                Console.WriteLine("Felcidades hundiste a un barco TITANIC");


            }
            else
            {
                tablero[fila, columna] = -2;
                Console.WriteLine("Fallaste no hundiste mi barco TITANIC");
            }


            paso3_imprimir_tablero();
            Console.WriteLine("LLevas " + intentos + " intentos");
            intentos++;
            Console.WriteLine("Si logras enocntrar los cinco # dejame decirte que has ganado este juego, ¡FELICIDADES!");
        } while (true);
    }
}



paso1_crear_tablero();
paso2_colocar_barcos();
paso3_imprimir_tablero();
paso_4_5_6_7_8_ingreso_cordenadas();