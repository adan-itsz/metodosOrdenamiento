using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quickSort
{
    class bubbleSort
    {
        int i = 0;
        int j = 0;
        int contadorInter = 0;
        int contadorComp = 0;

        int[] contadores;
        int[] arreglo;

        bool bandera = true;
        int auxi_intercambio;

        public int[] Burbuja(int[] arreglo1)
        {
                arreglo=arreglo1;

            for (i = 0; i < arreglo.Length && bandera == true; i++)
            {
                bandera = false;

                for (j = 0; j < arreglo.Length - i - 1; j++)
                {

                    if (arreglo[j] > arreglo[j + 1])
                    {
                        contadorInter++;
                        auxi_intercambio = arreglo[j];
                        arreglo[j] = arreglo[j + 1];
                        arreglo[j + 1] = auxi_intercambio;
                        bandera = true;
                        
                    }
                    contadorComp++;
                }
            }

            return this.arreglo;
        }



        public int[] contadorCambios()
        {
            contadores = new int[2];
            contadores[0] = contadorInter;
            contadores[1] = contadorComp;
            return contadores;
        }
    }
}
