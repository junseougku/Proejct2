namespace Project3.ScheduleManagement
{
    partial class ScheduleManagementForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.todayDateLabel = new System.Windows.Forms.Label();
            this.yearTxt = new System.Windows.Forms.NumericUpDown();
            this.yearDownButton = new System.Windows.Forms.Button();
            this.yearUpButton = new System.Windows.Forms.Button();
            this.monthCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dayCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.scheduleMemoTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.alramCheckBox = new WindowsFormsApplication2.CustomCheckBox(this.components);
            this.closeButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.scheduleMemoList = new System.Windows.Forms.ListView();
            this.dateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.yearTxt)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "일정관리";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(14, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 21);
            this.label10.TabIndex = 18;
            this.label10.Text = "오늘날짜 : ";
            // 
            // todayDateLabel
            // 
            this.todayDateLabel.AutoSize = true;
            this.todayDateLabel.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.todayDateLabel.Location = new System.Drawing.Point(126, 57);
            this.todayDateLabel.Name = "todayDateLabel";
            this.todayDateLabel.Size = new System.Drawing.Size(52, 21);
            this.todayDateLabel.TabIndex = 17;
            this.todayDateLabel.Text = "날짜";
            // 
            // yearTxt
            // 
            this.yearTxt.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.yearTxt.Location = new System.Drawing.Point(65, 94);
            this.yearTxt.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.yearTxt.Name = "yearTxt";
            this.yearTxt.Size = new System.Drawing.Size(120, 32);
            this.yearTxt.TabIndex = 19;
            this.yearTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.yearTxt.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            // 
            // yearDownButton
            // 
            this.yearDownButton.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.yearDownButton.Location = new System.Drawing.Point(18, 94);
            this.yearDownButton.Name = "yearDownButton";
            this.yearDownButton.Size = new System.Drawing.Size(41, 32);
            this.yearDownButton.TabIndex = 21;
            this.yearDownButton.Text = "<";
            this.yearDownButton.UseVisualStyleBackColor = true;
            this.yearDownButton.Click += new System.EventHandler(this.yearDownButton_Click);
            // 
            // yearUpButton
            // 
            this.yearUpButton.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.yearUpButton.Location = new System.Drawing.Point(191, 94);
            this.yearUpButton.Name = "yearUpButton";
            this.yearUpButton.Size = new System.Drawing.Size(41, 32);
            this.yearUpButton.TabIndex = 22;
            this.yearUpButton.Text = ">";
            this.yearUpButton.UseVisualStyleBackColor = true;
            this.yearUpButton.Click += new System.EventHandler(this.yearUpButton_Click);
            // 
            // monthCombo
            // 
            this.monthCombo.DropDownWidth = 90;
            this.monthCombo.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.monthCombo.FormattingEnabled = true;
            this.monthCombo.ItemHeight = 21;
            this.monthCombo.Items.AddRange(new object[] {
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
            "12"});
            this.monthCombo.Location = new System.Drawing.Point(18, 143);
            this.monthCombo.Name = "monthCombo";
            this.monthCombo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.monthCombo.Size = new System.Drawing.Size(61, 29);
            this.monthCombo.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(85, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 21);
            this.label1.TabIndex = 24;
            this.label1.Text = "월";
            // 
            // dayCombo
            // 
            this.dayCombo.DropDownWidth = 90;
            this.dayCombo.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dayCombo.FormattingEnabled = true;
            this.dayCombo.Items.AddRange(new object[] {
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
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.dayCombo.Location = new System.Drawing.Point(18, 178);
            this.dayCombo.Name = "dayCombo";
            this.dayCombo.Size = new System.Drawing.Size(61, 29);
            this.dayCombo.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(85, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 21);
            this.label3.TabIndex = 26;
            this.label3.Text = "일";
            // 
            // scheduleMemoTxt
            // 
            this.scheduleMemoTxt.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.scheduleMemoTxt.Location = new System.Drawing.Point(18, 274);
            this.scheduleMemoTxt.Multiline = true;
            this.scheduleMemoTxt.Name = "scheduleMemoTxt";
            this.scheduleMemoTxt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.scheduleMemoTxt.Size = new System.Drawing.Size(214, 164);
            this.scheduleMemoTxt.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(14, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 21);
            this.label4.TabIndex = 28;
            this.label4.Text = "일정메모";
            // 
            // alramCheckBox
            // 
            this.alramCheckBox.Check = false;
            this.alramCheckBox.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.alramCheckBox.Location = new System.Drawing.Point(130, 230);
            this.alramCheckBox.Name = "alramCheckBox";
            this.alramCheckBox.Size = new System.Drawing.Size(140, 38);
            this.alramCheckBox.TabIndex = 29;
            this.alramCheckBox.Text = "알람설정";
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.closeButton.Location = new System.Drawing.Point(482, 373);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(132, 65);
            this.closeButton.TabIndex = 30;
            this.closeButton.Text = "창 닫기";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.saveButton.Location = new System.Drawing.Point(344, 373);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(132, 65);
            this.saveButton.TabIndex = 31;
            this.saveButton.Text = "저  장";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(272, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 21);
            this.label5.TabIndex = 32;
            this.label5.Text = "일정기록";
            // 
            // scheduleMemoList
            // 
            this.scheduleMemoList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.dateColumn});
            this.scheduleMemoList.HideSelection = false;
            this.scheduleMemoList.Location = new System.Drawing.Point(276, 81);
            this.scheduleMemoList.Name = "scheduleMemoList";
            this.scheduleMemoList.Size = new System.Drawing.Size(338, 286);
            this.scheduleMemoList.TabIndex = 33;
            this.scheduleMemoList.UseCompatibleStateImageBehavior = false;
            // 
            // dateColumn
            // 
            this.dateColumn.Text = "날짜";
            // 
            // ScheduleManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 450);
            this.Controls.Add(this.scheduleMemoList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.alramCheckBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.scheduleMemoTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dayCombo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCombo);
            this.Controls.Add(this.yearUpButton);
            this.Controls.Add(this.yearDownButton);
            this.Controls.Add(this.yearTxt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.todayDateLabel);
            this.Controls.Add(this.label2);
            this.Name = "ScheduleManagementForm";
            this.Text = "일정관리 창";
            this.Load += new System.EventHandler(this.ScheduleManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yearTxt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label todayDateLabel;
        private System.Windows.Forms.NumericUpDown yearTxt;
        private System.Windows.Forms.Button yearDownButton;
        private System.Windows.Forms.Button yearUpButton;
        private System.Windows.Forms.ComboBox monthCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox dayCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox scheduleMemoTxt;
        private System.Windows.Forms.Label label4;
        private WindowsFormsApplication2.CustomCheckBox alramCheckBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView scheduleMemoList;
        private System.Windows.Forms.ColumnHeader dateColumn;
    }
}