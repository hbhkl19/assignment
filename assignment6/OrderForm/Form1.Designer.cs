
using OrderSource;

namespace OrderForm
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
            components = new System.ComponentModel.Container();
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            splitContainer2 = new System.Windows.Forms.SplitContainer();
            textBox1 = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            splitContainer3 = new System.Windows.Forms.SplitContainer();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            orderNumberDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            clientDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            totalDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            orderBindingSource = new System.Windows.Forms.BindingSource(components);
            dataGridView2 = new System.Windows.Forms.DataGridView();
            productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            subTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            detailBindingSource = new System.Windows.Forms.BindingSource(components);
            label2 = new System.Windows.Forms.Label();
            findBt = new System.Windows.Forms.Button();
            removeBt = new System.Windows.Forms.Button();
            updateBt = new System.Windows.Forms.Button();
            addBt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)detailBindingSource).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.Location = new System.Drawing.Point(0, 0);
            splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(findBt);
            splitContainer1.Panel2.Controls.Add(removeBt);
            splitContainer1.Panel2.Controls.Add(updateBt);
            splitContainer1.Panel2.Controls.Add(addBt);
            splitContainer1.Size = new System.Drawing.Size(1315, 1057);
            splitContainer1.SplitterDistance = 1137;
            splitContainer1.SplitterWidth = 6;
            splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer2.Location = new System.Drawing.Point(0, 0);
            splitContainer2.Margin = new System.Windows.Forms.Padding(4);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(textBox1);
            splitContainer2.Panel1.Controls.Add(label1);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(splitContainer3);
            splitContainer2.Size = new System.Drawing.Size(1137, 1057);
            splitContainer2.SplitterDistance = 141;
            splitContainer2.SplitterWidth = 6;
            splitContainer2.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(448, 60);
            textBox1.Margin = new System.Windows.Forms.Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(584, 42);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(35, 64);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(417, 70);
            label1.TabIndex = 0;
            label1.Text = "输入订单号以查找/删除/修改订单\r\n\r\n";
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer3.Location = new System.Drawing.Point(0, 0);
            splitContainer3.Margin = new System.Windows.Forms.Padding(4);
            splitContainer3.Name = "splitContainer3";
            splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(dataGridView1);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(dataGridView2);
            splitContainer3.Size = new System.Drawing.Size(1137, 910);
            splitContainer3.SplitterDistance = 756;
            splitContainer3.SplitterWidth = 6;
            splitContainer3.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { orderNumberDataGridViewTextBoxColumn2, clientDataGridViewTextBoxColumn2, totalDataGridViewTextBoxColumn2 });
            dataGridView1.DataSource = orderBindingSource;
            dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridView1.Location = new System.Drawing.Point(0, 0);
            dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new System.Drawing.Size(1137, 756);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // orderNumberDataGridViewTextBoxColumn2
            // 
            orderNumberDataGridViewTextBoxColumn2.DataPropertyName = "orderNumber";
            orderNumberDataGridViewTextBoxColumn2.HeaderText = "orderNumber";
            orderNumberDataGridViewTextBoxColumn2.MinimumWidth = 8;
            orderNumberDataGridViewTextBoxColumn2.Name = "orderNumberDataGridViewTextBoxColumn2";
            // 
            // clientDataGridViewTextBoxColumn2
            // 
            clientDataGridViewTextBoxColumn2.DataPropertyName = "client";
            clientDataGridViewTextBoxColumn2.HeaderText = "client";
            clientDataGridViewTextBoxColumn2.MinimumWidth = 8;
            clientDataGridViewTextBoxColumn2.Name = "clientDataGridViewTextBoxColumn2";
            // 
            // totalDataGridViewTextBoxColumn2
            // 
            totalDataGridViewTextBoxColumn2.DataPropertyName = "Total";
            totalDataGridViewTextBoxColumn2.HeaderText = "Total";
            totalDataGridViewTextBoxColumn2.MinimumWidth = 8;
            totalDataGridViewTextBoxColumn2.Name = "totalDataGridViewTextBoxColumn2";
            totalDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // orderBindingSource
            // 
            orderBindingSource.DataSource = typeof(Order);
            // 
            // dataGridView2
            // 
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { productNameDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, quantityDataGridViewTextBoxColumn, subTotalDataGridViewTextBoxColumn });
            dataGridView2.DataSource = detailBindingSource;
            dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridView2.Location = new System.Drawing.Point(0, 0);
            dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new System.Drawing.Size(1137, 148);
            dataGridView2.TabIndex = 0;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            productNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.MinimumWidth = 8;
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            quantityDataGridViewTextBoxColumn.MinimumWidth = 8;
            quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // subTotalDataGridViewTextBoxColumn
            // 
            subTotalDataGridViewTextBoxColumn.DataPropertyName = "SubTotal";
            subTotalDataGridViewTextBoxColumn.HeaderText = "SubTotal";
            subTotalDataGridViewTextBoxColumn.MinimumWidth = 8;
            subTotalDataGridViewTextBoxColumn.Name = "subTotalDataGridViewTextBoxColumn";
            subTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // detailBindingSource
            // 
            detailBindingSource.DataMember = "Details";
            detailBindingSource.DataSource = orderBindingSource;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(29, 104);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(123, 35);
            label2.TabIndex = 1;
            label2.Text = "订单操作";
            // 
            // findBt
            // 
            findBt.Location = new System.Drawing.Point(29, 663);
            findBt.Margin = new System.Windows.Forms.Padding(4);
            findBt.Name = "findBt";
            findBt.Size = new System.Drawing.Size(119, 98);
            findBt.TabIndex = 0;
            findBt.Text = "查找";
            findBt.UseVisualStyleBackColor = true;
            findBt.Click += findBt_Click;
            // 
            // removeBt
            // 
            removeBt.Location = new System.Drawing.Point(26, 401);
            removeBt.Margin = new System.Windows.Forms.Padding(4);
            removeBt.Name = "removeBt";
            removeBt.Size = new System.Drawing.Size(119, 98);
            removeBt.TabIndex = 0;
            removeBt.Text = "删除";
            removeBt.UseVisualStyleBackColor = true;
            removeBt.Click += removeBt_Click;
            // 
            // updateBt
            // 
            updateBt.Location = new System.Drawing.Point(26, 535);
            updateBt.Margin = new System.Windows.Forms.Padding(4);
            updateBt.Name = "updateBt";
            updateBt.Size = new System.Drawing.Size(119, 98);
            updateBt.TabIndex = 0;
            updateBt.Text = "修改";
            updateBt.UseVisualStyleBackColor = true;
            updateBt.Click += updateBt_Click;
            // 
            // addBt
            // 
            addBt.Location = new System.Drawing.Point(26, 282);
            addBt.Margin = new System.Windows.Forms.Padding(4);
            addBt.Name = "addBt";
            addBt.Size = new System.Drawing.Size(119, 98);
            addBt.TabIndex = 0;
            addBt.Text = "添加";
            addBt.UseVisualStyleBackColor = true;
            addBt.Click += addBt_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(16F, 35F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1315, 1057);
            Controls.Add(splitContainer1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(4);
            Name = "Form1";
            Text = "OrderManage";
            Load += Form1_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)detailBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.BindingSource detailBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button findBt;
        private System.Windows.Forms.Button removeBt;
        private System.Windows.Forms.Button updateBt;
        private System.Windows.Forms.Button addBt;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNumberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNumberDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

