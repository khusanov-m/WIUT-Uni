namespace ExploringProperties
{
    partial class Form1
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
            this.btn_submit = new System.Windows.Forms.Button();
            this.lbl_helo = new System.Windows.Forms.Label();
            this.tbx_name = new System.Windows.Forms.TextBox();
            this.lbl_labelName = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(221, 226);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(100, 23);
            this.btn_submit.TabIndex = 0;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // lbl_helo
            // 
            this.lbl_helo.AutoSize = true;
            this.lbl_helo.Location = new System.Drawing.Point(190, 167);
            this.lbl_helo.Name = "lbl_helo";
            this.lbl_helo.Size = new System.Drawing.Size(169, 13);
            this.lbl_helo.TabIndex = 1;
            this.lbl_helo.Text = "Welcome, Please enter your name";
            // 
            // tbx_name
            // 
            this.tbx_name.Location = new System.Drawing.Point(221, 200);
            this.tbx_name.Name = "tbx_name";
            this.tbx_name.Size = new System.Drawing.Size(100, 20);
            this.tbx_name.TabIndex = 2;
            // 
            // lbl_labelName
            // 
            this.lbl_labelName.AutoSize = true;
            this.lbl_labelName.Location = new System.Drawing.Point(44, 400);
            this.lbl_labelName.Name = "lbl_labelName";
            this.lbl_labelName.Size = new System.Drawing.Size(89, 13);
            this.lbl_labelName.TabIndex = 3;
            this.lbl_labelName.Text = "This is your name";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(271, 400);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(0, 13);
            this.lbl_name.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 450);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_labelName);
            this.Controls.Add(this.tbx_name);
            this.Controls.Add(this.lbl_helo);
            this.Controls.Add(this.btn_submit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Label lbl_helo;
        private System.Windows.Forms.TextBox tbx_name;
        private System.Windows.Forms.Label lbl_labelName;
        private System.Windows.Forms.Label lbl_name;
    }
}

