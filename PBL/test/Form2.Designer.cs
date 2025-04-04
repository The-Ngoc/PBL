namespace PBL.test
{
    partial class Form2
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
            button1 = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(489, 392);
            button1.Name = "button1";
            button1.Size = new Size(126, 37);
            button1.TabIndex = 0;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Back_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(512, 42);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(230, 33);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += Room_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(512, 116);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(230, 33);
            comboBox2.TabIndex = 2;
            comboBox2.SelectedIndexChanged += YearAcademi_SelectedIndexChanged;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(512, 190);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(230, 33);
            comboBox3.TabIndex = 3;
            comboBox3.SelectedIndexChanged += Hocky_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(363, 42);
            label1.Name = "label1";
            label1.Size = new Size(98, 25);
            label1.TabIndex = 4;
            label1.Text = "Phong hoc";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(363, 119);
            label2.Name = "label2";
            label2.Size = new Size(84, 25);
            label2.TabIndex = 5;
            label2.Text = "Nam hoc";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(363, 198);
            label3.Name = "label3";
            label3.Size = new Size(67, 25);
            label3.TabIndex = 6;
            label3.Text = "Hoc ky";
            // 
            // button2
            // 
            button2.Location = new Point(651, 392);
            button2.Name = "button2";
            button2.Size = new Size(116, 35);
            button2.TabIndex = 7;
            button2.Text = "Next";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Name = "Form2";
            Text = "test2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button2;
    }
}