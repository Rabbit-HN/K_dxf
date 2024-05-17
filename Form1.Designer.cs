namespace Alter_Flat_Parameter
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_en_NO = new System.Windows.Forms.TextBox();
            this.cmd_path = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.txt_Kvalue = new System.Windows.Forms.TextBox();
            this.comb_thickness = new System.Windows.Forms.ComboBox();
            this.txt_outpath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_prog = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.col_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_draw_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_before_alterK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_flatsize_old = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_after_alterK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_flatsize_new = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_atler_bool = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmd_confirm = new System.Windows.Forms.Button();
            this.cmd_cancel = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmd_clear = new System.Windows.Forms.Button();
            this.cmd_delete = new System.Windows.Forms.Button();
            this.cmd_selection = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_en_NO);
            this.groupBox1.Controls.Add(this.cmd_path);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.txt_Kvalue);
            this.groupBox1.Controls.Add(this.comb_thickness);
            this.groupBox1.Controls.Add(this.txt_outpath);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label_prog);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1057, 196);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "输入设置";
            // 
            // txt_en_NO
            // 
            this.txt_en_NO.Location = new System.Drawing.Point(220, 38);
            this.txt_en_NO.Name = "txt_en_NO";
            this.txt_en_NO.Size = new System.Drawing.Size(150, 29);
            this.txt_en_NO.TabIndex = 9;
            this.txt_en_NO.TextChanged += new System.EventHandler(this.txt_en_NO_TextChanged);
            // 
            // cmd_path
            // 
            this.cmd_path.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmd_path.Location = new System.Drawing.Point(928, 71);
            this.cmd_path.Name = "cmd_path";
            this.cmd_path.Size = new System.Drawing.Size(115, 29);
            this.cmd_path.TabIndex = 8;
            this.cmd_path.Text = "路径选择";
            this.cmd_path.UseVisualStyleBackColor = true;
            this.cmd_path.Click += new System.EventHandler(this.cmd_path_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(220, 143);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(702, 29);
            this.progressBar1.TabIndex = 6;
            // 
            // txt_Kvalue
            // 
            this.txt_Kvalue.Location = new System.Drawing.Point(675, 108);
            this.txt_Kvalue.Name = "txt_Kvalue";
            this.txt_Kvalue.Size = new System.Drawing.Size(150, 29);
            this.txt_Kvalue.TabIndex = 5;
            this.txt_Kvalue.TextChanged += new System.EventHandler(this.txt_Kvalue_TextChanged);
            // 
            // comb_thickness
            // 
            this.comb_thickness.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comb_thickness.FormattingEnabled = true;
            this.comb_thickness.Items.AddRange(new object[] {
            "1.5",
            "2",
            "2.5",
            "3"});
            this.comb_thickness.Location = new System.Drawing.Point(220, 108);
            this.comb_thickness.Name = "comb_thickness";
            this.comb_thickness.Size = new System.Drawing.Size(68, 29);
            this.comb_thickness.TabIndex = 4;
            this.comb_thickness.SelectedIndexChanged += new System.EventHandler(this.comb_thickness_SelectedIndexChanged);
            // 
            // txt_outpath
            // 
            this.txt_outpath.Location = new System.Drawing.Point(220, 71);
            this.txt_outpath.Name = "txt_outpath";
            this.txt_outpath.Size = new System.Drawing.Size(700, 29);
            this.txt_outpath.TabIndex = 3;
            this.txt_outpath.TextChanged += new System.EventHandler(this.txt_outpath_TextChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(296, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "mm";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(455, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "钣金件展开K系数修改值";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_prog
            // 
            this.label_prog.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_prog.Location = new System.Drawing.Point(927, 143);
            this.label_prog.Name = "label_prog";
            this.label_prog.Size = new System.Drawing.Size(82, 29);
            this.label_prog.TabIndex = 2;
            this.label_prog.Text = "0%";
            this.label_prog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(27, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "完成进度";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(24, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "钣金件厚度选择";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(376, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(241, 29);
            this.label7.TabIndex = 2;
            this.label7.Text = "示例：2WK.024.XXXXX";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(24, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 29);
            this.label6.TabIndex = 2;
            this.label6.Text = "外壳图号";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(24, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "DXF展开图导出路径";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_num,
            this.col_draw_num,
            this.col_material,
            this.col_before_alterK,
            this.col_flatsize_old,
            this.col_after_alterK,
            this.col_flatsize_new,
            this.col_atler_bool});
            this.dataGridView1.Location = new System.Drawing.Point(404, 186);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1008, 356);
            this.dataGridView1.TabIndex = 4;
            // 
            // col_num
            // 
            this.col_num.Frozen = true;
            this.col_num.HeaderText = "序号";
            this.col_num.Name = "col_num";
            this.col_num.ReadOnly = true;
            this.col_num.Width = 60;
            // 
            // col_draw_num
            // 
            this.col_draw_num.HeaderText = "钣金件图号";
            this.col_draw_num.Name = "col_draw_num";
            this.col_draw_num.ReadOnly = true;
            this.col_draw_num.Width = 160;
            // 
            // col_material
            // 
            this.col_material.HeaderText = "钣金件材料";
            this.col_material.Name = "col_material";
            this.col_material.ReadOnly = true;
            // 
            // col_before_alterK
            // 
            this.col_before_alterK.HeaderText = "修改前K系数值";
            this.col_before_alterK.Name = "col_before_alterK";
            this.col_before_alterK.ReadOnly = true;
            this.col_before_alterK.Width = 120;
            // 
            // col_flatsize_old
            // 
            this.col_flatsize_old.HeaderText = "修改K系数前展开尺寸";
            this.col_flatsize_old.Name = "col_flatsize_old";
            this.col_flatsize_old.ReadOnly = true;
            this.col_flatsize_old.Width = 150;
            // 
            // col_after_alterK
            // 
            this.col_after_alterK.HeaderText = "修改后K系数值";
            this.col_after_alterK.Name = "col_after_alterK";
            this.col_after_alterK.ReadOnly = true;
            this.col_after_alterK.Width = 120;
            // 
            // col_flatsize_new
            // 
            this.col_flatsize_new.HeaderText = "修改K系数后展开尺寸";
            this.col_flatsize_new.Name = "col_flatsize_new";
            this.col_flatsize_new.ReadOnly = true;
            this.col_flatsize_new.Width = 150;
            // 
            // col_atler_bool
            // 
            this.col_atler_bool.HeaderText = "修改状态";
            this.col_atler_bool.Name = "col_atler_bool";
            this.col_atler_bool.ReadOnly = true;
            // 
            // cmd_confirm
            // 
            this.cmd_confirm.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmd_confirm.Location = new System.Drawing.Point(477, 587);
            this.cmd_confirm.Name = "cmd_confirm";
            this.cmd_confirm.Size = new System.Drawing.Size(146, 35);
            this.cmd_confirm.TabIndex = 0;
            this.cmd_confirm.Text = "确认";
            this.cmd_confirm.UseVisualStyleBackColor = true;
            this.cmd_confirm.Click += new System.EventHandler(this.cmd_confirm_Click);
            // 
            // cmd_cancel
            // 
            this.cmd_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmd_cancel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmd_cancel.Location = new System.Drawing.Point(731, 587);
            this.cmd_cancel.Name = "cmd_cancel";
            this.cmd_cancel.Size = new System.Drawing.Size(146, 35);
            this.cmd_cancel.TabIndex = 1;
            this.cmd_cancel.Text = "取消";
            this.cmd_cancel.UseVisualStyleBackColor = true;
            this.cmd_cancel.Click += new System.EventHandler(this.cmd_cancel_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmd_clear);
            this.groupBox2.Controls.Add(this.cmd_delete);
            this.groupBox2.Controls.Add(this.cmd_selection);
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(24, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 363);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "选择图号清单";
            // 
            // cmd_clear
            // 
            this.cmd_clear.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmd_clear.Location = new System.Drawing.Point(230, 168);
            this.cmd_clear.Name = "cmd_clear";
            this.cmd_clear.Size = new System.Drawing.Size(117, 35);
            this.cmd_clear.TabIndex = 8;
            this.cmd_clear.Text = "清空选择";
            this.cmd_clear.UseVisualStyleBackColor = true;
            this.cmd_clear.Click += new System.EventHandler(this.cmd_clear_Click_1);
            // 
            // cmd_delete
            // 
            this.cmd_delete.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmd_delete.Location = new System.Drawing.Point(230, 101);
            this.cmd_delete.Name = "cmd_delete";
            this.cmd_delete.Size = new System.Drawing.Size(115, 35);
            this.cmd_delete.TabIndex = 7;
            this.cmd_delete.Text = "钣金件删除";
            this.cmd_delete.UseVisualStyleBackColor = true;
            this.cmd_delete.Click += new System.EventHandler(this.cmd_delete_Click);
            // 
            // cmd_selection
            // 
            this.cmd_selection.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmd_selection.Location = new System.Drawing.Point(232, 38);
            this.cmd_selection.Name = "cmd_selection";
            this.cmd_selection.Size = new System.Drawing.Size(115, 35);
            this.cmd_selection.TabIndex = 7;
            this.cmd_selection.Text = "钣金件选择";
            this.cmd_selection.UseVisualStyleBackColor = true;
            this.cmd_selection.Click += new System.EventHandler(this.cmd_selection_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(6, 37);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(218, 298);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AcceptButton = this.cmd_confirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmd_cancel;
            this.ClientSize = new System.Drawing.Size(1484, 643);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmd_cancel);
            this.Controls.Add(this.cmd_confirm);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "钣金件导DXF";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comb_thickness;
        private System.Windows.Forms.TextBox txt_outpath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox txt_Kvalue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button cmd_confirm;
        private System.Windows.Forms.Button cmd_cancel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button cmd_clear;
        private System.Windows.Forms.Button cmd_delete;
        private System.Windows.Forms.Button cmd_selection;
        private System.Windows.Forms.Label label_prog;
        private System.Windows.Forms.Button cmd_path;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox txt_en_NO;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_draw_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_material;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_before_alterK;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_flatsize_old;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_after_alterK;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_flatsize_new;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_atler_bool;
    }
}

