namespace TutExample1
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
            label1 = new Label();
            label2 = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            label3 = new Label();
            txtAge = new TextBox();
            label4 = new Label();
            btnRun = new Button();
            splitContainer1 = new SplitContainer();
            lblOutput = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Bisque;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(800, 61);
            label1.TabIndex = 0;
            label1.Text = "Data Entry for new Client";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 34);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 1;
            label2.Text = "First Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(44, 82);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(150, 31);
            txtFirstName.TabIndex = 2;
//            txtFirstName.TextChanged += txtFirstName_TextChanged;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(44, 160);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(150, 31);
            txtLastName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 119);
            label3.Name = "label3";
            label3.Size = new Size(95, 25);
            label3.TabIndex = 3;
            label3.Text = "Last Name";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(44, 246);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(150, 31);
            txtAge.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 205);
            label4.Name = "label4";
            label4.Size = new Size(44, 25);
            label4.TabIndex = 5;
            label4.Text = "Age";
            // 
            // btnRun
            // 
            btnRun.Dock = DockStyle.Fill;
            btnRun.Font = new Font("Segoe UI", 20F);
            btnRun.Location = new Point(0, 0);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(268, 389);
            btnRun.TabIndex = 7;
            btnRun.Text = "Generate Details";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 61);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(lblOutput);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(txtAge);
            splitContainer1.Panel1.Controls.Add(txtFirstName);
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(txtLastName);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(btnRun);
            splitContainer1.Size = new Size(800, 389);
            splitContainer1.SplitterDistance = 528;
            splitContainer1.TabIndex = 8;
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Location = new Point(48, 289);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(59, 25);
            lblOutput.TabIndex = 7;
            lblOutput.Text = "label5";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Label label3;
        private TextBox txtAge;
        private Label label4;
        private Button btnRun;
        private SplitContainer splitContainer1;
        private Label lblOutput;
    }
}
