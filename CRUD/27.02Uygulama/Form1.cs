using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _27._02Uygulama
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }
        
        private void telefonDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            TelefonForm tf = new TelefonForm();
            tf.MdiParent = this;
            tf.Show();
        }

        private void telefonlarıListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            
            
            
            Form2 f2 = new Form2();
            f2.MdiParent = this;
            f2.Show();



        }
    }
}
