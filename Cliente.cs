using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perfil_aceniceros
{
    public class Cliente
    {

        private string nombre;
        private string dni;
        private string direccion;
        private List<RedSocial> redes;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Dni { get => dni; set => dni = value; }
        public List<RedSocial> Redes { get => redes; set => redes = value; }

        public Cliente(string nombre, string dni, string direccion)
        {
            this.nombre = nombre;
            this.dni = dni;
            this.direccion = direccion;
            this.redes = new List<RedSocial>();
        }

        public Cliente()
        {
            this.nombre = "";
            this.dni = "";
            this.direccion = "";
            this.redes = new List<RedSocial>();

        }

        public bool AnadirRed(RedSocial red)
        {
            foreach (RedSocial r in redes)
            {
                if (r.Id != red.Id)
                {
                    redes.Add(r);
                    return true;
                }
                else
                {

                    Console.WriteLine("El id ya existe en el cliente");
                }
            }
            return false;
        }

        public bool EliminarRed(int id)
        {
            foreach (RedSocial r in redes)
            {
                if (r.Id == id)
                {

                    redes.Remove(r);
                    return true;
                }
                else
                {

                    Console.WriteLine("La red no se encuentra en la lista del cliente");

                }

            }
            return false;
        }

        public void MostrarRedes()
        {

            if (redes.Count == 0)
            {
                Console.WriteLine("Este cliente no tiene Redes Sociales.");
                return;
            }

            Console.WriteLine("Redes Sociales:");
            foreach (RedSocial r in redes)
            {
                Console.WriteLine(r);

            }
        }

        public void MostrarInstagram()
        {
            foreach (RedSocial r in redes)
            {
                if (r is Instagram)
                {

                    Console.WriteLine(r);

                }
            }

        }

        public void MostrarLinkedin()
        {
            foreach (RedSocial r in redes)
            {
                if (r is Linkedin)
                {

                    Console.WriteLine(r);

                }
            }

        }

        public double MediaMinutos()
        { 

            double mediaMinutos;
            int cont=0;
            double sum = 0;
       
            foreach (Instagram i in redes)
            {
                if (i is Instagram)
                {

                    sum = sum + i.MinutosVideo;
                    cont++;

                }
            }

            return mediaMinutos = sum / cont;

        }

        public override string ToString() 
        {
            MostrarRedes();
            return "{Cliente "+this.nombre + " " + this.dni + " " + this.direccion+"}"; 
        }

    }
}
