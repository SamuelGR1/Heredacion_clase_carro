using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heredacion_clase_carro
{
    internal class Moto : Carro
    {

        private int Cambio = 5;
        private int metecambio = 0;
        private int foco = 0;

        public Moto(string _marca, int _modelo, string _color, int maxvel) : base(_marca, _modelo, _color, maxvel)
        {
        }


        public string Cambiovel()

        {
            if (metecambio == Cambio)
            {

                return "HAS LLEGADO AL LIMITE DE CAMBIOS";

            }
            else
            {
                metecambio += 1; 
                return $"Cambio de velocida a {metecambio}";

            }
            
        }

        public string Bajarcambio()

        {
            if (metecambio == 0)
            {

                return "No hay cambio metido";

            }
            else
            {
                metecambio -= 1;
                return $"Bajas el cambio a {metecambio}";

            }

        }



        public string luz()
        {
            if (foco == 0)
            {
                foco = 1;
                return  "Has prendido el Faro de luz";
            }
            else
            {
                return "EL Faro de luz esta apagado";

            }
        }

        public string Apagaluz()
        {
            if (foco == 1)
            {
                foco = 0;
                return "Has apagado el Faro de luz";
            }
            else
            {
                return "EL Faro de luz esta prendido";

            }
        }






    }


}
