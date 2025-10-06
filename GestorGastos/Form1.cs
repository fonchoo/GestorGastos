using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace GestorGastos
{
    public partial class Form1 : Form
    {
        private List<Gasto> listaGastos = new List<Gasto>();
        private Dictionary<string, PresupuestoCategoria> presupuestosPorCategoria
            = new Dictionary<string, PresupuestoCategoria>();

        public Form1()
        {
            InitializeComponent();
        }
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Por favor, ingresa un nombre para el gasto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una categoria.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (nudMonto.Value <= 0)
            {
                MessageBox.Show("El monto debe ser mayor a 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var gasto = new Gasto()
            {
                Nombre = txtNombre.Text,
                Categoria = cmbCategoria.Text,
                Monto = nudMonto.Value,
                Fecha = DateTime.Now
            };

            listaGastos.Add(gasto);

            if (presupuestosPorCategoria.ContainsKey(gasto.Categoria))
            {
                presupuestosPorCategoria[gasto.Categoria].GastoAcumulado += gasto.Monto;
            }

            dgvGastos.DataSource = null;
            dgvGastos.DataSource = listaGastos;

            lblTotal.Text = "Total gastado: $" + CalcularTotal().ToString("N0");
            ActualizarProgressBar();

            txtNombre.Clear();
            cmbCategoria.SelectedIndex = -1;
            nudMonto.Value = 0;
        }

        private decimal CalcularTotal()
        {
            decimal total = 0;
            foreach (var g in listaGastos)
            {
                total += g.Monto;
            }
            return total;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvGastos.SelectedRows.Count > 0)
            {
                var gasto = (Gasto)dgvGastos.SelectedRows[0].DataBoundItem;

                if (presupuestosPorCategoria.ContainsKey(gasto.Categoria))
                {
                    presupuestosPorCategoria[gasto.Categoria].GastoAcumulado -= gasto.Monto;
                }

                listaGastos.Remove(gasto);

                dgvGastos.DataSource = null;
                dgvGastos.DataSource = listaGastos;

                lblTotal.Text = "Total: $" + CalcularTotal();
                ActualizarProgressBar();
            }
            else
            {
                MessageBox.Show("Por favor selecciona un gasto para eliminar.");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvGastos.SelectedRows.Count > 0)
            {
                var gasto = (Gasto)dgvGastos.SelectedRows[0].DataBoundItem;

                decimal montoAnterior = gasto.Monto;
                string categoriaAnterior = gasto.Categoria;

                gasto.Nombre = txtNombre.Text;
                gasto.Categoria = cmbCategoria.Text;
                gasto.Monto = nudMonto.Value;

                if (categoriaAnterior != gasto.Categoria)
                {
                    if (presupuestosPorCategoria.ContainsKey(categoriaAnterior))
                    {
                        presupuestosPorCategoria[categoriaAnterior].GastoAcumulado -= montoAnterior;
                    }
                    if (presupuestosPorCategoria.ContainsKey(gasto.Categoria))
                    {
                        presupuestosPorCategoria[gasto.Categoria].GastoAcumulado += gasto.Monto;
                    }
                }
                else
                {
                    if (presupuestosPorCategoria.ContainsKey(gasto.Categoria))
                    {
                        presupuestosPorCategoria[gasto.Categoria].GastoAcumulado -= montoAnterior;
                        presupuestosPorCategoria[gasto.Categoria].GastoAcumulado += gasto.Monto;
                    }
                }

                dgvGastos.DataSource = null;
                dgvGastos.DataSource = listaGastos;

                lblTotal.Text = "Total: $" + CalcularTotal();
                ActualizarProgressBar();
            }
            else
            {
                MessageBox.Show("Selecciona un gasto para editar.");
            }
        }

        private void ActualizarProgressBar()
        {
            flpPresupuestos.Controls.Clear();
            foreach (var p in presupuestosPorCategoria.Values)
            {
                int porcentaje = (int)Math.Round(p.PorcentajeUsado);
                porcentaje = Math.Max(0, Math.Min(100, porcentaje));

                Label lbl = new Label();
                lbl.Text = $"{p.Categoria}: ${p.GastoAcumulado:N0} / ${p.PresupuestoAsignado:N0} ({porcentaje}%)";
                lbl.AutoSize = true;

                // Usamos la nueva barra de progreso
                ColoredProgressBar pb = new ColoredProgressBar();
                pb.Width = 200;
                pb.Minimum = 0;
                pb.Maximum = 100;
                pb.Value = porcentaje;

                if (p.GastoAcumulado > p.PresupuestoAsignado)
                {
                    pb.ProgressColor = Color.Red;
                    MessageBox.Show(
                        $"¡Has superado el presupuesto en la categoria {p.Categoria}!",
                        "Presupuesto excedido",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
                else
                {
                    pb.ProgressColor = Color.Green;
                }

                flpPresupuestos.Controls.Add(lbl);
                flpPresupuestos.Controls.Add(pb);
            }

            lblPresupuestoTotal.Text = $"Presupuesto total: ${CalcularPresupuestoTotal():N0}";
            lblGastoTotal.Text = $"Gasto total: ${CalcularTotal():N0}";
        }


        private decimal CalcularPresupuestoTotal()
        {
            decimal total = 0;
            foreach (var p in presupuestosPorCategoria.Values)
            {
                total += p.PresupuestoAsignado;
            }
            return total;
        }

        private void btnAsignarPresupuesto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbCategoriaPresupuesto.Text))
            {
                MessageBox.Show("Debe seleccionar una categoría.");
                return;
            }

            string categoria = cmbCategoriaPresupuesto.Text;
            decimal monto = nudPresupuesto.Value;

            AgregarPresupuestoCategoria(categoria, monto);

            if (!presupuestosPorCategoria.ContainsKey(categoria))
            {
                presupuestosPorCategoria[categoria] = new PresupuestoCategoria
                {
                    Categoria = categoria,
                    PresupuestoAsignado = monto,
                    GastoAcumulado = 0
                };
            }
            else
            {
                presupuestosPorCategoria[categoria].PresupuestoAsignado = monto;
            }

            MessageBox.Show($"Presupuesto asignado para {categoria}: ${monto:N0}");

            ActualizarProgressBar();
        }

        private void AgregarPresupuestoCategoria(string categoria, decimal presupuesto)
        {
            if (!presupuestosPorCategoria.ContainsKey(categoria))
            {
                decimal gastoAcumulado = 0;
                foreach (var g in listaGastos)
                {
                    if (g.Categoria == categoria)
                    {
                        gastoAcumulado += g.Monto;
                    }
                }

                presupuestosPorCategoria[categoria] = new PresupuestoCategoria()
                {
                    Categoria = categoria,
                    PresupuestoAsignado = presupuesto,
                    GastoAcumulado = gastoAcumulado
                };
            }
            else
            {
                presupuestosPorCategoria[categoria].PresupuestoAsignado = presupuesto;

                decimal gastoAcumulado = 0;
                foreach (var g in listaGastos)
                {
                    if (g.Categoria == categoria)
                    {
                        gastoAcumulado += g.Monto;
                    }
                }
                presupuestosPorCategoria[categoria].GastoAcumulado = gastoAcumulado;
            }

            ActualizarProgressBar();
        }

        private void dgvGastos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var gasto = (Gasto)dgvGastos.Rows[e.RowIndex].DataBoundItem;

                txtNombre.Text = gasto.Nombre;
                cmbCategoria.Text = gasto.Categoria;
                nudMonto.Value = gasto.Monto;
            }
        }
    }

    public class Gasto
    {
        public string Nombre {  get; set; }
        public string Categoria { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }
    }

    public class PresupuestoCategoria
    {
        public string Categoria { get; set; }
        public decimal PresupuestoAsignado { get; set; }
        public decimal GastoAcumulado { get; set; }

        public decimal PorcentajeUsado
        {
            get
            {
                if (PresupuestoAsignado == 0) return 0;
                return (GastoAcumulado / PresupuestoAsignado) * 100;
            }
        }
    }   
    public class ColoredProgressBar : ProgressBar
        {
            public Color ProgressColor { get; set; } = Color.Green;

            public ColoredProgressBar()
            {
                this.SetStyle(ControlStyles.UserPaint, true);
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                Rectangle rect = this.ClientRectangle;

                // Fondo
                e.Graphics.FillRectangle(new SolidBrush(this.BackColor), rect);

                // Progreso
                rect.Width = (int)(rect.Width * ((double)Value / Maximum));
                e.Graphics.FillRectangle(new SolidBrush(this.ProgressColor), 0, 0, rect.Width, this.Height);
            }
        }

}
