using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heredacion_clase_carro
{
    internal class camionvolteo : Carro
    {
        public int bajarhidrodeposito = 0;
        public int subirhidrodeposito= 0;

        public camionvolteo(string _marca, int _modelo, string _color, int maxvel) : base(_marca, _modelo, _color, maxvel)
        {
        }


        public string deposito()
        {
           
            if (subirhidrodeposito == 0)
            {

                subirhidrodeposito = 1;

                return "EL DEPOSITO A EMPEZADO A ELEVARSE\n se ha retirado la carga";

            }
            else
            {

                return "El DEPOSITO NO SE HA ACTIVADO";

            }

          

        }

        public string regresardepo()
        {
            string mensaje = "";
            if (bajarhidrodeposito == 0)
            {

                bajarhidrodeposito = 1;

                mensaje = "\nEL DEPOSITO ESTA REGRESANDO";

            }
            else
            {

                mensaje = "El ESTA ARRIBA";

            }

            return mensaje;

        }





    }
}
