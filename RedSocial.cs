using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perfil_aceniceros
{
    public abstract class RedSocial
    {
        private string correo;
        private string contrasena;
        private string usuario;
        private int numPost;
        private readonly int id;
        private static int contador = 0;

        public int Id => id;

        public RedSocial(string correo, string contrasena, string usuario, int numPost)
        {
            this.correo = correo;
            this.contrasena = contrasena;
            this.usuario = usuario;
            this.numPost = numPost;
            this.id = contador;
            contador++;


        }
        public RedSocial()
        {
            this.correo = "";
            this.contrasena = "";
            this.usuario = "";
            this.numPost = 0;
            this.id = contador;
            contador++;


        }

        public override string ToString()
        {
            return "{Red Social " + this.id + " " + this.correo + " " + this.contrasena + " " + this.usuario + " " + this.numPost + "}";
        }

    }
}

