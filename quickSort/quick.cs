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
        int longitudArreglo;
        int num;
        Random rand = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("", "");
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try{
            longitudArreglo = Convert.ToInt32(txtBoxCantidadElementos.Text);
            array = new int[longitudArreglo];
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
    }
}
