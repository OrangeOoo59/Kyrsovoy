using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RaspisanieProjrct.Forms;

namespace RaspisanieProjrct.Forms
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void OutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ViewForm = new SearchViewForm();
            ViewForm.MdiParent = this;
            ViewForm.Show();
        }

        private void LessonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form AddForm = new Form1();
            AddForm.MdiParent = this;
            AddForm.Show();
        }
    }
}
