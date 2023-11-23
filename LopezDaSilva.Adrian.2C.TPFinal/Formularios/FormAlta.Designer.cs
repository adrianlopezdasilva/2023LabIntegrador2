namespace Formularios
{
    partial class FormAlta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlta));
            txtNombre = new TextBox();
            txtEdad = new TextBox();
            btnAlta = new Button();
            txtDNI = new TextBox();
            lblRol = new Label();
            txtLogro = new TextBox();
            rdbSi = new RadioButton();
            rdbNo = new RadioButton();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(41, 159);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Ingrese un nombre";
            txtNombre.Size = new Size(311, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(41, 200);
            txtEdad.Name = "txtEdad";
            txtEdad.PlaceholderText = "Ingrese una edad";
            txtEdad.Size = new Size(311, 23);
            txtEdad.TabIndex = 1;
            // 
            // btnAlta
            // 
            btnAlta.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            btnAlta.Location = new Point(41, 329);
            btnAlta.Name = "btnAlta";
            btnAlta.Size = new Size(311, 114);
            btnAlta.TabIndex = 3;
            btnAlta.Text = "Alta";
            btnAlta.UseVisualStyleBackColor = true;
            btnAlta.Click += btnAlta_Click;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(41, 245);
            txtDNI.Name = "txtDNI";
            txtDNI.PlaceholderText = "Ingrese un DNI";
            txtDNI.Size = new Size(311, 23);
            txtDNI.TabIndex = 2;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblRol.ForeColor = SystemColors.MenuHighlight;
            lblRol.Location = new Point(422, 134);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(121, 28);
            lblRol.TabIndex = 5;
            lblRol.Text = "Es un heroe?";
            // 
            // txtLogro
            // 
            txtLogro.Location = new Point(422, 236);
            txtLogro.Name = "txtLogro";
            txtLogro.PlaceholderText = "Ingrese un logro";
            txtLogro.Size = new Size(121, 23);
            txtLogro.TabIndex = 6;
            // 
            // rdbSi
            // 
            rdbSi.AutoSize = true;
            rdbSi.Location = new Point(509, 185);
            rdbSi.Name = "rdbSi";
            rdbSi.Size = new Size(34, 19);
            rdbSi.TabIndex = 7;
            rdbSi.TabStop = true;
            rdbSi.Text = "Si";
            rdbSi.UseVisualStyleBackColor = true;
            rdbSi.CheckedChanged += rdbSi_CheckedChanged;
            // 
            // rdbNo
            // 
            rdbNo.AutoSize = true;
            rdbNo.Location = new Point(422, 185);
            rdbNo.Name = "rdbNo";
            rdbNo.Size = new Size(41, 19);
            rdbNo.TabIndex = 8;
            rdbNo.TabStop = true;
            rdbNo.Text = "No";
            rdbNo.UseVisualStyleBackColor = true;
            rdbNo.CheckedChanged += rdbNo_CheckedChanged;
            // 
            // FormAlta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(700, 546);
            Controls.Add(rdbNo);
            Controls.Add(rdbSi);
            Controls.Add(txtLogro);
            Controls.Add(lblRol);
            Controls.Add(txtDNI);
            Controls.Add(btnAlta);
            Controls.Add(txtEdad);
            Controls.Add(txtNombre);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAlta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alta";
            FormClosing += FormAlta_FormClosing;
            FormClosed += FormAlta_FormClosed;
            Load += FormAlta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtEdad;
        private Button btnAlta;
        private TextBox txtDNI;
        private Label lblRol;
        private TextBox txtLogro;
        private RadioButton rdbSi;
        private RadioButton rdbNo;
    }
}