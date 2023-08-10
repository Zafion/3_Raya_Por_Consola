using System;

namespace _3_en_raya_EXTREMO
{
    class Program
    {
        static void Main(string[] args)
        {

            /*INTRODUCCIÓN
            CREACIÓN DEL JUEGO 3 EN RAYA
            Consiste en la creación del juego tres en raya entre dos jugadores.
            Tres en raya.jpg.
            ¿Qué pasos debemos seguir?.
            1º) Crear un tablero de juego 3x3.
            2º) Ir rellenando ese tablero para inicializarlo. La matriz estará compuesta por caracteres.
            3º) Vamos a obtener la posición donde queremos poner nuestra 'X' o 'O'.
            4º) Para realizar el punto 3, debemos comprobar si podemos escribir en esa casilla.
            5º) Conocer el turno del jugador.
            6º) Comprobar quién ha ganado.
            Recordad compartir con vuestros compañeros en este foro los pasos que vayáis dando y así, podréis recibir feedback.
            Un saludo :)*/

            //DECLARAMOS VARIABLES PARA EL JUEGO
            string Jugador1 = "";
            string Jugador2 = "";
            int fila;
            int columna;
            string[,] Tablero = new string[3, 3];
            Tablero[0, 0] = " ";
            Tablero[0, 1] = " ";
            Tablero[0, 2] = " ";
            Tablero[1, 0] = " ";
            Tablero[1, 1] = " ";
            Tablero[1, 2] = " ";
            Tablero[2, 0] = " ";
            Tablero[2, 1] = " ";
            Tablero[2, 2] = " ";

            //INTRODUCCION AL JUEGO:

            Console.WriteLine("Es el mi primer 'jueguecito' que hago y le quiero dar un toque de contexto/Rol.");
            Console.WriteLine("¡¡Empieza el juego!!");
            Console.WriteLine("Os despertais uno frente al otro, cada uno esta en una jaula donde apenas cabeis.");
            Console.WriteLine("Tambien teneis delante vuestro un monitor y un teclado.");
            Console.WriteLine("Están resaltadas las teclas con los numeros del 0 al 2, 'Enter'");
            Console.WriteLine("No recordais como habeis llegado a esta situación");
            Console.WriteLine("pero lo mas terrorifico es ver el foso oscuro juto debajo de vuestras jaulas");
            Console.WriteLine("El monitor se enciende y aparece un mensaje:");
            Console.WriteLine("¡¡Bienvenidos a 3 en raya EXTREMO!!");
            Console.WriteLine("2 entran uno sale, el que pierda esta partida caera al foso y no volverá.");
            Console.WriteLine("aqui teneis el tablero:");
            Console.WriteLine();


            //DIBUJO DE TABLERO:
            Console.WriteLine(" |0|1|2|"); Console.WriteLine("---------"); //INDICAMOS LAS COLUMNAS 0, 1 Y 2 ; PONEMOS UN SEPARADOR.
            Console.Write("0|");
            for (int i = 0; i < 1; i++)   //bucle para recorrer la 1ª filas.
            {                
                for (int j = 0; j < 3; j++)  //bucle for (detro de otro) para recorrer las columnas.
                {                                           
                    Console.Write(Tablero[i,j] + "|");  //imprimimos los valores de la 1ª filas.                   
                }
                Console.WriteLine(); Console.WriteLine("---------");   // crea un salto cuando termina el bucle de las lineas para separarlas.
            }
            Console.Write("1|");
            for (int i = 1; i < 2; i++)   //bucle para recorrer la 2ª filas.
            {
                for (int j = 0; j < 3; j++)  //bucle for (detro de otro) para recorrer las columnas.
                {
                    Console.Write(Tablero[i, j] + "|");  //imprimimos los valores de la 1ª filas.                  
                }
                Console.WriteLine(); Console.WriteLine("---------");   // crea un salto cuando termina el bucle de las lineas para separarlas.
            }
            Console.Write("2|");
            for (int i = 2; i < 3; i++)   //bucle para recorrer la 3ª filas.
            {
                for (int j = 0; j < 3; j++)  //bucle for (detro de otro) para recorrer las columnas.
                {
                    Console.Write(Tablero[i, j] + "|");  //imprimimos los valores de la 1ª filas.                   
                }
                Console.WriteLine(); Console.WriteLine("---------");   // crea un salto cuando termina el bucle de las lineas para separarlas.
            }


            Console.WriteLine();
            Console.WriteLine("Creo que no hace falta que os explique como se juega al 3 en raya.");
            Console.WriteLine("uno de vosotros jugara con una 'O' y el otro con la 'X'.");
            Console.WriteLine("Como podeis ver cada casilla tiene unas coordenadas.");
            Console.WriteLine("Por ejemplo. la segunda corresponde a la fila 0 y la columna 1, sería '0,1'.");
            Console.WriteLine("Ahora vamos a conocernos un poco más.");
            Console.WriteLine("Primero vamos a ver quien responde antes ¿COMO TE LLAMAS?");
            Jugador1 = Console.ReadLine();
            Console.WriteLine("Muy bien, muy bien, has sido rapido... ¿Y tu? Indeciso ¿COMO TE LLAMAS?");
            Jugador2 = Console.ReadLine();
            Console.WriteLine("¿Veis? ya nos conocemos un poco más... "+Jugador1+" el valiente y "+Jugador2+" el precavido." );
            Console.WriteLine(Jugador1+" Seras el jugador 1, te toca jugar el primero y usaras las 'O'");
            Console.WriteLine(Jugador2 + " Seras el jugador 2, te toca jugar el segundo y usaras las 'X'");
            Console.WriteLine("Teneis que indicar primero la fila y despues la columna para elegir donde poneis vuestra marca");
            Console.WriteLine("Si no lo haceis correctamente el juego no avanzara y morireis los dos de deshidratación"); 
            Console.WriteLine("De aquí no se va nadie hasta que uno no gane MUHAHAHAHAHAHAHAHA.");
            


            //Inicio del bucle del juego:

            

            //Condiciones de victoria y Fin de Juego:

            

            //if (Tablero[0, 0] == "O" && Tablero[0, 1] == "O" && Tablero[0, 2] == "O") { Console.WriteLine("Ha ganado " + Jugador1 + " MUHAHAHAHAHAHAHAHA"); }
            //if (Tablero[1, 0] == "O" && Tablero[1, 1] == "O" && Tablero[1, 2] == "O") { Console.WriteLine("Ha ganado " + Jugador1 + " MUHAHAHAHAHAHAHAHA"); }
            //if (Tablero[2, 0] == "O" && Tablero[2, 1] == "O" && Tablero[2, 2] == "O") { Console.WriteLine("Ha ganado " + Jugador1 + " MUHAHAHAHAHAHAHAHA"); }
            //if (Tablero[0, 0] == "O" && Tablero[1, 1] == "O" && Tablero[2, 2] == "O") { Console.WriteLine("Ha ganado " + Jugador1 + " MUHAHAHAHAHAHAHAHA"); }
            //if (Tablero[2, 0] == "O" && Tablero[1, 1] == "O" && Tablero[0, 2] == "O") { Console.WriteLine("Ha ganado " + Jugador1 + " MUHAHAHAHAHAHAHAHA"); }
            //if (Tablero[3, 0] == "O" && Tablero[3, 1] == "O" && Tablero[3, 2] == "O") { Console.WriteLine("Ha ganado " + Jugador1 + " MUHAHAHAHAHAHAHAHA"); }
            //if (Tablero[3, 0] == "O" && Tablero[3, 1] == "O" && Tablero[3, 2] == "O") { Console.WriteLine("Ha ganado " + Jugador1 + " MUHAHAHAHAHAHAHAHA"); }
            //if (Tablero[3, 0] == "O" && Tablero[3, 1] == "O" && Tablero[3, 2] == "O") { Console.WriteLine("Ha ganado " + Jugador1 + " MUHAHAHAHAHAHAHAHA"); }
            //if (Tablero[0, 0] == "X" && Tablero[0, 1] == "X" && Tablero[0, 2] == "X") { Console.WriteLine("Ha ganado " + Jugador2 + " MUHAHAHAHAHAHAHAHA"); }
            //if (Tablero[1, 0] == "X" && Tablero[1, 1] == "X" && Tablero[1, 2] == "X") { Console.WriteLine("Ha ganado " + Jugador2 + " MUHAHAHAHAHAHAHAHA"); }
            //if (Tablero[2, 0] == "X" && Tablero[2, 1] == "X" && Tablero[2, 2] == "X") { Console.WriteLine("Ha ganado " + Jugador2 + " MUHAHAHAHAHAHAHAHA"); }
            //if (Tablero[0, 0] == "X" && Tablero[1, 1] == "X" && Tablero[2, 2] == "X") { Console.WriteLine("Ha ganado " + Jugador2 + " MUHAHAHAHAHAHAHAHA"); }
            //if (Tablero[2, 0] == "X" && Tablero[1, 1] == "X" && Tablero[0, 2] == "X") { Console.WriteLine("Ha ganado " + Jugador2 + " MUHAHAHAHAHAHAHAHA"); }
            //if (Tablero[3, 0] == "X" && Tablero[3, 1] == "X" && Tablero[3, 2] == "X") { Console.WriteLine("Ha ganado " + Jugador2 + " MUHAHAHAHAHAHAHAHA"); }
            //if (Tablero[3, 0] == "X" && Tablero[3, 1] == "X" && Tablero[3, 2] == "X") { Console.WriteLine("Ha ganado " + Jugador2 + " MUHAHAHAHAHAHAHAHA"); }
            //if (Tablero[3, 0] == "X" && Tablero[3, 1] == "X" && Tablero[3, 2] == "X") { Console.WriteLine("Ha ganado " + Jugador2 + " MUHAHAHAHAHAHAHAHA"); }


            //// CODIGO DEL JUEGO EN SI:

            //else 
            //{
                for (int i = 0; i < 9; i++)    //bucle con el juego, solo hay 9 casillas por lo que solo hay 9 ejecuciones.
                {
                    if (i % 2 == 0) //pares juega el jugador 1
                    {
                        Console.WriteLine(Jugador1 + " Del 0 al 2 ¿En que fila quieres poner tu marca?");   //solicitamos al jugador1 la fila
                        fila = int.Parse(Console.ReadLine());
                        switch (fila)   //switch para definir la eleccion del jugador y decirle si la opcion es incorrecta.
                        {
                            case 0:
                                Console.WriteLine("has elegido la fila 0");
                                break;
                            case 1:
                                Console.WriteLine("has elegido la fila 1");
                                break;
                            case 2:
                                Console.WriteLine("has elegido la fila 2");
                                break;
                            default:
                                Console.WriteLine("Esa opcion no era valida, por listillo pierdes el turno");
                                break;
                        }
                        Console.WriteLine(Jugador1 + " Del 0 al 2 ¿En que columna quieres poner tu marca?");    //solicitamos al jugador1 la columna
                        columna = int.Parse(Console.ReadLine());
                        switch (columna)
                        {
                            case 0:
                                Console.WriteLine("has elegido la columna 0");
                                break;
                            case 1:
                                Console.WriteLine("has elegido la columna 1");
                                break;
                            case 2:
                                Console.WriteLine("has elegido la columna 2");
                                break;
                            default:
                                Console.WriteLine("Esa opcion no era valida, por listillo pierdes el turno");
                                break;
                        }
                        if (fila == 0 || fila == 1 || fila == 2)    //si ha puesto en fila valores del 0 al 2 contina, si no pasa al siguiente jugador
                        {
                            if (columna == 0 || columna == 1 || columna == 2)    //si ha puesto en columna valores del 0 al 2 contina, si no pasa al siguiente jugador
                            {
                                Tablero[fila, columna] = "O";
                                Console.WriteLine(Jugador1 + " has puesto la marca en la posición " + fila + "," + columna);
                                Console.WriteLine("El tablero queda así:");
                            }


                        }
                        //Volvemos a mostrar como está el tablero.

                        Console.WriteLine(" |0|1|2|"); Console.WriteLine("---------"); //INDICAMOS LAS COLUMNAS 0, 1 Y 2 ; PONEMOS UN SEPARADOR.
                        Console.Write("0|");
                        for (int m = 0; m < 1; m++)   //bucle para recorrer la 1ª filas.
                        {
                            for (int n = 0; n < 3; n++)  //bucle for (detro de otro) para recorrer las columnas.
                            {
                                Console.Write(Tablero[m, n] + "|");  //imprimimos los valores de la 1ª filas.                   
                            }
                            Console.WriteLine(); Console.WriteLine("---------");   // crea un salto cuando termina el bucle de las lineas para separarlas.
                        }
                        Console.Write("1|");
                        for (int m = 1; m < 2; m++)   //bucle para recorrer la 2ª filas.
                        {
                            for (int n = 0; n < 3; n++)  //bucle for (detro de otro) para recorrer las columnas.
                            {
                                Console.Write(Tablero[m, n] + "|");  //imprimimos los valores de la 1ª filas.                  
                            }
                            Console.WriteLine(); Console.WriteLine("---------");   // crea un salto cuando termina el bucle de las lineas para separarlas.
                        }
                        Console.Write("2|");
                        for (int m = 2; m < 3; m++)   //bucle para recorrer la 3ª filas.
                        {
                            for (int n = 0; n < 3; n++)  //bucle for (detro de otro) para recorrer las columnas.
                            {
                                Console.Write(Tablero[m, n] + "|");  //imprimimos los valores de la 1ª filas.                   
                            }
                            Console.WriteLine(); Console.WriteLine("---------");   // crea un salto cuando termina el bucle de las lineas para separarlas.
                        }

                    }
                    else
                    {
                        Console.WriteLine(Jugador2 + " Del 0 al 2 ¿En que fila quieres poner tu marca?");
                        fila = int.Parse(Console.ReadLine());
                        switch (fila)
                        {
                            case 0:
                                Console.WriteLine("has elegido la fila 0");
                                break;
                            case 1:
                                Console.WriteLine("has elegido la fila 1");
                                break;
                            case 2:
                                Console.WriteLine("has elegido la fila 2");
                                break;
                            default:
                                Console.WriteLine("Esa opcion no era valida, por listillo pierdes el turno");
                                break;
                        }
                        Console.WriteLine(Jugador2 + " Del 0 al 2 ¿En que columna quieres poner tu marca?");
                        columna = int.Parse(Console.ReadLine());
                        switch (columna)
                        {
                            case 0:
                                Console.WriteLine("has elegido la columna 0");
                                break;
                            case 1:
                                Console.WriteLine("has elegido la columna 1");
                                break;
                            case 2:
                                Console.WriteLine("has elegido la columna 2");
                                break;
                            default:
                                Console.WriteLine("Esa opcion no era valida, por listillo pierdes el turno");
                                break;
                        }
                        if (fila == 0 || fila == 1 || fila == 2)
                        {
                            if (columna == 0 || columna == 1 || columna == 2)
                            {
                                Tablero[fila, columna] = "X";
                                Console.WriteLine(Jugador2 + " has puesto la marca en la posición " + fila + "," + columna);
                                Console.WriteLine("El tablero queda así:");
                            }
                        }

                        Console.WriteLine(" |0|1|2|"); Console.WriteLine("---------"); //INDICAMOS LAS COLUMNAS 0, 1 Y 2 ; PONEMOS UN SEPARADOR.
                        Console.Write("0|");
                        for (int o = 0; o < 1; o++)   //bucle para recorrer la 1ª filas.
                        {
                            for (int p = 0; p < 3; p++)  //bucle for (detro de otro) para recorrer las columnas.
                            {
                                Console.Write(Tablero[o, p] + "|");  //imprimimos los valores de la 1ª filas.                   
                            }
                            Console.WriteLine(); Console.WriteLine("---------");   // crea un salto cuando termina el bucle de las lineas para separarlas.
                        }
                        Console.Write("1|");
                        for (int o = 1; o < 2; o++)   //bucle para recorrer la 2ª filas.
                        {
                            for (int p = 0; p < 3; p++)  //bucle for (detro de otro) para recorrer las columnas.
                            {
                                Console.Write(Tablero[o, p] + "|");  //imprimimos los valores de la 1ª filas.                  
                            }
                            Console.WriteLine(); Console.WriteLine("---------");   // crea un salto cuando termina el bucle de las lineas para separarlas.
                        }
                        Console.Write("2|");
                        for (int o = 2; o < 3; o++)   //bucle para recorrer la 3ª filas.
                        {
                            for (int p = 0; p < 3; p++)  //bucle for (detro de otro) para recorrer las columnas.
                            {
                                Console.Write(Tablero[o, p] + "|");  //imprimimos los valores de la 1ª filas.                   
                            }
                            Console.WriteLine(); Console.WriteLine("---------");   // crea un salto cuando termina el bucle de las lineas para separarlas.
                        }
                    }
                }

            

            //}
            






        }
    }
}
