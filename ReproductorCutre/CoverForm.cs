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
    public partial class CoverForm : Form
    {
        public CoverForm(Image cover){
            if (cover == null){
                this.Dispose();
                return;
            }
            
            int ww = cover.Width / Propiedades.dimensionCaratula;
            int hh = cover.Height / Propiedades.dimensionCaratula;
            Console.WriteLine("ww: " + ww);
            Console.WriteLine("hh: " + hh);
            Console.WriteLine("ww: " + cover.Width);
            Console.WriteLine("hh: " + cover.Height);
            Image ncover = Utiles.ScaleImage(cover, ww, hh);
            InitializeComponent();
            pictureBox1.Image = ncover;
            pictureBox1.Width = ncover.Width;
            pictureBox1.Height = ncover.Height;
            this.Height = ncover.Height+39;
            this.Width = ncover.Width+16;
        }
    }
}
