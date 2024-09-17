using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class FormApp : Form
    {
        public FormApp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 cDwochGraczy;
            cDwochGraczy = new Form1('M');
            cDwochGraczy.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 cDwochGraczy;
            cDwochGraczy = new Form1('C');
            cDwochGraczy.ShowDialog();
        }

        private void oProgramieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInfo formInfo;
            formInfo = new FormInfo();
            formInfo.ShowDialog();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRules formRules;
            formRules = new FormRules();
            formRules.ShowDialog();
        }
    }
}
