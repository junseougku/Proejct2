namespace Proejct2
{
    partial class mainForm
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.laborerManagementButton = new System.Windows.Forms.Button();
            this.expenseManagementButton = new System.Windows.Forms.Button();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("돋움체", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(26, 23);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(102, 27);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "홈 화면";
            // 
            // laborerManagementButton
            // 
            this.laborerManagementButton.Font = new System.Drawing.Font("돋움체", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.laborerManagementButton.Location = new System.Drawing.Point(15, 76);
            this.laborerManagementButton.Margin = new System.Windows.Forms.Padding(6);
            this.laborerManagementButton.Name = "laborerManagementButton";
            this.laborerManagementButton.Size = new System.Drawing.Size(166, 65);
            this.laborerManagementButton.TabIndex = 1;
            this.laborerManagementButton.Text = "인력관리";
            this.laborerManagementButton.UseVisualStyleBackColor = true;
            this.laborerManagementButton.Click += new System.EventHandler(this.laborerManagementButton_Click);
            // 
            // expenseManagementButton
            // 
            this.expenseManagementButton.Font = new System.Drawing.Font("돋움체", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.expenseManagementButton.Location = new System.Drawing.Point(15, 153);
            this.expenseManagementButton.Margin = new System.Windows.Forms.Padding(6);
            this.expenseManagementButton.Name = "expenseManagementButton";
            this.expenseManagementButton.Size = new System.Drawing.Size(166, 65);
            this.expenseManagementButton.TabIndex = 2;
            this.expenseManagementButton.Text = "지출관리";
            this.expenseManagementButton.UseVisualStyleBackColor = true;
            this.expenseManagementButton.Click += new System.EventHandler(this.expenseManagementButton_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("돋움체", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(472, 76);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(50, 24);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "날씨";
            // 
            // mainForm
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 496);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.expenseManagementButton);
            this.Controls.Add(this.laborerManagementButton);
            this.Controls.Add(this.labelControl1);
            this.Font = new System.Drawing.Font("돋움체", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "mainForm";
            this.Text = "호박";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Button laborerManagementButton;
        private System.Windows.Forms.Button expenseManagementButton;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}

