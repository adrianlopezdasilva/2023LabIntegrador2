using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Funeraria;
using Entidades;

namespace Formularios
{
    public partial class FormAlta : Form
    {
        public Cementerio cementerio;
        public FormAlta()
        {
            InitializeComponent();
            this.cementerio = new Cementerio();
        }

        private void FormAlta_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de querer salir?", "Salir", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void FormAlta_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Cementerio.GuardarDatos(cementerio.Personas);
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {  
            if (int.TryParse(txtEdad.Text, out int edadPersona))
             {
                 try
                 {
                    Persona auxPersona = new Persona(txtNombre.Text, edadPersona, txtDNI.Text);
                    cementerio = this.cementerio + auxPersona;

                    MessageBox.Show("Alta dada con exito", "Exito");

                    this.txtNombre.Text = "";
                    this.txtEdad.Text = "";
                    this.txtDNI.Text = "";

                }
                catch (Exception ex)
                 {
                     MessageBox.Show(ex.Message, "Error");
                 }
                }
             }
    }
}
