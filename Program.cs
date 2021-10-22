using System;

namespace proyecto_final_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Int32 platanos = 25, yuca = 30, guineo = 5, papa = 25, cebolla = 5;
            Int32 jugo = 25, soda = 15, gatorade = 60, maltamorena = 50, cerveza = 50;
            Int32 sal = 10, pimienta = 10, azucar = 15, oregano = 5, salsa = 20;
            Int32 total = 0;


        //login




        //punto de venta
        inicio:
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Seleccione el tipo de producto que desa adquirir");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.Write("1- Viveres  ");
            Console.Write("2- Bebidas  ");
            Console.Write("3- Condimentos   ");
            Console.Write("4- Frutas   ");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("  El total de su compra es: " + total);

            byte y = Convert.ToByte(Console.ReadLine());
            if (y == 1)
            {
            inicio1:
                Console.Clear();
                Console.WriteLine("1-   Platanos   " + platanos);
                Console.WriteLine("2-   Yuca   " + yuca);
                Console.WriteLine("3-   Guineo   " + guineo);
                Console.WriteLine("4-   Papa   " + papa);
                Console.WriteLine("5-   Cebolla   " + cebolla);
                Console.WriteLine("6-   Regresar al menu principal   ");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("  El total de su compra es: " + total);
                Console.WriteLine("");
                Console.WriteLine("");

                byte a = Convert.ToByte(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        Console.WriteLine("   Platanos   " + platanos);
                        total = total + platanos;
                        goto inicio1;
                    case 2:
                        Console.WriteLine("   Yuca   " + yuca);
                        total = total + yuca;
                        goto inicio1;
                    case 3:
                        Console.WriteLine("   Guineo   " + guineo);
                        total = total + guineo;
                        goto inicio1;
                    case 4:
                        Console.WriteLine("   Papa   " + papa);
                        total = total + papa;
                        goto inicio1;
                    case 5:
                        Console.WriteLine("   Cebolla   " + cebolla);
                        total = total + cebolla;
                        goto inicio1;
                    case 6:
                        Console.WriteLine("   Regresar al menu principal   ");
                        goto inicio;

                }
            }

            else if (y == 2)
            {
            inicio2:
                Console.Clear();
                Console.WriteLine("1-   Jugo   " + jugo);
                Console.WriteLine("2-   Soda   " + soda);
                Console.WriteLine("3-   gatorade   " + gatorade);
                Console.WriteLine("4-   Malta Morena   " + maltamorena);
                Console.WriteLine("5-   Cerbeza   " + cerveza);
                Console.WriteLine("6-   Regresar al menu principal   ");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("  El total de su compra es: " + total);
                Console.WriteLine("");
                Console.WriteLine("");

                byte b = Convert.ToByte(Console.ReadLine());
                switch (b)
                {
                    case 1:
                        Console.WriteLine("   Jugo   " + jugo);
                        total = total + jugo;
                        goto inicio2;
                    case 2:
                        Console.WriteLine("   Soda   " + soda);
                        total = total + soda;
                        goto inicio2;
                    case 3:
                        Console.WriteLine("   Gatorade   " + gatorade);
                        total = total + gatorade;
                        goto inicio2;
                    case 4:
                        Console.WriteLine("   Malta Morena   " + maltamorena);
                        total = total + maltamorena;
                        goto inicio2;
                    case 5:
                        Console.WriteLine("   Cerveza   " + cerveza);
                        total = total + cerveza;
                        goto inicio2;
                    case 6:
                        Console.WriteLine("   Regresar al menu principal   ");
                        goto inicio;

                }
            }

            else if (y == 3)
            {
            inicio3:
                Console.Clear();
                Console.WriteLine("1-   Sal   " + sal);
                Console.WriteLine("2-   Pimienta   " + pimienta);
                Console.WriteLine("3-   Azucar   " + azucar);
                Console.WriteLine("4-   Oregano   " + oregano);
                Console.WriteLine("5-   Salsa   " + salsa);
                Console.WriteLine("6-   Regresar al menu principal   ");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("  El total de su compra es: " + total);
                Console.WriteLine("");
                Console.WriteLine("");

                byte c = Convert.ToByte(Console.ReadLine());
                switch (c)
                {
                    case 1:
                        Console.WriteLine("   Sal   " + sal);
                        total = total + sal;
                        goto inicio3;
                    case 2:
                        Console.WriteLine("   Pimienta   " + pimienta);
                        total = total + pimienta;
                        goto inicio3;
                    case 3:
                        Console.WriteLine("   Azucar   " + azucar);
                        total = total + azucar;
                        goto inicio3;
                    case 4:
                        Console.WriteLine("   Oregano   " + oregano);
                        total = total + oregano;
                        goto inicio3;
                    case 5:
                        Console.WriteLine("   Salsa   " + salsa);
                        total = total + salsa;
                        goto inicio3;
                    case 6:
                        Console.WriteLine("   Regresar al menu principal   ");
                        goto inicio;

                }

            }
                    Console.WriteLine("");
                Console.ReadKey();
            }
        }
    }

