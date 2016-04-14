namespace VFPInprt
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.bn_loadDatabase = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.checkLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_databasePath = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.cb_checkAll = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lb_outportColumn = new System.Windows.Forms.ListBox();
            this.bn_outportFile = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bn_writeBack = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lb_checkColumn = new System.Windows.Forms.ListBox();
            this.cb_unique = new System.Windows.Forms.CheckBox();
            this.cb_import = new System.Windows.Forms.CheckBox();
            this.cb_checkAllExport = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.说明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bn_loadDatabase
            // 
            this.bn_loadDatabase.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bn_loadDatabase.Location = new System.Drawing.Point(161, 35);
            this.bn_loadDatabase.Name = "bn_loadDatabase";
            this.bn_loadDatabase.Size = new System.Drawing.Size(90, 34);
            this.bn_loadDatabase.TabIndex = 0;
            this.bn_loadDatabase.Text = "载入数据库";
            this.bn_loadDatabase.UseVisualStyleBackColor = true;
            this.bn_loadDatabase.Click += new System.EventHandler(this.bn_loadDatabase_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 30);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(589, 331);
            this.splitContainer1.SplitterDistance = 284;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.splitContainer3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 331);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1、打开数据库文件";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(3, 17);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.checkLabel);
            this.splitContainer3.Panel1.Controls.Add(this.label1);
            this.splitContainer3.Panel1.Controls.Add(this.bn_loadDatabase);
            this.splitContainer3.Panel1.Controls.Add(this.tb_databasePath);
            this.splitContainer3.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.textBox3);
            this.splitContainer3.Panel2.Controls.Add(this.cb_checkAll);
            this.splitContainer3.Panel2.Controls.Add(this.textBox2);
            this.splitContainer3.Panel2.Controls.Add(this.lb_outportColumn);
            this.splitContainer3.Panel2.Controls.Add(this.bn_outportFile);
            this.splitContainer3.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer3.Size = new System.Drawing.Size(278, 311);
            this.splitContainer3.SplitterDistance = 76;
            this.splitContainer3.TabIndex = 5;
            // 
            // checkLabel
            // 
            this.checkLabel.AutoSize = true;
            this.checkLabel.Font = new System.Drawing.Font("宋体", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkLabel.Location = new System.Drawing.Point(7, 48);
            this.checkLabel.Name = "checkLabel";
            this.checkLabel.Size = new System.Drawing.Size(0, 10);
            this.checkLabel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "文件路径";
            // 
            // tb_databasePath
            // 
            this.tb_databasePath.Location = new System.Drawing.Point(66, 8);
            this.tb_databasePath.Name = "tb_databasePath";
            this.tb_databasePath.ReadOnly = true;
            this.tb_databasePath.Size = new System.Drawing.Size(185, 21);
            this.tb_databasePath.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Window;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(161, 108);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 60);
            this.textBox3.TabIndex = 7;
            this.textBox3.Text = "\r\n导出文件位置与\r\n\r\n数据库位置相同";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cb_checkAll
            // 
            this.cb_checkAll.AutoSize = true;
            this.cb_checkAll.Location = new System.Drawing.Point(161, 83);
            this.cb_checkAll.Name = "cb_checkAll";
            this.cb_checkAll.Size = new System.Drawing.Size(48, 16);
            this.cb_checkAll.TabIndex = 6;
            this.cb_checkAll.Text = "全选";
            this.cb_checkAll.UseVisualStyleBackColor = true;
            this.cb_checkAll.CheckedChanged += new System.EventHandler(this.cb_checkAll_CheckedChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Window;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(161, 9);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 60);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "\r\n从左侧列表选择\r\n\r\n需要导出的列";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_outportColumn
            // 
            this.lb_outportColumn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lb_outportColumn.FormattingEnabled = true;
            this.lb_outportColumn.ItemHeight = 12;
            this.lb_outportColumn.Location = new System.Drawing.Point(9, 9);
            this.lb_outportColumn.Name = "lb_outportColumn";
            this.lb_outportColumn.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lb_outportColumn.Size = new System.Drawing.Size(146, 220);
            this.lb_outportColumn.TabIndex = 0;
            // 
            // bn_outportFile
            // 
            this.bn_outportFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bn_outportFile.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bn_outportFile.Location = new System.Drawing.Point(161, 175);
            this.bn_outportFile.Name = "bn_outportFile";
            this.bn_outportFile.Size = new System.Drawing.Size(100, 46);
            this.bn_outportFile.TabIndex = 4;
            this.bn_outportFile.Text = "导出EXCEL";
            this.bn_outportFile.UseVisualStyleBackColor = true;
            this.bn_outportFile.Click += new System.EventHandler(this.bn_outportFile_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_checkAllExport);
            this.groupBox2.Controls.Add(this.cb_import);
            this.groupBox2.Controls.Add(this.cb_unique);
            this.groupBox2.Controls.Add(this.bn_writeBack);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.lb_checkColumn);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(301, 331);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2、写回数据库文件";
            // 
            // bn_writeBack
            // 
            this.bn_writeBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bn_writeBack.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bn_writeBack.Location = new System.Drawing.Point(180, 264);
            this.bn_writeBack.Name = "bn_writeBack";
            this.bn_writeBack.Size = new System.Drawing.Size(100, 46);
            this.bn_writeBack.TabIndex = 7;
            this.bn_writeBack.Text = "确认写回";
            this.bn_writeBack.UseVisualStyleBackColor = true;
            this.bn_writeBack.Click += new System.EventHandler(this.bn_writeBack_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(180, 85);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 60);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "\r\n从左侧列表选择\r\n\r\n需要写入的列\r\n";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_checkColumn
            // 
            this.lb_checkColumn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lb_checkColumn.FormattingEnabled = true;
            this.lb_checkColumn.ItemHeight = 12;
            this.lb_checkColumn.Location = new System.Drawing.Point(17, 20);
            this.lb_checkColumn.Name = "lb_checkColumn";
            this.lb_checkColumn.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lb_checkColumn.Size = new System.Drawing.Size(146, 304);
            this.lb_checkColumn.TabIndex = 7;
            // 
            // cb_unique
            // 
            this.cb_unique.AutoSize = true;
            this.cb_unique.Checked = true;
            this.cb_unique.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_unique.Location = new System.Drawing.Point(180, 244);
            this.cb_unique.Name = "cb_unique";
            this.cb_unique.Size = new System.Drawing.Size(96, 16);
            this.cb_unique.TabIndex = 8;
            this.cb_unique.Text = "唯一性约束？";
            this.cb_unique.UseVisualStyleBackColor = true;
            // 
            // cb_import
            // 
            this.cb_import.AutoSize = true;
            this.cb_import.Location = new System.Drawing.Point(180, 222);
            this.cb_import.Name = "cb_import";
            this.cb_import.Size = new System.Drawing.Size(78, 16);
            this.cb_import.TabIndex = 9;
            this.cb_import.Text = "导入空表?";
            this.cb_import.UseVisualStyleBackColor = true;
            // 
            // cb_checkAllExport
            // 
            this.cb_checkAllExport.AutoSize = true;
            this.cb_checkAllExport.Location = new System.Drawing.Point(180, 200);
            this.cb_checkAllExport.Name = "cb_checkAllExport";
            this.cb_checkAllExport.Size = new System.Drawing.Size(48, 16);
            this.cb_checkAllExport.TabIndex = 10;
            this.cb_checkAllExport.Text = "全选";
            this.cb_checkAllExport.UseVisualStyleBackColor = true;
            this.cb_checkAllExport.CheckedChanged += new System.EventHandler(this.cb_checkAllExport_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.帮助ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 5);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(589, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.说明ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 说明ToolStripMenuItem
            // 
            this.说明ToolStripMenuItem.Name = "说明ToolStripMenuItem";
            this.说明ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.说明ToolStripMenuItem.Text = "使用说明";
            this.说明ToolStripMenuItem.Click += new System.EventHandler(this.说明ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 361);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "报名信息处理程序";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bn_loadDatabase;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_databasePath;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListBox lb_outportColumn;
        private System.Windows.Forms.Button bn_outportFile;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cb_checkAll;
        private System.Windows.Forms.Button bn_writeBack;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox lb_checkColumn;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label checkLabel;
        private System.Windows.Forms.CheckBox cb_unique;
        private System.Windows.Forms.CheckBox cb_import;
        private System.Windows.Forms.CheckBox cb_checkAllExport;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 说明ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
    }
}

