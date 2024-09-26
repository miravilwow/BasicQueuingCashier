namespace BasicQueuingCashier
{
    partial class QueuingForm
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
            label1 = new Label();
            btnCashier = new Button();
            label2 = new Label();
            lblQueue = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(453, 65);
            label1.Name = "label1";
            label1.Size = new Size(246, 32);
            label1.TabIndex = 0;
            label1.Text = "POSITION IN QUEUE";
            // 
            // btnCashier
            // 
            btnCashier.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCashier.ForeColor = SystemColors.ActiveCaptionText;
            btnCashier.Location = new Point(36, 44);
            btnCashier.Name = "btnCashier";
            btnCashier.Size = new Size(308, 244);
            btnCashier.TabIndex = 1;
            btnCashier.Text = "CASHIER";
            btnCashier.UseVisualStyleBackColor = true;
            btnCashier.Click += btnCashier_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(128, 306);
            label2.Name = "label2";
            label2.Size = new Size(126, 15);
            label2.TabIndex = 2;
            label2.Text = "*Click to get a number";
            // 
            // lblQueue
            // 
            lblQueue.AutoSize = true;
            lblQueue.Font = new Font("Nirmala UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQueue.Location = new Point(453, 182);
            lblQueue.Name = "lblQueue";
            lblQueue.Size = new Size(68, 30);
            lblQueue.TabIndex = 3;
            lblQueue.Text = "label3";
            // 
            // QueuingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(783, 374);
            Controls.Add(lblQueue);
            Controls.Add(label2);
            Controls.Add(btnCashier);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "QueuingForm";
            Text = "QueuingForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCashier;
        private Label label2;
        private Label lblQueue;
    }
}