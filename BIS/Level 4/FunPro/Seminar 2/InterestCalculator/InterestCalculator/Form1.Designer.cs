namespace InterestCalculator
{
    partial class button
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
            this.tbx_name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.num_deposit = new System.Windows.Forms.NumericUpDown();
            this.lbl_deposit = new System.Windows.Forms.Label();
            this.lbl_interest = new System.Windows.Forms.Label();
            this.num_interest = new System.Windows.Forms.NumericUpDown();
            this.btn_submit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_deposit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_interest)).BeginInit();
            this.SuspendLayout();
            // 
            // tbx_name
            // 
            this.tbx_name.Location = new System.Drawing.Point(271, 139);
            this.tbx_name.Name = "tbx_name";
            this.tbx_name.Size = new System.Drawing.Size(100, 20);
            this.tbx_name.TabIndex = 0;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(182, 142);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(67, 13);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Client Name:";
            // 
            // num_deposit
            // 
            this.num_deposit.Location = new System.Drawing.Point(271, 165);
            this.num_deposit.Name = "num_deposit";
            this.num_deposit.Size = new System.Drawing.Size(100, 20);
            this.num_deposit.TabIndex = 2;
            // 
            // lbl_deposit
            // 
            this.lbl_deposit.AutoSize = true;
            this.lbl_deposit.Location = new System.Drawing.Point(182, 167);
            this.lbl_deposit.Name = "lbl_deposit";
            this.lbl_deposit.Size = new System.Drawing.Size(43, 13);
            this.lbl_deposit.TabIndex = 4;
            this.lbl_deposit.Text = "Deposit";
            // 
            // lbl_interest
            // 
            this.lbl_interest.AutoSize = true;
            this.lbl_interest.Location = new System.Drawing.Point(182, 193);
            this.lbl_interest.Name = "lbl_interest";
            this.lbl_interest.Size = new System.Drawing.Size(66, 13);
            this.lbl_interest.TabIndex = 6;
            this.lbl_interest.Text = "Interest rate:";
            // 
            // num_interest
            // 
            this.num_interest.Location = new System.Drawing.Point(271, 191);
            this.num_interest.Name = "num_interest";
            this.num_interest.Size = new System.Drawing.Size(100, 20);
            this.num_interest.TabIndex = 5;
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(239, 226);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 7;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // button
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 351);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.lbl_interest);
            this.Controls.Add(this.num_interest);
            this.Controls.Add(this.lbl_deposit);
            this.Controls.Add(this.num_deposit);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.tbx_name);
            this.Name = "button";
            this.Text = "button1";
            ((System.ComponentModel.ISupportInitialize)(this.num_deposit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_interest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_name;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.NumericUpDown num_deposit;
        private System.Windows.Forms.Label lbl_deposit;
        private System.Windows.Forms.Label lbl_interest;
        private System.Windows.Forms.NumericUpDown num_interest;
        private System.Windows.Forms.Button btn_submit;
    }
}

