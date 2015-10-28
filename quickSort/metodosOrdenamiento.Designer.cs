namespace quickSort
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxCantidadElementos = new System.Windows.Forms.TextBox();
            this.btnLlenar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnQuickSort = new System.Windows.Forms.Button();
            this.btnShellSort = new System.Windows.Forms.Button();
            this.txtShellComparaciones = new System.Windows.Forms.TextBox();
            this.txtShellIntercambios = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQuickIntercambios = new System.Windows.Forms.TextBox();
            this.txtQuickComparaciones = new System.Windows.Forms.TextBox();
            this.txtBubbleIntercambios = new System.Windows.Forms.TextBox();
            this.txtBubbleComparaciones = new System.Windows.Forms.TextBox();
            this.btnBubble = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtHeapIntercambios = new System.Windows.Forms.TextBox();
            this.txtHeapComparaciones = new System.Windows.Forms.TextBox();
            this.btnHeap = new System.Windows.Forms.Button();
            this.txtShakerIntercambios = new System.Windows.Forms.TextBox();
            this.txtShakerComparaciones = new System.Windows.Forms.TextBox();
            this.btnShaker = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(199, 123);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Longitud de arreglo";
            // 
            // txtBoxCantidadElementos
            // 
            this.txtBoxCantidadElementos.Location = new System.Drawing.Point(41, 124);
            this.txtBoxCantidadElementos.Name = "txtBoxCantidadElementos";
            this.txtBoxCantidadElementos.Size = new System.Drawing.Size(131, 22);
            this.txtBoxCantidadElementos.TabIndex = 9;
            // 
            // btnLlenar
            // 
            this.btnLlenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLlenar.Location = new System.Drawing.Point(41, 178);
            this.btnLlenar.Name = "btnLlenar";
            this.btnLlenar.Size = new System.Drawing.Size(151, 29);
            this.btnLlenar.TabIndex = 12;
            this.btnLlenar.Text = "Llenar random";
            this.btnLlenar.UseVisualStyleBackColor = true;
            this.btnLlenar.Click += new System.EventHandler(this.btnLlenar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(460, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(511, 367);
            this.dataGridView1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Elige metodo de ordenamiento";
            // 
            // btnQuickSort
            // 
            this.btnQuickSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuickSort.Location = new System.Drawing.Point(16, 344);
            this.btnQuickSort.Name = "btnQuickSort";
            this.btnQuickSort.Size = new System.Drawing.Size(151, 29);
            this.btnQuickSort.TabIndex = 15;
            this.btnQuickSort.Text = "QuickSort";
            this.btnQuickSort.UseVisualStyleBackColor = true;
            this.btnQuickSort.Click += new System.EventHandler(this.btnQuickSort_Click);
            // 
            // btnShellSort
            // 
            this.btnShellSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShellSort.Location = new System.Drawing.Point(16, 289);
            this.btnShellSort.Name = "btnShellSort";
            this.btnShellSort.Size = new System.Drawing.Size(151, 29);
            this.btnShellSort.TabIndex = 16;
            this.btnShellSort.Text = "ShellSort";
            this.btnShellSort.UseVisualStyleBackColor = true;
            this.btnShellSort.Click += new System.EventHandler(this.btnShellSort_Click);
            // 
            // txtShellComparaciones
            // 
            this.txtShellComparaciones.Location = new System.Drawing.Point(199, 296);
            this.txtShellComparaciones.Name = "txtShellComparaciones";
            this.txtShellComparaciones.Size = new System.Drawing.Size(109, 22);
            this.txtShellComparaciones.TabIndex = 17;
            // 
            // txtShellIntercambios
            // 
            this.txtShellIntercambios.Location = new System.Drawing.Point(345, 293);
            this.txtShellIntercambios.Name = "txtShellIntercambios";
            this.txtShellIntercambios.Size = new System.Drawing.Size(109, 22);
            this.txtShellIntercambios.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Comparaciones";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Intercambios";
            // 
            // txtQuickIntercambios
            // 
            this.txtQuickIntercambios.Location = new System.Drawing.Point(345, 345);
            this.txtQuickIntercambios.Name = "txtQuickIntercambios";
            this.txtQuickIntercambios.Size = new System.Drawing.Size(109, 22);
            this.txtQuickIntercambios.TabIndex = 22;
            // 
            // txtQuickComparaciones
            // 
            this.txtQuickComparaciones.Location = new System.Drawing.Point(199, 348);
            this.txtQuickComparaciones.Name = "txtQuickComparaciones";
            this.txtQuickComparaciones.Size = new System.Drawing.Size(109, 22);
            this.txtQuickComparaciones.TabIndex = 21;
            // 
            // txtBubbleIntercambios
            // 
            this.txtBubbleIntercambios.Location = new System.Drawing.Point(345, 398);
            this.txtBubbleIntercambios.Name = "txtBubbleIntercambios";
            this.txtBubbleIntercambios.Size = new System.Drawing.Size(109, 22);
            this.txtBubbleIntercambios.TabIndex = 25;
            // 
            // txtBubbleComparaciones
            // 
            this.txtBubbleComparaciones.Location = new System.Drawing.Point(199, 395);
            this.txtBubbleComparaciones.Name = "txtBubbleComparaciones";
            this.txtBubbleComparaciones.Size = new System.Drawing.Size(109, 22);
            this.txtBubbleComparaciones.TabIndex = 24;
            // 
            // btnBubble
            // 
            this.btnBubble.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBubble.Location = new System.Drawing.Point(16, 391);
            this.btnBubble.Name = "btnBubble";
            this.btnBubble.Size = new System.Drawing.Size(151, 29);
            this.btnBubble.TabIndex = 23;
            this.btnBubble.Text = "BubbleSort";
            this.btnBubble.UseVisualStyleBackColor = true;
            this.btnBubble.Click += new System.EventHandler(this.btnBubble_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(360, 12);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 26;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtHeapIntercambios
            // 
            this.txtHeapIntercambios.Location = new System.Drawing.Point(345, 443);
            this.txtHeapIntercambios.Name = "txtHeapIntercambios";
            this.txtHeapIntercambios.Size = new System.Drawing.Size(109, 22);
            this.txtHeapIntercambios.TabIndex = 29;
            // 
            // txtHeapComparaciones
            // 
            this.txtHeapComparaciones.Location = new System.Drawing.Point(199, 440);
            this.txtHeapComparaciones.Name = "txtHeapComparaciones";
            this.txtHeapComparaciones.Size = new System.Drawing.Size(109, 22);
            this.txtHeapComparaciones.TabIndex = 28;
            // 
            // btnHeap
            // 
            this.btnHeap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHeap.Location = new System.Drawing.Point(16, 436);
            this.btnHeap.Name = "btnHeap";
            this.btnHeap.Size = new System.Drawing.Size(151, 29);
            this.btnHeap.TabIndex = 27;
            this.btnHeap.Text = "HeapSort";
            this.btnHeap.UseVisualStyleBackColor = true;
            this.btnHeap.Click += new System.EventHandler(this.btnHeap_Click);
            // 
            // txtShakerIntercambios
            // 
            this.txtShakerIntercambios.Location = new System.Drawing.Point(345, 496);
            this.txtShakerIntercambios.Name = "txtShakerIntercambios";
            this.txtShakerIntercambios.Size = new System.Drawing.Size(109, 22);
            this.txtShakerIntercambios.TabIndex = 32;
            // 
            // txtShakerComparaciones
            // 
            this.txtShakerComparaciones.Location = new System.Drawing.Point(199, 493);
            this.txtShakerComparaciones.Name = "txtShakerComparaciones";
            this.txtShakerComparaciones.Size = new System.Drawing.Size(109, 22);
            this.txtShakerComparaciones.TabIndex = 31;
            // 
            // btnShaker
            // 
            this.btnShaker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShaker.Location = new System.Drawing.Point(16, 489);
            this.btnShaker.Name = "btnShaker";
            this.btnShaker.Size = new System.Drawing.Size(151, 29);
            this.btnShaker.TabIndex = 30;
            this.btnShaker.Text = "ShakerSort";
            this.btnShaker.UseVisualStyleBackColor = true;
            this.btnShaker.Click += new System.EventHandler(this.btnShaker_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 530);
            this.Controls.Add(this.txtShakerIntercambios);
            this.Controls.Add(this.txtShakerComparaciones);
            this.Controls.Add(this.btnShaker);
            this.Controls.Add(this.txtHeapIntercambios);
            this.Controls.Add(this.txtHeapComparaciones);
            this.Controls.Add(this.btnHeap);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtBubbleIntercambios);
            this.Controls.Add(this.txtBubbleComparaciones);
            this.Controls.Add(this.btnBubble);
            this.Controls.Add(this.txtQuickIntercambios);
            this.Controls.Add(this.txtQuickComparaciones);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtShellIntercambios);
            this.Controls.Add(this.txtShellComparaciones);
            this.Controls.Add(this.btnShellSort);
            this.Controls.Add(this.btnQuickSort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLlenar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxCantidadElementos);
            this.Name = "frmPrincipal";
            this.Text = "Métodos de ordenamiento";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxCantidadElementos;
        private System.Windows.Forms.Button btnLlenar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnQuickSort;
        private System.Windows.Forms.Button btnShellSort;
        private System.Windows.Forms.TextBox txtShellComparaciones;
        private System.Windows.Forms.TextBox txtShellIntercambios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQuickIntercambios;
        private System.Windows.Forms.TextBox txtQuickComparaciones;
        private System.Windows.Forms.TextBox txtBubbleIntercambios;
        private System.Windows.Forms.TextBox txtBubbleComparaciones;
        private System.Windows.Forms.Button btnBubble;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtHeapIntercambios;
        private System.Windows.Forms.TextBox txtHeapComparaciones;
        private System.Windows.Forms.Button btnHeap;
        private System.Windows.Forms.TextBox txtShakerIntercambios;
        private System.Windows.Forms.TextBox txtShakerComparaciones;
        private System.Windows.Forms.Button btnShaker;

    }
}

