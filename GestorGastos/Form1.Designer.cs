namespace GestorGastos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAgregar = new Button();
            txtNombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            cmbCategoria = new ComboBox();
            label3 = new Label();
            nudMonto = new NumericUpDown();
            dgvGastos = new DataGridView();
            lblTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)nudMonto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvGastos).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(594, 66);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(149, 29);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar gasto";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(182, 12);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(252, 27);
            txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(130, 20);
            label1.TabIndex = 2;
            label1.Text = "Nombre del gasto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 70);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 3;
            label2.Text = "Categoria";
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Items.AddRange(new object[] { "Comida", "Transporte", "Cuentas", "Ocio", "Otros" });
            cmbCategoria.Location = new Point(182, 62);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(252, 28);
            cmbCategoria.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 124);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 5;
            label3.Text = "Monto";
            // 
            // nudMonto
            // 
            nudMonto.Location = new Point(182, 122);
            nudMonto.Maximum = new decimal(new int[] { 1215752191, 23, 0, 0 });
            nudMonto.Name = "nudMonto";
            nudMonto.Size = new Size(252, 27);
            nudMonto.TabIndex = 6;
            // 
            // dgvGastos
            // 
            dgvGastos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGastos.Location = new Point(12, 259);
            dgvGastos.Name = "dgvGastos";
            dgvGastos.RowHeadersWidth = 51;
            dgvGastos.Size = new Size(511, 186);
            dgvGastos.TabIndex = 7;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(626, 288);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(65, 20);
            lblTotal.TabIndex = 8;
            lblTotal.Text = "Total: 0$";
            // 
            // Form1
            // 
            ClientSize = new Size(837, 480);
            Controls.Add(lblTotal);
            Controls.Add(dgvGastos);
            Controls.Add(nudMonto);
            Controls.Add(label3);
            Controls.Add(cmbCategoria);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Controls.Add(btnAgregar);
            Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudMonto).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvGastos).EndInit();
            ResumeLayout(false);
            PerformLayout();
            // 
        }

        #endregion

        private Button btnAgregar;
        private TextBox txtNombre;
        private Label label1;
        private Label label2;
        private ComboBox cmbCategoria;
        private Label label3;
        private NumericUpDown nudMonto;
        private DataGridView dgvGastos;
        private Label lblTotal;
    }
}
