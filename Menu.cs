using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace perfil_aceniceros
{
    public class Menu
    {
        private Empresa empresa;

        public Menu()
        {
            Empresa empresa = new Empresa();

        }

        public void MenuBasico()
        {

            Empresa empresa = new Empresa();


            Console.WriteLine("Introduce la opcion que deseas hacer:");
            Console.WriteLine("1 para crear empresa.");
            Console.WriteLine("2 para añadir un cliente.");
            Console.WriteLine("3 para añadir una red social a un cliente.");
            Console.WriteLine("4 para borrar la red social de un cliente.");
            Console.WriteLine("5 para mostrar todas las redes de un cliente por dni.");
            Console.WriteLine("6 mostrar instagram de un cliente.");
            Console.WriteLine("7 mostrar la media de minutos de video de un cliente.");
            Console.WriteLine("8 para mostrar todas las redes de todos los clientes.");
            Console.WriteLine("9 mostrar la info de una red de un cliente.");
            Console.WriteLine("0 para salir.");
            string input = Console.ReadLine();
            int opcion = Int32.Parse(input);

            while (opcion != 0)
            {

                switch (opcion)
                {
                    case 1: // Crear empresa

                        Console.WriteLine("Introduce el nombre de la empresa de comunicación");
                        string nombre = Console.ReadLine();
                        empresa = new Empresa(nombre);
                        empresa.Lista = new List<Cliente>();

                        break;

                    case 2: // Añadir cliente

                        Console.WriteLine("Introduce el nombre del cliente");
                        string name = Console.ReadLine();
                        Console.WriteLine("Introduce la dirección del cliente");
                        string address = Console.ReadLine();
                        Console.WriteLine("Introduce el número de DNI del cliente");
                        string dni = Console.ReadLine();
                        Cliente user = new Cliente (name, address, dni);
                              
                        empresa.AnadirCliente(user);

                        break;

                    case 3: // Añadir red social al cliente

                        Console.WriteLine("Introduce el nombre del cliente");
                        name = Console.ReadLine();
                        foreach (Cliente c in empresa.Lista)
                        {
                            if (c.Nombre.Equals(name))
                            {
                                Console.WriteLine("Indica el nombre de la red social (Instagram o Linkedin)");
                                nombre = Console.ReadLine();

                                Console.WriteLine("Introduce el correo vinculado a la cuenta");
                                string correo = Console.ReadLine();

                                Console.WriteLine("Introduce el nombre de usuario de la cuenta");
                                string usuario = Console.ReadLine();

                                Console.WriteLine("Introduce la contraseña para la cuenta");
                                string contrasena = Console.ReadLine();

                                Console.WriteLine("Introduce el número de posts en la red");
                                input = Console.ReadLine();
                                int numPost = Int32.Parse(input);

                                if (c.Nombre.Equals("Instagram"))
                                {
                                    Console.WriteLine("Introduce el número de minutos de visualización de vídeo");
                                    input = Console.ReadLine();
                                    int minVideo = Int32.Parse(input);
                                    RedSocial red = new Instagram(correo, contrasena, usuario, numPost, minVideo);
                                    c.AnadirRed(red);
                                }
                                else
                                {

                                    Console.WriteLine("Introduce el número de minutos de visualización de vídeo");
                                    input = Console.ReadLine();
                                    int numVisitas = Int32.Parse(input);
                                    RedSocial red = new Instagram(correo, contrasena, usuario, numPost, numVisitas);
                                    c.AnadirRed(red);


                                }

                            }else{

                                Console.WriteLine("El cliente no existe");
                            }

                        }
                        break;

                    case 4: // Eliminar red del cliente

                        Console.WriteLine("Introduce el nombre del cliente");
                        name = Console.ReadLine();
                        Console.WriteLine("Introduce el id de la red a eliminar");
                        input = Console.ReadLine();
                        int id = Int32.Parse(input);

                        foreach (Cliente c in empresa.Lista)
                        {
                            if (c.Nombre.Equals(name))
                            {

                                c.EliminarRed(id);

                            }
                        }
  
                       break;


                    case 5: // Mostrar todas las redes de un cliente por dni

                        Console.WriteLine("Introduce el dni del cliente");
                        dni = Console.ReadLine();

                        foreach (Cliente c in empresa.Lista)
                        {
                            if (c.Dni.Equals(dni))
                            {

                                c.MostrarRedes();

                            }
                        }

                        break;

                    case 6: //Mostrar redes de instagram de un cliente


                        foreach (Cliente c in empresa.Lista)
                        {

                            c.MostrarInstagram();
                        }
                        break;

                    case 7: // Media de minutos de vídeo de un cliente

                        Console.WriteLine("Introduce el dni del cliente del que quieras ver la media de minutos de vídeo");
                        dni = Console.ReadLine();

                        foreach (Cliente c in empresa.Lista)
                        {
                            if (c.Dni.Equals(dni))
                            {

                            Console.WriteLine(c.MediaMinutos());

                            }
                        }


                        break;

                     case 8: // Mostrar todo

                        empresa.MostrarEmpresa();

                      break;

                     case 9: // Mostrar la info de una red de un cliente

                        Console.WriteLine("Introduce el nombre del cliente");
                        name = Console.ReadLine();
                        Console.WriteLine("Introduce el id de la red a mostrar");
                        input = Console.ReadLine();
                        id = Int32.Parse(input);


                        foreach (Cliente c in empresa.Lista)
                        {
                            if (c.Nombre.Equals(name))
                            {
                                foreach (RedSocial r in c.Redes)
                                {

                                    if (r.Id == id)
                                    {
                                        Console.WriteLine(r);
                                    }
                                    else
                                    {
                                        Console.WriteLine("La red no existe para el cliente");
                                    }


                                }
                            }

                        }

                        break;

                    default:
                        Console.WriteLine("No has introducido una opción válida");
                        break;
                }

                Console.WriteLine("Introduce la opcion que deseas hacer:");
                Console.WriteLine("1 para crear empresa.");
                Console.WriteLine("2 para añadir un cliente.");
                Console.WriteLine("3 para añadir una red social a un cliente.");
                Console.WriteLine("4 para borrar la red social de un cliente.");
                Console.WriteLine("5 para mostrar todas las redes de un cliente por dni.");
                Console.WriteLine("6 mostrar instagram de un cliente.");
                Console.WriteLine("7 mostrar la media de minutos de video de un cliente.");
                Console.WriteLine("8 para mostrar todas las redes de todos los clientes.");
                Console.WriteLine("9 mostrar la info de una red de un cliente.");
                Console.WriteLine("0 para salir.");
                input = Console.ReadLine();
                opcion = Int32.Parse(input);
            }

            Console.WriteLine("¡Gracias por usar nuestra aplicación!");


        }

    }


}



