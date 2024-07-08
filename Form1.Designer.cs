namespace BatchExcelOpetateTool
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SourceFileGridView = new System.Windows.Forms.DataGridView();
            this.FileListLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SheetTextBox = new System.Windows.Forms.TextBox();
            this.RowKeyTextBox = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ColKeyTextBox = new System.Windows.Forms.TextBox();
            this.ModifyValueTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ModifyButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SourceFileGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // SourceFileGridView
            // 
            this.SourceFileGridView.AllowDrop = true;
            this.SourceFileGridView.AllowUserToAddRows = false;
            this.SourceFileGridView.AllowUserToDeleteRows = false;
            this.SourceFileGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.SourceFileGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.SourceFileGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SourceFileGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SourceFileGridView.Location = new System.Drawing.Point(0, 0);
            this.SourceFileGridView.Name = "SourceFileGridView";
            this.SourceFileGridView.RowHeadersWidth = 72;
            this.SourceFileGridView.RowTemplate.Height = 33;
            this.SourceFileGridView.Size = new System.Drawing.Size(1524, 393);
            this.SourceFileGridView.TabIndex = 0;
            this.SourceFileGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SourceFileGridView_CellDoubleClick);
            this.SourceFileGridView.Click += new System.EventHandler(this.SourceFileGridView_Click);
            this.SourceFileGridView.DragDrop += new System.Windows.Forms.DragEventHandler(this.SourceFileGridView_DragDrop);
            this.SourceFileGridView.DragEnter += new System.Windows.Forms.DragEventHandler(this.SourceFileGridView_DragEnter);
            // 
            // FileListLabel
            // 
            this.FileListLabel.Font = new System.Drawing.Font("宋体", 11F);
            this.FileListLabel.Location = new System.Drawing.Point(24, 9);
            this.FileListLabel.Name = "FileListLabel";
            this.FileListLabel.Size = new System.Drawing.Size(167, 45);
            this.FileListLabel.TabIndex = 1;
            this.FileListLabel.Text = "File List";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.SourceFileGridView);
            this.panel1.Location = new System.Drawing.Point(16, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1524, 393);
            this.panel1.TabIndex = 2;
            // 
            // SheetTextBox
            // 
            this.SheetTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SheetTextBox.Location = new System.Drawing.Point(241, 17);
            this.SheetTextBox.Name = "SheetTextBox";
            this.SheetTextBox.Size = new System.Drawing.Size(596, 31);
            this.SheetTextBox.TabIndex = 3;
            this.SheetTextBox.TextChanged += new System.EventHandler(this.SheetTextBox_TextChanged);
            // 
            // RowKeyTextBox
            // 
            this.RowKeyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RowKeyTextBox.Location = new System.Drawing.Point(241, 78);
            this.RowKeyTextBox.Name = "RowKeyTextBox";
            this.RowKeyTextBox.Size = new System.Drawing.Size(596, 31);
            this.RowKeyTextBox.TabIndex = 4;
            this.RowKeyTextBox.TextChanged += new System.EventHandler(this.RowKeyTextBox_TextChanged);
            // 
            // ColKeyTextBox
            // 
            this.ColKeyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ColKeyTextBox.Location = new System.Drawing.Point(241, 142);
            this.ColKeyTextBox.Name = "ColKeyTextBox";
            this.ColKeyTextBox.Size = new System.Drawing.Size(596, 31);
            this.ColKeyTextBox.TabIndex = 5;
            this.ColKeyTextBox.TextChanged += new System.EventHandler(this.ColKeyTextBox_TextChanged);
            // 
            // ModifyValueTextBox
            // 
            this.ModifyValueTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ModifyValueTextBox.Location = new System.Drawing.Point(241, 211);
            this.ModifyValueTextBox.Name = "ModifyValueTextBox";
            this.ModifyValueTextBox.Size = new System.Drawing.Size(596, 31);
            this.ModifyValueTextBox.TabIndex = 6;
            this.ModifyValueTextBox.TextChanged += new System.EventHandler(this.ModifyValueTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sheet";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "RowKey";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "ColKey";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "ModifyValue";
            // 
            // ModifyButton
            // 
            this.ModifyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ModifyButton.Location = new System.Drawing.Point(241, 288);
            this.ModifyButton.Name = "ModifyButton";
            this.ModifyButton.Size = new System.Drawing.Size(596, 100);
            this.ModifyButton.TabIndex = 11;
            this.ModifyButton.Text = "Apply Modify";
            this.ModifyButton.UseVisualStyleBackColor = true;
            this.ModifyButton.Click += new System.EventHandler(this.ModifyButton_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.ModifyButton);
            this.panel2.Controls.Add(this.SheetTextBox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.RowKeyTextBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.ColKeyTextBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.ModifyValueTextBox);
            this.panel2.Location = new System.Drawing.Point(16, 466);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(911, 432);
            this.panel2.TabIndex = 12;
            this.panel2.Resize += new System.EventHandler(this.panel2_Resize);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.FileListLabel);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1552, 910);
            this.panel3.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Location = new System.Drawing.Point(1200, 754);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(340, 93);
            this.label5.TabIndex = 13;
            this.label5.Text = "注：                           1.需要将文件先checkout         2.需要将待修改的文件关闭      3.双击可以删除" +
    "文件";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1552, 910);
            this.Controls.Add(this.panel3);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BatchExeclOperate";
            ((System.ComponentModel.ISupportInitialize)(this.SourceFileGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.DataGridView SourceFileGridView;
		private System.Windows.Forms.Label FileListLabel;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox SheetTextBox;
		private System.Windows.Forms.TextBox RowKeyTextBox;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.TextBox ColKeyTextBox;
		private System.Windows.Forms.TextBox ModifyValueTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button ModifyButton;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label5;
	}
}

