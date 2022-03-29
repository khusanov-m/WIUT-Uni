
namespace Zurumbia_11883
{
    partial class RegionPaymentListForm
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
            this.dvRegionPayment = new System.Windows.Forms.DataGridView();
            this.fullSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneyPaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extraHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numRegion = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numLimitHours = new System.Windows.Forms.NumericUpDown();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lblTotalHoursPaid = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.socialWorkerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.socialWorkerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dvRegionPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRegion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLimitHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.socialWorkerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.socialWorkerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dvRegionPayment
            // 
            this.dvRegionPayment.AllowUserToAddRows = false;
            this.dvRegionPayment.AllowUserToDeleteRows = false;
            this.dvRegionPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvRegionPayment.AutoGenerateColumns = false;
            this.dvRegionPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvRegionPayment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.rateDataGridViewTextBoxColumn,
            this.hoursDataGridViewTextBoxColumn,
            this.fullSalary,
            this.moneyPaid,
            this.extraHours});
            this.dvRegionPayment.DataSource = this.socialWorkerBindingSource1;
            this.dvRegionPayment.Location = new System.Drawing.Point(11, 139);
            this.dvRegionPayment.Margin = new System.Windows.Forms.Padding(2);
            this.dvRegionPayment.Name = "dvRegionPayment";
            this.dvRegionPayment.RowHeadersWidth = 51;
            this.dvRegionPayment.RowTemplate.Height = 24;
            this.dvRegionPayment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvRegionPayment.Size = new System.Drawing.Size(856, 311);
            this.dvRegionPayment.TabIndex = 0;
            // 
            // fullSalary
            // 
            this.fullSalary.HeaderText = "Full Salary";
            this.fullSalary.MinimumWidth = 6;
            this.fullSalary.Name = "fullSalary";
            this.fullSalary.Width = 125;
            // 
            // moneyPaid
            // 
            this.moneyPaid.HeaderText = "Salary to be paid";
            this.moneyPaid.MinimumWidth = 6;
            this.moneyPaid.Name = "moneyPaid";
            this.moneyPaid.ReadOnly = true;
            this.moneyPaid.Width = 125;
            // 
            // extraHours
            // 
            this.extraHours.HeaderText = "Unpaid Salary";
            this.extraHours.MinimumWidth = 6;
            this.extraHours.Name = "extraHours";
            this.extraHours.ReadOnly = true;
            this.extraHours.Width = 125;
            // 
            // numRegion
            // 
            this.numRegion.Font = new System.Drawing.Font("Century Gothic", 9.25F);
            this.numRegion.Location = new System.Drawing.Point(151, 12);
            this.numRegion.Margin = new System.Windows.Forms.Padding(2);
            this.numRegion.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numRegion.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRegion.Name = "numRegion";
            this.numRegion.Size = new System.Drawing.Size(127, 23);
            this.numRegion.TabIndex = 1;
            this.numRegion.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Region Number :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Month :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Budget Limit :";
            // 
            // numLimitHours
            // 
            this.numLimitHours.Font = new System.Drawing.Font("Century Gothic", 9.25F);
            this.numLimitHours.Location = new System.Drawing.Point(151, 67);
            this.numLimitHours.Margin = new System.Windows.Forms.Padding(2);
            this.numLimitHours.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numLimitHours.Name = "numLimitHours";
            this.numLimitHours.Size = new System.Drawing.Size(127, 23);
            this.numLimitHours.TabIndex = 5;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.Black;
            this.btnLoad.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Location = new System.Drawing.Point(11, 93);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(215, 41);
            this.btnLoad.TabIndex = 7;
            this.btnLoad.Text = "Load data";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lblTotalHoursPaid
            // 
            this.lblTotalHoursPaid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalHoursPaid.AutoSize = true;
            this.lblTotalHoursPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalHoursPaid.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotalHoursPaid.Location = new System.Drawing.Point(25, 460);
            this.lblTotalHoursPaid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalHoursPaid.Name = "lblTotalHoursPaid";
            this.lblTotalHoursPaid.Size = new System.Drawing.Size(0, 20);
            this.lblTotalHoursPaid.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.Black;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(648, 454);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 54);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.Black;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(762, 454);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 54);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "yyyy:MM";
            this.dtpDate.Font = new System.Drawing.Font("Century Gothic", 9.25F);
            this.dtpDate.Location = new System.Drawing.Point(151, 39);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(128, 23);
            this.dtpDate.TabIndex = 11;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // rateDataGridViewTextBoxColumn
            // 
            this.rateDataGridViewTextBoxColumn.DataPropertyName = "Rate";
            this.rateDataGridViewTextBoxColumn.HeaderText = "Rate";
            this.rateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rateDataGridViewTextBoxColumn.Name = "rateDataGridViewTextBoxColumn";
            this.rateDataGridViewTextBoxColumn.Width = 120;
            // 
            // hoursDataGridViewTextBoxColumn
            // 
            this.hoursDataGridViewTextBoxColumn.DataPropertyName = "Hours";
            this.hoursDataGridViewTextBoxColumn.HeaderText = "Hours";
            this.hoursDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hoursDataGridViewTextBoxColumn.Name = "hoursDataGridViewTextBoxColumn";
            this.hoursDataGridViewTextBoxColumn.Width = 120;
            // 
            // socialWorkerBindingSource1
            // 
            this.socialWorkerBindingSource1.DataSource = typeof(Zurumbia_11883.DAL.SocialWorker);
            // 
            // socialWorkerBindingSource
            // 
            this.socialWorkerBindingSource.DataSource = typeof(Zurumbia_11883.DAL.SocialWorker);
            // 
            // RegionPaymentListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(880, 517);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblTotalHoursPaid);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numLimitHours);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numRegion);
            this.Controls.Add(this.dvRegionPayment);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RegionPaymentListForm";
            this.Text = "Region";
            this.Load += new System.EventHandler(this.RegionPaymentListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvRegionPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRegion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLimitHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.socialWorkerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.socialWorkerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dvRegionPayment;
        private System.Windows.Forms.NumericUpDown numRegion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numLimitHours;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblTotalHoursPaid;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.BindingSource socialWorkerBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneyPaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn extraHours;
        private System.Windows.Forms.BindingSource socialWorkerBindingSource1;
    }
}