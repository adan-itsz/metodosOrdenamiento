using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quickSort
{
    class quickSort
    {
        
        int[] arreglo;
        int izquierda ;
        int derecha;
        int pivote;
        int aux;
        bool band;
        public quickSort(int[] array)
        {
            arreglo = array;
        }

        public int[] metodoQuickSort(int ini ,int fin)
        {
            
            
            izquierda = ini;
            derecha = fin;
            pivote = izquierda;
            band = true;
            while (band)
            {
                band = false;
                while (arreglo[pivote] <= arreglo[derecha] && pivote != derecha)
                {
                    derecha= derecha- 1;
                }
                if (pivote != derecha)
                {
                    aux = arreglo[pivote];
                    arreglo[pivote] = arreglo[derecha];
                    arreglo[derecha] = aux;
                    pivote = derecha;
                    while (arreglo[pivote] >= arreglo[izquierda] && pivote != izquierda)
                    {
                        izquierda++;
                    }
                    if (pivote != izquierda)
                    {
                        band = true; ;
                        aux= arreglo[pivote];
                        arreglo[pivote] = arreglo[izquierda];
                        arreglo[izquierda] = aux;
                        pivote = izquierda;
                    }
                }
            }
            if (pivote - 1 > ini)// 0 es la posicion del inicio
            {
                metodoQuickSort(ini, pivote - 1);
            }
            if (fin > (pivote + 1))
            {
                metodoQuickSort(pivote + 1, fin);
            }
            return arreglo;
        }
    }
}
