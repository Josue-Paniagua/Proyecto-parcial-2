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
using System.IO; 

namespace formproyecto2.UI
{
    public partial class CrearJugadorForm : Form
    {
        private readonly JugadorService _jugadorService;
        private readonly InventarioService _inventarioService; // Agrega esta línea aquí
        private readonly int? _jugadorId;

        public CrearJugadorForm()
        {
            InitializeComponent();
            _jugadorService = new JugadorService(new DatabaseManager());
        }

        // Constructor para editar un jugador existente
        public CrearJugadorForm(Jugador jugador) : this()
        {
            _jugadorId = jugador.Id; // Guardar el ID del jugador para actualizarlo
            txtNombre.Text = jugador.Nombre;
            numNivel.Value = jugador.Nivel;
        }
        private void CargarInventario(int jugadorId)
        {
            try
            {
                var inventario = _inventarioService.ObtenerPorJugador(jugadorId);
                dgvInventario.DataSource = inventario;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el inventario: {ex.Message}");
            }
        }
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que el nombre no esté vacío
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("El nombre del jugador no puede estar vacío.");
                    return;
                }

                // Crear o actualizar un jugador
                Jugador jugador = new Jugador
                {
                    Id = _jugadorId ?? 0, // Si es nulo, se asume que es un nuevo jugador
                    Nombre = txtNombre.Text,
                    Nivel = (int)numNivel.Value,
                    FechaCreacion = DateTime.Now
                };

                if (_jugadorId.HasValue)
                {
                    // Actualizar jugador existente
                    _jugadorService.Actualizar(jugador);
                    MessageBox.Show("Jugador actualizado con éxito.");
                }
                else
                {
                    // Crear un nuevo jugador
                    _jugadorService.Crear(jugador);
                    MessageBox.Show("Jugador creado con éxito.");
                }

                this.DialogResult = DialogResult.OK; // Indicar que se guardó correctamente
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar jugador: {ex.Message}");
            }
        }

        private void numNivel_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Crear una instancia de BloqueService
            BloqueService bloqueService = new BloqueService(new DatabaseManager());

            // Crear una nueva instancia del formulario CrearBloqueForm
            CrearBloqueForm formBloque = new CrearBloqueForm(bloqueService);

            // Abrir el formulario CrearBloqueForm de manera modal
            formBloque.ShowDialog();
        }
        private void dgvInventario_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvInventario.SelectedRows.Count > 0)
            {
                var bloqueSeleccionado = dgvInventario.SelectedRows[0].DataBoundItem as Inventario;
                if (bloqueSeleccionado != null)
                {
                    // Asume que el bloque tiene una propiedad ImagenRecurso
                    var bloque = new BloqueService(new DatabaseManager()).ObtenerPorId(bloqueSeleccionado.BloqueId);
                    if (bloque != null && !string.IsNullOrEmpty(bloque.ImagenRecurso))
                    {
                        pbBloque.Image = (Image)Properties.Resources.ResourceManager.GetObject(bloque.ImagenRecurso);
                    }
                    else
                    {
                        pbBloque.Image = null; // Si no hay imagen, limpia el PictureBox
                    }
                }
            }
        }
        private void btnExportarInventario_Click(object sender, EventArgs e)
{
    try
    {
        if (dgvInventario.DataSource is List<Inventario> inventario)
        {
            // Ruta del archivo CSV
            string filePath = "inventario.csv";

            // Crear el archivo CSV
            using (var writer = new StreamWriter(filePath))
            {
                // Escribir encabezados
                writer.WriteLine("Id,JugadorId,BloqueId,Cantidad,NombreJugador,NombreBloque");

                // Escribir datos
                foreach (var item in inventario)
                {
                    writer.WriteLine($"{item.Id},{item.JugadorId},{item.BloqueId},{item.Cantidad},{item.NombreJugador},{item.NombreBloque}");
                }
            }

            MessageBox.Show($"Inventario exportado correctamente a {filePath}");
        }
        else
        {
            MessageBox.Show("No hay datos en el inventario para exportar.");
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show($"Error al exportar el inventario: {ex.Message}");
    }
}

    }
}
