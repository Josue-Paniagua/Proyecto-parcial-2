using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MinecraftManager.Models;
using MinecraftManager.Services;
using MinecraftManager.Utils;

namespace formproyecto2.UI
{

    public partial class GestionarJugadoresForm : Form
    {
        private readonly JugadorService _jugadorService;

        public GestionarJugadoresForm()
        {
            InitializeComponent();
            _jugadorService = new JugadorService(new DatabaseManager());
            CargarJugadores();
        }

        private void CargarJugadores()
        {
            try
            {
                var jugadores = _jugadorService.ObtenerTodos();
                dgvJugadores.DataSource = jugadores;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar jugadores: {ex.Message}");
            }
        }


        private void GestionarJugadoresForm_Load(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvJugadores.SelectedRows.Count > 0)
            {
                var jugadorSeleccionado = (Jugador)dgvJugadores.SelectedRows[0].DataBoundItem;
                var confirmResult = MessageBox.Show($"¿Estás seguro de eliminar al jugador {jugadorSeleccionado.Nombre}?",
                                                    "Confirmar eliminación",
                                                    MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        _jugadorService.Eliminar(jugadorSeleccionado.Id);
                        MessageBox.Show("Jugador eliminado con éxito.");
                        CargarJugadores(); // Recargar la lista de jugadores
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al eliminar jugador: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un jugador para eliminar.");
            }
        }
        private void btEditar_Click(object sender, EventArgs e)
        {
            if (dgvJugadores.SelectedRows.Count > 0)
            {
                var jugadorSeleccionado = dgvJugadores.SelectedRows[0].DataBoundItem as Jugador;
                if (jugadorSeleccionado == null)
                {
                    MessageBox.Show("El jugador seleccionado no es válido.");
                    return;
                }

                // Abre el formulario de edición, pasándole el jugador
                var formEditar = new CrearJugadorForm(jugadorSeleccionado);

                if (formEditar.ShowDialog() == DialogResult.OK)
                {
                    CargarJugadores(); // Recarga la lista
                    MessageBox.Show("Jugador actualizado correctamente.");
                }
            }
            else
            {
                MessageBox.Show("Selecciona un jugador para editar.");
            }
        }
        private void dbtncrearb_Click(object sender, EventArgs e)
        {
            var formCrear = new CrearJugadorForm(); // Asumiendo que tienes este formulario
            if (formCrear.ShowDialog() == DialogResult.OK)
            {
                CargarJugadores(); // Actualiza el DataGridView después de crear un nuevo jugador
                MessageBox.Show("Jugador creado correctamente.");
            }
        }

        private void dgvJugadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

    

