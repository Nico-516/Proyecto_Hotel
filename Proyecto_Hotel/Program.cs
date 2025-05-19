using System;

namespace Proyecto_Hotel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcionMenu = 0, habitacion = 0, dias = 0, claseSeleccion = 0, precio = 0;
            string nombre = "", claseHabitacion = "";
            
            Console.WriteLine("Este programa sirve para manejar las reservas de habitaciones en un hotel");
            
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1 - Consultar precios");
                Console.WriteLine("2 - Consultar habitaciones disponibles");
                Console.WriteLine("3 - Reservar una habitacion");
                Console.WriteLine("4 - Modificar / Cancelar una reserva");
                Console.WriteLine("5 - Ver datos ingresados ");
                Console.WriteLine("0 - Salir de la aplicacion");
                opcionMenu = int.Parse(Console.ReadLine());

                Console.Clear();

                switch (opcionMenu)
                {
                    case 1:
                        Console.WriteLine("Precios");
                        Console.WriteLine("La habitacion Economica esta a $1000 por dia.\n Incluye estadia y servicio a la habitacion\n");
                        Console.WriteLine("La habitacion Estandar esta a $2500 por dia.\n Incluye estadia, servicio a la habitacion y un descuento del 50% del desayuno\n");
                        Console.WriteLine("La habitacion Deluxe esta a $5000 por dia.\n Incluye estadia, servicio a la habitacion, desayuno gratis y prioridad a la hora de brindar servicos\n");
                        break;
                    case 2:
                        Console.WriteLine("Las habitaciones disponibles son:\n 1\n 2\n 3");
                        break;
                    case 3:
                        Console.WriteLine("Reserva");

                        for (int contadorClase = 0; contadorClase < 1;)
                        {
                            Console.WriteLine("Ingrese el numero de la clase de habitacion que desea reservar: ");
                            Console.WriteLine("1 - Clase Economica");
                            Console.WriteLine("2 - Clase Estandar");
                            Console.WriteLine("3 - Clase Deluxe");
                            claseSeleccion = int.Parse(Console.ReadLine());

                            if (claseSeleccion == 1)
                            {
                                claseHabitacion = "Economica";
                                contadorClase ++;
                            }
                            else if (claseSeleccion == 2)
                            {
                                claseHabitacion = "Estandar";
                                contadorClase ++;
                            }
                            else if (claseSeleccion == 3)
                            {
                                claseHabitacion = "Deluxe";
                                contadorClase ++;
                            }
                            else
                            {
                                Console.WriteLine("Ingrese un numero valido");
                            }
                            Console.Clear();
                        }
                        Console.Clear();

                        for (int contadorHabitacion = 0; contadorHabitacion < 1;)
                        {
                            Console.Write("Ingrese el numero de la habitacion en la que desea alojarse: ");
                            habitacion = int.Parse(Console.ReadLine());

                            if (habitacion == 1 || habitacion == 2 || habitacion == 3)
                            {
                                contadorHabitacion ++;
                            }
                            else
                            {
                                Console.WriteLine("Las habitaciones disponibles son:\n 1\n 2\n 3");
                            }
                        }

                        Console.Write("Ingrese su nombre: ");
                        nombre = Console.ReadLine();
                        Console.Clear();

                        Console.Write("Por cuantos dias desea reservar la habitacion?: ");
                        dias = int.Parse(Console.ReadLine());
                        Console.Clear();

                        if (claseHabitacion == "Economica")
                        {
                            precio = dias * 1000;
                        }
                        else if (claseHabitacion == "Estandar")
                        {
                            precio = dias * 2500;
                        }
                        else if (claseHabitacion == "Deluxe")
                        {
                            precio = dias * 5000;
                        }

                            break;
                    case 4:
                        break;
                    case 5:
                        Console.WriteLine("Nombre: " + nombre);
                        Console.WriteLine("Dias: " + dias);
                        Console.WriteLine("Clase: " + claseHabitacion);
                        Console.WriteLine("Precio: " + precio);
                        Console.WriteLine("Habitacion: " + habitacion);
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Ingrese un numero valido");
                        break;
                }


            } while (opcionMenu != 0);

            
        }
    }
}
