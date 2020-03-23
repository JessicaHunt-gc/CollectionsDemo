namespace CollectionsDemo
{
    partial class frmDictionary
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValToAdd = new System.Windows.Forms.TextBox();
            this.btnIndex = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnContains = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblList = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtKeyToAdd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Value";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Key";
            // 
            // txtValToAdd
            // 
            this.txtValToAdd.Location = new System.Drawing.Point(53, 42);
            this.txtValToAdd.Name = "txtValToAdd";
            this.txtValToAdd.Size = new System.Drawing.Size(100, 20);
            this.txtValToAdd.TabIndex = 27;
            // 
            // btnIndex
            // 
            this.btnIndex.Location = new System.Drawing.Point(23, 155);
            this.btnIndex.Name = "btnIndex";
            this.btnIndex.Size = new System.Drawing.Size(91, 23);
            this.btnIndex.TabIndex = 26;
            this.btnIndex.Text = "Val @ Key";
            this.btnIndex.UseVisualStyleBackColor = true;
            this.btnIndex.Click += new System.EventHandler(this.btnIndex_Click);
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(23, 126);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(91, 23);
            this.btnCount.TabIndex = 25;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // btnContains
            // 
            this.btnContains.Location = new System.Drawing.Point(23, 97);
            this.btnContains.Name = "btnContains";
            this.btnContains.Size = new System.Drawing.Size(91, 23);
            this.btnContains.TabIndex = 24;
            this.btnContains.Text = "Contains(key)";
            this.btnContains.UseVisualStyleBackColor = true;
            this.btnContains.Click += new System.EventHandler(this.btnContains_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(23, 234);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(91, 23);
            this.btnReturn.TabIndex = 23;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Location = new System.Drawing.Point(179, 12);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(26, 13);
            this.lblList.TabIndex = 22;
            this.lblList.Text = "List:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(23, 205);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(91, 23);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(23, 68);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 23);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtKeyToAdd
            // 
            this.txtKeyToAdd.Location = new System.Drawing.Point(53, 12);
            this.txtKeyToAdd.Name = "txtKeyToAdd";
            this.txtKeyToAdd.Size = new System.Drawing.Size(100, 20);
            this.txtKeyToAdd.TabIndex = 19;
            // 
            // frmDictionary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 278);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValToAdd);
            this.Controls.Add(this.btnIndex);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnContains);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtKeyToAdd);
            this.Name = "frmDictionary";
            this.Text = "frmDictionary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValToAdd;
        private System.Windows.Forms.Button btnIndex;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnContains;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtKeyToAdd;
    }
}