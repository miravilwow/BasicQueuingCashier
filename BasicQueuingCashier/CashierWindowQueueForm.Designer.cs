namespace BasicQueuingCashier
{
    partial class CashierWindowQueueForm
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
            btnRefresh = new Button();
            listCashierQueue = new ListView();
            btnNext = new Button();
            SuspendLayout();
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold);
            btnRefresh.Location = new Point(30, 51);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(176, 77);
            btnRefresh.TabIndex = 0;
            btnRefresh.Text = "REFRESH";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += button1_Click;
            // 
            // listCashierQueue
            // 
            listCashierQueue.Location = new Point(243, 51);
            listCashierQueue.Name = "listCashierQueue";
            listCashierQueue.Size = new Size(426, 369);
            listCashierQueue.TabIndex = 1;
            listCashierQueue.UseCompatibleStateImageBehavior = false;
            // 
            // btnNext
            // 
            btnNext.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNext.Location = new Point(30, 157);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(176, 60);
            btnNext.TabIndex = 2;
            btnNext.Text = "NEXT";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // CashierWindowQueueForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(721, 470);
            Controls.Add(btnNext);
            Controls.Add(listCashierQueue);
            Controls.Add(btnRefresh);
            Name = "CashierWindowQueueForm";
            Text = "CashierWindowQueueForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRefresh;
        private ListView listCashierQueue;
        private Button btnNext;
    }
}