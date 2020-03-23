using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollectionsDemo
{
    public partial class frmCollectionDemo : Form
    {
        public frmCollectionDemo()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            frmList ListDemo = new frmList();
            OpenForm(ListDemo);
        }

        private void OpenForm(Form ListDemo)
        {
            ListDemo.Location = this.Location;
            ListDemo.StartPosition = FormStartPosition.Manual;
            ListDemo.FormClosing += delegate { this.Show(); };
            ListDemo.Show();
            this.Hide();
        }

        private void btnSortedList_Click(object sender, EventArgs e)
        {
            frmSortedList listDemo = new frmSortedList();
            OpenForm(listDemo);
        }

        private void btnDictionary_Click(object sender, EventArgs e)
        {
            frmDictionary dictionaryDemo = new frmDictionary();
            OpenForm(dictionaryDemo);
        }

        private void btnQueue_Click(object sender, EventArgs e)
        {
            frmQueue queueDemo = new frmQueue();
            OpenForm(queueDemo);
        }

        private void btnStack_Click(object sender, EventArgs e)
        {
            frmStack stackDemo = new frmStack();
            OpenForm(stackDemo);
        }
    }
}
