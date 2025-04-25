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

namespace formproyecto2.UI
{
    public partial class CrearBloqueForm : Form
    {
        private readonly BloqueService _bloqueService;
        private Bloque _bloque; // Para editar un bloque existente (si es necesario)

        public CrearBloqueForm(BloqueService bloqueService)
        {
            InitializeComponent();
            _bloqueService = bloqueService;
        }

        public CrearBloqueForm(BloqueService bloqueService, Bloque bloque) : this(bloqueService)
        {
            _bloque = bloque;
            textBoxNombre.Text = bloque.Nombre;
            textBoxTipo.Text = bloque.Tipo;
            textBoxRareza.Text = bloque.Rareza;
            btnGuardar.Text = "Actualizar"; // Cambia el texto a "Actualizar"
        }

        // Evento para guardar el bloque
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Obtener datos desde los TextBox
            string nombre = textBoxNombre.Text;
            string tipo = textBoxTipo.Text;
            string rareza = textBoxRareza.Text;

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(tipo) || string.IsNullOrEmpty(rareza))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Si estamos editando un bloque
            if (_bloque != null)
            {
                _bloque.Nombre = nombre;
                _bloque.Tipo = tipo;
                _bloque.Rareza = rareza;
                _bloqueService.Actualizar(_bloque);
            }
            else // Si es un nuevo bloque
            {
                var bloque = new Bloque
                {
                    Nombre = nombre,
                    Tipo = tipo,
                    Rareza = rareza
                };
                _bloqueService.Crear(bloque);
            }

            // Cerrar el formulario después de guardar
            this.Close();
        }

        // Configuración del formulario al cargar
        private void CrearBloqueForm_Load(object sender, EventArgs e)
        {
            // Puedes inicializar cualquier cosa que necesites al cargar el formulario
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            // 1. Crear el nuevo bloque
            var nuevoBloque = new Bloque
            {
                Nombre = textBoxNombre.Text,
                Tipo = textBoxTipo.Text
            };
            _bloqueService.Crear(nuevoBloque);

            // 2. Obtener el último bloque agregado
            var bloqueAgregado = _bloqueService.ObtenerTodos().Last();

            // 3. Agregar ese bloque al inventario de un jugador (por ejemplo, jugador con ID = 1)
            var nuevoInventario = new Inventario
            {
                JugadorId = 1, // o podrías dejar que el usuario lo elija en un ComboBox
                BloqueId = bloqueAgregado.Id,
                Cantidad = 1
            };
            _bloqueService.Crear(nuevoBloque);

            MessageBox.Show("Bloque guardado y agregado al inventario");
        }
    }
}