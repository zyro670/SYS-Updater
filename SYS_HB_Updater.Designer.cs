namespace SYS_AutoUpdater
{
    partial class SYS_HB_Updater
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SYS_HB_Updater));
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            progressBar1 = new ProgressBar();
            textBox1 = new TextBox();
            button2 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            AMSCheck = new CheckBox();
            HekateCheck = new CheckBox();
            ldnCheck = new CheckBox();
            SbbCheck = new CheckBox();
            groupBox1 = new GroupBox();
            checkBox5 = new CheckBox();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(10, 6);
            label1.Name = "label1";
            label1.Size = new Size(123, 15);
            label1.TabIndex = 0;
            label1.Text = "Atmosphere Version:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(10, 40);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 1;
            label2.Text = "Hekate Version:";
            // 
            // button1
            // 
            button1.Location = new Point(13, 156);
            button1.Name = "button1";
            button1.Size = new Size(226, 36);
            button1.TabIndex = 4;
            button1.Text = "Grab Latest Releases";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(13, 198);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(226, 18);
            progressBar1.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(13, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 8;
            textBox1.Visible = false;
            // 
            // button2
            // 
            button2.Location = new Point(164, 12);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 9;
            button2.Text = "Connect";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(10, 74);
            label3.Name = "label3";
            label3.Size = new Size(106, 15);
            label3.TabIndex = 10;
            label3.Text = "ldn_mitm Version:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(10, 108);
            label4.Name = "label4";
            label4.Size = new Size(117, 15);
            label4.TabIndex = 11;
            label4.Text = "Hybrid SBB Version:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 23);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 57);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 91);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(10, 125);
            label8.Name = "label8";
            label8.Size = new Size(0, 15);
            label8.TabIndex = 15;
            // 
            // AMSCheck
            // 
            AMSCheck.AutoSize = true;
            AMSCheck.Location = new Point(6, 19);
            AMSCheck.Name = "AMSCheck";
            AMSCheck.Size = new Size(56, 19);
            AMSCheck.TabIndex = 16;
            AMSCheck.Text = "AMS?";
            AMSCheck.UseVisualStyleBackColor = true;
            // 
            // HekateCheck
            // 
            HekateCheck.AutoSize = true;
            HekateCheck.Location = new Point(6, 37);
            HekateCheck.Name = "HekateCheck";
            HekateCheck.Size = new Size(68, 19);
            HekateCheck.TabIndex = 17;
            HekateCheck.Text = "Hekate?";
            HekateCheck.UseVisualStyleBackColor = true;
            // 
            // ldnCheck
            // 
            ldnCheck.AutoSize = true;
            ldnCheck.Location = new Point(6, 55);
            ldnCheck.Name = "ldnCheck";
            ldnCheck.Size = new Size(82, 19);
            ldnCheck.TabIndex = 18;
            ldnCheck.Text = "ldn-mitm?";
            ldnCheck.UseVisualStyleBackColor = true;
            // 
            // SbbCheck
            // 
            SbbCheck.AutoSize = true;
            SbbCheck.Location = new Point(6, 73);
            SbbCheck.Name = "SbbCheck";
            SbbCheck.Size = new Size(51, 19);
            SbbCheck.TabIndex = 19;
            SbbCheck.Text = "SBB?";
            SbbCheck.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox5);
            groupBox1.Controls.Add(SbbCheck);
            groupBox1.Controls.Add(AMSCheck);
            groupBox1.Controls.Add(ldnCheck);
            groupBox1.Controls.Add(HekateCheck);
            groupBox1.Location = new Point(245, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(95, 117);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Selections";
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(6, 92);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(67, 19);
            checkBox5.TabIndex = 22;
            checkBox5.Text = "Extract?";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(245, 140);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(95, 76);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // SYS_HB_Updater
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 228);
            Controls.Add(pictureBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(progressBar1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "SYS_HB_Updater";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SYS_HB_Updater";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private ProgressBar progressBar1;
        private TextBox textBox1;
        private Button button2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private CheckBox AMSCheck;
        private CheckBox HekateCheck;
        private CheckBox ldnCheck;
        private CheckBox SbbCheck;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private CheckBox checkBox5;
    }
}