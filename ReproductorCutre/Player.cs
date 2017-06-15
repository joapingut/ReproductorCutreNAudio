using System;
using System.Windows.Forms;

namespace ReproductorCutre
{
    public partial class Player : Form
    {
        private const int UPDATE_INTERVAL = 50;

        private PlayerControl playerCtrl;
        private Timer updateTimer = null;
        private KeyboardHook keyHook = null;
        private string firstSong = null;

        public Player(string firstSong){
            this.firstSong = firstSong;
            InitializeComponent();
            updateTimer = new Timer();
            updateTimer.Interval = 50;
            updateTimer.Tick += new EventHandler(timerUpdate);
            trackProgreso.Scroll += new EventHandler(trackPositionChange);
            trackBar1.Scroll += new EventHandler(volumenChange);
            playerCtrl = new PlayerControl("");
            try{
                keyHook = new KeyboardHook();
                keyHook.KeyPressed += new EventHandler<KeyPressedEventArgs>(hook_KeyPressed);
                keyHook.RegisterHotKey(0, Keys.MediaPlayPause);
                keyHook.RegisterHotKey(0, Keys.MediaStop);
                keyHook.RegisterHotKey(0, Keys.MediaNextTrack);
                keyHook.RegisterHotKey(0, Keys.MediaPreviousTrack);
            }catch (Exception e) {
                Console.WriteLine("ERROR - No se han podido registrar correctamente los keyHot multimedia.\n" + e.StackTrace);
            }
        }

        private void Player_Load(object sender, EventArgs e){
            cbAleatorio.Checked = Propiedades.autoAleatorio;
            cbAvanceAutomatico.Checked = Propiedades.autoAvance;
            if (firstSong != null){
                playerCtrl.rute = firstSong;
                btPlay.PerformClick();
                Console.WriteLine(playerCtrl.estadoActual());
                Console.WriteLine("Ifif: " + firstSong);
            }else {
                if (Propiedades.rutaPorDefecto != null && Propiedades.rutaPorDefecto != String.Empty && Propiedades.autoPlay && System.IO.Directory.Exists(Propiedades.rutaPorDefecto)) {
                    //string dummy = System.IO.Directory.GetFiles(Propiedades.rutaPorDefecto)[0];
                    PlayerListControl.crear(Propiedades.rutaPorDefecto, "dummy");
                    string rut = PlayerListControl.aleatorio();
                    playerCtrl.rute = rut;
                    btPlay.PerformClick();
                }
            }
        }

        private void hook_KeyPressed(object sender, KeyPressedEventArgs e){
            switch (e.Key) {
                case Keys.MediaPlayPause:
                    btPlay.PerformClick();
                    break;
                case Keys.MediaStop:
                    btStop.PerformClick();
                    break;
                case Keys.MediaPreviousTrack:
                    btRetroceder.PerformClick();
                    break;
                case Keys.MediaNextTrack:
                    btAvanzar.PerformClick();
                    break;
                default:
                    break;
            }
        }

        private void changeEstado() {
            switch (playerCtrl.estadoActual()) {
                case ESTADO.PLAY:
                    updateTimer.Stop();
                    btPlay.Text = "Pause";
                    btOtravez.Enabled = true;
                    btStop.Enabled = true;
                    btRetroceder.Enabled = true;
                    btAvanzar.Enabled = true;
                    btCaratula.Enabled = true;
                    trackProgreso.Enabled = true;
                    lTiempoTotal.Text = Utiles.parseDoubleToSeconds(playerCtrl.longitudRaw());
                    lTiempoActual.Text = Utiles.parseDoubleToSeconds(playerCtrl.positionActualRaw());
                    lPistas.Text = PlayerListControl.cadenaInfo();
                    trackProgreso.Maximum = (int)playerCtrl.longitudRaw();
                    trackProgreso.Value = (int)playerCtrl.positionActualRaw();
                    tbNombre.Text = playerCtrl.getTitle();
                    lRuta.Text = playerCtrl.getRuteOnly();
                    playerCtrl.setVolumen(((float) trackBar1.Value) / 100);
                    updateTimer.Start();
                    break;
                case ESTADO.PAUSE:
                case ESTADO.STOP:
                    updateTimer.Stop();
                    btPlay.Text = "Play";
                    break;
                default:
                    updateTimer.Stop();
                    btPlay.Text = "Play";
                    btOtravez.Enabled = false;
                    btStop.Enabled = false;
                    btRetroceder.Enabled = false;
                    btAvanzar.Enabled = false;
                    btCaratula.Enabled = false;
                    trackProgreso.Enabled = false;
                    break;
            }
        }

        private int counter = 0;

        private void timerUpdate(object sender, EventArgs e){
            if (playerCtrl.estadoActual() == ESTADO.STOP){
                if (cbRepetir.Checked)
                    btOtravez.PerformClick();
                else{
                    if (cbAvanceAutomatico.Checked)
                        btAvanzar.PerformClick();
                    else
                        changeEstado();
                }
                return;
            }
            counter += 1;
            if (counter > 4) {
                counter = 0;
                int valor = (int)playerCtrl.positionActualRaw();
                if ( valor >= trackProgreso.Minimum && valor <= trackProgreso.Maximum)
                    trackProgreso.Value = (int)playerCtrl.positionActualRaw();
                lTiempoActual.Text = Utiles.parseDoubleToSeconds(playerCtrl.positionActualRaw());
            }
            
        }

        private void trackPositionChange(object sender, EventArgs e){
            int pos = trackProgreso.Value;
            playerCtrl.goToPosition(pos);
        }

        private void volumenChange(object sender, EventArgs e){
            float pos = trackBar1.Value;
            playerCtrl.setVolumen(pos/100);
        }

        private void btPlay_Click(object sender, EventArgs e){
            if (playerCtrl.estadoActual() == ESTADO.PLAY){
                playerCtrl.pause();
            }else {
                if (!playerCtrl.play()){
                    btAbrir.PerformClick();
                }else {
                    if (ventanaCover != null && ventanaCover.Visible)
                        ventanaCover.Dispose();
                }
            }
            changeEstado();
        }

        private void btAbrir_Click(object sender, EventArgs e){
            OpenFileDialog openDiag = new System.Windows.Forms.OpenFileDialog();
            if (openDiag.ShowDialog(this) == DialogResult.OK){
                string fileName = openDiag.FileName;
                playerCtrl.rute = fileName;
                btStop.PerformClick();
                btPlay.PerformClick();
                return;
            }
        }

        private void btStop_Click(object sender, EventArgs e){
            playerCtrl.stop();
            changeEstado();
        }

        private void btOtravez_Click(object sender, EventArgs e){
            playerCtrl.stop();
            playerCtrl.play();
            changeEstado();
        }

        CoverForm ventanaCover = null;

        private void btCaratula_Click(object sender, EventArgs e){
            if (ventanaCover != null && ventanaCover.Visible)
                ventanaCover.Dispose();
            if (playerCtrl.getCover() == null)
                return;
            ventanaCover = new CoverForm(playerCtrl.getCover());
            ventanaCover.Visible = true;
        }

        private void btAvanzar_Click(object sender, EventArgs e){
            string rutasig;
            if (cbAleatorio.Checked)
                rutasig = PlayerListControl.aleatorio();
            else
                rutasig = PlayerListControl.siguiente();
            playerCtrl.rute = rutasig;
            btOtravez.PerformClick();
            changeEstado();
        }

        private void btRetroceder_Click(object sender, EventArgs e){
            string rutasig;
            if (cbAleatorio.Checked)
                rutasig = PlayerListControl.aleatorio();
            else
                rutasig = PlayerListControl.anterior();
            playerCtrl.rute = rutasig;
            btOtravez.PerformClick();
            changeEstado();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e){
            btAbrir.PerformClick();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e){
            playerCtrl.freeResources();
            Application.Exit();
        }

        private void opcionesToolStripMenuItem_Click(object sender, EventArgs e){
            OptionsForm opt = new OptionsForm();
            opt.ShowDialog(this);
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e){
            AboutBox about = new AboutBox();
            about.ShowDialog(this);
        }
    }
}
