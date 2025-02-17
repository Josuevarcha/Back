﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaBoscoso.Views.InicioLogin;

namespace LibreriaBoscoso.Views.Gerente
{
    public partial class ConsultarLibro : Form
    {
        public ConsultarLibro()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AgregarNuevoLibro nuevoLibro = new AgregarNuevoLibro();
            nuevoLibro.Show();
            this.Hide();
        }

        private void consultarLibrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarLibro bucarLibro = new ConsultarLibro();
            bucarLibro.Show();
            this.Hide();
        }

        private void consultarVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarVentas consultarVentas = new ConsultarVentas();
            consultarVentas.Show();
            this.Hide();
        }

        private void consultarPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarPedido consultarPedido = new ConsultarPedido();
            consultarPedido.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GerentePrincipal gerentePrincipal = new GerentePrincipal();
            gerentePrincipal.Show();
            this.Hide();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            EditarLibro editarLibro = new EditarLibro();
            editarLibro.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            VerLibro verLibro = new VerLibro();
            verLibro.Show();
            this.Hide();
        }
    }
}
