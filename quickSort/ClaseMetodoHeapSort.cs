using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quickSort
{
    class ClaseMetodoHeapSort
    {
          int ContaInter;
        int ContaCompa ;
        int[] Contadores;


        public void ordenacionMonticulos(int[] arrayAuxiliar) 
        {
        int N = arrayAuxiliar.Length;
        for(int nodo = N/2; nodo>=0; nodo--) hacerMonticulo(arrayAuxiliar, nodo, N-1);
        for (int nodo = N - 1; nodo >= 0; nodo--)
        {
            int tmp = arrayAuxiliar[0];
            arrayAuxiliar[0] = arrayAuxiliar[nodo];
            arrayAuxiliar[nodo] = tmp;
            hacerMonticulo(arrayAuxiliar, 0, nodo - 1);
        }
        }

        public void hacerMonticulo(int[] Arreglo, int nodo, int fin)
        {
        int izq = 2*nodo+1;
        int der = izq+1;
        int may;
        if (izq > fin)
        {
        ContaCompa++;
        return;
        }
        if(der>fin) may=izq;
        else may = Arreglo[izq] > Arreglo[der] ? izq : der;
        if (Arreglo[nodo] < Arreglo[may])
        {
            int tmp = Arreglo[nodo];
            Arreglo[nodo] = Arreglo[may];
            Arreglo[may] = tmp;
            hacerMonticulo(Arreglo, may, fin);
            ContaInter++;
        }
        }

        public int[] contadorCambios()
        {
            Contadores = new int[2];
            Contadores[0] = ContaInter;
            Contadores[1] = ContaCompa;
            return Contadores;

        }



    }
    }

