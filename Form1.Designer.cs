namespace PedidosFarmacia
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            cmbTipo = new ComboBox();
            label3 = new Label();
            txtCantidad = new TextBox();
            groupBox1 = new GroupBox();
            rbCopidrogas = new RadioButton();
            rbAudifarma = new RadioButton();
            rbCruzVerde = new RadioButton();
            label4 = new Label();
            label5 = new Label();
            btnBorrar = new Button();
            btnConfirmar = new Button();
            groupBox2 = new GroupBox();
            rbPrincipal = new RadioButton();
            rbSecundaria = new RadioButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.HighlightText;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 39);
            label1.Name = "label1";
            label1.Size = new Size(226, 23);
            label1.TabIndex = 0;
            label1.Text = "Nombre del medicamento:";
            label1.Click += label1_Click;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = SystemColors.ButtonHighlight;
            txtNombre.Location = new Point(264, 35);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(320, 27);
            txtNombre.TabIndex = 1;

            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 97);
            label2.Name = "label2";
            label2.Size = new Size(191, 23);
            label2.TabIndex = 2;
            label2.Text = "Tipo de medicamento:";
            // 
            // cmbTipo
            // 
            cmbTipo.AutoCompleteCustomSource.AddRange(new string[] { "analgésico", "analéptico", "anestésico", "antiácido", "antidepresivo", "antibióticos" });
            cmbTipo.BackColor = SystemColors.ButtonHighlight;
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "Analgésico", "Analéptico", "Anestésico", "Aantiácido", "Antidepresivo", "Antibióticos" });
            cmbTipo.Location = new Point(264, 96);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(320, 28);
            cmbTipo.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(23, 155);
            label3.Name = "label3";
            label3.Size = new Size(171, 23);
            label3.TabIndex = 4;
            label3.Text = "Cantidad requerida:";
            label3.Click += label3_Click;
            // 
            // txtCantidad
            // 
            txtCantidad.BackColor = SystemColors.ButtonHighlight;
            txtCantidad.Location = new Point(264, 155);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(320, 27);
            txtCantidad.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonHighlight;
            groupBox1.Controls.Add(rbCopidrogas);
            groupBox1.Controls.Add(rbAudifarma);
            groupBox1.Controls.Add(rbCruzVerde);
            groupBox1.Location = new Point(264, 224);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(320, 154);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // rbCopidrogas
            // 
            rbCopidrogas.AutoSize = true;
            rbCopidrogas.Location = new Point(23, 118);
            rbCopidrogas.Name = "rbCopidrogas";
            rbCopidrogas.Size = new Size(107, 24);
            rbCopidrogas.TabIndex = 2;
            rbCopidrogas.TabStop = true;
            rbCopidrogas.Text = "Copidrogas";
            rbCopidrogas.UseVisualStyleBackColor = true;
            // 
            // rbAudifarma
            // 
            rbAudifarma.AutoSize = true;
            rbAudifarma.Location = new Point(23, 71);
            rbAudifarma.Name = "rbAudifarma";
            rbAudifarma.Size = new Size(100, 24);
            rbAudifarma.TabIndex = 1;
            rbAudifarma.TabStop = true;
            rbAudifarma.Text = "Audifarma";
            rbAudifarma.UseVisualStyleBackColor = true;
            // 
            // rbCruzVerde
            // 
            rbCruzVerde.AutoSize = true;
            rbCruzVerde.Location = new Point(23, 26);
            rbCruzVerde.Name = "rbCruzVerde";
            rbCruzVerde.Size = new Size(101, 24);
            rbCruzVerde.TabIndex = 0;
            rbCruzVerde.TabStop = true;
            rbCruzVerde.Text = "Cruz Verde";
            rbCruzVerde.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(23, 248);
            label4.Name = "label4";
            label4.Size = new Size(224, 23);
            label4.TabIndex = 7;
            label4.Text = "Distribuidor Farmacéutico:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonHighlight;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(23, 418);
            label5.Name = "label5";
            label5.Size = new Size(81, 23);
            label5.TabIndex = 8;
            label5.Text = "Sucursal:";
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = SystemColors.ButtonHighlight;
            btnBorrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBorrar.Location = new Point(89, 533);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(106, 49);
            btnBorrar.TabIndex = 11;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = SystemColors.ButtonHighlight;
            btnConfirmar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmar.Location = new Point(384, 533);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(128, 49);
            btnConfirmar.TabIndex = 12;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ButtonHighlight;
            groupBox2.Controls.Add(rbSecundaria);
            groupBox2.Controls.Add(rbPrincipal);
            groupBox2.Location = new Point(264, 405);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(320, 108);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            // 
            // rbPrincipal
            // 
            rbPrincipal.AutoSize = true;
            rbPrincipal.Location = new Point(21, 26);
            rbPrincipal.Name = "rbPrincipal";
            rbPrincipal.Size = new Size(150, 24);
            rbPrincipal.TabIndex = 0;
            rbPrincipal.TabStop = true;
            rbPrincipal.Text = "Farmacia Principal";
            rbPrincipal.UseVisualStyleBackColor = true;
            // 
            // rbSecundaria
            // 
            rbSecundaria.AutoSize = true;
            rbSecundaria.Location = new Point(21, 68);
            rbSecundaria.Name = "rbSecundaria";
            rbSecundaria.Size = new Size(166, 24);
            rbSecundaria.TabIndex = 1;
            rbSecundaria.TabStop = true;
            rbSecundaria.Text = "Farmacia Secundaria";
            rbSecundaria.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(615, 621);
            Controls.Add(groupBox2);
            Controls.Add(btnConfirmar);
            Controls.Add(btnBorrar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(txtCantidad);
            Controls.Add(label3);
            Controls.Add(cmbTipo);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private Label label2;
        private ComboBox cmbTipo;
        private Label label3;
        private TextBox txtCantidad;
        private GroupBox groupBox1;
        private RadioButton rbCopidrogas;
        private RadioButton rbAudifarma;
        private RadioButton rbCruzVerde;
        private Label label4;
        private Label label5;
        private Button btnBorrar;
        private Button btnConfirmar;
        private GroupBox groupBox2;
        private RadioButton rbSecundaria;
        private RadioButton rbPrincipal;
    }
}
