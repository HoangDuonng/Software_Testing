namespace WindowsFormsApp1
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
            this.button_11_HoangNongDuong = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_11_HoangNongDuong
            // 
            this.button_11_HoangNongDuong.Location = new System.Drawing.Point(219, 145);
            this.button_11_HoangNongDuong.Margin = new System.Windows.Forms.Padding(2);
            this.button_11_HoangNongDuong.Name = "button_11_HoangNongDuong";
            this.button_11_HoangNongDuong.Size = new System.Drawing.Size(130, 29);
            this.button_11_HoangNongDuong.TabIndex = 0;
            this.button_11_HoangNongDuong.Text = "Element HTML";
            this.button_11_HoangNongDuong.UseVisualStyleBackColor = true;
            this.button_11_HoangNongDuong.Click += new System.EventHandler(this.button_11_HoangNongDuong_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_11_HoangNongDuong);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_11_HoangNongDuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

