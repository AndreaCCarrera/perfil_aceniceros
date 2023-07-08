using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perfil_aceniceros
{
    public class Linkedin : RedSocial
    {

        private int numVisitas;

    public Linkedin(string correo, string contrasena, string usuario, int numPost, int numVisitas) : base(correo, contrasena, usuario, numPost)
    {
        this.numVisitas = numVisitas;
    }

    public Linkedin() : base()
    {
            this.numVisitas = 0;
    }

    public override string ToString()
    {
        return base.ToString() + "{ Linkedin " + this.numVisitas + "}";
    }
}


}



