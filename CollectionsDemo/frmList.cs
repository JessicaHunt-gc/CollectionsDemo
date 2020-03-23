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
    public partial class frmList : Form
    {
        public frmList()
        {
            InitializeComponent();
            testList = new List<string>();
        }

        private List<String> testList;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            testList.Add(txtValToAdd.Text);
            RenderList();
        }


        private void RenderList()
        {
            String Contents = "List: \n";
            /*for (int x = 0; x < testList.Count; x++)
                Contents += testList[x] + "\n";*/
            foreach (String s in testList)
                Contents += s + "\n";
            lblList.Text = Contents;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            testList.Clear();
            RenderList();
        }

        private void btnContains_Click(object sender, EventArgs e)
        {
            MessageBox.Show("testList.Contains(\"" + txtValToAdd.Text + "\") = " + testList.Contains(txtValToAdd.Text));
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Count: " + testList.Count);
        }

        private void btnIndex_Click(object sender, EventArgs e)
        {
            int idx;
            if (!Int32.TryParse(txtValToAdd.Text, out idx)) {
                MessageBox.Show("Please enter a numeric value");
                return;
            }

            if(idx <0 || idx >= testList.Count)
            {
                MessageBox.Show("index entered is out of range");
                return;
            }

            MessageBox.Show("Value at Index " + txtValToAdd.Text + ": " + testList[idx]);
        }
    }
}
