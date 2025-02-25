namespace _1_2
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
            txtNumber1 = new TextBox();
            txtNumber2 = new TextBox();
            calculate = new Button();
            choice = new ComboBox();
            result = new Label();
            SuspendLayout();
            // 
            // txtNumber1
            // 
            txtNumber1.Location = new Point(167, 273);
            txtNumber1.Name = "txtNumber1";
            txtNumber1.Size = new Size(225, 42);
            txtNumber1.TabIndex = 0;
            // 
            // txtNumber2
            // 
            txtNumber2.Location = new Point(517, 273);
            txtNumber2.Name = "txtNumber2";
            txtNumber2.Size = new Size(225, 42);
            txtNumber2.TabIndex = 1;
            // 
            // calculate
            // 
            calculate.Location = new Point(362, 362);
            calculate.Name = "calculate";
            calculate.Size = new Size(169, 52);
            calculate.TabIndex = 3;
            calculate.Text = "calculate\r\n";
            calculate.UseVisualStyleBackColor = true;
            calculate.Click += button1_Click_1;
            // 
            // choice
            // 
            choice.FormattingEnabled = true;
            choice.Items.AddRange(new object[] { "+", "-", "*", "/" });
            choice.Location = new Point(415, 272);
            choice.Name = "choice";
            choice.Size = new Size(72, 43);
            choice.TabIndex = 5;
            // 
            // result
            // 
            result.AutoSize = true;
            result.Location = new Point(395, 474);
            result.Name = "result";
            result.Size = new Size(87, 35);
            result.TabIndex = 6;
            result.Text = "result";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(16F, 35F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 965);
            Controls.Add(result);
            Controls.Add(choice);
            Controls.Add(calculate);
            Controls.Add(txtNumber2);
            Controls.Add(txtNumber1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumber1;
        private TextBox txtNumber2;
        private Button calculate;
        private ComboBox choice;
        private Label result;
    }
}
