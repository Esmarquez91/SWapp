using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWapp
{
    public partial class InfoMessageForm : Form
    {
        public InfoMessageForm()
        {
            InitializeComponent();
            RBInfoText.Text = "";
            RBInfoText.SelectionStart = RBInfoText.TextLength;
            RBInfoText.SelectionLength = 0;
            RBInfoText.SelectionColor = Color.DarkSlateBlue;
            RBInfoText.AppendText("Ejemplo: Córdoba y Arroyito, segmento Gral Paz - Barracas");
        }

        private void InfoMessageForm_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = SWapp.Properties.Resources.InfoLocation1;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Image = SWapp.Properties.Resources.InfoLocation2;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
