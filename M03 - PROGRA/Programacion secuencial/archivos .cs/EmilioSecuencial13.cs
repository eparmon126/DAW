using System;

namespace TableroAjedrez
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Supongamos que tenemos un tablero de ajedrez con las casillas numeradas de la 1 a la 64
             * en el orden de izquierda a derecha y de arriba abajo.
             * Realiza un programa que calcula la fila y la columna en la que se encuentra una casilla
             * introducida por el usuario.*/

            int[,] tablero = new int[8,8];                  //Declaramos la matriz de enteros con dimensión 8,8
            int n=1, i=0, fila, casilla, posh=0, posv=0;    //Declaramos la variable n con valor inicial 1 que será el primer valor que se guarde en la posición 1,1

            for (fila = 0; fila < 8; fila++)                //Hacemos un bucle FOR para rellenar las filas de la matriz y dentro de este otro FOR para las columnas.       
            {                                               //Cuando las 8 columnas estén rellenas con el valor de n, saldrá del bucle y pasará a la siguiente fila.
                for (i = 0; i < 8; i++)                     //i=0 es la primera posición de la columna y mientras sea menor que 8, entrará en el FOR guardando en la
                {                                           //posición el valor de n que incrementará +1 en cada vuelta llegando de 1 a 7.
                    tablero[i, fila] = n++;
                    Console.Write($"{tablero[i,fila]} \t"); //Escribimos el contenido de cada posición para ver que es correcto.

                }
                Console.WriteLine();
                
            }

            Console.WriteLine("\nIntroduzca la casilla que desea buscar");
            casilla = int.Parse(Console.ReadLine());

            for (fila = 0; fila < 8; fila++)            //Recorremos la matriz como cuando rellenamos las posiciones pero esta vez sin guardar información.
            {                                               
                for (i = 0; i < 8; i++)                 
                {
                    if (tablero[i, fila] == casilla)    //Si la casilla introducida coincide con el número guardado en la posición de la matriz en la que nos encontramos,
                    {                                   //entrará en la condición del if.
                        posh = i+1;                     //Guardamos las coordenadas en otras variables sumando 1 a la posición porque el tablero empieza por la casilla 1,1.
                        posv = fila+1;
                        break;                          //Con el break saldremos del bucle interrumpiendo el recorrido por la matriz.
                    }
                }
                

            }

            Console.WriteLine($"\nLa casilla {casilla} se encuentra en la posición {posh}, {posv}");

        }
    }
}
