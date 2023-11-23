namespace Formularios
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            lstPersonas = new ListBox();
            btnAgregarPersona = new Button();
            SuspendLayout();
            // 
            // lstPersonas
            // 
            lstPersonas.FormattingEnabled = true;
            lstPersonas.ItemHeight = 15;
            lstPersonas.Location = new Point(12, 12);
            lstPersonas.Name = "lstPersonas";
            lstPersonas.Size = new Size(641, 574);
            lstPersonas.TabIndex = 0;
            // 
            // btnAgregarPersona
            // 
            btnAgregarPersona.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarPersona.Location = new Point(784, 280);
            btnAgregarPersona.Name = "btnAgregarPersona";
            btnAgregarPersona.Size = new Size(281, 57);
            btnAgregarPersona.TabIndex = 1;
            btnAgregarPersona.Text = "Agregar";
            btnAgregarPersona.UseVisualStyleBackColor = true;
            btnAgregarPersona.Click += btnAgregarPersona_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1167, 748);
            Controls.Add(btnAgregarPersona);
            Controls.Add(lstPersonas);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bienvenidos";
            FormClosing += FormPrincipal_FormClosing;
            Load += FormPrincipal_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstPersonas;
        private Button btnAgregarPersona;
    }
}