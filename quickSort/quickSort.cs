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
        int[] contadores;
        int izquierda ;
        int derecha;
        int pivote;
        int aux;
        bool band;
        int contadorComparaciones;
        int contadorIntercambios;
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
                    contadorIntercambios++;
                    while (arreglo[pivote] >= arreglo[izquierda] && pivote != izquierda)
                    {
                        izquierda++;
                    }
                    if (pivote != izquierda)
                    {
                        band = true; 
                        aux= arreglo[pivote];
                        arreglo[pivote] = arreglo[izquierda];
                        arreglo[izquierda] = aux;
                        pivote = izquierda;
                        contadorIntercambios++;
                    }
                }
            }
            if (pivote - 1 > ini)// 0 es la posicion del inicio
            {
                contadorComparaciones++;
                metodoQuickSort(ini, pivote - 1);
            }
            if (fin > (pivote + 1))
            {
                contadorComparaciones++;
                metodoQuickSort(pivote + 1, fin);
            }
            return arreglo;
        }
        public int[] contadoresMetodo()
        {
            contadores= new int[2];
            contadores[0]=contadorComparaciones;
            contadores[1] = contadorIntercambios;
            return contadores;
        }
    }
}
