using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace piskvorky
{
    class Tictactoes
    {
        static void Main(string[] args)
        {



           
            //vygeneruje to hraci plochu
            string[,] arena = new string[3, 3];
            for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        arena[i, j] = " ";

                    }
                }

            //hraci cyklus
            int endgame = 0;
            for (int k = 0; endgame < 1; k++)
            {

                Console.Clear();
                // if na rozeznani kdo je na tahu jestli X nebo O
                if (k % 2 == 0)
                {
                    Console.WriteLine("zadej hodnotu na ose x: \a");
                    int x = int.Parse(Console.ReadLine());
                    Console.WriteLine("zadej hodnotu na ose y:\a");
                    int y = int.Parse(Console.ReadLine());



                    // Tady jsem chtel poresit to kdyz nedko vstoupi 2x na to stejne policko s X
                    /*
                    if ((arena[x, y] == "X") || (arena[x, y] == "O"))
                    {
                        for (int i = 0; (arena[x, y] != "X") && (arena[x, y] != "O"); i++) // "Tohle z nejakeho duvodu nefunguje s whilem" while  ((arena[x, y] != "X") && (arena[x, y]))
                        {
                            Console.WriteLine("Toto pole uz je obsazene zvol si jine pole: ");
                            Console.WriteLine("zadej hodnotu na ose x: \a");
                            x = int.Parse(Console.ReadLine());
                            Console.WriteLine("zadej hodnotu na ose y:\a");
                            y = int.Parse(Console.ReadLine());
                        }
                        arena[x, y] = "X";
                    }
                    else
                    {
                        arena[x, y] = "X";
                    }
                    */



                    arena[x, y] = "X";
                }
                else
                {
                    Console.WriteLine("zadej hodnotu na ose x: \a");
                    int x1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("zadej hodnotu na ose y:\a");
                    int y1 = int.Parse(Console.ReadLine());
                    // Tady jsem chtel poresit to kdyz nedko vstoupi 2x na to stejne policko s O

                    /*
                                        if ((arena[x1, y1] == "X") || (arena[x1, y1] == "O"))
                                        {
                                            for (int i = 0; (arena[x1, y1] != "X") && (arena[x1, y1] != "O"); i++)
                                            {
                                                Console.WriteLine("Toto pole uz je obsazene zvol si jine pole: ");
                                                Console.WriteLine("zadej hodnotu na ose x: \a");
                                                x1 = int.Parse(Console.ReadLine());
                                                Console.WriteLine("zadej hodnotu na ose y:\a");
                                                y1 = int.Parse(Console.ReadLine());
                                            }
                                            arena[x1, y1] = "O";
                                        }

                                        else
                                        {
                                            arena[x1, y1] = "O";
                                        }
                    */
                    arena[x1, y1] = "O";
                }


                //vypis hraci plochy
                for (int i1 = 0; i1 < 3; i1++)
                {
                    for (int j1 = 0; j1 < 3; j1++)
                    {
                        Console.Write("|" + arena[i1, j1]);
                    }
                    Console.WriteLine("|\a");
                }

                //tady je vypis pravidel kdo vyhral
                // nevim jak to udelat pres switch kdyz jsem to zkousel tak to vzdzcky vypsalo chybu :(

                if (arena[0, 0] == "X" && arena[0, 1] == "X" && arena[0, 2] == "X")
                {
                    Console.WriteLine("Player with X won");
                    endgame = 2;
                }
                else if (arena[1, 0] == "X" && arena[1, 1] == "X" && arena[1, 2] == "X")
                {
                    Console.WriteLine("Player with X won");
                    endgame = 2;
                }
                else if (arena[2, 0] == "X" && arena[2, 1] == "X" && arena[2, 2] == "X")
                {
                    Console.WriteLine("Player with X won");
                    endgame = 2;
                }
                else if (arena[0, 0] == "X" && arena[1, 0] == "X" && arena[2, 0] == "X")
                {
                    Console.WriteLine("Player with X won");
                    endgame = 2;
                }
                else if (arena[0, 1] == "X" && arena[1, 1] == "X" && arena[2, 1] == "X")
                {
                    Console.WriteLine("Player with X won");
                    endgame = 2;
                }
                else if (arena[0, 2] == "X" && arena[1, 2] == "X" && arena[2, 2] == "X")
                {
                    Console.WriteLine("Player with X won");
                    endgame = 2;
                }
                else if (arena[0, 0] == "X" && arena[1, 1] == "X" && arena[2, 2] == "X")
                {
                    Console.WriteLine("Player with X won");
                    endgame = 2;
                }
                else if (arena[2, 2] == "X" && arena[1, 1] == "X" && arena[0, 0] == "X")
                {
                    Console.WriteLine("Player with X won");
                    endgame = 2;
                }





                // nejak mi to neslo pridat ty O na predchozi if tak jsem to zkopiroval a X prespal na O

                if (arena[0, 0] == "O" && arena[0, 1] == "O" && arena[0, 2] == "O")
                {
                    Console.WriteLine("Player with O won");
                    endgame = 2;
                }
                else if (arena[1, 0] == "O" && arena[1, 1] == "O" && arena[1, 2] == "O")
                {
                    Console.WriteLine("Player with O won");
                    endgame = 2;
                }
                else if (arena[2, 0] == "O" && arena[2, 1] == "O" && arena[2, 2] == "O")
                {
                    Console.WriteLine("Player with O won");
                    endgame = 2;
                }
                else if (arena[0, 0] == "O" && arena[1, 0] == "O" && arena[2, 0] == "O")
                {
                    Console.WriteLine("Player with O won");
                    endgame = 2;
                }
                else if (arena[0, 1] == "O" && arena[1, 1] == "O" && arena[2, 1] == "O")
                {
                    Console.WriteLine("Player with O won");
                    endgame = 2;
                }
                else if (arena[0, 2] == "O" && arena[1, 2] == "O" && arena[2, 2] == "O")
                {
                    Console.WriteLine("Player with O won");
                    endgame = 2;
                }
                else if (arena[0, 0] == "O" && arena[1, 1] == "O" && arena[2, 2] == "O")
                {
                    Console.WriteLine("Player with O won");
                    endgame = 2;
                }
                else if (arena[2, 2] == "O" && arena[1, 1] == "O" && arena[0, 0] == "O")
                {
                    Console.WriteLine("Player with O won");
                    endgame = 2;
                }



                //tohle tady je aby se ta hra stopla a hned se nevyclearovala
                Console.WriteLine("Press any key to continue:");
                string key = (Console.ReadLine());


            }
        }
    }
}
