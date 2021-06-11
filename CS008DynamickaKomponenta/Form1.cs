using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS008DynamickaKomponenta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("{0}, {1}", MousePosition.X, MousePosition.Y));
            Button btn = new Button();
            btn.Top = MousePosition.Y;
            btn.Left = MousePosition.X;
            btn.Width = 10;
            btn.Height = 10;
            this.Controls.Add(btn);
        }
    }
}
