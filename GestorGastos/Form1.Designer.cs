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
            btnEditar = new Button();
            btnEliminar = new Button();
            label4 = new Label();
            cmbCategoriaPresupuesto = new ComboBox();
            label5 = new Label();
            nudPresupuesto = new NumericUpDown();
            label6 = new Label();
            btnAsignarPresupuesto = new Button();
            flpPresupuestos = new FlowLayoutPanel();
            lblGastoTotal = new Label();
            lblPresupuestoTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)nudMonto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvGastos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPresupuesto).BeginInit();
            flpPresupuestos.SuspendLayout();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(729, 23);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(149, 29);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar gasto";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(324, 16);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(252, 27);
            txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(154, 23);
            label1.Name = "label1";
            label1.Size = new Size(130, 20);
            label1.TabIndex = 2;
            label1.Text = "Nombre del gasto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(154, 74);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 3;
            label2.Text = "Categoria";
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Items.AddRange(new object[] { "Comida", "Transporte", "Cuentas", "Salud", "Ocio", "Otros" });
            cmbCategoria.Location = new Point(324, 66);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(252, 28);
            cmbCategoria.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(154, 128);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 5;
            label3.Text = "Monto";
            // 
            // nudMonto
            // 
            nudMonto.Location = new Point(324, 126);
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
            dgvGastos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGastos.Size = new Size(595, 243);
            dgvGastos.TabIndex = 7;
            dgvGastos.CellClick += dgvGastos_CellClick;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(484, 519);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(123, 20);
            lblTotal.TabIndex = 8;
            lblTotal.Text = "Total gastado: 0$";
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(729, 70);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(149, 29);
            btnEditar.TabIndex = 9;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(729, 119);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(149, 29);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(644, 168);
            label4.Name = "label4";
            label4.Size = new Size(186, 20);
            label4.TabIndex = 11;
            label4.Text = "Presupuesto por categoria:";
            // 
            // cmbCategoriaPresupuesto
            // 
            cmbCategoriaPresupuesto.FormattingEnabled = true;
            cmbCategoriaPresupuesto.Items.AddRange(new object[] { "Comida", "Transporte", "Cuentas", "Salud", "Ocio", "Otros" });
            cmbCategoriaPresupuesto.Location = new Point(765, 209);
            cmbCategoriaPresupuesto.Name = "cmbCategoriaPresupuesto";
            cmbCategoriaPresupuesto.Size = new Size(209, 28);
            cmbCategoriaPresupuesto.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(653, 212);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 13;
            label5.Text = "Categoria";
            // 
            // nudPresupuesto
            // 
            nudPresupuesto.Location = new Point(765, 271);
            nudPresupuesto.Maximum = new decimal(new int[] { 1215752191, 23, 0, 0 });
            nudPresupuesto.Name = "nudPresupuesto";
            nudPresupuesto.Size = new Size(209, 27);
            nudPresupuesto.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(653, 273);
            label6.Name = "label6";
            label6.Size = new Size(89, 20);
            label6.TabIndex = 15;
            label6.Text = "Presupuesto";
            // 
            // btnAsignarPresupuesto
            // 
            btnAsignarPresupuesto.Location = new Point(1004, 240);
            btnAsignarPresupuesto.Name = "btnAsignarPresupuesto";
            btnAsignarPresupuesto.Size = new Size(159, 30);
            btnAsignarPresupuesto.TabIndex = 16;
            btnAsignarPresupuesto.Text = "Agregar presupuesto";
            btnAsignarPresupuesto.UseVisualStyleBackColor = true;
            btnAsignarPresupuesto.Click += btnAsignarPresupuesto_Click;
            // 
            // flpPresupuestos
            // 
            flpPresupuestos.Controls.Add(lblGastoTotal);
            flpPresupuestos.Controls.Add(lblPresupuestoTotal);
            flpPresupuestos.Location = new Point(653, 322);
            flpPresupuestos.Name = "flpPresupuestos";
            flpPresupuestos.Size = new Size(321, 217);
            flpPresupuestos.TabIndex = 17;
            // 
            // lblGastoTotal
            // 
            lblGastoTotal.AutoSize = true;
            lblGastoTotal.Location = new Point(3, 0);
            lblGastoTotal.Name = "lblGastoTotal";
            lblGastoTotal.Size = new Size(82, 20);
            lblGastoTotal.TabIndex = 19;
            lblGastoTotal.Text = "Gasto total";
            // 
            // lblPresupuestoTotal
            // 
            lblPresupuestoTotal.AutoSize = true;
            lblPresupuestoTotal.Location = new Point(91, 0);
            lblPresupuestoTotal.Name = "lblPresupuestoTotal";
            lblPresupuestoTotal.Size = new Size(124, 20);
            lblPresupuestoTotal.TabIndex = 18;
            lblPresupuestoTotal.Text = "Presupuesto total";
            // 
            // Form1
            // 
            ClientSize = new Size(1232, 551);
            Controls.Add(flpPresupuestos);
            Controls.Add(btnAsignarPresupuesto);
            Controls.Add(lblTotal);
            Controls.Add(label6);
            Controls.Add(nudPresupuesto);
            Controls.Add(label5);
            Controls.Add(cmbCategoriaPresupuesto);
            Controls.Add(label4);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
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
            ((System.ComponentModel.ISupportInitialize)nudPresupuesto).EndInit();
            flpPresupuestos.ResumeLayout(false);
            flpPresupuestos.PerformLayout();
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
        private Button btnEditar;
        private Button btnEliminar;
        private Label label4;
        private ComboBox cmbCategoriaPresupuesto;
        private Label label5;
        private NumericUpDown nudPresupuesto;
        private Label label6;
        private Button btnAsignarPresupuesto;
        private FlowLayoutPanel flpPresupuestos;
        private Label lblPresupuestoTotal;
        private Label lblGastoTotal;
    }
}
