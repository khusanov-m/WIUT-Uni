namespace SimpleCalculator
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
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn_multiply = new System.Windows.Forms.Button();
            this.btn_divide = new System.Windows.Forms.Button();
            this.btn_power = new System.Windows.Forms.Button();
            this.btn_remainder = new System.Windows.Forms.Button();
            this.num_first = new System.Windows.Forms.NumericUpDown();
            this.num_second = new System.Windows.Forms.NumericUpDown();
            this.lbl_result = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.num_first)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_second)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_plus
            // 
            this.btn_plus.Location = new System.Drawing.Point(163, 111);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(75, 23);
            this.btn_plus.TabIndex = 0;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = true;
            this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
            // 
            // btn_minus
            // 
            this.btn_minus.Location = new System.Drawing.Point(257, 111);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(75, 23);
            this.btn_minus.TabIndex = 1;
            this.btn_minus.Text = "-";
            this.btn_minus.UseVisualStyleBackColor = true;
            this.btn_minus.Click += new System.EventHandler(this.btn_minus_Click);
            // 
            // btn_multiply
            // 
            this.btn_multiply.Location = new System.Drawing.Point(349, 111);
            this.btn_multiply.Name = "btn_multiply";
            this.btn_multiply.Size = new System.Drawing.Size(75, 23);
            this.btn_multiply.TabIndex = 4;
            this.btn_multiply.Text = "*";
            this.btn_multiply.UseVisualStyleBackColor = true;
            this.btn_multiply.Click += new System.EventHandler(this.btn_multiply_Click);
            // 
            // btn_divide
            // 
            this.btn_divide.Location = new System.Drawing.Point(163, 150);
            this.btn_divide.Name = "btn_divide";
            this.btn_divide.Size = new System.Drawing.Size(75, 23);
            this.btn_divide.TabIndex = 3;
            this.btn_divide.Text = "/";
            this.btn_divide.UseVisualStyleBackColor = true;
            this.btn_divide.Click += new System.EventHandler(this.btn_divide_Click);
            // 
            // btn_power
            // 
            this.btn_power.Location = new System.Drawing.Point(349, 150);
            this.btn_power.Name = "btn_power";
            this.btn_power.Size = new System.Drawing.Size(75, 23);
            this.btn_power.TabIndex = 6;
            this.btn_power.Text = "^";
            this.btn_power.UseVisualStyleBackColor = true;
            this.btn_power.Click += new System.EventHandler(this.btn_power_Click);
            // 
            // btn_remainder
            // 
            this.btn_remainder.Location = new System.Drawing.Point(257, 150);
            this.btn_remainder.Name = "btn_remainder";
            this.btn_remainder.Size = new System.Drawing.Size(75, 23);
            this.btn_remainder.TabIndex = 5;
            this.btn_remainder.Text = "%";
            this.btn_remainder.UseVisualStyleBackColor = true;
            this.btn_remainder.Click += new System.EventHandler(this.btn_remainder_Click);
            // 
            // num_first
            // 
            this.num_first.Location = new System.Drawing.Point(163, 75);
            this.num_first.Name = "num_first";
            this.num_first.Size = new System.Drawing.Size(120, 20);
            this.num_first.TabIndex = 7;
            // 
            // num_second
            // 
            this.num_second.Location = new System.Drawing.Point(304, 75);
            this.num_second.Name = "num_second";
            this.num_second.Size = new System.Drawing.Size(120, 20);
            this.num_second.TabIndex = 8;
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(265, 206);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(37, 13);
            this.lbl_result.TabIndex = 9;
            this.lbl_result.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.num_second);
            this.Controls.Add(this.num_first);
            this.Controls.Add(this.btn_power);
            this.Controls.Add(this.btn_remainder);
            this.Controls.Add(this.btn_multiply);
            this.Controls.Add(this.btn_divide);
            this.Controls.Add(this.btn_minus);
            this.Controls.Add(this.btn_plus);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.num_first)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_second)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button btn_minus;
        private System.Windows.Forms.Button btn_multiply;
        private System.Windows.Forms.Button btn_divide;
        private System.Windows.Forms.Button btn_power;
        private System.Windows.Forms.Button btn_remainder;
        private System.Windows.Forms.NumericUpDown num_first;
        private System.Windows.Forms.NumericUpDown num_second;
        private System.Windows.Forms.Label lbl_result;
    }
}

