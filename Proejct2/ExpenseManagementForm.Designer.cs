namespace Proejct2
{
    partial class ExpenseManagementForm
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
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.expenseGrid = new DevExpress.XtraGrid.GridControl();
            this.mainView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.expenseSumColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.expenseItemColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.expenseContentColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.expenseGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainView)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("돋움체", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(116, 27);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "지출관리";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("돋움체", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 59);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(180, 24);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "오늘의 지출등록";
            // 
            // expenseGrid
            // 
            this.expenseGrid.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenseGrid.Location = new System.Drawing.Point(12, 89);
            this.expenseGrid.MainView = this.mainView;
            this.expenseGrid.Name = "expenseGrid";
            this.expenseGrid.Size = new System.Drawing.Size(1039, 527);
            this.expenseGrid.TabIndex = 3;
            this.expenseGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.mainView});
            // 
            // mainView
            // 
            this.mainView.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainView.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.mainView.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainView.Appearance.GroupPanel.Options.UseFont = true;
            this.mainView.Appearance.GroupRow.Font = new System.Drawing.Font("돋움체", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainView.Appearance.GroupRow.Options.UseFont = true;
            this.mainView.Appearance.HeaderPanel.Font = new System.Drawing.Font("돋움", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainView.Appearance.HeaderPanel.Options.UseFont = true;
            this.mainView.Appearance.Row.Font = new System.Drawing.Font("돋움체", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainView.Appearance.Row.Options.UseFont = true;
            this.mainView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.expenseSumColumn,
            this.expenseItemColumn,
            this.expenseContentColumn});
            this.mainView.GridControl = this.expenseGrid;
            this.mainView.Name = "mainView";
            // 
            // expenseSumColumn
            // 
            this.expenseSumColumn.Caption = "지출가격";
            this.expenseSumColumn.Name = "expenseSumColumn";
            this.expenseSumColumn.Visible = true;
            this.expenseSumColumn.VisibleIndex = 1;
            this.expenseSumColumn.Width = 155;
            // 
            // expenseItemColumn
            // 
            this.expenseItemColumn.Caption = "지출항목";
            this.expenseItemColumn.Name = "expenseItemColumn";
            this.expenseItemColumn.Visible = true;
            this.expenseItemColumn.VisibleIndex = 0;
            this.expenseItemColumn.Width = 209;
            // 
            // expenseContentColumn
            // 
            this.expenseContentColumn.Caption = "지출내용";
            this.expenseContentColumn.Name = "expenseContentColumn";
            this.expenseContentColumn.Visible = true;
            this.expenseContentColumn.VisibleIndex = 2;
            this.expenseContentColumn.Width = 657;
            // 
            // ExpenseManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 628);
            this.Controls.Add(this.expenseGrid);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "ExpenseManagementForm";
            this.Text = "지출관리";
            ((System.ComponentModel.ISupportInitialize)(this.expenseGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView mainView;
        private DevExpress.XtraGrid.Columns.GridColumn expenseItemColumn;
        private DevExpress.XtraGrid.Columns.GridColumn expenseContentColumn;
        private DevExpress.XtraGrid.Columns.GridColumn expenseSumColumn;
        public DevExpress.XtraGrid.GridControl expenseGrid;
    }
}