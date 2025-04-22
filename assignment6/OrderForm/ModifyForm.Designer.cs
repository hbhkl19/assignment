
namespace OrderForm
{
    partial class ModifyForm
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
            modifyLabel1 = new System.Windows.Forms.Label();
            modifyLabel2 = new System.Windows.Forms.Label();
            modifyLabel3 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            modifyButton1 = new System.Windows.Forms.Button();
            modifyTextbox1 = new System.Windows.Forms.TextBox();
            modifyTextbox2 = new System.Windows.Forms.TextBox();
            panel2 = new System.Windows.Forms.Panel();
            modifyButton2 = new System.Windows.Forms.Button();
            modifyTextbox5 = new System.Windows.Forms.TextBox();
            modifyLabel6 = new System.Windows.Forms.Label();
            modifyTextbox4 = new System.Windows.Forms.TextBox();
            modifyLabel5 = new System.Windows.Forms.Label();
            modifyTextbox3 = new System.Windows.Forms.TextBox();
            modifyLabel4 = new System.Windows.Forms.Label();
            modifyButton3 = new System.Windows.Forms.Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // modifyLabel1
            // 
            modifyLabel1.AutoSize = true;
            modifyLabel1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            modifyLabel1.Location = new System.Drawing.Point(374, 29);
            modifyLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            modifyLabel1.Name = "modifyLabel1";
            modifyLabel1.Size = new System.Drawing.Size(402, 55);
            modifyLabel1.TabIndex = 0;
            modifyLabel1.Text = "输入该订单的新信息";
            // 
            // modifyLabel2
            // 
            modifyLabel2.AutoSize = true;
            modifyLabel2.Location = new System.Drawing.Point(45, 34);
            modifyLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            modifyLabel2.Name = "modifyLabel2";
            modifyLabel2.Size = new System.Drawing.Size(93, 35);
            modifyLabel2.TabIndex = 1;
            modifyLabel2.Text = "客户id";
            // 
            // modifyLabel3
            // 
            modifyLabel3.AutoSize = true;
            modifyLabel3.Location = new System.Drawing.Point(45, 117);
            modifyLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            modifyLabel3.Name = "modifyLabel3";
            modifyLabel3.Size = new System.Drawing.Size(123, 35);
            modifyLabel3.TabIndex = 1;
            modifyLabel3.Text = "客户姓名";
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(modifyButton1);
            panel1.Controls.Add(modifyTextbox1);
            panel1.Controls.Add(modifyTextbox2);
            panel1.Controls.Add(modifyLabel3);
            panel1.Controls.Add(modifyLabel2);
            panel1.Location = new System.Drawing.Point(0, 101);
            panel1.Margin = new System.Windows.Forms.Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1130, 251);
            panel1.TabIndex = 2;
            // 
            // modifyButton1
            // 
            modifyButton1.Location = new System.Drawing.Point(278, 185);
            modifyButton1.Margin = new System.Windows.Forms.Padding(4);
            modifyButton1.Name = "modifyButton1";
            modifyButton1.Size = new System.Drawing.Size(627, 50);
            modifyButton1.TabIndex = 3;
            modifyButton1.Text = "保存";
            modifyButton1.UseVisualStyleBackColor = true;
            modifyButton1.Click += modifyButton1_Click;
            // 
            // modifyTextbox1
            // 
            modifyTextbox1.Location = new System.Drawing.Point(273, 29);
            modifyTextbox1.Margin = new System.Windows.Forms.Padding(4);
            modifyTextbox1.Name = "modifyTextbox1";
            modifyTextbox1.Size = new System.Drawing.Size(702, 42);
            modifyTextbox1.TabIndex = 2;
            // 
            // modifyTextbox2
            // 
            modifyTextbox2.Location = new System.Drawing.Point(273, 112);
            modifyTextbox2.Margin = new System.Windows.Forms.Padding(4);
            modifyTextbox2.Name = "modifyTextbox2";
            modifyTextbox2.Size = new System.Drawing.Size(702, 42);
            modifyTextbox2.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel2.Controls.Add(modifyButton2);
            panel2.Controls.Add(modifyTextbox5);
            panel2.Controls.Add(modifyLabel6);
            panel2.Controls.Add(modifyTextbox4);
            panel2.Controls.Add(modifyLabel5);
            panel2.Controls.Add(modifyTextbox3);
            panel2.Controls.Add(modifyLabel4);
            panel2.Location = new System.Drawing.Point(0, 374);
            panel2.Margin = new System.Windows.Forms.Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1130, 423);
            panel2.TabIndex = 3;
            // 
            // modifyButton2
            // 
            modifyButton2.Enabled = false;
            modifyButton2.Location = new System.Drawing.Point(273, 344);
            modifyButton2.Margin = new System.Windows.Forms.Padding(4);
            modifyButton2.Name = "modifyButton2";
            modifyButton2.Size = new System.Drawing.Size(627, 48);
            modifyButton2.TabIndex = 2;
            modifyButton2.Text = "保存";
            modifyButton2.UseVisualStyleBackColor = true;
            modifyButton2.Click += modifyButton2_Click;
            // 
            // modifyTextbox5
            // 
            modifyTextbox5.Location = new System.Drawing.Point(269, 251);
            modifyTextbox5.Margin = new System.Windows.Forms.Padding(4);
            modifyTextbox5.Name = "modifyTextbox5";
            modifyTextbox5.Size = new System.Drawing.Size(752, 42);
            modifyTextbox5.TabIndex = 1;
            // 
            // modifyLabel6
            // 
            modifyLabel6.AutoSize = true;
            modifyLabel6.Location = new System.Drawing.Point(48, 251);
            modifyLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            modifyLabel6.Name = "modifyLabel6";
            modifyLabel6.Size = new System.Drawing.Size(69, 35);
            modifyLabel6.TabIndex = 0;
            modifyLabel6.Text = "数量";
            // 
            // modifyTextbox4
            // 
            modifyTextbox4.Location = new System.Drawing.Point(269, 141);
            modifyTextbox4.Margin = new System.Windows.Forms.Padding(4);
            modifyTextbox4.Name = "modifyTextbox4";
            modifyTextbox4.Size = new System.Drawing.Size(752, 42);
            modifyTextbox4.TabIndex = 1;
            // 
            // modifyLabel5
            // 
            modifyLabel5.AutoSize = true;
            modifyLabel5.Location = new System.Drawing.Point(48, 146);
            modifyLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            modifyLabel5.Name = "modifyLabel5";
            modifyLabel5.Size = new System.Drawing.Size(69, 35);
            modifyLabel5.TabIndex = 0;
            modifyLabel5.Text = "单价";
            // 
            // modifyTextbox3
            // 
            modifyTextbox3.Location = new System.Drawing.Point(269, 47);
            modifyTextbox3.Margin = new System.Windows.Forms.Padding(4);
            modifyTextbox3.Name = "modifyTextbox3";
            modifyTextbox3.Size = new System.Drawing.Size(752, 42);
            modifyTextbox3.TabIndex = 1;
            // 
            // modifyLabel4
            // 
            modifyLabel4.AutoSize = true;
            modifyLabel4.Location = new System.Drawing.Point(48, 50);
            modifyLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            modifyLabel4.Name = "modifyLabel4";
            modifyLabel4.Size = new System.Drawing.Size(123, 35);
            modifyLabel4.TabIndex = 0;
            modifyLabel4.Text = "产品名称";
            // 
            // modifyButton3
            // 
            modifyButton3.Location = new System.Drawing.Point(270, 823);
            modifyButton3.Margin = new System.Windows.Forms.Padding(4);
            modifyButton3.Name = "modifyButton3";
            modifyButton3.Size = new System.Drawing.Size(627, 54);
            modifyButton3.TabIndex = 4;
            modifyButton3.Text = "完成";
            modifyButton3.UseVisualStyleBackColor = true;
            modifyButton3.Click += modifyButton3_Click;
            // 
            // ModifyForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(16F, 35F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1132, 987);
            Controls.Add(modifyButton3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(modifyLabel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ModifyForm";
            Text = "ModifyForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label modifyLabel1;
        private System.Windows.Forms.Label modifyLabel2;
        private System.Windows.Forms.Label modifyLabel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox modifyTextbox1;
        private System.Windows.Forms.TextBox modifyTextbox2;
        private System.Windows.Forms.Button modifyButton1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button modifyButton2;
        private System.Windows.Forms.TextBox modifyTextbox5;
        private System.Windows.Forms.Label modifyLabel6;
        private System.Windows.Forms.TextBox modifyTextbox4;
        private System.Windows.Forms.Label modifyLabel5;
        private System.Windows.Forms.TextBox modifyTextbox3;
        private System.Windows.Forms.Label modifyLabel4;
        private System.Windows.Forms.Button modifyButton3;
    }
}