using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace proyecto_final_2
{
    class Entrada
    {
        /* Viveres */
        Int32 platanos = 25, yuca = 30, guineo = 5, papa = 25, yautia = 5;
        /* Bebidas */
        Int32 jugo = 25, soda = 15, gatorade = 60, maltamorena = 50, cerveza = 50;
        /* Frutas */
        Int32 manzana = 15, banana = 20, sandia = 25, piña = 15, fresa = 5;
        /* Condimentos */
        Int32 sal = 10, pimienta = 10, azucar = 15, oregano = 5, salsa = 20;
        Int32 total = 0;

        /* cantViveres */
        int cantPlatanos = 0, cantYuca = 0, cantGuineo = 0, cantPapa = 0, cantYautia = 0;
        /* cantBebidas */
        int cantJugo = 0, cantSoda = 0, cantGatorade = 0, cantMaltamorena = 0, cantCerveza = 0;
        /* cantFrutas */
        int cantManzana = 0, cantBanana = 0, cantSandia = 0, cantPiña = 0, cantFresa = 0;
        /* cantCondimentos */
        int cantSal = 0, cantPimienta = 0, cantAzucar = 0, cantOregano = 0, cantSalsa = 0;
        int cantTotal = 0;

        ///* VALIDACION cantViveres */
        //int VcantPlatanos = 0, VcantYuca = 0, VcantGuineo = 0, VcantPapa = 0, VcantYautia = 0;
        ///* VALIDACION cantBebidas */
        //int VcantJugo = 0, VcantSoda = 0, VcantGatorade = 0, VcantMaltamorena = 0, VcantCerveza = 0;
        ///* VALIDACION cantFrutas */
        //int VcantManzana = 0, VcantBanana = 0, VcantSandia = 0, VcantPiña = 0, VcantFresa = 0;
        ///* VALIDACION cantCondimentos */
        //int VcantSal = 0, VcantPimienta = 0, VcantAzucar = 0, VcantOregano = 0, VcantSalsa = 0;
        //int VcantTotal = 0;

        /*Dinero para pagar*/
        int cash = 0;

        





        public void Start()
        {
            Title = "Colmado";
            RunMainMenu();
        }

        //Menu principal
        private void RunMainMenu()
        {
            

            string Prompt = @" 

 ██████╗ ██████╗ ██╗     ███╗   ███╗ █████╗ ██████╗  ██████╗ 
██╔════╝██╔═══██╗██║     ████╗ ████║██╔══██╗██╔══██╗██╔═══██╗
██║     ██║   ██║██║     ██╔████╔██║███████║██║  ██║██║   ██║
██║     ██║   ██║██║     ██║╚██╔╝██║██╔══██║██║  ██║██║   ██║
╚██████╗╚██████╔╝███████╗██║ ╚═╝ ██║██║  ██║██████╔╝╚██████╔╝
 ╚═════╝ ╚═════╝ ╚══════╝╚═╝     ╚═╝╚═╝  ╚═╝╚═════╝  ╚═════╝ 
                                                             
                                          
Bienvenido a nuestro colmado, Como podemos ayudarle?
(Use las teclas de direccion para navegar por el menu y selecciona con la tecla Enter.)
";
            string[] Options = { "COMPRAR", "FACTURA", "SALIR" };

            Menu MainMenu = new Menu(Prompt, Options);
            int SelectedIndex = MainMenu.Run();

            switch (SelectedIndex)
            {
                case 0:
                    Comprar();
                    break;
                case 1:
                    Factura();
                    break;
                case 2:
                    Salir();                    
                    break;               

                default:
                    break;
            }

        }


        //Menu clasificacion
        public void RunClasificacion()
        {
            string Prompt = @" 

  _____               _            _            
 |  __ \             | |          | |           
 | |__) | __ ___   __| |_   _  ___| |_ ___  ___ 
 |  ___/ '__/ _ \ / _` | | | |/ __| __/ _ \/ __|
 | |   | | | (_) | (_| | |_| | (__| || (_) \__ \
 |_|   |_|  \___/ \__,_|\__,_|\___|\__\___/|___/                                                
                                                
                                           
Estos son nuestros productos, que desea comprar?";

            string[] Options = { "Víveres", "Bebidas", "Condimentos", "Frutas", "* Volver al menu principal *" };

            Clasificacion MenuDeClasificacion = new Clasificacion(Prompt, Options);
            int SelectedIndex = MenuDeClasificacion.RunClasificacion();

            switch (SelectedIndex)
            {
                case 0:
                    Viveres();
                    break;
                case 1:
                    Bebidas();
                    break;
                case 2:
                    Condimentos();
                    break;
                case 3:
                    Frutas();
                    break;
                case 4:
                    RunMainMenu();
                    break;

                default:
                    break;
            }

        }

        //Menu de productos viveres
        public void RunViveres()
        {

            string Prompt = @" 
 __     ___                         
 \ \   / (_)_   _____ _ __ ___  ___ 
  \ \ / /| \ \ / / _ \ '__/ _ \/ __|
   \ V / | |\ V /  __/ | |  __/\__ \
    \_/  |_| \_/ \___|_|  \___||___/                                    
                                                
                                           
Estos son nuestros víveres, que desea comprar?

El total de su compra es: $" + total;

            Console.WriteLine("");

            string[] Options = { "Platanos = $25", "Yuca = $30", "Guineo = $5", "Papa = $25", "Yautia = $5", "* Volver al menu de productos *" };

            Viveres MenuDeViveres = new Viveres(Prompt, Options);
            int SelectedIndex = MenuDeViveres.RunViveres();

            switch (SelectedIndex)
            {
                case 0:
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese la cantidad de platanos que desea: ");
                    try
                    {
                        cantPlatanos = Convert.ToInt32(Console.ReadLine());
                    }

                    catch
                    {
                        WriteLine("");
                        WriteLine("CARACTERES INCORRECTOS... Debe ingresar un valor numerico");
                        WriteLine("Pulse cualquier tecla para reintentar...");
                        ReadKey();
                    }
                 

                    total = total + (platanos * cantPlatanos);
                    RunViveres();
                    break;

                case 1:
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese la cantidad de yuca que desea: ");
                    try
                    {
                        cantYuca = Convert.ToInt32(Console.ReadLine());
                    }

                    catch
                    {
                        WriteLine("");
                        WriteLine("CARACTERES INCORRECTOS... Debe ingresar un valor numerico");
                        WriteLine("Pulse cualquier tecla para reintentar...");
                        ReadKey();
                    }
                    total = total + (yuca * cantYuca);
                    RunViveres();
                    break;

                case 2:
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese la cantidad de guineos que desea: ");
                    try
                    {
                        cantGuineo = Convert.ToInt32(Console.ReadLine());
                    }

                    catch
                    {
                        WriteLine("");
                        WriteLine("CARACTERES INCORRECTOS... Debe ingresar un valor numerico");
                        WriteLine("Pulse cualquier tecla para reintentar...");
                        ReadKey();
                    }
                    total = total + (guineo * cantGuineo);
                    RunViveres();
                    break;

                case 3:
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese la cantidad de papas que desea: ");
                    try
                    {
                        cantPapa = Convert.ToInt32(Console.ReadLine());
                    }

                    catch
                    {
                        WriteLine("");
                        WriteLine("CARACTERES INCORRECTOS... Debe ingresar un valor numerico");
                        WriteLine("Pulse cualquier tecla para reintentar...");
                        ReadKey();
                    }
                    total = total + (papa * cantPapa);
                    RunViveres();
                    break;

                case 4:
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese la cantidad de Yautias que desea: ");
                    try
                    {
                        cantYautia = Convert.ToInt32(Console.ReadLine());
                    }

                    catch
                    {
                        WriteLine("");
                        WriteLine("CARACTERES INCORRECTOS... Debe ingresar un valor numerico");
                        WriteLine("Pulse cualquier tecla para reintentar...");
                        ReadKey();
                    }
                    total = total + (yautia * cantYautia);
                    RunViveres();
                    break;

                case 5:
                    RunClasificacion();
                    break;

                default:
                    break;
            }

        }

        public void RunBebidas()
        {
            string Prompt = @"
  ____       _     _     _           
 | __ )  ___| |__ (_) __| | __ _ ___ 
 |  _ \ / _ \ '_ \| |/ _` |/ _` / __|
 | |_) |  __/ |_) | | (_| | (_| \__ \
 |____/ \___|_.__/|_|\__,_|\__,_|___/
                                     

Estos son nuestras bebidas, que desea comprar?

El total de su compra es: $" + total;

            Console.WriteLine("");

            string[] Options = { "Jugo = $25", "Soda = $15", "Gatorade = $60", "Maltamorena = $50", "Cerveza = $50", "* Volver al menu de productos *" };

            Bebidas MenuDeBebidas = new Bebidas(Prompt, Options);
            int SelectedIndex = MenuDeBebidas.RunBebidas();

            switch (SelectedIndex)
            {
                case 0:
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese la cantidad de jugos que desea: ");
                    try
                    {
                        cantJugo = Convert.ToInt32(Console.ReadLine());
                    }

                    catch
                    {
                        WriteLine("");
                        WriteLine("CARACTERES INCORRECTOS... Debe ingresar un valor numerico");
                        WriteLine("Pulse cualquier tecla para reintentar...");
                        ReadKey();
                    }
                    total = total + (jugo * cantJugo);
                    RunBebidas();
                    break;

                case 1:
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese la cantidad de sodas que desea: ");
                    try
                    {
                        cantSoda = Convert.ToInt32(Console.ReadLine());
                    }

                    catch
                    {
                        WriteLine("");
                        WriteLine("CARACTERES INCORRECTOS... Debe ingresar un valor numerico");
                        WriteLine("Pulse cualquier tecla para reintentar...");
                        ReadKey();
                    }
                    total = total + (soda * cantSoda);
                    RunBebidas();
                    break;

                case 2:
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese la cantidad de gatorades que desea: ");
                    try
                    {
                        cantGatorade = Convert.ToInt32(Console.ReadLine());
                    }

                    catch
                    {
                        WriteLine("");
                        WriteLine("CARACTERES INCORRECTOS... Debe ingresar un valor numerico");
                        WriteLine("Pulse cualquier tecla para reintentar...");
                        ReadKey();
                    }

                    total = total + (gatorade * cantGatorade);
                    RunBebidas();
                    break;

                case 3:
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese la cantidad de maltamorenas que desea: ");
                    try
                    {
                        cantMaltamorena = Convert.ToInt32(Console.ReadLine());
                    }

                    catch
                    {
                        WriteLine("");
                        WriteLine("CARACTERES INCORRECTOS... Debe ingresar un valor numerico");
                        WriteLine("Pulse cualquier tecla para reintentar...");
                        ReadKey();
                    }
                    total = total + (maltamorena * cantMaltamorena); RunBebidas();
                    break;
                    ;
                case 4:
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese la cantidad de cervezas que desea: ");
                    try
                    {
                        cantCerveza = Convert.ToInt32(Console.ReadLine());
                    }

                    catch
                    {
                        WriteLine("");
                        WriteLine("CARACTERES INCORRECTOS... Debe ingresar un valor numerico");
                        WriteLine("Pulse cualquier tecla para reintentar...");
                        ReadKey();
                    }
                    total = total + (cerveza * cantCerveza);
                    RunBebidas();
                    break;

                case 5:
                    RunClasificacion();
                    break;

                default:
                    break;
            }
        }

        public void RunCondimentos()
        {
            string Prompt = @"
   ____                _ _                      _            
  / ___|___  _ __   __| (_)_ __ ___   ___ _ __ | |_ ___  ___ 
 | |   / _ \| '_ \ / _` | | '_ ` _ \ / _ \ '_ \| __/ _ \/ __|
 | |__| (_) | | | | (_| | | | | | | |  __/ | | | || (_) \__ \
  \____\___/|_| |_|\__,_|_|_| |_| |_|\___|_| |_|\__\___/|___/


Estos son nuestras condimentos, que desea comprar?

El total de su compra es: $" + total;

            Console.WriteLine("");

            string[] Options = { "Sal = $10", "Pimienta = $10", "Azucar = $15", "Oregano = $5", "Salsa = $20", "* Volver al menu de productos *" };

            Frutas MenuDeFrutas = new Frutas(Prompt, Options);
            int SelectedIndex = MenuDeFrutas.RunFrutas();

            switch (SelectedIndex)
            {
                case 0:
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese la cantidad de sales que desea: ");
                    try
                    {
                        cantSal = Convert.ToInt32(Console.ReadLine());
                    }

                    catch
                    {
                        WriteLine("");
                        WriteLine("CARACTERES INCORRECTOS... Debe ingresar un valor numerico");
                        WriteLine("Pulse cualquier tecla para reintentar...");
                        ReadKey();
                    }

                    total = total + (sal * cantSal);
                    RunCondimentos();
                    break;

                case 1:
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese la cantidad de pimientas que desea: ");
                    try
                    {
                        cantPimienta = Convert.ToInt32(Console.ReadLine());
                    }

                    catch
                    {
                        WriteLine("");
                        WriteLine("CARACTERES INCORRECTOS... Debe ingresar un valor numerico");
                        WriteLine("Pulse cualquier tecla para reintentar...");
                        ReadKey();
                    }
                    total = total + (pimienta * cantPimienta);
                    RunCondimentos();
                    break;

                case 2:
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese la cantidad de azucares que desea: ");
                    try
                    {
                        cantAzucar = Convert.ToInt32(Console.ReadLine());
                    }

                    catch
                    {
                        WriteLine("");
                        WriteLine("CARACTERES INCORRECTOS... Debe ingresar un valor numerico");
                        WriteLine("Pulse cualquier tecla para reintentar...");
                        ReadKey();
                    }
                    total = total + (azucar * cantAzucar);
                    RunCondimentos();
                    break;

                case 3:
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese la cantidad de oreganos que desea: ");
                    try
                    {
                        cantOregano = Convert.ToInt32(Console.ReadLine());
                    }

                    catch
                    {
                        WriteLine("");
                        WriteLine("CARACTERES INCORRECTOS... Debe ingresar un valor numerico");
                        WriteLine("Pulse cualquier tecla para reintentar...");
                        ReadKey();
                    }
                    total = total + (oregano * cantOregano);
                    RunCondimentos();
                    break;

                case 4:
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese la cantidad de salsas que desea: ");
                    try
                    {
                        cantSalsa = Convert.ToInt32(Console.ReadLine());
                    }

                    catch
                    {
                        WriteLine("");
                        WriteLine("CARACTERES INCORRECTOS... Debe ingresar un valor numerico");
                        WriteLine("Pulse cualquier tecla para reintentar...");
                        ReadKey();
                    }
                    total = total + (salsa * cantSalsa);
                    RunCondimentos();
                    break;

                case 5:
                    RunClasificacion();
                    break;

                default:
                    break;
            }
        }

        public void RunFrutas()
        {
            string Prompt = @"
  _____           _            
 |  ___| __ _   _| |_ __ _ ___ 
 | |_ | '__| | | | __/ _` / __|
 |  _|| |  | |_| | || (_| \__ \
 |_|  |_|   \__,_|\__\__,_|___/


Estos son nuestros frutas, que desea comprar?

El total de su compra es: $" + total;

            Console.WriteLine("");

            string[] Options = { "Manzana = $15", "Banana = $20", "Sandía = $25", "Piña = $15", "Fresa = $5", "* Volver al menu de productos *" };

            Frutas MenuDeFrutas = new Frutas(Prompt, Options);
            int SelectedIndex = MenuDeFrutas.RunFrutas();

            switch (SelectedIndex)
            {
                case 0:
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese la cantidad de mazanas que desea: ");
                    try
                    {
                        cantManzana = Convert.ToInt32(Console.ReadLine());
                    }

                    catch
                    {
                        WriteLine("");
                        WriteLine("CARACTERES INCORRECTOS... Debe ingresar un valor numerico");
                        WriteLine("Pulse cualquier tecla para reintentar...");
                        ReadKey();
                    }
                    total = total + (manzana * cantManzana);
                    RunFrutas();
                    break;

                case 1:
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese la cantidad de bananas que desea: ");
                    try
                    {
                        cantBanana = Convert.ToInt32(Console.ReadLine());
                    }

                    catch
                    {
                        WriteLine("");
                        WriteLine("CARACTERES INCORRECTOS... Debe ingresar un valor numerico");
                        WriteLine("Pulse cualquier tecla para reintentar...");
                        ReadKey();
                    }
                    total = total + (banana * cantBanana);
                    RunFrutas();
                    break;

                case 2:
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese la cantidad de sandías que desea: ");
                    try
                    {
                        cantSandia = Convert.ToInt32(Console.ReadLine());
                    }

                    catch
                    {
                        WriteLine("");
                        WriteLine("CARACTERES INCORRECTOS... Debe ingresar un valor numerico");
                        WriteLine("Pulse cualquier tecla para reintentar...");
                        ReadKey();
                    }
                    total = total + (sandia * cantSandia);
                    RunFrutas();
                    break;

                case 3:
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese la cantidad de piñas que desea: ");
                    try
                    {
                        cantPiña = Convert.ToInt32(Console.ReadLine());
                    }

                    catch
                    {
                        WriteLine("");
                        WriteLine("CARACTERES INCORRECTOS... Debe ingresar un valor numerico");
                        WriteLine("Pulse cualquier tecla para reintentar...");
                        ReadKey();
                    }
                    total = total + (piña * cantPiña);
                    RunFrutas();
                    break;

                case 4:
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese la cantidad de fresas que desea: ");
                    try
                    {
                        cantFresa = Convert.ToInt32(Console.ReadLine());
                    }

                    catch
                    {
                        WriteLine("");
                        WriteLine("CARACTERES INCORRECTOS... Debe ingresar un valor numerico");
                        WriteLine("Pulse cualquier tecla para reintentar...");
                        ReadKey();
                    }
                    total = total + (fresa * cantFresa);
                    RunFrutas();
                    break;

                case 5:
                    RunClasificacion();
                    break;

                default:
                    break;
            }
        }



        private void Comprar()
        {
            RunClasificacion();
        }

        private void Salir()
        {
            WriteLine("Pulsa cualquier tecla para salir...");
            ReadKey(true);
            Environment.Exit(0);
        }

        private void Viveres()
        {
            RunViveres();
        }

        private void Bebidas()
        {
            RunBebidas();
        }

        private void Condimentos()
        {
            RunCondimentos();
        }

        private void Frutas()
        {
            RunFrutas();
        }

        //private void Pagar()
        //{
        
        //}


        private void Factura()
        {
            Clear();
        
            Console.WriteLine("|—————————————————————————————————————————————————————————————————————|");
            Console.WriteLine($"|{" Producto",-20} {"|",0} {"Precio",-13} {"|",0} {"Cantidad",-12} {"|",0} {"Total",-15}|");
            Console.WriteLine("|—————————————————————————————————————————————————————————————————————|");
            if (total == 0)
            {
                WriteLine("");
                WriteLine("Aun no ha realizado ninguna compra.");
                WriteLine("Pulsa cualquier tecla para volver al menu principal...");
                ReadKey();
                Start();
            }

            if (cantPlatanos != 0)
            {
                Console.WriteLine($"|{" Platanos",-20} {"|",-1} {"$25",-13} {"|",-1} {cantPlatanos,-12} {"|",-1} ${cantPlatanos * platanos,-14}|");
                Console.WriteLine("|—————————————————————————————————————————————————————————————————————|");
            }            

            if (cantYuca != 0)
            {
                Console.WriteLine($"|{" Yucas",-20} {"|",-1} {"$30",-13} {"|",-1} {cantYuca,-12} {"|",-1} ${cantYuca * yuca,-14}|");                
                Console.WriteLine("|—————————————————————————————————————————————————————————————————————|");
            }

             if (cantGuineo != 0)
            {
                Console.WriteLine($"|{" Guineos",-20} {"|",-1} {"$5",-13} {"|",-1} {cantGuineo,-12} {"|",-1} ${cantGuineo * guineo,-14}|");                
                Console.WriteLine("|—————————————————————————————————————————————————————————————————————|");
            }

             if (cantPapa != 0)
            {
                Console.WriteLine($"|{" Papas",-20} {"|",-1} {"$25",-13} {"|",-1} {cantPapa,-12} {"|",-1} ${cantPapa * papa,-14}|");
                Console.WriteLine("|—————————————————————————————————————————————————————————————————————|");
            }

             if (cantYautia != 0)
            {
                Console.WriteLine($"|{" Yautias",-20} {"|",-1} {"$5",-13} {"|",-1} {cantYautia,-12} {"|",-1} ${cantYautia * yautia,-14}|");
                Console.WriteLine("|—————————————————————————————————————————————————————————————————————|");
            }

             if (cantJugo != 0)
            {
                Console.WriteLine($"|{" Jugos",-20} {"|",-1} {"$25",-13} {"|",-1} {cantJugo,-12} {"|",-1} ${cantJugo * jugo,-14}|");
                Console.WriteLine("|—————————————————————————————————————————————————————————————————————|");
            }

             if (cantSoda != 0)
            {
                Console.WriteLine($"|{" Sodas",-20} {"|",-1} {"$15",-13} {"|",-1} {cantSoda,-12} {"|",-1} ${cantSoda * soda,-14}|");                
                Console.WriteLine("|—————————————————————————————————————————————————————————————————————|");
            }

             if (cantGatorade != 0)
            {
                Console.WriteLine($"|{" Gatorades",-20} {"|",-1} {"$60",-13} {"|",-1} {cantGatorade,-12} {"|",-1} ${cantGatorade * gatorade,-14}|");
                Console.WriteLine("|—————————————————————————————————————————————————————————————————————|");
            }            

             if (cantMaltamorena != 0)
            {
                Console.WriteLine($"|{" Malta Morena",-20} {"|",-1} {"$50",-13} {"|",-1} {cantMaltamorena,-12} {"|",-1} ${cantMaltamorena * maltamorena,-14}|");
                Console.WriteLine("|—————————————————————————————————————————————————————————————————————|");
            }

             if (cantCerveza != 0)
            {
                Console.WriteLine($"|{" Cervezas",-20} {"|",-1} {"$50",-13} {"|",-1} {cantCerveza,-12} {"|",-1} ${cantCerveza * cerveza,-14}|");
                Console.WriteLine("|—————————————————————————————————————————————————————————————————————|");
            }

             if (cantManzana != 0)
            {
                Console.WriteLine($"|{" Manzanas",-20} {"|",-1} {"$15",-13} {"|",-1} {cantManzana,-12} {"|",-1} ${cantManzana * manzana,-14}|");
                Console.WriteLine("|—————————————————————————————————————————————————————————————————————|");
            }

             if (cantBanana != 0)
            {
                Console.WriteLine($"|{" Bananas",-20} {"|",-1} {"$20",-13} {"|",-1} {cantBanana,-12} {"|",-1} ${cantBanana * banana,-14}|");
                Console.WriteLine("|—————————————————————————————————————————————————————————————————————|");
            }

            if (cantPiña != 0)
            {
                Console.WriteLine($"|{" Piñas",-20} {"|",-1} {"$15",-13} {"|",-1} {cantPiña,-12} {"|",-1} ${cantPiña * piña,-14}|");
                Console.WriteLine("|—————————————————————————————————————————————————————————————————————|");
            }

            if (cantSandia != 0)
            {
                Console.WriteLine($"|{" Sandias",-20} {"|",-1} {"$25",-13} {"|",-1} {cantSandia,-12} {"|",-1} ${cantSandia * sandia,-14}|");
                Console.WriteLine("|—————————————————————————————————————————————————————————————————————|");
            }

             if (cantFresa != 0)
            {
                Console.WriteLine($"|{" Fresas",-20} {"|",-1} {"$5",-13} {"|",-1} {cantFresa,-12} {"|",-1} ${cantFresa * fresa,-14}|");
                Console.WriteLine("|—————————————————————————————————————————————————————————————————————|");
            }

             if (cantSal != 0)
            {
                Console.WriteLine($"|{" Sales",-20} {"|",-1} {"$10",-13} {"|",-1} {cantSal,-12} {"|",-1} ${cantSal * sal,-14}|");
                Console.WriteLine("|—————————————————————————————————————————————————————————————————————|");
            }

             if (cantAzucar != 0) 
            {
                Console.WriteLine($"|{" Azucares",-20} {"|",-1} {"$15",-13} {"|",-1} {cantAzucar,-12} {"|",-1} ${cantAzucar * azucar,-14}|");
                Console.WriteLine("|—————————————————————————————————————————————————————————————————————|");
            }            

             if (cantOregano != 0) 
            {
                Console.WriteLine($"|{" Oreganos",-20} {"|",-1} {"$5",-13} {"|",-1} {cantOregano,-12} {"|",-1} ${cantOregano * oregano,-14}|");
                Console.WriteLine("|—————————————————————————————————————————————————————————————————————|");
            }            

            if (cantPimienta != 0) 
            {
                Console.WriteLine($"|{" Pimientas",-20} {"|",-1} {"$10",-13} {"|",-1} {cantPimienta,-12} {"|",-1} ${cantPimienta * pimienta,-14}|");
                Console.WriteLine("|—————————————————————————————————————————————————————————————————————|");
            }

            if (cantSalsa != 0)
            {
                Console.WriteLine($"|{" Salsas",-20} {"|",-1} {"$20",-13} {"|",-1} {cantSalsa,-12} {"|",-1} ${cantSalsa * salsa,-14}|");
                Console.WriteLine("|—————————————————————————————————————————————————————————————————————|");
            }

        
            WriteLine("");
            Console.WriteLine($"El total general de su compra es: ${total}");
            Write("Con cuanto desea pagar: ");

            try
            {
                cash = Convert.ToInt32(Console.ReadLine());
            }
            
            catch
            {
                WriteLine("");
                WriteLine("CARACTERES INCORRECTOS... Debe ingresar un valor numerico");
                WriteLine("Pulse cualquier tecla para reintentar...");
                ReadKey();
                Factura();
            }                        

            //catch
            //{
            //    WriteLine($"El monto de ${cash} no es suficiente para realizar la compra.");
            //    ReadKey();
            //}


            if (cash < total)
            {
                WriteLine("");
                Console.WriteLine($"El monto de ${cash} no es suficiente para realizar la compra.");
                WriteLine("Pulse cualquier tecla para reintentar el pago...");
                Console.ReadKey();
                Console.Clear();
                Factura();
                
            }

            //if (cash == null)
            //{
            //    WriteLine("");
            //    Console.WriteLine($"El monto de ${cash} no es suficiente para realizar la compra.");
            //    WriteLine("Pulse cualquier tecla para reintentar el pago...");
            //    Console.ReadKey();
            //    Console.Clear();
            //    Factura();
            //}

            else
            {
                WriteLine("");
                Console.WriteLine($"Su cambio es de: ${cash - total}");
                WriteLine("Pulse cualquier tecla para volver al menu principal...");
                total = 0;
                Console.ReadKey();
                limpiarfactura();
                RunMainMenu();
            }                    


        }

        private void limpiarfactura()
        {
            /* cantViveres */
            cantPlatanos = 0; cantYuca = 0; cantGuineo = 0; cantPapa = 0; cantYautia = 0;
            /* cantBebidas */
            cantJugo = 0; cantSoda = 0; cantGatorade = 0; cantMaltamorena = 0; cantCerveza = 0;
            /* cantFrutas */
            cantManzana = 0; cantBanana = 0; cantSandia = 0; cantPiña = 0; cantFresa = 0;
            /* cantCondimentos */
            cantSal = 0; cantPimienta = 0; cantAzucar = 0; cantOregano = 0; cantSalsa = 0;
            cantTotal = 0;

            /*Dinero para pagar*/
            cash = 0;

            Start();

        }









    }




}
