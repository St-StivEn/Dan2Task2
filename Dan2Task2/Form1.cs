using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dan2Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();



            this.Width -= 17;
            PanelBody.AutoScroll = false;

            foreach (var panel in PanelBody.Controls.OfType<Guna2Panel>())
            {
                panel.Height = PanelBody.Height;
            }
        }

        private void PanelBody_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
