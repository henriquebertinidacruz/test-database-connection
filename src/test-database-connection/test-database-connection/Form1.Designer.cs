namespace test_database_connection
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnConnect = new Button();
            label1 = new Label();
            lblStatus = new Label();
            btnDisconnect = new Button();
            SuspendLayout();
            // 
            // btnConnect
            // 
            btnConnect.Font = new Font("Segoe UI", 14F);
            btnConnect.Location = new Point(12, 200);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(393, 116);
            btnConnect.TabIndex = 0;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(291, 32);
            label1.TabIndex = 1;
            label1.Text = "Test Database Connection";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 12F);
            lblStatus.Location = new Point(12, 73);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(168, 32);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "Current status:";
            // 
            // btnDisconnect
            // 
            btnDisconnect.Font = new Font("Segoe UI", 14F);
            btnDisconnect.Location = new Point(12, 322);
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.Size = new Size(393, 116);
            btnDisconnect.TabIndex = 4;
            btnDisconnect.Text = "Disconnect";
            btnDisconnect.UseVisualStyleBackColor = true;
            btnDisconnect.Click += btnDisconnect_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDisconnect);
            Controls.Add(lblStatus);
            Controls.Add(label1);
            Controls.Add(btnConnect);
            Name = "Form1";
            Text = "Test Database Connection";
            Load += Form1_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConnect;
        private Label label1;
        private Label lblStatus;
        private Button btnDisconnect;
    }
}
