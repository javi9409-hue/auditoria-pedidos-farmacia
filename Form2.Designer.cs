namespace PedidosFarmacia
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            lblResumenMedicamento = new Label();
            lblDireccionEnvio = new Label();
            btnCancelar = new Button();
            btnEnviar = new Button();
            SuspendLayout();
            // 
            // lblResumenMedicamento
            // 
            lblResumenMedicamento.AutoSize = true;
            lblResumenMedicamento.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResumenMedicamento.Location = new Point(24, 57);
            lblResumenMedicamento.Name = "lblResumenMedicamento";
            lblResumenMedicamento.Size = new Size(503, 31);
            lblResumenMedicamento.TabIndex = 0;
            lblResumenMedicamento.Text = "El resumen del medicamento aparecerá aquí...";
            // 
            // lblDireccionEnvio
            // 
            lblDireccionEnvio.AutoSize = true;
            lblDireccionEnvio.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDireccionEnvio.Location = new Point(24, 196);
            lblDireccionEnvio.Name = "lblDireccionEnvio";
            lblDireccionEnvio.Size = new Size(420, 31);
            lblDireccionEnvio.TabIndex = 1;
            lblDireccionEnvio.Text = "La dirección de envío aparecerá aquí...";
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(118, 323);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(107, 44);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEnviar
            // 
            btnEnviar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnviar.Location = new Point(332, 323);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(112, 44);
            btnEnviar.TabIndex = 3;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(568, 397);
            Controls.Add(btnEnviar);
            Controls.Add(btnCancelar);
            Controls.Add(lblDireccionEnvio);
            Controls.Add(lblResumenMedicamento);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblResumenMedicamento;
        private Label lblDireccionEnvio;
        private Button btnCancelar;
        private Button btnEnviar;
    }
}