using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace perfil_aceniceros
{
    public class Empresa
    {
        private string nombre;
        private List<Cliente> lista;

        public List<Cliente> Lista { get => lista; set => lista = value; }

        public Empresa()
        {

            this.nombre = "";
            this.lista = new List<Cliente>();

        }

        public Empresa(string nombre)
        {
            this.nombre = nombre;
            this.lista = new List<Cliente>();

        }


        public void MostrarClientes()
        {


            foreach (Cliente c in lista)
            {
                Console.WriteLine(c);

            }

        }

        public override string ToString()
        {
            return this.nombre;
        }

        public bool AnadirCliente(Cliente c)
        {
            if (lista.Exists(cli => c.Nombre.Equals(cli.Nombre)))
            {
                Console.WriteLine("Ya existe el cliente.");
                return false; // Salir del método si ya existe una máquina con el mismo nombre
            }
            else
            {

                lista.Add(c);
                Console.WriteLine("Cliente agregado correctamente.");
                return true;
            }
        }

        public void BorrarCliente(string nombre)
        {

            foreach (Cliente c in lista)
            {

                if (c.Nombre.Equals(nombre))
                {
                    lista.Remove(c);
                    break;

                }

            }

        }

        public void MostrarEmpresa()
        {


            Console.WriteLine(ToString());
            MostrarClientes();
        }

    }
}
