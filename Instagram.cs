using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perfil_aceniceros
{
    public class Instagram : RedSocial
    {

        private double minutosVideo;

        public double MinutosVideo { get => minutosVideo; set => minutosVideo = value; }

        public Instagram(string correo, string contrasena, string usuario, int numPost, double minutosVideo) : base(correo,contrasena,usuario,numPost)
    {
        this.minutosVideo = minutosVideo;
    }

    public Instagram() : base()
    {
        this.minutosVideo = 0.0;
    }



    public override string ToString()
    {
        return base.ToString() + "{ Instagram " + this.minutosVideo + "}";
    }
    }


}
