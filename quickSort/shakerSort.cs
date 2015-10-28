using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quickSort
{
    class shakerSort
    {
         int[] arreglo;
        int izquierda;
        int derecha;
        int auxiliar;
        int comparaciones;
        int intercambios;
        int final;
        public shakerSort(int [] arreglo1)
        {
            arreglo = arreglo1;
        }

        public int[] MetodoShakerSort() 
        {
           
            izquierda = 1;
            derecha = arreglo.Length-1;
            final = derecha;
            while (derecha >= izquierda)
            {
                for (int i = derecha; i > izquierda; i--)
                {
                    comparaciones++;
                    if (arreglo[i] < arreglo[i - 1])
                    {
                        
                        auxiliar = arreglo[i - 1];
                        arreglo[i - 1] = arreglo[i];
                        arreglo[i] = auxiliar;
                        intercambios++;
                        final = i;
                    }
                }

               izquierda = final + 1;



                for (int y = 1; derecha > y; y++)
                {
                    comparaciones++;
                    if (arreglo[y - 1] > arreglo[y])
                    {
                       
                        auxiliar = arreglo[y - 1];
                        arreglo[y - 1] = arreglo[y];
                        arreglo[y] = auxiliar;
                         intercambios++;
                        final = y;
                    }
                }
                derecha = final - 1;
                comparaciones++;
            }
               
                return arreglo;
            
            
 
        }
        public int[] contadores()
        {
            int[] contador = new int[2];
            contador[0] = comparaciones;
            contador[1] = intercambios;
            return contador;
        }
    }
    }

