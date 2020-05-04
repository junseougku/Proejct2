namespace Project3.SellManagement
{
    partial class SellItemRemoveForm
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
            this.label10 = new System.Windows.Forms.Label();
            this.sellItemRemoveCombo = new System.Windows.Forms.ComboBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.AutoSize = true;
            this.labelControl1.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelControl1.Location = new System.Drawing.Point(17, 9);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(190, 27);
            this.labelControl1.TabIndex = 22;
            this.labelControl1.Text = "판매항목 삭제";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 45);
            this.label10.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(409, 21);
            this.label10.TabIndex = 23;
            this.label10.Text = "지울 항목을 선택 후 삭제 버튼을 누르세요";
            // 
            // sellItemRemoveCombo
            // 
            this.sellItemRemoveCombo.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.sellItemRemoveCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sellItemRemoveCombo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.sellItemRemoveCombo.FormattingEnabled = true;
            this.sellItemRemoveCombo.Location = new System.Drawing.Point(22, 78);
            this.sellItemRemoveCombo.Name = "sellItemRemoveCombo";
            this.sellItemRemoveCombo.Size = new System.Drawing.Size(219, 29);
            this.sellItemRemoveCombo.TabIndex = 24;
            // 
            // removeButton
            // 
            this.removeButton.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.removeButton.Location = new System.Drawing.Point(22, 113);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(132, 65);
            this.removeButton.TabIndex = 25;
            this.removeButton.Text = "삭제";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.closeButton.Location = new System.Drawing.Point(160, 113);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(132, 65);
            this.closeButton.TabIndex = 26;
            this.closeButton.Text = "취소";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // SellItemRemoveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 193);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.sellItemRemoveCombo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labelControl1);
            this.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "SellItemRemoveForm";
            this.Text = "판매항목 삭제창";
            this.Load += new System.EventHandler(this.SellItemRemoveForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelControl1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox sellItemRemoveCombo;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button closeButton;
    }
}