using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace proyecto_final_2
{
    class Entrada
    {
        Int32 platanos = 25, yuca = 30, guineo = 5, papa = 25, cebolla = 5;
        Int32 jugo = 25, soda = 15, gatorade = 60, maltamorena = 50, cerveza = 50;
        Int32 sal = 10, pimienta = 10, azucar = 15, oregano = 5, salsa = 20;
        Int32 total = 0;
        public void Start()
        {
            Title = "Colmado";
            RunMainMenu();
        
        }

        //Menu principal
        private void RunMainMenu()
        {

            string Prompt = @" 
 _____       _                     _       
/  __ \     | |                   | |      
| /  \/ ___ | |_ __ ___   __ _  __| | ___  
| |    / _ \| | '_ ` _ \ / _` |/ _` |/ _ \ 
| \__/\ (_) | | | | | | | (_| | (_| | (_) |
 \____/\___/|_|_| |_| |_|\__,_|\__,_|\___/ 
                                           
                                          
Bienvenido a nuestro colmado, Como podemos ayudarle?
(Use las teclas de direccion para navegar por el menu y selecciona con la tecla Enter.)
";
            string[] Options = { "Comprar" , "Salir" };
             
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
                default:
                    break;
            }

        }
        //Menu de productos
        public void RunProductos()
        {

            string Prompt = @" 

  _____               _            _            
 |  __ \             | |          | |           
 | |__) | __ ___   __| |_   _  ___| |_ ___  ___ 
 |  ___/ '__/ _ \ / _` | | | |/ __| __/ _ \/ __|
 | |   | | | (_) | (_| | |_| | (__| || (_) \__ \
 |_|   |_|  \___/ \__,_|\__,_|\___|\__\___/|___/
                                                
                                                
                                           
Estos son nuestros productos, que desea comprar?
(Use las teclas de direccion para navegar por el menu y selecciona con la tecla Enter.)

El total de su compra es: 
"+ total


;
        

            string[] Options = { "platanos = 25", "yuca = 30", "guineo = 5", "papa = 25", "cebolla = 5", "jugo = 25", "soda = 15", " gatorade = 60", " maltamorena = 50", " cerveza = 50 ", "sal = 10", " pimienta = 10", " azucar = 15", " oregano = 5", "salsa = 20","","Volver al menu principal"};



            Productos MenudeProductos = new Productos(Prompt, Options);
            int SelectedIndex = MenudeProductos.RunProducts();

            switch (SelectedIndex)
            {
                case 0:

                    total = total + platanos;
                    RunProductos();
                    break;
                    
                    RunProductos();
                case 1:

                    total = total + yuca;
                    RunProductos();
                    break;
                case 2:

                    total = total + guineo;
                    RunProductos();
                    break;
                case 3:

                    total = total + papa;
                    RunProductos();
                    break;
                case 4:

                    total = total + cebolla;
                    RunProductos();
                    break;

                case 5:

                    total = total + jugo;
                    RunProductos();
                    break;

                case 6:

                    total = total + soda;
                    RunProductos();
                    break;

                case 7:

                    total = total + gatorade;
                    RunProductos();
                    break;

                case 8:

                    total = total + maltamorena;
                    RunProductos();
                    break;
                    ;
                case 9:

                    total = total + cerveza;
                    RunProductos();
                    break;

                case 10:
                    total = total + sal;
                    RunProductos();

                    break;
                case 11:
                    total = total + pimienta;
                    RunProductos();

                    break;

                case 12:
                    total = total + azucar;
                    RunProductos();

                    break;
                case 13:
                    total = total + oregano;
                    RunProductos();

                    break;
                case 14:
                    total = total + salsa;
                    RunProductos();
                    break;
                case 15:
                    RunProductos();
                    break;

                    break;
                case 16:
                    RunMainMenu();
                    break;
            }
        }


        private void Salir()
        {
            WriteLine("Pulsa cualquier tecla para salir...");
                ReadKey(true);
            Environment.Exit(0);
        
        
        }

        private void Comprar()
        {
            RunProductos();
        }

  
    }




}
