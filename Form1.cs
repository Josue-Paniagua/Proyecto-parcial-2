using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using formproyecto2.UI;

namespace formproyecto2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearJugador_Click(object sender, EventArgs e)
        {
            CrearJugadorForm crearJugadorForm = new CrearJugadorForm();
            if (crearJugadorForm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Jugador creado correctamente.");
            }
        }
        

        private void btnGestionarJugadores_Click_1(object sender, EventArgs e)
        {
            GestionarJugadoresForm gestionarJugadoresForm = new GestionarJugadoresForm();
            gestionarJugadoresForm.ShowDialog();
        }
    }
}
