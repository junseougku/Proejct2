namespace Project3
{
    partial class MemoForm
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "343434",
            "ㅂㅂㅂ"}, -1);
            this.labelControl1 = new System.Windows.Forms.Label();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.MemoTab = new System.Windows.Forms.TabControl();
            this.todayMemoPage = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.memoTitleBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fontSettingButton = new System.Windows.Forms.Button();
            this.memoBox = new System.Windows.Forms.TextBox();
            this.oldMemoPage = new System.Windows.Forms.TabPage();
            this.memoModifyButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.closeButton = new System.Windows.Forms.Button();
            this.MemoTab.SuspendLayout();
            this.todayMemoPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.oldMemoPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.AutoSize = true;
            this.labelControl1.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelControl1.Location = new System.Drawing.Point(20, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(68, 27);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "메모";
            // 
            // MemoTab
            // 
            this.MemoTab.Controls.Add(this.todayMemoPage);
            this.MemoTab.Controls.Add(this.oldMemoPage);
            this.MemoTab.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MemoTab.Location = new System.Drawing.Point(12, 39);
            this.MemoTab.Name = "MemoTab";
            this.MemoTab.SelectedIndex = 0;
            this.MemoTab.Size = new System.Drawing.Size(941, 498);
            this.MemoTab.TabIndex = 2;
            // 
            // todayMemoPage
            // 
            this.todayMemoPage.Controls.Add(this.label10);
            this.todayMemoPage.Controls.Add(this.dateLabel);
            this.todayMemoPage.Controls.Add(this.label1);
            this.todayMemoPage.Controls.Add(this.memoTitleBox);
            this.todayMemoPage.Controls.Add(this.saveButton);
            this.todayMemoPage.Controls.Add(this.groupBox1);
            this.todayMemoPage.Controls.Add(this.memoBox);
            this.todayMemoPage.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.todayMemoPage.Location = new System.Drawing.Point(4, 31);
            this.todayMemoPage.Name = "todayMemoPage";
            this.todayMemoPage.Padding = new System.Windows.Forms.Padding(3);
            this.todayMemoPage.Size = new System.Drawing.Size(933, 463);
            this.todayMemoPage.TabIndex = 0;
            this.todayMemoPage.Text = "오늘메모";
            this.todayMemoPage.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(8, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 21);
            this.label10.TabIndex = 28;
            this.label10.Text = "오늘날짜 : ";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateLabel.Location = new System.Drawing.Point(120, 5);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(52, 21);
            this.dateLabel.TabIndex = 27;
            this.dateLabel.Text = "날짜";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(6, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 21);
            this.label1.TabIndex = 26;
            this.label1.Text = "메모 제목 : ";
            // 
            // memoTitleBox
            // 
            this.memoTitleBox.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.memoTitleBox.Location = new System.Drawing.Point(132, 138);
            this.memoTitleBox.MaxLength = 1024;
            this.memoTitleBox.Name = "memoTitleBox";
            this.memoTitleBox.Size = new System.Drawing.Size(795, 32);
            this.memoTitleBox.TabIndex = 25;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.saveButton.Location = new System.Drawing.Point(795, 392);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(132, 65);
            this.saveButton.TabIndex = 24;
            this.saveButton.Text = "저  장";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fontSettingButton);
            this.groupBox1.Location = new System.Drawing.Point(6, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(921, 81);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // fontSettingButton
            // 
            this.fontSettingButton.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.fontSettingButton.Location = new System.Drawing.Point(6, 20);
            this.fontSettingButton.Name = "fontSettingButton";
            this.fontSettingButton.Size = new System.Drawing.Size(70, 55);
            this.fontSettingButton.TabIndex = 0;
            this.fontSettingButton.Text = "글자설정";
            this.fontSettingButton.UseVisualStyleBackColor = true;
            // 
            // memoBox
            // 
            this.memoBox.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.memoBox.Location = new System.Drawing.Point(6, 176);
            this.memoBox.Multiline = true;
            this.memoBox.Name = "memoBox";
            this.memoBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.memoBox.Size = new System.Drawing.Size(921, 210);
            this.memoBox.TabIndex = 21;
            // 
            // oldMemoPage
            // 
            this.oldMemoPage.Controls.Add(this.memoModifyButton);
            this.oldMemoPage.Controls.Add(this.listView1);
            this.oldMemoPage.Location = new System.Drawing.Point(4, 31);
            this.oldMemoPage.Name = "oldMemoPage";
            this.oldMemoPage.Padding = new System.Windows.Forms.Padding(3);
            this.oldMemoPage.Size = new System.Drawing.Size(933, 463);
            this.oldMemoPage.TabIndex = 1;
            this.oldMemoPage.Text = "지난메모";
            this.oldMemoPage.UseVisualStyleBackColor = true;
            // 
            // memoModifyButton
            // 
            this.memoModifyButton.Enabled = false;
            this.memoModifyButton.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.memoModifyButton.Location = new System.Drawing.Point(795, 392);
            this.memoModifyButton.Name = "memoModifyButton";
            this.memoModifyButton.Size = new System.Drawing.Size(132, 65);
            this.memoModifyButton.TabIndex = 26;
            this.memoModifyButton.Text = "선택한 메모 상세보기";
            this.memoModifyButton.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.date});
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(9, 6);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(918, 380);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // date
            // 
            this.date.Text = "날짜";
            this.date.Width = 80;
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.closeButton.Location = new System.Drawing.Point(821, 543);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(132, 65);
            this.closeButton.TabIndex = 23;
            this.closeButton.Text = "창 닫기";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // MemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 620);
            this.Controls.Add(this.MemoTab);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.closeButton);
            this.Name = "MemoForm";
            this.Text = "메모";
            this.Load += new System.EventHandler(this.MemoForm_Load);
            this.MemoTab.ResumeLayout(false);
            this.todayMemoPage.ResumeLayout(false);
            this.todayMemoPage.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.oldMemoPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelControl1;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.TabControl MemoTab;
        private System.Windows.Forms.TabPage todayMemoPage;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox memoTitleBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button fontSettingButton;
        private System.Windows.Forms.TextBox memoBox;
        private System.Windows.Forms.TabPage oldMemoPage;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.Button memoModifyButton;
    }
}