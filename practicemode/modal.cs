using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practicemode
{
    public partial class modal : Form
    {
        public modal(string tex)
        {
            InitializeComponent();
            label1.Text = tex;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
