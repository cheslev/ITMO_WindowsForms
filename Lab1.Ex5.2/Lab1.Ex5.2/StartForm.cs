using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1.Ex5._2
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChildForm f2 = new ChildForm();
            f2.ShowDialog();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {

        }
    }
}
