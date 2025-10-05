using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GestorGastos
{
    public partial class Form1 : Form
    {
        private List<Gasto> listaGastos = new List<Gasto>();
        public Form1()
        {
            InitializeComponent();
        }
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            var gasto = new Gasto()
            {
                Nombre = txtNombre.Text,
                Categoria = cmbCategoria.Text,
                Monto = nudMonto.Value,
                Fecha = DateTime.Now
            };

            listaGastos.Add(gasto);

            dgvGastos.DataSource = null;
            dgvGastos.DataSource = listaGastos;

            lblTotal.Text = "Total: $" + CalcularTotal();
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

    }

    public class Gasto
    {
        public string Nombre {  get; set; }
        public string Categoria { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }
    }
}
