﻿namespace Project3
{
    partial class mainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.laborerManagementButton = new System.Windows.Forms.Button();
            this.expenseManagementButton = new System.Windows.Forms.Button();
            this.sellManagementButton = new System.Windows.Forms.Button();
            this.memoButton = new System.Windows.Forms.Button();
            this.scheduleManagementButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "홈 화면";
            // 
            // laborerManagementButton
            // 
            this.laborerManagementButton.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.laborerManagementButton.Location = new System.Drawing.Point(17, 68);
            this.laborerManagementButton.Name = "laborerManagementButton";
            this.laborerManagementButton.Size = new System.Drawing.Size(157, 82);
            this.laborerManagementButton.TabIndex = 1;
            this.laborerManagementButton.Text = "인력관리";
            this.laborerManagementButton.UseVisualStyleBackColor = true;
            this.laborerManagementButton.Click += new System.EventHandler(this.laborerManagementButton_Click);
            // 
            // expenseManagementButton
            // 
            this.expenseManagementButton.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.expenseManagementButton.Location = new System.Drawing.Point(17, 177);
            this.expenseManagementButton.Name = "expenseManagementButton";
            this.expenseManagementButton.Size = new System.Drawing.Size(157, 82);
            this.expenseManagementButton.TabIndex = 2;
            this.expenseManagementButton.Text = "지출관리";
            this.expenseManagementButton.UseVisualStyleBackColor = true;
            this.expenseManagementButton.Click += new System.EventHandler(this.expenseManagementButton_Click);
            // 
            // sellManagementButton
            // 
            this.sellManagementButton.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sellManagementButton.Location = new System.Drawing.Point(17, 288);
            this.sellManagementButton.Name = "sellManagementButton";
            this.sellManagementButton.Size = new System.Drawing.Size(157, 82);
            this.sellManagementButton.TabIndex = 4;
            this.sellManagementButton.Text = "판매관리";
            this.sellManagementButton.UseVisualStyleBackColor = true;
            this.sellManagementButton.Click += new System.EventHandler(this.sellManagementButton_Click);
            // 
            // memoButton
            // 
            this.memoButton.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.memoButton.Location = new System.Drawing.Point(253, 177);
            this.memoButton.Name = "memoButton";
            this.memoButton.Size = new System.Drawing.Size(157, 82);
            this.memoButton.TabIndex = 5;
            this.memoButton.Text = "메  모";
            this.memoButton.UseVisualStyleBackColor = true;
            this.memoButton.Click += new System.EventHandler(this.memoButton_Click);
            // 
            // scheduleManagementButton
            // 
            this.scheduleManagementButton.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.scheduleManagementButton.Location = new System.Drawing.Point(253, 68);
            this.scheduleManagementButton.Name = "scheduleManagementButton";
            this.scheduleManagementButton.Size = new System.Drawing.Size(157, 82);
            this.scheduleManagementButton.TabIndex = 6;
            this.scheduleManagementButton.Text = "일정관리";
            this.scheduleManagementButton.UseVisualStyleBackColor = true;
            this.scheduleManagementButton.Click += new System.EventHandler(this.scheduleManagementButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.exitButton.Location = new System.Drawing.Point(253, 288);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(157, 82);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "종  료";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(428, 381);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.scheduleManagementButton);
            this.Controls.Add(this.memoButton);
            this.Controls.Add(this.sellManagementButton);
            this.Controls.Add(this.expenseManagementButton);
            this.Controls.Add(this.laborerManagementButton);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Text = "관리프로그램";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button laborerManagementButton;
        private System.Windows.Forms.Button expenseManagementButton;
        private System.Windows.Forms.Button sellManagementButton;
        private System.Windows.Forms.Button memoButton;
        private System.Windows.Forms.Button scheduleManagementButton;
        private System.Windows.Forms.Button exitButton;
    }
}

