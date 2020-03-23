namespace CollectionsDemo
{
    partial class frmCollectionDemo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnList = new System.Windows.Forms.Button();
            this.btnSortedList = new System.Windows.Forms.Button();
            this.btnQueue = new System.Windows.Forms.Button();
            this.btnStack = new System.Windows.Forms.Button();
            this.btnDictionary = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(25, 24);
            this.btnList.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(150, 23);
            this.btnList.TabIndex = 1;
            this.btnList.Text = "List<Object>";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnSortedList
            // 
            this.btnSortedList.Location = new System.Drawing.Point(25, 60);
            this.btnSortedList.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnSortedList.Name = "btnSortedList";
            this.btnSortedList.Size = new System.Drawing.Size(150, 23);
            this.btnSortedList.TabIndex = 2;
            this.btnSortedList.Text = "SortedList<Object>";
            this.btnSortedList.UseVisualStyleBackColor = true;
            this.btnSortedList.Click += new System.EventHandler(this.btnSortedList_Click);
            // 
            // btnQueue
            // 
            this.btnQueue.Location = new System.Drawing.Point(25, 98);
            this.btnQueue.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnQueue.Name = "btnQueue";
            this.btnQueue.Size = new System.Drawing.Size(150, 23);
            this.btnQueue.TabIndex = 3;
            this.btnQueue.Text = "Queue<Object>";
            this.btnQueue.UseVisualStyleBackColor = true;
            this.btnQueue.Click += new System.EventHandler(this.btnQueue_Click);
            // 
            // btnStack
            // 
            this.btnStack.Location = new System.Drawing.Point(25, 131);
            this.btnStack.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnStack.Name = "btnStack";
            this.btnStack.Size = new System.Drawing.Size(150, 23);
            this.btnStack.TabIndex = 4;
            this.btnStack.Text = "Stack<Object>";
            this.btnStack.UseVisualStyleBackColor = true;
            this.btnStack.Click += new System.EventHandler(this.btnStack_Click);
            // 
            // btnDictionary
            // 
            this.btnDictionary.Location = new System.Drawing.Point(25, 165);
            this.btnDictionary.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnDictionary.Name = "btnDictionary";
            this.btnDictionary.Size = new System.Drawing.Size(150, 23);
            this.btnDictionary.TabIndex = 5;
            this.btnDictionary.Text = "Dictionary<Object,Object>";
            this.btnDictionary.UseVisualStyleBackColor = true;
            this.btnDictionary.Click += new System.EventHandler(this.btnDictionary_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(25, 197);
            this.btnExit.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmCollectionDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(195, 234);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDictionary);
            this.Controls.Add(this.btnStack);
            this.Controls.Add(this.btnQueue);
            this.Controls.Add(this.btnSortedList);
            this.Controls.Add(this.btnList);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "frmCollectionDemo";
            this.Text = "C# Collections Demo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnSortedList;
        private System.Windows.Forms.Button btnQueue;
        private System.Windows.Forms.Button btnStack;
        private System.Windows.Forms.Button btnDictionary;
        private System.Windows.Forms.Button btnExit;
    }
}

