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
            this.memoBox = new System.Windows.Forms.TextBox();
            this.labelControl1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.memoListButton = new System.Windows.Forms.Button();
            this.fontSettingButton = new System.Windows.Forms.Button();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.closeButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.memoTitleBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // memoBox
            // 
            this.memoBox.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.memoBox.Location = new System.Drawing.Point(12, 222);
            this.memoBox.Multiline = true;
            this.memoBox.Name = "memoBox";
            this.memoBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.memoBox.Size = new System.Drawing.Size(941, 315);
            this.memoBox.TabIndex = 0;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.memoListButton);
            this.groupBox1.Controls.Add(this.fontSettingButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(941, 81);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // memoListButton
            // 
            this.memoListButton.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.memoListButton.Location = new System.Drawing.Point(442, 20);
            this.memoListButton.Name = "memoListButton";
            this.memoListButton.Size = new System.Drawing.Size(70, 55);
            this.memoListButton.TabIndex = 1;
            this.memoListButton.Text = "지난메모";
            this.memoListButton.UseVisualStyleBackColor = true;
            this.memoListButton.Click += new System.EventHandler(this.memoListButton_Click);
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
            this.fontSettingButton.Click += new System.EventHandler(this.fontSettingButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.closeButton.Location = new System.Drawing.Point(821, 543);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(132, 65);
            this.closeButton.TabIndex = 15;
            this.closeButton.Text = "창 닫기";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.saveButton.Location = new System.Drawing.Point(683, 543);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(132, 65);
            this.saveButton.TabIndex = 16;
            this.saveButton.Text = "저  장";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // memoTitleBox
            // 
            this.memoTitleBox.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.memoTitleBox.Location = new System.Drawing.Point(138, 184);
            this.memoTitleBox.MaxLength = 1024;
            this.memoTitleBox.Name = "memoTitleBox";
            this.memoTitleBox.Size = new System.Drawing.Size(815, 32);
            this.memoTitleBox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "메모 제목 : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(14, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 21);
            this.label10.TabIndex = 20;
            this.label10.Text = "오늘날짜 : ";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateLabel.Location = new System.Drawing.Point(126, 51);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(52, 21);
            this.dateLabel.TabIndex = 19;
            this.dateLabel.Text = "날짜";
            // 
            // MemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 620);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.memoTitleBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.memoBox);
            this.Name = "MemoForm";
            this.Text = "메모";
            this.Load += new System.EventHandler(this.MemoForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox memoBox;
        private System.Windows.Forms.Label labelControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button fontSettingButton;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox memoTitleBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button memoListButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label dateLabel;
    }
}