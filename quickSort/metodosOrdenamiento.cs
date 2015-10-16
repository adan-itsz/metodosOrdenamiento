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
        Random rand = new Random();
        // colocar aqui instancias de clase
        shellSort shell = new shellSort();
        
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("","arreglo original");
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try{
            longitudArreglo = Convert.ToInt32(txtBoxCantidadElementos.Text);
            array = new int[longitudArreglo];
            arrayAuxiliar = array;
            for (int i = 0; i < longitudArreglo - 1; i++)
                {
                    dataGridView1.Rows.Add();
                }
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
             arreglo2 = new int[longitudArreglo];
            arreglo2 = shell.metodoShellSort(arrayAuxiliar);
            for (int i = 0; i < arreglo2.Length; i++)
            {
                dataGridView1[1, i].Value = arreglo2[i];
            }
        }

        private void btnQuickSort_Click(object sender, EventArgs e)
        {
            quickSort quick = new quickSort(arrayAuxiliar);
            dataGridView1.Columns.Add("", "QuickSort");
            arreglo2 = quick.metodoQuickSort(0,array.Length -1);
            for (int i = 0; i < arreglo2.Length; i++)
            {
                dataGridView1[2, i].Value = arreglo2[i];
            }
        }
    }
}
