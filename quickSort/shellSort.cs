using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quickSort
{
    class shellSort
    {
        int[] arreglo;
        int contadorComparaciones;
        int contadorIntercambios;
        public int[] metodoShellSort(int[] array)
        {
            arreglo = array;
            bool ban = false;
            int i;
            int aux;
            int acumulador = arreglo.Length / 2;//INT
            while (acumulador > 0)
            {
                // acumulador = (acumulador / 2);
                ban = true;
                while (ban == true)
                {
                    ban = false;
                    i = 1;
                    while (i <= (arreglo.Length - acumulador))
                    {
                        if (arreglo[i - 1] > arreglo[(i - 1) + acumulador])
                        {
                            aux = arreglo[i - 1 + acumulador];
                            arreglo[(i - 1) + acumulador] = arreglo[i - 1];
                            arreglo[i - 1] = aux;
                            ban = true;
                            contadorIntercambios++;
                        }
                        contadorComparaciones++;
                        i++;
                    }

                }
                acumulador = acumulador / 2;
            }
            return arreglo;

        }
        public int[] contadores()
        {
            int[] arregloContadores = new int[2];
            arregloContadores[0] = contadorComparaciones;
            arregloContadores[1] = contadorIntercambios;
            return arregloContadores;
        }
    }
}
