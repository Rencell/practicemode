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
    public partial class listitem : UserControl
    {
        private string title;
        public listitem(string title)
        {   
            this.title = title;
            InitializeComponent();

            label1.Text = title;
        }

        private void listitem_Click(object sender, EventArgs e)
        {
            modal mod = new modal(title);
            mod.ShowDialog();   
        }
        
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
    }
}
