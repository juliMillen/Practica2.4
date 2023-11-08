
namespace practica_pp2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tBdni = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTicket = new System.Windows.Forms.Button();
            this.rBdenuncia = new System.Windows.Forms.RadioButton();
            this.rBnuevo = new System.Windows.Forms.RadioButton();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.tBpatente = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDenuncia = new System.Windows.Forms.Button();
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI:";
            // 
            // tBdni
            // 
            this.tBdni.Location = new System.Drawing.Point(122, 13);
            this.tBdni.Name = "tBdni";
            this.tBdni.Size = new System.Drawing.Size(100, 20);
            this.tBdni.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tBpatente);
            this.groupBox1.Controls.Add(this.cbxTipo);
            this.groupBox1.Controls.Add(this.rBnuevo);
            this.groupBox1.Controls.Add(this.rBdenuncia);
            this.groupBox1.Location = new System.Drawing.Point(16, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 160);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Consulta:";
            // 
            // btnTicket
            // 
            this.btnTicket.Location = new System.Drawing.Point(385, 93);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Size = new System.Drawing.Size(75, 68);
            this.btnTicket.TabIndex = 3;
            this.btnTicket.Text = "Ticket";
            this.btnTicket.UseVisualStyleBackColor = true;
            this.btnTicket.Click += new System.EventHandler(this.btnTicket_Click);
            // 
            // rBdenuncia
            // 
            this.rBdenuncia.AutoSize = true;
            this.rBdenuncia.Location = new System.Drawing.Point(23, 37);
            this.rBdenuncia.Name = "rBdenuncia";
            this.rBdenuncia.Size = new System.Drawing.Size(69, 17);
            this.rBdenuncia.TabIndex = 0;
            this.rBdenuncia.TabStop = true;
            this.rBdenuncia.Text = "denuncia";
            this.rBdenuncia.UseVisualStyleBackColor = true;
            // 
            // rBnuevo
            // 
            this.rBnuevo.AutoSize = true;
            this.rBnuevo.Location = new System.Drawing.Point(23, 92);
            this.rBnuevo.Name = "rBnuevo";
            this.rBnuevo.Size = new System.Drawing.Size(57, 17);
            this.rBnuevo.TabIndex = 1;
            this.rBnuevo.TabStop = true;
            this.rBnuevo.Text = "Nuevo";
            this.rBnuevo.UseVisualStyleBackColor = true;
            // 
            // cbxTipo
            // 
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Items.AddRange(new object[] {
            "Auto",
            "Moto",
            "Equipo de trabajo",
            "Bicicleta"});
            this.cbxTipo.Location = new System.Drawing.Point(121, 92);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(100, 21);
            this.cbxTipo.TabIndex = 2;
            // 
            // tBpatente
            // 
            this.tBpatente.Location = new System.Drawing.Point(121, 37);
            this.tBpatente.Name = "tBpatente";
            this.tBpatente.Size = new System.Drawing.Size(100, 20);
            this.tBpatente.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(16, 267);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(444, 160);
            this.listBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Turnos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 436);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Denuncia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(245, 436);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nuevo Cliente";
            // 
            // btnDenuncia
            // 
            this.btnDenuncia.Location = new System.Drawing.Point(39, 468);
            this.btnDenuncia.Name = "btnDenuncia";
            this.btnDenuncia.Size = new System.Drawing.Size(75, 23);
            this.btnDenuncia.TabIndex = 8;
            this.btnDenuncia.Text = "Atender";
            this.btnDenuncia.UseVisualStyleBackColor = true;
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.Location = new System.Drawing.Point(248, 468);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(75, 23);
            this.btnNuevoCliente.TabIndex = 9;
            this.btnNuevoCliente.Text = "Atender";
            this.btnNuevoCliente.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 503);
            this.Controls.Add(this.btnNuevoCliente);
            this.Controls.Add(this.btnDenuncia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnTicket);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tBdni);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBdni;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tBpatente;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.RadioButton rBnuevo;
        private System.Windows.Forms.RadioButton rBdenuncia;
        private System.Windows.Forms.Button btnTicket;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDenuncia;
        private System.Windows.Forms.Button btnNuevoCliente;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

