using Entidades;
using Funeraria;

namespace Formularios
{
    public partial class FormPrincipal : Form
    {
        private Cementerio cementerio;
        public FormPrincipal()
        {
            InitializeComponent();
            this.cementerio = new Cementerio();
        }

        private void btnAgregarPersona_Click(object sender, EventArgs e)
        {
            FormAlta frmAlta = new FormAlta();
            this.Hide();
            frmAlta.ShowDialog();
            if (frmAlta.DialogResult == DialogResult.OK)
            {
                this.Show();
                Refrescar();
            }
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de querer salir?", "Salir", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            Refrescar();

        }

        private void Refrescar()
        {
            this.lstPersonas.DataSource = null;
            this.lstPersonas.Text = string.Empty;
            cementerio.Personas.AddRange(Cementerio.CargarDatos());
            this.lstPersonas.DataSource = cementerio.Personas;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            foreach (var item in cementerio.Personas)
            {
                if (txtBuscarDNI.Text == item.Dni )
                {
                    MessageBox.Show(item.ToString(), "Persona");
                }

            }

        }
    }
}