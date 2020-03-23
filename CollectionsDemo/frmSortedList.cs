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
    public partial class frmSortedList : Form
    {
        private SortedList<String, String> testList;
        public frmSortedList()
        {
            InitializeComponent();
            testList = new SortedList<string, string>();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            testList.Add(txtKeyToAdd.Text, txtValToAdd.Text);
            RenderList();
        }

        private void RenderList()
        {
            String Contents = "List: \n";
            foreach (String s in testList.Keys)
                Contents += "testList[\"" + s + "\"] = " + testList[s] + "\n";
            lblList.Text = Contents;
        }

        private void btnContains_Click(object sender, EventArgs e)
        {
            MessageBox.Show("testList.ContainsKey(\"" + txtKeyToAdd.Text + "\") = " + testList.ContainsKey(txtKeyToAdd.Text));
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Count: " + testList.Count);
        }

        private void btnIndex_Click(object sender, EventArgs e)
        {
            if(!testList.ContainsKey(txtKeyToAdd.Text))
            {
                MessageBox.Show("Key is not in the list");
                return;
            }
            MessageBox.Show("Value at Key \"" + txtKeyToAdd.Text + "\": " + testList[txtKeyToAdd.Text]);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            testList.Clear();
            RenderList();
        }

        private void frmSortedList_Load(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
