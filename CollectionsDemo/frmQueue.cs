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
    public partial class frmQueue : Form
    {
        private Queue<String> testQueue;
        public frmQueue()
        {
            InitializeComponent();
            testQueue = new Queue<string>();
        }

        private void RenderList()
        {
            String Contents = "Queue: \n";
            /*for (int x = 0; x < testList.Count; x++)
                Contents += testList[x] + "\n";*/
            foreach (String s in testQueue)
                Contents += s + "\n";
            lblList.Text = Contents;
        }

        private void btnEnqueue_Click(object sender, EventArgs e)
        {
            testQueue.Enqueue(txtValToAdd.Text);
            RenderList();
        }

        private void btnDequeue_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dequeued Value: " + testQueue.Dequeue());
            RenderList();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Count: " + testQueue.Count);
        }

        private void btnPeek_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Peeked Value: " + testQueue.Peek());
            RenderList();            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            testQueue.Clear();
            RenderList();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
