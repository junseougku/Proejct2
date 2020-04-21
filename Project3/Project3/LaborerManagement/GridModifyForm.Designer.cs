namespace Project3.LaborerManagement
{
    partial class GridModifyForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.sumcostCheckBox = new WindowsFormsApplication2.CustomCheckBox(this.components);
            this.snakCheckBox = new WindowsFormsApplication2.CustomCheckBox(this.components);
            this.laborcostCheckBox = new WindowsFormsApplication2.CustomCheckBox(this.components);
            this.hireCountCheckBox = new WindowsFormsApplication2.CustomCheckBox(this.components);
            this.womanCheckBox = new WindowsFormsApplication2.CustomCheckBox(this.components);
            this.manCheckBox = new WindowsFormsApplication2.CustomCheckBox(this.components);
            this.dateCheckBox = new WindowsFormsApplication2.CustomCheckBox(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sumcostCheckBox);
            this.groupBox1.Controls.Add(this.snakCheckBox);
            this.groupBox1.Controls.Add(this.laborcostCheckBox);
            this.groupBox1.Controls.Add(this.hireCountCheckBox);
            this.groupBox1.Controls.Add(this.womanCheckBox);
            this.groupBox1.Controls.Add(this.manCheckBox);
            this.groupBox1.Controls.Add(this.dateCheckBox);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 343);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "표 항목 표시";
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.saveButton.Location = new System.Drawing.Point(286, 287);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(132, 65);
            this.saveButton.TabIndex = 18;
            this.saveButton.Text = "저  장";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.closeButton.Location = new System.Drawing.Point(424, 287);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(132, 65);
            this.closeButton.TabIndex = 19;
            this.closeButton.Text = "창 닫기";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // sumcostCheckBox
            // 
            this.sumcostCheckBox.Check = true;
            this.sumcostCheckBox.Location = new System.Drawing.Point(6, 295);
            this.sumcostCheckBox.Name = "sumcostCheckBox";
            this.sumcostCheckBox.Size = new System.Drawing.Size(135, 38);
            this.sumcostCheckBox.TabIndex = 6;
            this.sumcostCheckBox.Text = "총합";
            // 
            // snakCheckBox
            // 
            this.snakCheckBox.Check = true;
            this.snakCheckBox.Location = new System.Drawing.Point(6, 251);
            this.snakCheckBox.Name = "snakCheckBox";
            this.snakCheckBox.Size = new System.Drawing.Size(135, 38);
            this.snakCheckBox.TabIndex = 5;
            this.snakCheckBox.Text = "간식비";
            // 
            // laborcostCheckBox
            // 
            this.laborcostCheckBox.Check = true;
            this.laborcostCheckBox.Location = new System.Drawing.Point(6, 207);
            this.laborcostCheckBox.Name = "laborcostCheckBox";
            this.laborcostCheckBox.Size = new System.Drawing.Size(135, 38);
            this.laborcostCheckBox.TabIndex = 4;
            this.laborcostCheckBox.Text = "인건비";
            // 
            // hireCountCheckBox
            // 
            this.hireCountCheckBox.Check = true;
            this.hireCountCheckBox.Location = new System.Drawing.Point(6, 163);
            this.hireCountCheckBox.Name = "hireCountCheckBox";
            this.hireCountCheckBox.Size = new System.Drawing.Size(194, 38);
            this.hireCountCheckBox.TabIndex = 3;
            this.hireCountCheckBox.Text = "고용한 사람 수";
            // 
            // womanCheckBox
            // 
            this.womanCheckBox.Check = false;
            this.womanCheckBox.Location = new System.Drawing.Point(6, 119);
            this.womanCheckBox.Name = "womanCheckBox";
            this.womanCheckBox.Size = new System.Drawing.Size(135, 38);
            this.womanCheckBox.TabIndex = 2;
            this.womanCheckBox.Text = "여자";
            // 
            // manCheckBox
            // 
            this.manCheckBox.Check = false;
            this.manCheckBox.Location = new System.Drawing.Point(6, 75);
            this.manCheckBox.Name = "manCheckBox";
            this.manCheckBox.Size = new System.Drawing.Size(135, 38);
            this.manCheckBox.TabIndex = 1;
            this.manCheckBox.Text = "남자";
            // 
            // dateCheckBox
            // 
            this.dateCheckBox.Check = true;
            this.dateCheckBox.Enabled = false;
            this.dateCheckBox.Location = new System.Drawing.Point(6, 31);
            this.dateCheckBox.Name = "dateCheckBox";
            this.dateCheckBox.Size = new System.Drawing.Size(135, 38);
            this.dateCheckBox.TabIndex = 0;
            this.dateCheckBox.Text = "날짜";
            // 
            // GridModifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 364);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "GridModifyForm";
            this.Text = "표 편집창";
            this.Load += new System.EventHandler(this.GridModifyForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private WindowsFormsApplication2.CustomCheckBox dateCheckBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private WindowsFormsApplication2.CustomCheckBox sumcostCheckBox;
        private WindowsFormsApplication2.CustomCheckBox snakCheckBox;
        private WindowsFormsApplication2.CustomCheckBox laborcostCheckBox;
        private WindowsFormsApplication2.CustomCheckBox hireCountCheckBox;
        private WindowsFormsApplication2.CustomCheckBox womanCheckBox;
        private WindowsFormsApplication2.CustomCheckBox manCheckBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button closeButton;
    }
}