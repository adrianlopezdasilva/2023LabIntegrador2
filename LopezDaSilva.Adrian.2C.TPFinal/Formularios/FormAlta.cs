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
                    Persona auxPersona;
                    Heroe heroe;

                    if(rdbSi.Checked == true)
                    {
                        heroe = new Heroe(txtNombre.Text, edadPersona, txtDNI.Text);
                        heroe.AgregarLogro(txtLogro.Text);
                        cementerio = this.cementerio + heroe;

                    }
                    else
                    {
                        auxPersona = new Persona(txtNombre.Text, edadPersona, txtDNI.Text);
                        cementerio = this.cementerio + auxPersona;
                    }

                    //cementerio = this.cementerio + auxPersona;

                    MessageBox.Show("Alta dada con exito", "Exito");
                    this.Limpiar();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }

        private void FormAlta_Load(object sender, EventArgs e)
        {
            rdbNo.Checked = true;
            cementerio.Personas.AddRange(Cementerio.CargarDatos());

        }

        private void rdbSi_CheckedChanged(object sender, EventArgs e)
        {
            txtLogro.Enabled = true;
            txtLogro.Visible = true;
        }

        private void rdbNo_CheckedChanged(object sender, EventArgs e)
        {
            txtLogro.Enabled = false;
            txtLogro.Visible = false;
        }

        /// <summary>
        /// Borra los datos de los textboxs
        /// </summary>
        private void Limpiar()
        {
            this.txtNombre.Text = "";
            this.txtEdad.Text = "";
            this.txtDNI.Text = "";
        }
    }
}
