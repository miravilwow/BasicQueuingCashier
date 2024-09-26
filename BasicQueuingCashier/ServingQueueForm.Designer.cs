namespace BasicQueuingCashier
{
    partial class ServingQueueForm
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
            lblStudentQeueu = new Label();
            UpdateQeueDisplay = new Label();
            SuspendLayout();
            // 
            // lblStudentQeueu
            // 
            lblStudentQeueu.AutoSize = true;
            lblStudentQeueu.Font = new Font("Nirmala UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudentQeueu.Location = new Point(35, 31);
            lblStudentQeueu.Name = "lblStudentQeueu";
            lblStudentQeueu.Size = new Size(218, 37);
            lblStudentQeueu.TabIndex = 0;
            lblStudentQeueu.Text = "*NOW SERVING";
            lblStudentQeueu.Click += label1_Click;
            // 
            // UpdateQeueDisplay
            // 
            UpdateQeueDisplay.AutoSize = true;
            UpdateQeueDisplay.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UpdateQeueDisplay.Location = new Point(55, 129);
            UpdateQeueDisplay.Name = "UpdateQeueDisplay";
            UpdateQeueDisplay.Size = new Size(52, 21);
            UpdateQeueDisplay.TabIndex = 1;
            UpdateQeueDisplay.Text = "label2";
            UpdateQeueDisplay.Click += UpdateQeueDisplay_Click;
            // 
            // ServingQueueForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(610, 383);
            Controls.Add(UpdateQeueDisplay);
            Controls.Add(lblStudentQeueu);
            Name = "ServingQueueForm";
            Text = "ServingQueueForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStudentQeueu;
        private Label UpdateQeueDisplay;
    }
}