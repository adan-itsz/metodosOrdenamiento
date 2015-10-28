using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quickSort
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        int[] array;
        //int[] arrayAuxiliar;
        // arreglos para cada metodo
            int[] arrayShell;
            int[] arrayQuick;
            int[] arrayBubble;
            int[] arrayHeap;
            int[] arrayShaker;
        int longitudArreglo;
        int num;
        int[] arreglo2;// se usa para recibir el arreglo de cada uno de los metodos
        int[] arregloComparaciones;
        int columna = 0;
        Random rand = new Random();
        // colocar aqui instancias de clase
        shellSort shell = new shellSort();
        bubbleSort bubble = new bubbleSort();
        
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try{
            dataGridView1.Columns.Add("", "arreglo original");
            longitudArreglo = Convert.ToInt32(txtBoxCantidadElementos.Text);
            array = new int[longitudArreglo];
            arrayShell = new int[longitudArreglo];
            arrayQuick= new int[longitudArreglo];
            arrayBubble = new int[longitudArreglo];
            arrayHeap= new int[longitudArreglo];
            arrayShaker= new int[longitudArreglo];
            for (int i = 0; i < longitudArreglo - 1; i++)
                {
                    dataGridView1.Rows.Add();
                }
            btnAceptar.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("llenar correctamente");
            }
        }

        private void btnLlenar_Click(object sender, EventArgs e)
        {
             int j = 0;
             
             while (j < array.Length)
             {
                 num = rand.Next(0, 200);
                 dataGridView1[0, j].Value = num;
                 array[j] = num;
                 arrayShell[j] = num;
                 arrayQuick[j] = num;
                 arrayBubble[j] = num;
                 arrayHeap[j] = num;
                 arrayShaker[j] = num;
                 j++;
             }
             MessageBox.Show("arreglo lleno");
            // arrayAuxiliar = array;
        }

        private void btnShellSort_Click(object sender, EventArgs e)
        {
                dataGridView1.Columns.Add("", "ShellSort");
                columna++;
               // arrayAuxiliar = array;
            arreglo2 = shell.metodoShellSort(arrayShell);
            for (int i = 0; i < arreglo2.Length; i++)
            {
                dataGridView1[columna, i].Value = arreglo2[i];
            }
             arregloComparaciones = shell.contadores();
            txtShellComparaciones.Text = Convert.ToString (arregloComparaciones[0]);
            txtShellIntercambios.Text = Convert.ToString(arregloComparaciones[1]);

        }

        private void btnQuickSort_Click(object sender, EventArgs e)
        {
            quickSort quick = new quickSort(arrayQuick);
            
                dataGridView1.Columns.Add("", "QuickSort");
                columna++;
            

            arreglo2 = quick.metodoQuickSort(0,arrayQuick.Length -1);
            for (int i = 0; i < arreglo2.Length; i++)
            {
                dataGridView1[columna,i].Value = arreglo2[i];
            }
            
              arregloComparaciones= quick.contadoresMetodo();
            txtQuickComparaciones.Text = Convert.ToString(arregloComparaciones[0]);
            txtQuickIntercambios.Text = Convert.ToString(arregloComparaciones[1]);
        }

        private void btnBubble_Click(object sender, EventArgs e)
        {
            
                dataGridView1.Columns.Add("", "BubbleSort");
                columna++;
            arreglo2 = bubble.Burbuja(arrayBubble);
            for (int i = 0; i < arreglo2.Length; i++)
            {
                dataGridView1[columna, i].Value = arreglo2[i];
           }
            
            arregloComparaciones = bubble.contadorCambios();
            txtBubbleComparaciones.Text = Convert.ToString(arregloComparaciones[1]);
            txtBubbleIntercambios.Text = Convert.ToString(arregloComparaciones[0]);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            array = new int[0];
            columna = 0;
           // arrayAuxiliar = new int[0];
            arrayShell = new int[0];
            arrayQuick = new int[0];
            arrayBubble = new int[0];
            arrayHeap = new int[0];
            arrayShaker = new int[0];
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            txtBoxCantidadElementos.Clear();
            txtBubbleComparaciones.Clear();
            txtBubbleIntercambios.Clear();
            txtHeapComparaciones.Clear();
            txtHeapIntercambios.Clear();
            txtQuickComparaciones.Clear();
            txtQuickIntercambios.Clear();
            txtShellComparaciones.Clear();
            txtShellIntercambios.Clear();
            txtShakerComparaciones.Clear();
            txtShakerIntercambios.Clear();
            btnAceptar.Enabled = true;
        }

        private void btnHeap_Click(object sender, EventArgs e)
        {
            ClaseMetodoHeapSort heap = new ClaseMetodoHeapSort(arrayHeap);
            dataGridView1.Columns.Add("", "HeapSort");
            columna++;
            heap.ordenacionMonticulos();
            arreglo2 = heap.arrayAuxiliar;
            for (int i = 0; i < arreglo2.Length; i++)
            {
                dataGridView1[columna, i].Value = arreglo2[i];
            }
            
            arregloComparaciones = heap.contadorCambios();
            txtHeapComparaciones.Text = Convert.ToString(arregloComparaciones[1]);
            txtHeapIntercambios.Text = Convert.ToString(arregloComparaciones[0]);
        
        }

        private void btnShaker_Click(object sender, EventArgs e)
        {
            shakerSort shake = new shakerSort(arrayShaker);
            dataGridView1.Columns.Add("", "ShakerSort");
            columna++;
            arreglo2= new int[longitudArreglo];
            arreglo2 = shake.MetodoShakerSort();
            for (int i = 0; i < arreglo2.Length; i++)
            {
                dataGridView1[columna, i].Value = arreglo2[i];
            }
           
            arregloComparaciones = shake.contadores();
            txtShakerComparaciones.Text = Convert.ToString(arregloComparaciones[0]);
            txtShakerIntercambios.Text = Convert.ToString(arregloComparaciones[1]);
            arregloComparaciones = null;
        }
        }
    }

