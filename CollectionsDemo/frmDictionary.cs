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
    public partial class frmDictionary : Form
    {
        private Dictionary<String, String> testList;
        public frmDictionary()
        {
            InitializeComponent();
            testList = new Dictionary<string, string>();
        }
        private void RenderList()
        {
            String Contents = "List: \n";
            foreach (String s in testList.Keys)
                Contents += "testList[\"" + s + "\"] = " + testList[s] + "\n";
            lblList.Text = Contents;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            testList.Add(txtKeyToAdd.Text, txtValToAdd.Text);
            RenderList();
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
            if (!testList.ContainsKey(txtKeyToAdd.Text))
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

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
