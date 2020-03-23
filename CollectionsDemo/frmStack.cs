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
    public partial class frmStack : Form
    {
        private Stack<String> testStack;
        public frmStack()
        {
            InitializeComponent();
            testStack = new Stack<string>();
        }
        private void RenderList()
        {
            String Contents = "Stack: \n";
            /*for (int x = 0; x < testList.Count; x++)
                Contents += testList[x] + "\n";*/
            foreach (String s in testStack)
                Contents += s + "\n";
            lblList.Text = Contents;
        }
        private void btnPush_Click(object sender, EventArgs e)
        {
            testStack.Push(txtValToAdd.Text);
            RenderList();
        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pop: " + testStack.Pop());
            RenderList();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Count: " + testStack.Count);
        }

        private void btnPeek_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pop: " + testStack.Peek());
            RenderList();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            testStack.Clear();
            RenderList();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
