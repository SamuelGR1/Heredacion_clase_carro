using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heredacion_clase_carro
{
    internal class Camioneta : Carro

    {
        public int CapasidadCarga = 70;
        public int carga = 0;

        public Camioneta(string _marca, int _modelo, string _color, int maxvel) : base(_marca, _modelo, _color, maxvel)
        {
        }

        public string Limitecarga()
        {

            if(carga < CapasidadCarga)
            {
                carga += 10;
                return $"Has  cargando a la camioneta unos kilos: total {carga} kilos";

            }
            else
            {
                carga = CapasidadCarga;
                return "HAS ALCANZADO EL LIMITE DE CARGA";
            }
        
        }

        public string Descarga()
        {

            if (carga == 0)
            {
                
                return $"CAMIONETA DESCARGADA {carga} kilos";

            }
            else
            {

                carga -= 10;
                return $"has descargado de la camioneta algunos kilos: total {carga} kilos";
            }

        }






    }
}
