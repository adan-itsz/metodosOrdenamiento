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
        int[] arrayAuxiliar;
        int longitudArreglo;
        int num;
        int[] arreglo2;
        int[] arregloComparaciones;
        bool ban = true;
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
            arrayAuxiliar = array;
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
                 j++;
             }
             MessageBox.Show("arreglo lleno");
            
        }

        private void btnShellSort_Click(object sender, EventArgs e)
        {
                dataGridView1.Columns.Add("", "ShellSort");
                columna++;
             arreglo2 = new int[longitudArreglo];
            arreglo2 = shell.metodoShellSort(arrayAuxiliar);
            for (int i = 0; i < arreglo2.Length; i++)
            {
                dataGridView1[columna, i].Value = arreglo2[i];
            }
            int[] arregloComparaciones = shell.contadores();
            txtShellComparaciones.Text = Convert.ToString (arregloComparaciones[0]);
            txtShellIntercambios.Text = Convert.ToString(arregloComparaciones[1]);

        }

        private void btnQuickSort_Click(object sender, EventArgs e)
        {
            quickSort quick = new quickSort(arrayAuxiliar);
            
                dataGridView1.Columns.Add("", "QuickSort");
                columna++;
                arreglo2 = new int[longitudArreglo];
            arreglo2 = quick.metodoQuickSort(0,array.Length -1);
            for (int i = 0; i < arreglo2.Length; i++)
            {
                dataGridView1[columna,i].Value = arreglo2[i];
            }
             int[]arregloComparaciones2 = new int[2];
              arregloComparaciones2= quick.contadoresMetodo();
            txtQuickComparaciones.Text = Convert.ToString(arregloComparaciones2[0]);
            txtQuickIntercambios.Text = Convert.ToString(arregloComparaciones2[1]);
        }

        private void btnBubble_Click(object sender, EventArgs e)
        {
            
                dataGridView1.Columns.Add("", "BubbleSort");
                columna++;
                arreglo2 = new int[longitudArreglo];
            arreglo2 = bubble.Burbuja(arrayAuxiliar);
            for (int i = 0; i < arreglo2.Length; i++)
            {
                dataGridView1[columna, i].Value = arreglo2[i];
           }
            int[]arregloComparaciones3 = new int[2];
            arregloComparaciones3 = bubble.contadorCambios();
            txtBubbleComparaciones.Text = Convert.ToString(arregloComparaciones3[1]);
            txtBubbleIntercambios.Text = Convert.ToString(arregloComparaciones3[0]);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            array = new int[0];
            columna = 0;
            arrayAuxiliar = new int[0];
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
            ClaseMetodoHeapSort heap = new ClaseMetodoHeapSort();
            dataGridView1.Columns.Add("", "HeapSort");
            columna++;
            heap.ordenacionMonticulos(arrayAuxiliar);
            arreglo2 = new int[longitudArreglo];
            arreglo2 = arrayAuxiliar;
            for (int i = 0; i < arreglo2.Length; i++)
            {
                dataGridView1[columna, i].Value = arreglo2[i];
            }
            int[]arregloComparaciones4 = new int[2];
            arregloComparaciones4 = heap.contadorCambios();
            txtHeapComparaciones.Text = Convert.ToString(arregloComparaciones4[1]);
            txtHeapIntercambios.Text = Convert.ToString(arregloComparaciones4[0]);
        
        }

        private void btnShaker_Click(object sender, EventArgs e)
        {
            shakerSort shake = new shakerSort(arrayAuxiliar);
            dataGridView1.Columns.Add("", "ShakerSort");
            columna++;
            arreglo2= new int[longitudArreglo];
            arreglo2 = shake.MetodoShakerSort();
            for (int i = 0; i < arreglo2.Length; i++)
            {
                dataGridView1[columna, i].Value = arreglo2[i];
            }
            int[] arregloComparaciones5 = new int[2];
            arregloComparaciones5 = shake.contadores();
            txtShakerComparaciones.Text = Convert.ToString(arregloComparaciones5[1]);
            txtShakerIntercambios.Text = Convert.ToString(arregloComparaciones5[0]);
        }
        }
    }

