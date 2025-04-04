namespace PBL.test
{
    partial class Form1
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
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBox4 = new ComboBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(473, 50);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(297, 33);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += ByFaculty_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(473, 123);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(297, 33);
            comboBox2.TabIndex = 1;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(473, 192);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(297, 33);
            comboBox3.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(613, 361);
            button1.Name = "button1";
            button1.Size = new Size(140, 41);
            button1.TabIndex = 3;
            button1.Text = "Next";
            button1.UseVisualStyleBackColor = true;
            button1.Click += next_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(349, 48);
            label1.Name = "label1";
            label1.Size = new Size(52, 25);
            label1.TabIndex = 4;
            label1.Text = "Khoa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(349, 123);
            label2.Name = "label2";
            label2.Size = new Size(83, 25);
            label2.TabIndex = 5;
            label2.Text = "Mon hoc";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(346, 195);
            label3.Name = "label3";
            label3.Size = new Size(85, 25);
            label3.TabIndex = 6;
            label3.Text = "Giao vien";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(473, 263);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(297, 33);
            comboBox4.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(346, 266);
            label4.Name = "label4";
            label4.Size = new Size(121, 25);
            label4.TabIndex = 8;
            label4.Text = "Lớp học phần";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(comboBox4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "testForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox4;
        private Label label4;
    }
}