using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReproductorCutre
{
    public partial class OptionsForm : Form
    {
        public OptionsForm(){
            InitializeComponent();
        }

        private void OptionsForm_Load(object sender, EventArgs e){
            cbAutoAleatorio.Checked = Propiedades.autoAleatorio;
            cbAutoAvance.Checked = Propiedades.autoAvance;
            cbAutoPlay.Checked = Propiedades.autoPlay;
            tbRutaDefault.Text = Propiedades.rutaPorDefecto;
            nupCaratula.Value = Propiedades.dimensionCaratula;
        }

        private void btGuardar_Click(object sender, EventArgs e){
            Propiedades.autoAleatorio = cbAutoAleatorio.Checked;
            Propiedades.autoAvance = cbAutoAvance.Checked;
            Propiedades.autoPlay = cbAutoPlay.Checked;
            Propiedades.rutaPorDefecto = tbRutaDefault.Text;
            Propiedades.dimensionCaratula = (int)((float)(nupCaratula.Value));
            Propiedades.salvar();
        }

        private void btRestablecer_Click(object sender, EventArgs e){
            Propiedades.defaults();
            cbAutoAleatorio.Checked = Propiedades.autoAleatorio;
            cbAutoAvance.Checked = Propiedades.autoAvance;
            cbAutoPlay.Checked = Propiedades.autoPlay;
            tbRutaDefault.Text = Propiedades.rutaPorDefecto;
            nupCaratula.Value = Propiedades.dimensionCaratula;
        }
    }
}
