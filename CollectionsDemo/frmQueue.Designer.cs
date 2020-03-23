﻿namespace CollectionsDemo
{
    partial class frmQueue
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
            this.btnPeek = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnDequeue = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblList = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEnqueue = new System.Windows.Forms.Button();
            this.txtValToAdd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPeek
            // 
            this.btnPeek.Location = new System.Drawing.Point(12, 125);
            this.btnPeek.Name = "btnPeek";
            this.btnPeek.Size = new System.Drawing.Size(75, 23);
            this.btnPeek.TabIndex = 15;
            this.btnPeek.Text = "Peek";
            this.btnPeek.UseVisualStyleBackColor = true;
            this.btnPeek.Click += new System.EventHandler(this.btnPeek_Click);
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(12, 96);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(75, 23);
            this.btnCount.TabIndex = 14;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // btnDequeue
            // 
            this.btnDequeue.Location = new System.Drawing.Point(12, 67);
            this.btnDequeue.Name = "btnDequeue";
            this.btnDequeue.Size = new System.Drawing.Size(75, 23);
            this.btnDequeue.TabIndex = 13;
            this.btnDequeue.Text = "Dequeue";
            this.btnDequeue.UseVisualStyleBackColor = true;
            this.btnDequeue.Click += new System.EventHandler(this.btnDequeue_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(12, 204);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 12;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Location = new System.Drawing.Point(169, 12);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(26, 13);
            this.lblList.TabIndex = 11;
            this.lblList.Text = "List:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 175);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnEnqueue
            // 
            this.btnEnqueue.Location = new System.Drawing.Point(12, 38);
            this.btnEnqueue.Name = "btnEnqueue";
            this.btnEnqueue.Size = new System.Drawing.Size(75, 23);
            this.btnEnqueue.TabIndex = 9;
            this.btnEnqueue.Text = "Enqueue";
            this.btnEnqueue.UseVisualStyleBackColor = true;
            this.btnEnqueue.Click += new System.EventHandler(this.btnEnqueue_Click);
            // 
            // txtValToAdd
            // 
            this.txtValToAdd.Location = new System.Drawing.Point(12, 12);
            this.txtValToAdd.Name = "txtValToAdd";
            this.txtValToAdd.Size = new System.Drawing.Size(100, 20);
            this.txtValToAdd.TabIndex = 8;
            // 
            // frmQueue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 250);
            this.Controls.Add(this.btnPeek);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnDequeue);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEnqueue);
            this.Controls.Add(this.txtValToAdd);
            this.Name = "frmQueue";
            this.Text = "frmQueue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPeek;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnDequeue;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEnqueue;
        private System.Windows.Forms.TextBox txtValToAdd;
    }
}