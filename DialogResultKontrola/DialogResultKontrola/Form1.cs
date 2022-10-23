using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialogResultKontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult messageBox = MessageBox.Show("Odaberite Yes, No ili Cancel.", "Naslovna linija Dijaloga za poruke",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Information);
            switch(messageBox) {
                case DialogResult.Yes: textBox1.Text = "Izabrali ste gum Yes."; break;
                case DialogResult.No: textBox1.Text = "Izabrali ste gum No."; break;
                case DialogResult.Cancel: textBox1.Text = "Izabrali ste gum Cancel."; break;
            }
        }
    }
}
