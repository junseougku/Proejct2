namespace Project3
{
    partial class LaborerManagementForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelControl1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sumcostLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.gridModifyButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.snakcostTxt = new System.Windows.Forms.TextBox();
            this.laborcostTxt = new System.Windows.Forms.TextBox();
            this.hireTotalCountLable = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.womanHireCountCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.manHireCountCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.laborGrid = new System.Windows.Forms.DataGridView();
            this.dateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manHireCountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.womanHireCountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.laborerCountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.laborcostColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snakcostColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumcostColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AllRemoveStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveButtonTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.laborGrid)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.AutoSize = true;
            this.labelControl1.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelControl1.Location = new System.Drawing.Point(13, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(124, 27);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "인력관리";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sumcostLabel);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.gridModifyButton);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.resetButton);
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.snakcostTxt);
            this.groupBox1.Controls.Add(this.laborcostTxt);
            this.groupBox1.Controls.Add(this.hireTotalCountLable);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.womanHireCountCombo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.manHireCountCombo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateLabel);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1058, 245);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // sumcostLabel
            // 
            this.sumcostLabel.AutoSize = true;
            this.sumcostLabel.Location = new System.Drawing.Point(232, 187);
            this.sumcostLabel.Name = "sumcostLabel";
            this.sumcostLabel.Size = new System.Drawing.Size(42, 21);
            this.sumcostLabel.TabIndex = 19;
            this.sumcostLabel.Text = "0원";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(147, 187);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 21);
            this.label11.TabIndex = 18;
            this.label11.Text = "총액 : ";
            // 
            // gridModifyButton
            // 
            this.gridModifyButton.Location = new System.Drawing.Point(638, 174);
            this.gridModifyButton.Name = "gridModifyButton";
            this.gridModifyButton.Size = new System.Drawing.Size(132, 65);
            this.gridModifyButton.TabIndex = 17;
            this.gridModifyButton.Text = "표 편집";
            this.gridModifyButton.UseVisualStyleBackColor = true;
            this.gridModifyButton.Click += new System.EventHandler(this.gridModifyButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 21);
            this.label10.TabIndex = 16;
            this.label10.Text = "오늘날짜 : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(628, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "명";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(914, 174);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(132, 65);
            this.resetButton.TabIndex = 14;
            this.resetButton.Text = "다시쓰기";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(776, 174);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(132, 65);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "저  장";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            this.saveButton.MouseHover += new System.EventHandler(this.saveButton_MouseHover);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(434, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 21);
            this.label9.TabIndex = 13;
            this.label9.Text = "원";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(434, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 21);
            this.label8.TabIndex = 12;
            this.label8.Text = "원";
            // 
            // snakcostTxt
            // 
            this.snakcostTxt.Location = new System.Drawing.Point(236, 146);
            this.snakcostTxt.MaxLength = 8;
            this.snakcostTxt.Name = "snakcostTxt";
            this.snakcostTxt.Size = new System.Drawing.Size(192, 32);
            this.snakcostTxt.TabIndex = 11;
            this.snakcostTxt.Text = "0";
            this.snakcostTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.snakcostTxt.TextChanged += new System.EventHandler(this.snakcostTxt_TextChanged);
            // 
            // laborcostTxt
            // 
            this.laborcostTxt.Location = new System.Drawing.Point(236, 108);
            this.laborcostTxt.MaxLength = 8;
            this.laborcostTxt.Name = "laborcostTxt";
            this.laborcostTxt.Size = new System.Drawing.Size(192, 32);
            this.laborcostTxt.TabIndex = 10;
            this.laborcostTxt.Text = "0";
            this.laborcostTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.laborcostTxt.TextChanged += new System.EventHandler(this.laborcostTxt_TextChanged);
            // 
            // hireTotalCountLable
            // 
            this.hireTotalCountLable.AutoSize = true;
            this.hireTotalCountLable.Location = new System.Drawing.Point(601, 70);
            this.hireTotalCountLable.Name = "hireTotalCountLable";
            this.hireTotalCountLable.Size = new System.Drawing.Size(21, 21);
            this.hireTotalCountLable.TabIndex = 9;
            this.hireTotalCountLable.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(553, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "총합";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(376, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "여자";
            // 
            // womanHireCountCombo
            // 
            this.womanHireCountCombo.DropDownWidth = 76;
            this.womanHireCountCombo.FormattingEnabled = true;
            this.womanHireCountCombo.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.womanHireCountCombo.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14"});
            this.womanHireCountCombo.Location = new System.Drawing.Point(434, 67);
            this.womanHireCountCombo.MaxLength = 2;
            this.womanHireCountCombo.Name = "womanHireCountCombo";
            this.womanHireCountCombo.Size = new System.Drawing.Size(76, 29);
            this.womanHireCountCombo.TabIndex = 6;
            this.womanHireCountCombo.Text = "0";
            this.womanHireCountCombo.TextChanged += new System.EventHandler(this.womanHireCountCombo_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "남자";
            // 
            // manHireCountCombo
            // 
            this.manHireCountCombo.FormattingEnabled = true;
            this.manHireCountCombo.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14"});
            this.manHireCountCombo.Location = new System.Drawing.Point(290, 67);
            this.manHireCountCombo.MaxLength = 2;
            this.manHireCountCombo.Name = "manHireCountCombo";
            this.manHireCountCombo.Size = new System.Drawing.Size(76, 29);
            this.manHireCountCombo.TabIndex = 4;
            this.manHireCountCombo.Text = "0";
            this.manHireCountCombo.TextChanged += new System.EventHandler(this.manHireCountCombo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "오늘 지출한 간식비 : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "오늘 지출한 인건비 : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "오늘 고용한 사람 수 : ";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(119, 28);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(52, 21);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "날짜";
            // 
            // laborGrid
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.laborGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.laborGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.laborGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateColumn,
            this.manHireCountColumn,
            this.womanHireCountColumn,
            this.laborerCountColumn,
            this.laborcostColumn,
            this.snakcostColumn,
            this.sumcostColumn});
            this.laborGrid.ContextMenuStrip = this.menuStrip;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.laborGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.laborGrid.Location = new System.Drawing.Point(12, 294);
            this.laborGrid.Name = "laborGrid";
            this.laborGrid.RowTemplate.Height = 23;
            this.laborGrid.Size = new System.Drawing.Size(1058, 304);
            this.laborGrid.TabIndex = 2;
            this.laborGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.laborGrid_CellClick);
            // 
            // dateColumn
            // 
            this.dateColumn.HeaderText = "날짜";
            this.dateColumn.MaxInputLength = 128;
            this.dateColumn.MinimumWidth = 20;
            this.dateColumn.Name = "dateColumn";
            this.dateColumn.ReadOnly = true;
            this.dateColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dateColumn.Width = 110;
            // 
            // manHireCountColumn
            // 
            this.manHireCountColumn.HeaderText = "남자고용수";
            this.manHireCountColumn.MaxInputLength = 2;
            this.manHireCountColumn.Name = "manHireCountColumn";
            this.manHireCountColumn.ReadOnly = true;
            this.manHireCountColumn.Width = 145;
            // 
            // womanHireCountColumn
            // 
            this.womanHireCountColumn.HeaderText = "여자고용수";
            this.womanHireCountColumn.MaxInputLength = 2;
            this.womanHireCountColumn.Name = "womanHireCountColumn";
            this.womanHireCountColumn.ReadOnly = true;
            this.womanHireCountColumn.Width = 145;
            // 
            // laborerCountColumn
            // 
            this.laborerCountColumn.HeaderText = "고용한사람수";
            this.laborerCountColumn.MaxInputLength = 2;
            this.laborerCountColumn.MinimumWidth = 20;
            this.laborerCountColumn.Name = "laborerCountColumn";
            this.laborerCountColumn.ReadOnly = true;
            this.laborerCountColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.laborerCountColumn.Width = 150;
            // 
            // laborcostColumn
            // 
            this.laborcostColumn.HeaderText = "인건비";
            this.laborcostColumn.MaxInputLength = 32;
            this.laborcostColumn.MinimumWidth = 20;
            this.laborcostColumn.Name = "laborcostColumn";
            this.laborcostColumn.ReadOnly = true;
            this.laborcostColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.laborcostColumn.Width = 170;
            // 
            // snakcostColumn
            // 
            this.snakcostColumn.HeaderText = "간식비";
            this.snakcostColumn.MaxInputLength = 32;
            this.snakcostColumn.MinimumWidth = 20;
            this.snakcostColumn.Name = "snakcostColumn";
            this.snakcostColumn.ReadOnly = true;
            this.snakcostColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.snakcostColumn.Width = 170;
            // 
            // sumcostColumn
            // 
            this.sumcostColumn.HeaderText = "총액";
            this.sumcostColumn.MaxInputLength = 32;
            this.sumcostColumn.MinimumWidth = 20;
            this.sumcostColumn.Name = "sumcostColumn";
            this.sumcostColumn.ReadOnly = true;
            this.sumcostColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.sumcostColumn.Width = 140;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AllRemoveStripItem});
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(159, 26);
            // 
            // AllRemoveStripItem
            // 
            this.AllRemoveStripItem.Name = "AllRemoveStripItem";
            this.AllRemoveStripItem.Size = new System.Drawing.Size(158, 22);
            this.AllRemoveStripItem.Text = "이 줄 전체 삭제";
            // 
            // saveButtonTooltip
            // 
            this.saveButtonTooltip.ToolTipTitle = "asd";
            // 
            // LaborerManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 610);
            this.Controls.Add(this.laborGrid);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelControl1);
            this.Name = "LaborerManagementForm";
            this.Text = "인력관리 창";
            this.Load += new System.EventHandler(this.LaborerManagementForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.laborGrid)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label hireTotalCountLable;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox womanHireCountCombo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox manHireCountCombo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox snakcostTxt;
        private System.Windows.Forms.TextBox laborcostTxt;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridView laborGrid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolTip saveButtonTooltip;
        private System.Windows.Forms.ContextMenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem AllRemoveStripItem;
        private System.Windows.Forms.Button gridModifyButton;
        private System.Windows.Forms.Label sumcostLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manHireCountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn womanHireCountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn laborerCountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn laborcostColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snakcostColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumcostColumn;
    }
}