using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLittleVault
{
    public partial class Form1 : Form
    {
        private void Form1_Shown(object sender, EventArgs e)
        {
            this.Hide();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите выйти?", "Выход", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }

        private void логинToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("Login123");
        }

        private void парольToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("MySecretPass123");
        }

        private void логинToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("LoginVPN123");
        }

        private void парольToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("MySecretPassVPN123");
        }

        private void логинToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("Proj2Login123");
        }

        private void парольToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("Proj2MySecretPass123");
        }

        
    }
}
