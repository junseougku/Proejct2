namespace Project3.SellManagement
{
    partial class SellManagementForm
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
            this.labelControl1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SellItemAddButton = new System.Windows.Forms.Button();
            this.sellItemCombo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.expenseContentTxt = new System.Windows.Forms.TextBox();
            this.sellItemCountTxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.sellItemRemove = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.AutoSize = true;
            this.labelControl1.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelControl1.Location = new System.Drawing.Point(12, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(124, 27);
            this.labelControl1.TabIndex = 21;
            this.labelControl1.Text = "판매관리";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sellItemRemove);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.SellItemAddButton);
            this.groupBox1.Controls.Add(this.sellItemCombo);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.resetButton);
            this.groupBox1.Controls.Add(this.expenseContentTxt);
            this.groupBox1.Controls.Add(this.sellItemCountTxt);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.dateLabel);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(17, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1058, 315);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "판매개수 : ";
            // 
            // SellItemAddButton
            // 
            this.SellItemAddButton.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SellItemAddButton.Location = new System.Drawing.Point(353, 48);
            this.SellItemAddButton.Name = "SellItemAddButton";
            this.SellItemAddButton.Size = new System.Drawing.Size(132, 65);
            this.SellItemAddButton.TabIndex = 18;
            this.SellItemAddButton.Text = "판매항목  추가등록";
            this.SellItemAddButton.UseVisualStyleBackColor = true;
            this.SellItemAddButton.Click += new System.EventHandler(this.SellItemAddButton_Click);
            // 
            // sellItemCombo
            // 
            this.sellItemCombo.FormattingEnabled = true;
            this.sellItemCombo.Location = new System.Drawing.Point(128, 67);
            this.sellItemCombo.Name = "sellItemCombo";
            this.sellItemCombo.Size = new System.Drawing.Size(219, 29);
            this.sellItemCombo.TabIndex = 17;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(434, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "원";
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.resetButton.Location = new System.Drawing.Point(914, 164);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(132, 65);
            this.resetButton.TabIndex = 14;
            this.resetButton.Text = "다시쓰기";
            this.resetButton.UseVisualStyleBackColor = true;
            // 
            // expenseContentTxt
            // 
            this.expenseContentTxt.Location = new System.Drawing.Point(128, 235);
            this.expenseContentTxt.MaxLength = 2048;
            this.expenseContentTxt.Multiline = true;
            this.expenseContentTxt.Name = "expenseContentTxt";
            this.expenseContentTxt.Size = new System.Drawing.Size(918, 32);
            this.expenseContentTxt.TabIndex = 11;
            // 
            // sellItemCountTxt
            // 
            this.sellItemCountTxt.Location = new System.Drawing.Point(128, 127);
            this.sellItemCountTxt.MaxLength = 8;
            this.sellItemCountTxt.Name = "sellItemCountTxt";
            this.sellItemCountTxt.Size = new System.Drawing.Size(150, 32);
            this.sellItemCountTxt.TabIndex = 10;
            this.sellItemCountTxt.Text = "0";
            this.sellItemCountTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.sellItemCountTxt.TextChanged += new System.EventHandler(this.sellItemCountTxt_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 239);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 21);
            this.label12.TabIndex = 3;
            this.label12.Text = "지출내용 : ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 200);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 21);
            this.label13.TabIndex = 2;
            this.label13.Text = "지출금액 : ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 70);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(115, 21);
            this.label14.TabIndex = 1;
            this.label14.Text = "판매항목 : ";
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
            // sellItemRemove
            // 
            this.sellItemRemove.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sellItemRemove.Location = new System.Drawing.Point(491, 48);
            this.sellItemRemove.Name = "sellItemRemove";
            this.sellItemRemove.Size = new System.Drawing.Size(132, 65);
            this.sellItemRemove.TabIndex = 20;
            this.sellItemRemove.Text = "판매항목  등록삭제";
            this.sellItemRemove.UseVisualStyleBackColor = true;
            this.sellItemRemove.Click += new System.EventHandler(this.sellItemRemove_Click);
            // 
            // SellManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 649);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelControl1);
            this.Name = "SellManagementForm";
            this.Text = "판매관리 창";
            this.Load += new System.EventHandler(this.SellManagementForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.TextBox expenseContentTxt;
        private System.Windows.Forms.TextBox sellItemCountTxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Button SellItemAddButton;
        private System.Windows.Forms.ComboBox sellItemCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sellItemRemove;
    }
}