
namespace Zurumbia_11883
{
    partial class RegionListForm
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
            this.dgvRegionList = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headcountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.limitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regionPaymentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.regionPaymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegionList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionPaymentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionPaymentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRegionList
            // 
            this.dgvRegionList.AllowUserToAddRows = false;
            this.dgvRegionList.AllowUserToDeleteRows = false;
            this.dgvRegionList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRegionList.AutoGenerateColumns = false;
            this.dgvRegionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegionList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.regionDataGridViewTextBoxColumn,
            this.headcountDataGridViewTextBoxColumn,
            this.limitDataGridViewTextBoxColumn,
            this.paidDataGridViewTextBoxColumn});
            this.dgvRegionList.DataSource = this.regionPaymentBindingSource1;
            this.dgvRegionList.Location = new System.Drawing.Point(9, 10);
            this.dgvRegionList.Margin = new System.Windows.Forms.Padding(2);
            this.dgvRegionList.Name = "dgvRegionList";
            this.dgvRegionList.ReadOnly = true;
            this.dgvRegionList.RowHeadersWidth = 51;
            this.dgvRegionList.RowTemplate.Height = 24;
            this.dgvRegionList.Size = new System.Drawing.Size(737, 351);
            this.dgvRegionList.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // regionDataGridViewTextBoxColumn
            // 
            this.regionDataGridViewTextBoxColumn.DataPropertyName = "Region";
            this.regionDataGridViewTextBoxColumn.HeaderText = "Region";
            this.regionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.regionDataGridViewTextBoxColumn.Name = "regionDataGridViewTextBoxColumn";
            this.regionDataGridViewTextBoxColumn.ReadOnly = true;
            this.regionDataGridViewTextBoxColumn.Width = 80;
            // 
            // headcountDataGridViewTextBoxColumn
            // 
            this.headcountDataGridViewTextBoxColumn.DataPropertyName = "Headcount";
            this.headcountDataGridViewTextBoxColumn.HeaderText = "Headcount";
            this.headcountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.headcountDataGridViewTextBoxColumn.Name = "headcountDataGridViewTextBoxColumn";
            this.headcountDataGridViewTextBoxColumn.ReadOnly = true;
            this.headcountDataGridViewTextBoxColumn.Width = 125;
            // 
            // limitDataGridViewTextBoxColumn
            // 
            this.limitDataGridViewTextBoxColumn.DataPropertyName = "Limit";
            this.limitDataGridViewTextBoxColumn.HeaderText = "Limit";
            this.limitDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.limitDataGridViewTextBoxColumn.Name = "limitDataGridViewTextBoxColumn";
            this.limitDataGridViewTextBoxColumn.ReadOnly = true;
            this.limitDataGridViewTextBoxColumn.Width = 125;
            // 
            // paidDataGridViewTextBoxColumn
            // 
            this.paidDataGridViewTextBoxColumn.DataPropertyName = "Paid";
            this.paidDataGridViewTextBoxColumn.HeaderText = "Paid";
            this.paidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paidDataGridViewTextBoxColumn.Name = "paidDataGridViewTextBoxColumn";
            this.paidDataGridViewTextBoxColumn.ReadOnly = true;
            this.paidDataGridViewTextBoxColumn.Width = 125;
            // 
            // regionPaymentBindingSource1
            // 
            this.regionPaymentBindingSource1.DataSource = typeof(Zurumbia_11883.DAL.RegionPayment);
            // 
            // regionPaymentBindingSource
            // 
            this.regionPaymentBindingSource.DataSource = typeof(Zurumbia_11883.DAL.RegionPayment);
            // 
            // RegionListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(757, 372);
            this.Controls.Add(this.dgvRegionList);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RegionListForm";
            this.Text = "Region List";
            this.Load += new System.EventHandler(this.RegionListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegionList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionPaymentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionPaymentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRegionList;
        private System.Windows.Forms.BindingSource regionPaymentBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn headcountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn limitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paidDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource regionPaymentBindingSource1;
    }
}