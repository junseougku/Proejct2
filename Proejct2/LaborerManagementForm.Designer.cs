namespace Proejct2
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dateLabel = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.manHireCountEdit = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.womanHireCountEdit = new DevExpress.XtraEditors.SpinEdit();
            this.hireTotalCountLable = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.spinEdit1 = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.spinEdit2 = new DevExpress.XtraEditors.SpinEdit();
            this.laborerManagementGrid = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dateColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.hireCountColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.laborcostColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.snakcostColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.totalcostColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.resetButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.manHireCountEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.womanHireCountEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laborerManagementGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("돋움체", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(116, 27);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "인력관리";
            // 
            // dateLabel
            // 
            this.dateLabel.Appearance.Font = new System.Drawing.Font("돋움체", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Appearance.Options.UseFont = true;
            this.dateLabel.Location = new System.Drawing.Point(5, 23);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(60, 24);
            this.dateLabel.TabIndex = 1;
            this.dateLabel.Text = "날짜 ";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("돋움체", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(5, 73);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(264, 24);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "오늘 고용한 사람 수 : ";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("돋움체", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(275, 73);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 24);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "남자";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("돋움체", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(405, 73);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 24);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "여자";
            // 
            // manHireCountEdit
            // 
            this.manHireCountEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.manHireCountEdit.Location = new System.Drawing.Point(329, 70);
            this.manHireCountEdit.Name = "manHireCountEdit";
            this.manHireCountEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manHireCountEdit.Properties.Appearance.Options.UseFont = true;
            this.manHireCountEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.manHireCountEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.manHireCountEdit.Size = new System.Drawing.Size(52, 36);
            this.manHireCountEdit.TabIndex = 6;
            this.manHireCountEdit.ValueChanged += new System.EventHandler(this.manHireCountEdit_ValueChanged);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("돋움체", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(545, 73);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(84, 24);
            this.labelControl8.TabIndex = 8;
            this.labelControl8.Text = "총합 : ";
            // 
            // womanHireCountEdit
            // 
            this.womanHireCountEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.womanHireCountEdit.Location = new System.Drawing.Point(459, 70);
            this.womanHireCountEdit.Name = "womanHireCountEdit";
            this.womanHireCountEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.womanHireCountEdit.Properties.Appearance.Options.UseFont = true;
            this.womanHireCountEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.womanHireCountEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.womanHireCountEdit.Size = new System.Drawing.Size(52, 36);
            this.womanHireCountEdit.TabIndex = 10;
            this.womanHireCountEdit.ValueChanged += new System.EventHandler(this.womanHireCountEdit_ValueChanged);
            // 
            // hireTotalCountLable
            // 
            this.hireTotalCountLable.Appearance.Font = new System.Drawing.Font("돋움체", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hireTotalCountLable.Appearance.Options.UseFont = true;
            this.hireTotalCountLable.Location = new System.Drawing.Point(635, 73);
            this.hireTotalCountLable.Name = "hireTotalCountLable";
            this.hireTotalCountLable.Size = new System.Drawing.Size(36, 24);
            this.hireTotalCountLable.TabIndex = 11;
            this.hireTotalCountLable.Text = "0명";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("돋움체", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(5, 130);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(252, 24);
            this.labelControl5.TabIndex = 12;
            this.labelControl5.Text = "오늘 지출한 인건비 : ";
            // 
            // spinEdit1
            // 
            this.spinEdit1.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEdit1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.spinEdit1.Location = new System.Drawing.Point(263, 124);
            this.spinEdit1.Name = "spinEdit1";
            this.spinEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinEdit1.Properties.Appearance.Options.UseFont = true;
            this.spinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEdit1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinEdit1.Size = new System.Drawing.Size(248, 36);
            this.spinEdit1.TabIndex = 13;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("돋움체", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(517, 130);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(24, 24);
            this.labelControl6.TabIndex = 14;
            this.labelControl6.Text = "원";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("돋움체", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(5, 188);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(252, 24);
            this.labelControl7.TabIndex = 15;
            this.labelControl7.Text = "오늘 지출한 간식비 : ";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("돋움체", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(517, 188);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(24, 24);
            this.labelControl9.TabIndex = 17;
            this.labelControl9.Text = "원";
            // 
            // spinEdit2
            // 
            this.spinEdit2.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEdit2.Location = new System.Drawing.Point(263, 182);
            this.spinEdit2.Name = "spinEdit2";
            this.spinEdit2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinEdit2.Properties.Appearance.Options.UseFont = true;
            this.spinEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEdit2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinEdit2.Size = new System.Drawing.Size(248, 36);
            this.spinEdit2.TabIndex = 16;
            // 
            // laborerManagementGrid
            // 
            this.laborerManagementGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.laborerManagementGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.laborerManagementGrid.Location = new System.Drawing.Point(0, 321);
            this.laborerManagementGrid.MainView = this.gridView;
            this.laborerManagementGrid.Name = "laborerManagementGrid";
            this.laborerManagementGrid.Size = new System.Drawing.Size(1059, 320);
            this.laborerManagementGrid.TabIndex = 18;
            this.laborerManagementGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Appearance.HeaderPanel.Font = new System.Drawing.Font("돋움", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView.Appearance.Row.Font = new System.Drawing.Font("돋움체", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView.Appearance.Row.Options.UseFont = true;
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.dateColumn,
            this.hireCountColumn,
            this.laborcostColumn,
            this.snakcostColumn,
            this.totalcostColumn});
            this.gridView.DetailHeight = 500;
            this.gridView.GridControl = this.laborerManagementGrid;
            this.gridView.Name = "gridView";
            // 
            // dateColumn
            // 
            this.dateColumn.Caption = "날짜";
            this.dateColumn.Name = "dateColumn";
            this.dateColumn.Visible = true;
            this.dateColumn.VisibleIndex = 0;
            this.dateColumn.Width = 168;
            // 
            // hireCountColumn
            // 
            this.hireCountColumn.Caption = "고용한사람수";
            this.hireCountColumn.Name = "hireCountColumn";
            this.hireCountColumn.Visible = true;
            this.hireCountColumn.VisibleIndex = 1;
            this.hireCountColumn.Width = 221;
            // 
            // laborcostColumn
            // 
            this.laborcostColumn.Caption = "인건비";
            this.laborcostColumn.Name = "laborcostColumn";
            this.laborcostColumn.Visible = true;
            this.laborcostColumn.VisibleIndex = 2;
            this.laborcostColumn.Width = 242;
            // 
            // snakcostColumn
            // 
            this.snakcostColumn.Caption = "간식비";
            this.snakcostColumn.Name = "snakcostColumn";
            this.snakcostColumn.Visible = true;
            this.snakcostColumn.VisibleIndex = 3;
            this.snakcostColumn.Width = 199;
            // 
            // totalcostColumn
            // 
            this.totalcostColumn.Caption = "총합";
            this.totalcostColumn.Name = "totalcostColumn";
            this.totalcostColumn.Visible = true;
            this.totalcostColumn.VisibleIndex = 4;
            this.totalcostColumn.Width = 211;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.resetButton);
            this.groupControl1.Controls.Add(this.saveButton);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.dateLabel);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.spinEdit2);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.manHireCountEdit);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.spinEdit1);
            this.groupControl1.Controls.Add(this.womanHireCountEdit);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.hireTotalCountLable);
            this.groupControl1.Location = new System.Drawing.Point(12, 45);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1035, 270);
            this.groupControl1.TabIndex = 19;
            // 
            // saveButton
            // 
            this.saveButton.Appearance.Font = new System.Drawing.Font("돋움", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Appearance.Options.UseFont = true;
            this.saveButton.Location = new System.Drawing.Point(726, 195);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(149, 70);
            this.saveButton.TabIndex = 18;
            this.saveButton.Text = "저  장";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Appearance.Font = new System.Drawing.Font("돋움", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Appearance.Options.UseFont = true;
            this.resetButton.Location = new System.Drawing.Point(881, 195);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(149, 70);
            this.resetButton.TabIndex = 19;
            this.resetButton.Text = "초기화";
            // 
            // LaborerManagementForm
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 641);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.laborerManagementGrid);
            this.Controls.Add(this.labelControl1);
            this.Font = new System.Drawing.Font("돋움체", 20F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "LaborerManagementForm";
            this.Text = "인력관리";
            this.Load += new System.EventHandler(this.LaborerManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.manHireCountEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.womanHireCountEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laborerManagementGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl dateLabel;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SpinEdit manHireCountEdit;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SpinEdit womanHireCountEdit;
        private DevExpress.XtraEditors.LabelControl hireTotalCountLable;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SpinEdit spinEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.SpinEdit spinEdit2;
        private DevExpress.XtraGrid.GridControl laborerManagementGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn dateColumn;
        private DevExpress.XtraGrid.Columns.GridColumn hireCountColumn;
        private DevExpress.XtraGrid.Columns.GridColumn laborcostColumn;
        private DevExpress.XtraGrid.Columns.GridColumn snakcostColumn;
        private DevExpress.XtraGrid.Columns.GridColumn totalcostColumn;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton resetButton;
        private DevExpress.XtraEditors.SimpleButton saveButton;
    }
}