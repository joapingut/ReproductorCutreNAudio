namespace ReproductorCutre
{
    partial class Player
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
            this.btAbrir = new System.Windows.Forms.Button();
            this.btCaratula = new System.Windows.Forms.Button();
            this.btRetroceder = new System.Windows.Forms.Button();
            this.btAvanzar = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.cbAleatorio = new System.Windows.Forms.CheckBox();
            this.trackProgreso = new System.Windows.Forms.TrackBar();
            this.lTiempoActual = new System.Windows.Forms.Label();
            this.lTiempoTotal = new System.Windows.Forms.Label();
            this.btStop = new System.Windows.Forms.Button();
            this.btPlay = new System.Windows.Forms.Button();
            this.btOtravez = new System.Windows.Forms.Button();
            this.cbRepetir = new System.Windows.Forms.CheckBox();
            this.cbAvanceAutomatico = new System.Windows.Forms.CheckBox();
            this.lRuta = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.lPistas = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.trackProgreso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAbrir
            // 
            this.btAbrir.Location = new System.Drawing.Point(12, 29);
            this.btAbrir.Name = "btAbrir";
            this.btAbrir.Size = new System.Drawing.Size(75, 23);
            this.btAbrir.TabIndex = 0;
            this.btAbrir.Text = "Abrir";
            this.btAbrir.UseVisualStyleBackColor = true;
            this.btAbrir.Click += new System.EventHandler(this.btAbrir_Click);
            // 
            // btCaratula
            // 
            this.btCaratula.Location = new System.Drawing.Point(94, 28);
            this.btCaratula.Name = "btCaratula";
            this.btCaratula.Size = new System.Drawing.Size(75, 23);
            this.btCaratula.TabIndex = 1;
            this.btCaratula.Text = "Caratula";
            this.btCaratula.UseVisualStyleBackColor = true;
            this.btCaratula.Click += new System.EventHandler(this.btCaratula_Click);
            // 
            // btRetroceder
            // 
            this.btRetroceder.Enabled = false;
            this.btRetroceder.Location = new System.Drawing.Point(261, 29);
            this.btRetroceder.Name = "btRetroceder";
            this.btRetroceder.Size = new System.Drawing.Size(75, 23);
            this.btRetroceder.TabIndex = 2;
            this.btRetroceder.Text = "Retroceder";
            this.btRetroceder.UseVisualStyleBackColor = true;
            this.btRetroceder.Click += new System.EventHandler(this.btRetroceder_Click);
            // 
            // btAvanzar
            // 
            this.btAvanzar.Enabled = false;
            this.btAvanzar.Location = new System.Drawing.Point(342, 29);
            this.btAvanzar.Name = "btAvanzar";
            this.btAvanzar.Size = new System.Drawing.Size(75, 23);
            this.btAvanzar.TabIndex = 3;
            this.btAvanzar.Text = "Avanzar";
            this.btAvanzar.UseVisualStyleBackColor = true;
            this.btAvanzar.Click += new System.EventHandler(this.btAvanzar_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(12, 58);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.ReadOnly = true;
            this.tbNombre.Size = new System.Drawing.Size(474, 20);
            this.tbNombre.TabIndex = 4;
            this.tbNombre.Text = "Título";
            // 
            // cbAleatorio
            // 
            this.cbAleatorio.AutoSize = true;
            this.cbAleatorio.Location = new System.Drawing.Point(424, 33);
            this.cbAleatorio.Name = "cbAleatorio";
            this.cbAleatorio.Size = new System.Drawing.Size(67, 17);
            this.cbAleatorio.TabIndex = 5;
            this.cbAleatorio.Text = "Aleatorio";
            this.cbAleatorio.UseVisualStyleBackColor = true;
            // 
            // trackProgreso
            // 
            this.trackProgreso.Enabled = false;
            this.trackProgreso.LargeChange = 10;
            this.trackProgreso.Location = new System.Drawing.Point(13, 85);
            this.trackProgreso.Maximum = 100;
            this.trackProgreso.Name = "trackProgreso";
            this.trackProgreso.Size = new System.Drawing.Size(473, 45);
            this.trackProgreso.SmallChange = 2;
            this.trackProgreso.TabIndex = 6;
            this.trackProgreso.TabStop = false;
            this.trackProgreso.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // lTiempoActual
            // 
            this.lTiempoActual.AutoSize = true;
            this.lTiempoActual.Location = new System.Drawing.Point(13, 116);
            this.lTiempoActual.Name = "lTiempoActual";
            this.lTiempoActual.Size = new System.Drawing.Size(49, 13);
            this.lTiempoActual.TabIndex = 7;
            this.lTiempoActual.Text = "00:00:00";
            // 
            // lTiempoTotal
            // 
            this.lTiempoTotal.AutoSize = true;
            this.lTiempoTotal.Location = new System.Drawing.Point(450, 115);
            this.lTiempoTotal.Name = "lTiempoTotal";
            this.lTiempoTotal.Size = new System.Drawing.Size(49, 13);
            this.lTiempoTotal.TabIndex = 8;
            this.lTiempoTotal.Text = "00:00:00";
            // 
            // btStop
            // 
            this.btStop.Enabled = false;
            this.btStop.Location = new System.Drawing.Point(134, 125);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(75, 23);
            this.btStop.TabIndex = 9;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // btPlay
            // 
            this.btPlay.Location = new System.Drawing.Point(216, 125);
            this.btPlay.Name = "btPlay";
            this.btPlay.Size = new System.Drawing.Size(75, 23);
            this.btPlay.TabIndex = 10;
            this.btPlay.Text = "Play";
            this.btPlay.UseVisualStyleBackColor = true;
            this.btPlay.Click += new System.EventHandler(this.btPlay_Click);
            // 
            // btOtravez
            // 
            this.btOtravez.Enabled = false;
            this.btOtravez.Location = new System.Drawing.Point(298, 125);
            this.btOtravez.Name = "btOtravez";
            this.btOtravez.Size = new System.Drawing.Size(75, 23);
            this.btOtravez.TabIndex = 11;
            this.btOtravez.Text = "Otra vez";
            this.btOtravez.UseVisualStyleBackColor = true;
            this.btOtravez.Click += new System.EventHandler(this.btOtravez_Click);
            // 
            // cbRepetir
            // 
            this.cbRepetir.AutoSize = true;
            this.cbRepetir.Location = new System.Drawing.Point(16, 136);
            this.cbRepetir.Name = "cbRepetir";
            this.cbRepetir.Size = new System.Drawing.Size(60, 17);
            this.cbRepetir.TabIndex = 12;
            this.cbRepetir.Text = "Repetir";
            this.cbRepetir.UseVisualStyleBackColor = true;
            // 
            // cbAvanceAutomatico
            // 
            this.cbAvanceAutomatico.AutoSize = true;
            this.cbAvanceAutomatico.Location = new System.Drawing.Point(405, 136);
            this.cbAvanceAutomatico.Name = "cbAvanceAutomatico";
            this.cbAvanceAutomatico.Size = new System.Drawing.Size(119, 17);
            this.cbAvanceAutomatico.TabIndex = 13;
            this.cbAvanceAutomatico.Text = "Avance Automatico";
            this.cbAvanceAutomatico.UseVisualStyleBackColor = true;
            // 
            // lRuta
            // 
            this.lRuta.AutoSize = true;
            this.lRuta.Location = new System.Drawing.Point(12, 177);
            this.lRuta.Name = "lRuta";
            this.lRuta.Size = new System.Drawing.Size(62, 13);
            this.lRuta.TabIndex = 14;
            this.lRuta.Text = "Ruta actual";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 193);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(157, 45);
            this.trackBar1.TabIndex = 15;
            this.trackBar1.TickFrequency = 25;
            this.trackBar1.Value = 100;
            // 
            // lPistas
            // 
            this.lPistas.AutoSize = true;
            this.lPistas.Location = new System.Drawing.Point(174, 193);
            this.lPistas.Name = "lPistas";
            this.lPistas.Size = new System.Drawing.Size(149, 13);
            this.lPistas.TabIndex = 16;
            this.lPistas.Text = "Pista Anterior || Pista Siguiente";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(525, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.cerrarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            this.opcionesToolStripMenuItem.Click += new System.EventHandler(this.opcionesToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sobreToolStripMenuItem.Text = "Sobre...";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 224);
            this.Controls.Add(this.lPistas);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.lRuta);
            this.Controls.Add(this.cbAvanceAutomatico);
            this.Controls.Add(this.cbRepetir);
            this.Controls.Add(this.btOtravez);
            this.Controls.Add(this.btPlay);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.lTiempoTotal);
            this.Controls.Add(this.lTiempoActual);
            this.Controls.Add(this.trackProgreso);
            this.Controls.Add(this.cbAleatorio);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.btAvanzar);
            this.Controls.Add(this.btRetroceder);
            this.Controls.Add(this.btCaratula);
            this.Controls.Add(this.btAbrir);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Player";
            this.Text = "Reproductor Cutre";
            this.Load += new System.EventHandler(this.Player_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackProgreso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAbrir;
        private System.Windows.Forms.Button btCaratula;
        private System.Windows.Forms.Button btRetroceder;
        private System.Windows.Forms.Button btAvanzar;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.CheckBox cbAleatorio;
        private System.Windows.Forms.TrackBar trackProgreso;
        private System.Windows.Forms.Label lTiempoActual;
        private System.Windows.Forms.Label lTiempoTotal;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Button btPlay;
        private System.Windows.Forms.Button btOtravez;
        private System.Windows.Forms.CheckBox cbRepetir;
        private System.Windows.Forms.CheckBox cbAvanceAutomatico;
        private System.Windows.Forms.Label lRuta;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label lPistas;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
    }
}

