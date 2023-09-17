﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetApp
{
    public partial class frmNewPet : Form
    {
        public frmNewPet()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Obtén los valores ingresados en los campos de texto y controles de fecha.
            string alias = txtAlias.Text;
            string especie = txtespecie.Text;
            string raza = txtRaza.Text;
            string color = txtColor.Text;
            DateTime fechaNacimiento = dtFechaNacimiento.Value;

            // Verifica si alguno de los campos obligatorios está vacío.
            if (string.IsNullOrEmpty(alias) || string.IsNullOrEmpty(especie) || string.IsNullOrEmpty(raza)
                || string.IsNullOrEmpty(color) || CbxNombre.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios y seleccione un nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método si faltan campos obligatorios.
            }

            using (var db = new PetAppContext())
            {
                // Obtiene el nombre seleccionado en el ComboBox
                string nombreCliente = CbxNombre.SelectedItem.ToString();

                // Realiza una consulta para obtener el cliente según el nombre
                var cliente = db.Cliente.FirstOrDefault(c => c.NombreCompleto == nombreCliente);

                if (cliente != null)
                {
                    var nuevaMascota = new Mascota()
                    {
                        Alias = alias,
                        Especie = especie,
                        Raza = raza,
                        ColorPelo = color,
                        FechaNacimiento = fechaNacimiento,
                        IdCliente = cliente.IdCliente // Asigna el ID del cliente obtenido
                    };

                    db.Mascota.Add(nuevaMascota);
                    db.SaveChanges();

                    MessageBox.Show("Nueva mascota registrada exitosamente.");
                }
                else
                {
                    MessageBox.Show("El cliente seleccionado no fue encontrado en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Limpia los campos de texto después de guardar la mascota.
            txtAlias.Clear();
            txtespecie.Clear();
            txtRaza.Clear();
            txtColor.Clear();
            dtFechaNacimiento.Value = DateTime.Now;
        }




        private void frmNewPet_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'petAppDataSet.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.petAppDataSet.Cliente);
            // TODO: This line of code loads data into the 'petAppDataSet.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.petAppDataSet.Cliente);

        }
    }
}
