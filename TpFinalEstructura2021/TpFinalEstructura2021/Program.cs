using System;
using System.Collections.Generic;
using System.Collections;


namespace pila
{
    class MainClass
    {


        public static void Main(string[] args)
        {

            
            Stack<string> miPila = new Stack<String>();
            miPila.Push("Batman");
            miPila.Push("Terminator");
            miPila.Push("Rambo");

            Stack<string> sugerencias = new Stack<String>();
            sugerencias.Push("Poca variedad");
            sugerencias.Push("Precio caro de membresia");
            sugerencias.Push("Pocas opciones de subtitulos");

            int opcion;




            Console.WriteLine(" ----------------------------------- ");
            Console.WriteLine(" ------PROGRAMA DE STREAMING-------- ");
            Console.WriteLine(" ----------------------------------- ");
            Console.WriteLine("");
            Console.WriteLine(" 1.  REGISTRO/INICIAR SESION         ");
            Console.WriteLine(" 2.      FAVORITOS                   ");
            Console.WriteLine(" 3.   ULTIMAS PELICULAS              ");
            Console.WriteLine(" 4.      SUGERENCIAS                 ");
            Console.WriteLine(" 5.        SALIR                     ");
            Console.WriteLine("");

            Console.WriteLine("Hola!! Elegi una opcion por favor: ");
            opcion = Convert.ToInt32(Console.ReadLine());
            bool salir = false;

            if (opcion < 1 || opcion > 5)
            {
                Console.WriteLine("");
                Console.WriteLine("-------------------------------------------------------------");
                Console.WriteLine("OPCION INVALIDA - VUELVA A INGRESAR UNA OPCION VALIDA (1 a 5)");
                Console.WriteLine("-------------------------------------------------------------");
                Console.WriteLine("");
            }

            while (!salir && opcion > 0 && opcion < 6)
                switch (opcion)
                {
                    case 1:
                        string user, pass, userconfirm, passconfirm;
                        Console.WriteLine("Bienvenido al registro de usuario de Blockbuster 2.0");
                        Console.WriteLine("Ingrese un alias para crear su cuenta");
                        user = Console.ReadLine();
                        Console.WriteLine("Introduzca su Contraseña");
                        pass = Console.ReadLine();
                        Console.WriteLine("Ingrese nuevamente su usuario para loguear ");
                        userconfirm = Console.ReadLine();
                        Console.WriteLine("Ingrese nuevamente su Contraseña para loguear ");
                        passconfirm = Console.ReadLine();

                        if (user != userconfirm || pass != passconfirm)
                            Console.WriteLine("Datos invalidos. Error al iniciar la cuenta. ");
                        else
                            Console.WriteLine("Bienvenidx {0}", user + " Esperamos que disfrutes de tus peliculas y series favoritas ;)");

                        string VolverMenu;

                        do
                        {
                            Console.Write("Desea volver al Menu Principal (S/N):");
                            VolverMenu = Console.ReadLine();

                            if (VolverMenu == "S")
                            {
                                Console.WriteLine("Bien! Vuelve a elegir una opcion del menu del 1 al 5!");
                                opcion = Convert.ToInt32(Console.ReadLine());
                                break;
                            }
                            else if (VolverMenu == "N")
                            {
                                Console.WriteLine("Adios! Gracias por utilizar nuestra plataforma!!");
                                Console.ReadKey();
                                Environment.Exit(0);
                            }
                        } while (VolverMenu != "S" || VolverMenu != "N");




                        break;



                    case 2:


                        Console.WriteLine("Tu Lista de favoritos");

                        {
                            Queue miCola = new Queue();
                            string frase = string.Empty;

                            do
                            {
                                Console.WriteLine("Ingrese peliculas o series a su lista de favoritas o ingrese una frase vacia para salir: ");
                                frase = Console.ReadLine();
                                miCola.Enqueue(frase);
                            } while (frase != string.Empty);

                            Console.WriteLine("Peliculas o series ingresadas a la lista de favoritos: ");

                            foreach (var item in miCola)
                            {
                                Console.WriteLine(item);
                            }
                        }
                        Console.WriteLine("Desea elegir otra opcion?");
                        opcion = Convert.ToInt32(Console.ReadLine());


                        break;

                    case 3:
                        Console.WriteLine("Lista de las ultimas peliculas vistas: ");

                        foreach (var item in miPila)
                            Console.WriteLine(item);

                        Console.WriteLine("Desea elegir otra opcion?");
                        opcion = Convert.ToInt32(Console.ReadLine());

                        break;


                    case 4:
                        Console.WriteLine("Lista de las ultimas sugerencias: ");

                        foreach (var sug in sugerencias)
                        Console.WriteLine(sug);
                        Console.WriteLine("Desea elegir otra opcion?");
                        opcion = Convert.ToInt32(Console.ReadLine());

                        break;

                    case 5:
                        Console.WriteLine("Adios! Gracias por utilizar nuestra plataforma!!");
                        Console.ReadKey();
                        Environment.Exit(0);

                        break;
                }
            



            }



        }
    }
