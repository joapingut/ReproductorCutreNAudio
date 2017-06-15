namespace ReproductorCutre
{
    partial class OptionsForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbRutaDefault = new System.Windows.Forms.TextBox();
            this.cbAutoAvance = new System.Windows.Forms.CheckBox();
            this.cbAutoAleatorio = new System.Windows.Forms.CheckBox();
            this.cbAutoPlay = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nupCaratula = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btGuardar = new System.Windows.Forms.Button();
            this.btRestablecer = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupCaratula)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbAutoPlay);
            this.groupBox1.Controls.Add(this.cbAutoAleatorio);
            this.groupBox1.Controls.Add(this.cbAutoAvance);
            this.groupBox1.Controls.Add(this.tbRutaDefault);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 102);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones de Inicio";
            // 
            // tbRutaDefault
            // 
            this.tbRutaDefault.Location = new System.Drawing.Point(6, 19);
            this.tbRutaDefault.Name = "tbRutaDefault";
            this.tbRutaDefault.Size = new System.Drawing.Size(270, 20);
            this.tbRutaDefault.TabIndex = 0;
            this.tbRutaDefault.Text = "Ruta";
            // 
            // cbAutoAvance
            // 
            this.cbAutoAvance.AutoSize = true;
            this.cbAutoAvance.Location = new System.Drawing.Point(7, 55);
            this.cbAutoAvance.Name = "cbAutoAvance";
            this.cbAutoAvance.Size = new System.Drawing.Size(88, 17);
            this.cbAutoAvance.TabIndex = 1;
            this.cbAutoAvance.Text = "Auto Avance";
            this.cbAutoAvance.UseVisualStyleBackColor = true;
            // 
            // cbAutoAleatorio
            // 
            this.cbAutoAleatorio.AutoSize = true;
            this.cbAutoAleatorio.Location = new System.Drawing.Point(101, 55);
            this.cbAutoAleatorio.Name = "cbAutoAleatorio";
            this.cbAutoAleatorio.Size = new System.Drawing.Size(92, 17);
            this.cbAutoAleatorio.TabIndex = 2;
            this.cbAutoAleatorio.Text = "Auto Aleatorio";
            this.cbAutoAleatorio.UseVisualStyleBackColor = true;
            // 
            // cbAutoPlay
            // 
            this.cbAutoPlay.AutoSize = true;
            this.cbAutoPlay.Location = new System.Drawing.Point(208, 55);
            this.cbAutoPlay.Name = "cbAutoPlay";
            this.cbAutoPlay.Size = new System.Drawing.Size(68, 17);
            this.cbAutoPlay.TabIndex = 3;
            this.cbAutoPlay.Text = "AutoPlay";
            this.cbAutoPlay.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btRestablecer);
            this.groupBox2.Controls.Add(this.btGuardar);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.nupCaratula);
            this.groupBox2.Location = new System.Drawing.Point(12, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(285, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Otras Opciones";
            // 
            // nupCaratula
            // 
            this.nupCaratula.Location = new System.Drawing.Point(7, 19);
            this.nupCaratula.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nupCaratula.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupCaratula.Name = "nupCaratula";
            this.nupCaratula.Size = new System.Drawing.Size(41, 20);
            this.nupCaratula.TabIndex = 0;
            this.nupCaratula.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Divisor tamaño caratulas";
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(6, 71);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(75, 23);
            this.btGuardar.TabIndex = 2;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // btRestablecer
            // 
            this.btRestablecer.Location = new System.Drawing.Point(201, 71);
            this.btRestablecer.Name = "btRestablecer";
            this.btRestablecer.Size = new System.Drawing.Size(75, 23);
            this.btRestablecer.TabIndex = 3;
            this.btRestablecer.Text = "Restablecer";
            this.btRestablecer.UseVisualStyleBackColor = true;
            this.btRestablecer.Click += new System.EventHandler(this.btRestablecer_Click);
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 226);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "OptionsForm";
            this.Text = "OptionsForm";
            this.Load += new System.EventHandler(this.OptionsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupCaratula)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbAutoPlay;
        private System.Windows.Forms.CheckBox cbAutoAleatorio;
        private System.Windows.Forms.CheckBox cbAutoAvance;
        private System.Windows.Forms.TextBox tbRutaDefault;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btRestablecer;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nupCaratula;
    }
}