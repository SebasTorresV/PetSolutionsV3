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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmNewUser = new frmNewUser();
            frmNewUser.MdiParent = this;
            frmNewUser.Show();
        }

        private void mascotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmNewPet = new frmNewPet();
            frmNewPet.MdiParent = this;
            frmNewPet.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmMantoUsuarios = new frmMantoUsuarios();
            frmMantoUsuarios.MdiParent = this;
            frmMantoUsuarios.Show();
        }


        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmClientes = new frmClientes();
            frmClientes.MdiParent = this;
            frmClientes.Show();

        }


        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registroDePesoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region Mensaje
            string mensaje = "PetApp - Versión 1.0\n\n" +
                "Una aplicación para gestionar mascotas y clientes.\n" +
                "Desarrollado por Benjamin Sebastian Torres Gonzalez.\n\n" +
                "Alias: Ajolote \n\n" +
                "Dudede de mi conocimento por un momento, pero la IA me salvó jsjsjs \n\n" +
                "Contacto: 202102202@gmail.com";


            string arteAscii =    "⣿⣿⣿⣿⣿⣏⣾⣟⣿⣻⢯⢷⣟⣞⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿\n" +
                                  "⣿⣿⣿⣿⣟⣼⣯⣿⡽⣯⡻⡷⣽⡽⣧⣻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿\n" +
                                  "⣿⣿⡿⣹⣾⣿⣿⣿⣻⣷⣻⣟⣾⢿⣯⣿⣾⡻⣿⣿⣿⣿⣿⣿⣿⣿\n" +
                                  "⣟⣿⢾⡿⣷⣿⡻⣿⢽⢯⢿⡽⣟⢿⡳⣿⣻⡿⣮⡽⣿⣿⣿⣿⣿⡟\n" +
                                  "⢞⠙⢍⠉⠊⠄⠑⡀⠁⠂⠂⠠⠈⠈⢁⠉⠊⠛⠝⢿⣮⣿⣿⣿⣿⡘\n" +
                                  "⡄⠡⠀⠄⠁⠀⠠⠀⠀⠐⠀⠀⢀⠀⠀⠀⠄⠀⠠⠀⠃⣿⣿⣿⣷⣔\n" +
                                  "⣦⡵⠀⠐⢄⢂⠀⠐⠀⠀⠁⢀⠀⡈⢀⠀⠁⡀⢐⣵⣿⣿⣿⣿⣿⣿\n" +
                                  "⣿⣿⠄⣮⢿⡁⢔⣑⢂⠂⡂⠡⡀⢄⠂⡐⣌⢲⣽⢟⡃⣩⣿⣿⣿\n" +
                                  "⣿⣿⠁⢘⡅⡠⢈⢎⠱⡁⢪⠠⡑⢔⣼⣿⣷⠿⣿⣧⠀⡳⣿⣿⣿\n" +
                                  "⣿⣿⣿⡶⠠⠑⣔⣅⢔⣡⡪⢊⠐⡩⠺⢻⣿⡟⡡⢘⣷⠈⡽⢿⣿\n" +
                                  "⣿⣿⣿⣿⣼⣰⣿⣿⣿⢯⡳⢠⠡⢑⢑⢔⠤⠐⢸⣿⣿⠀⡑⠝⢯\n" +
                                  "⣿⣿⢟⣿⢳⢯⡚⣾⡅⡯⡪⢆⠕⡨⠠⠡⡬⣿⣿⡆⠙⡻⢟⢿⣿\n" +
                                  "⣿⣿⢪⠃⣴⡇⢊⣿⣏⢞⢕⢣⡪⣲⢝⣞⣵⣏⢙⣷⣀⠑⠢⣑⣿\n" +
                                  "⣿⣿⡖⢨⣿⣿⣿⣿⣝⣯⢷⣫⣻⣽⡯⣿⢽⡍⡿⣿⣿⣾⡔⣢⣽\n" +
                                  "⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡮⣳⢿⢮⣟⢜⢗⢽⡙⣯⢻⣿⣿⣿⣿\n" +
                                  "⣿⣿⣿⣿⣿⡿⣻⣫⣮⣻⣋⣾⣝⢿⣼⣿⣽⠫⢮⢣⠙⢼⣿⣿⣿\n" +
                                  "⣿⣿⣿⣿⣿⣚⠕\n" +
                                  "Es un meme lic, no se enoje xd";

            

                MessageBox.Show(arteAscii, "Arte ASCII", MessageBoxButtons.OK, MessageBoxIcon.Information);
            


            #endregion



            MessageBox.Show(mensaje, "Acerca de PetApp", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
