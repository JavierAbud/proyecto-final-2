using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace proyecto_final_2
{
    class Entrada
    {
        /* Viveres */
        Int32 platanos = 25, yuca = 30, guineo = 5, papa = 25, cebolla = 5;
        /* Bebidas */
        Int32 jugo = 25, soda = 15, gatorade = 60, maltamorena = 50, cerveza = 50;
        /* Frutas */
        Int32 manzana = 15, banana = 20, sandia = 25, piña = 15, fresa = 5;
        /* Condimentos */
        Int32 sal = 10, pimienta = 10, azucar = 15, oregano = 5, salsa = 20;
        Int32 total = 0;

        /* cantViveres */
        int cantPlatanos = 0, cantYuca = 0, cantGuineo = 0, cantPapa = 0, cantCebolla = 0;
        /* cantBebidas */
        int cantJugo = 0, cantSoda = 0, cantGatorade = 0, cantMaltamorena = 0, cantCerveza = 0;
        /* cantFrutas */
        int cantManzana = 0, cantBanana = 0, cantSandia = 0, cantPiña = 0, cantFresa = 0;
        /* cantCondimentos */
        int cantSal = 0, cantPimienta = 0, cantAzucar = 0, cantOregano = 0, cantSalsa = 0;
        int cantTotal = 0;

        





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
            string[] Options = { "COMPRAR", "SALIR","Pagar" };

            Menu MainMenu = new Menu(Prompt, Options);
            int SelectedIndex = MainMenu.Run();

            switch (SelectedIndex)
            {
                case 0:
                    Comprar();
                    break;
                case 1:
                    Salir();
                    break;

                case 2:
                    Factura();
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

            string[] Options = { "Platanos = $25", "Yuca = $30", "Guineo = $5", "Papa = $25", "Cebolla = $5", "* Volver al menu de clasificaciones *" };

            Viveres MenuDeViveres = new Viveres(Prompt, Options);
            int SelectedIndex = MenuDeViveres.RunViveres();

            switch (SelectedIndex)
            {
                case 0:
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese la cantidad de platanos que desea: ");
                    cantPlatanos = Convert.ToInt32(Console.ReadLine());
                    total = total + (platanos * cantPlatanos);
                    RunViveres();
                    break;

                case 1:
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese la cantidad de yuca que desea: ");
                    cantYuca = Convert.ToInt32(Console.ReadLine());
                    total = total + (yuca * cantYuca);
                    RunViveres();
                    break;

                case 2:
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese la cantidad de guineos que desea: ");
                    cantGuineo = Convert.ToInt32(Console.ReadLine());
                    total = total + (guineo * cantGuineo);
                    RunViveres();
                    break;

                case 3:
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese la cantidad de papas que desea: ");
                    cantPapa = Convert.ToInt32(Console.ReadLine());
                    total = total + (papa * cantPapa);
                    RunViveres();
                    break;

                case 4:
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese la cantidad de cebollas que desea: ");
                    cantCebolla = Convert.ToInt32(Console.ReadLine());
                    total = total + (cebolla * cantCebolla);
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

            string[] Options = { "Jugo = $25", "Soda = $15", "Gatorade = $60", "Maltamorena = $50", "Cerveza = $50", "* Volver al menu de clasificaciones *" };

            Bebidas MenuDeBebidas = new Bebidas(Prompt, Options);
            int SelectedIndex = MenuDeBebidas.RunBebidas();

            switch (SelectedIndex)
            {
                case 0:
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese la cantidad de jugos que desea: ");
                    cantJugo = Convert.ToInt32(Console.ReadLine());
                    total = total + (jugo * cantJugo);
                    RunBebidas();
                    break;

                case 1:
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese la cantidad de sodas que desea: ");
                    cantSoda = Convert.ToInt32(Console.ReadLine());
                    total = total + (soda * cantSoda);
                    RunBebidas();
                    break;

                case 2:
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese la cantidad de gatorades que desea: ");
                    cantGatorade = Convert.ToInt32(Console.ReadLine());
                    total = total + (gatorade * cantGatorade);
                    RunBebidas();
                    break;

                case 3:
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese la cantidad de maltamorenas que desea: ");
                    cantMaltamorena = Convert.ToInt32(Console.ReadLine());
                    total = total + (maltamorena * cantMaltamorena); RunBebidas();
                    break;
                    ;
                case 4:
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese la cantidad de cervezas que desea: ");
                    cantCerveza = Convert.ToInt32(Console.ReadLine());
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

            string[] Options = { "Sal = $10", "Pimienta = $10", "Azucar = $15", "Oregano = $5", "Salsa = $20", "* Volver al menu de clasificaciones *" };

            Frutas MenuDeFrutas = new Frutas(Prompt, Options);
            int SelectedIndex = MenuDeFrutas.RunFrutas();

            switch (SelectedIndex)
            {
                case 0:
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese la cantidad de sales que desea: ");
                    cantSal = Convert.ToInt32(Console.ReadLine());
                    total = total + (sal * cantSal);
                    RunCondimentos();
                    break;

                case 1:
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese la cantidad de pimientas que desea: ");
                    cantPimienta = Convert.ToInt32(Console.ReadLine());
                    total = total + (pimienta * cantPimienta);
                    RunCondimentos();
                    break;

                case 2:
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese la cantidad de azucares que desea: ");
                    cantAzucar = Convert.ToInt32(Console.ReadLine());
                    total = total + (azucar * cantAzucar);
                    RunCondimentos();
                    break;

                case 3:
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese la cantidad de oreganos que desea: ");
                    cantOregano = Convert.ToInt32(Console.ReadLine());
                    total = total + (oregano * cantOregano);
                    RunCondimentos();
                    break;

                case 4:
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese la cantidad de salsas que desea: ");
                    cantSalsa = Convert.ToInt32(Console.ReadLine());
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

            string[] Options = { "Manzana = $15", "Banana = $20", "Sandía = $25", "Piña = $15", "Fresa = $5", "* Volver al menu de clasificaciones *" };

            Frutas MenuDeFrutas = new Frutas(Prompt, Options);
            int SelectedIndex = MenuDeFrutas.RunFrutas();

            switch (SelectedIndex)
            {
                case 0:
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese la cantidad de mazanas que desea: ");
                    cantManzana = Convert.ToInt32(Console.ReadLine());
                    total = total + (manzana * cantManzana);
                    RunFrutas();
                    break;

                case 1:
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese la cantidad de bananas que desea: ");
                    cantBanana = Convert.ToInt32(Console.ReadLine());
                    total = total + (banana * cantBanana);
                    RunFrutas();
                    break;

                case 2:
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese la cantidad de sandías que desea: ");
                    cantSandia = Convert.ToInt32(Console.ReadLine());
                    total = total + (sandia * cantSandia);
                    RunFrutas();
                    break;

                case 3:
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese la cantidad de piñas que desea: ");
                    cantPiña = Convert.ToInt32(Console.ReadLine());
                    total = total + (piña * cantPiña);
                    RunFrutas();
                    break;

                case 4:
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese la cantidad de fresas que desea: ");
                    cantFresa = Convert.ToInt32(Console.ReadLine());
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


        private void Factura()
        {
            Clear();
            if (cantPlatanos != 0)
            {

              WriteLine("Platanos 25$   ");
            }

            if (cantAzucar != 0) 
            { 
                WriteLine("Azucar 15$   " + cantAzucar*azucar);
            }

            if (cantBanana !=0) 
            {
                WriteLine("Banana 20$   " + cantBanana*banana);

            }

            if (cantCebolla != 0) 
            {
                WriteLine("Cebolla 5$   " + cantCebolla * cebolla);
            }

            if (cantCerveza != 0) 
            {
                WriteLine("Cerveza 50$   " + cantCerveza * cerveza);
            }

            if (cantFresa != 0) 
            {
                WriteLine("Fresa 5$   " + cantFresa * fresa);

            }

            if (cantGatorade !=0)
            {
                WriteLine("Gatorade 60$   " + cantGatorade * gatorade);
            }

            if (cantGuineo != 0) 
            {
                WriteLine("Guineo 5$   " + cantGuineo * guineo);
            }

            if (cantJugo !=0) 
            { 
                WriteLine("Jugo 25$   " + cantJugo * jugo);
            }

            if (cantMaltamorena !=0) 
            {
                WriteLine("Malta Morena 50$   " + cantMaltamorena * maltamorena);
            }

            if (cantManzana != 0) 
            {
                WriteLine("Manzana 15$   " + cantManzana * manzana);
            }

            if (cantOregano != 0) 
            {
                WriteLine("Oregano 5$   " + cantOregano * oregano);

            }

            if (cantPapa != 0) 
            {
                WriteLine("Papa 25$   " + cantPapa * papa);
            }

            if (cantPimienta != 0) 
            {
                WriteLine("Pimienta 10$   " + cantPimienta * pimienta);
            }




        }




        

    }




}
