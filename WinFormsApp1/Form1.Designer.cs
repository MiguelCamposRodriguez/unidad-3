namespace WinFormsApp1
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            listBox4 = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(303, 33);
            label1.Name = "label1";
            label1.Size = new Size(112, 25);
            label1.TabIndex = 0;
            label1.Text = "Z=X^2+X^3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 117);
            label2.Name = "label2";
            label2.Size = new Size(23, 25);
            label2.TabIndex = 1;
            label2.Text = "X";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(244, 117);
            label3.Name = "label3";
            label3.Size = new Size(45, 25);
            label3.TabIndex = 2;
            label3.Text = "X^2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(437, 117);
            label4.Name = "label4";
            label4.Size = new Size(45, 25);
            label4.TabIndex = 3;
            label4.Text = "X^3";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(656, 117);
            label5.Name = "label5";
            label5.Size = new Size(22, 25);
            label5.TabIndex = 4;
            label5.Text = "Z";
            // 
            // button1
            // 
            button1.Location = new Point(261, 393);
            button1.Name = "button1";
            button1.Size = new Size(196, 34);
            button1.TabIndex = 5;
            button1.Text = "Calcular valores";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(30, 145);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(124, 204);
            listBox1.TabIndex = 6;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 25;
            listBox2.Location = new Point(193, 145);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(135, 204);
            listBox2.TabIndex = 7;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 25;
            listBox3.Location = new Point(396, 145);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(131, 204);
            listBox3.TabIndex = 8;
            // 
            // listBox4
            // 
            listBox4.FormattingEnabled = true;
            listBox4.ItemHeight = 25;
            listBox4.Location = new Point(608, 145);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(128, 204);
            listBox4.TabIndex = 9;
            listBox4.SelectedIndexChanged += listBox4_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox4);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private ListBox listBox1;
        private ListBox listBox2;
        private ListBox listBox3;
        private ListBox listBox4;
    }
}
