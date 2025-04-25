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
    public partial class dataGridViewBloque : Form
    {
        private readonly BloqueService _bloqueService;

        public dataGridViewBloque(BloqueService bloqueService)
        {
            InitializeComponent();
            _bloqueService = bloqueService;
        }

        private void GestionarBloquesForm_Load(object sender, EventArgs e)
        {
            // Llenar combobox con valores únicos
            comboBoxtipo.Items.AddRange(new string[] { "Todos", "Piedra", "Mineral", "Madera", "Cristal" });
            comboBoxRar.Items.AddRange(new string[] { "Todos", "Común", "Raro", "Épico", "Legendario" });

            comboBoxtipo.SelectedIndex = 0;
            comboBoxRar.SelectedIndex = 0;

            CargarBloques();
        }

        private void CargarBloques()
        {
            string tipo = comboBoxtipo.SelectedItem?.ToString();
            string rareza = comboBoxRar.SelectedItem?.ToString();

            List<Bloque> bloques;

            if (tipo != "Todos" && rareza != "Todos")
                bloques = _bloqueService.ObtenerTodos().Where(b => b.Tipo == tipo && b.Rareza == rareza).ToList();
            else if (tipo != "Todos")
                bloques = _bloqueService.BuscarPorTipo(tipo);
            else if (rareza != "Todos")
                bloques = _bloqueService.BuscarPorRareza(rareza);
            else
                bloques = _bloqueService.ObtenerTodos();

            dataGridView5.DataSource = bloques;
        }

        private void comboBoxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarBloques();
        }

        private void comboBoxRareza_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarBloques();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            var form = new CrearBloqueForm(_bloqueService);
            form.ShowDialog();
            CargarBloques();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView5.SelectedRows.Count > 0)
            {
                var bloque = (Bloque)dataGridView5.SelectedRows[0].DataBoundItem;
                _bloqueService.Eliminar(bloque.Id);
                CargarBloques();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView5.SelectedRows.Count > 0)
            {
                var bloque = (Bloque)dataGridView5.SelectedRows[0].DataBoundItem;
                var form = new CrearBloqueForm(_bloqueService, bloque); // con sobrecarga para editar
                form.ShowDialog();
                CargarBloques();
            }
        }
    }
}