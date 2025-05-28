namespace ContactList
{
    partial class AddContactForm
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.btnluu = new System.Windows.Forms.Button();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(242, 128);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(112, 26);
            this.txtName.TabIndex = 0;
            this.txtName.Text = "Họ Tên";
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(354, 197);
            this.txtsdt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(112, 26);
            this.txtsdt.TabIndex = 1;
            this.txtsdt.Text = "Số Điện Thoại";
            this.txtsdt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(354, 324);
            this.btnluu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(112, 45);
            this.btnluu.TabIndex = 2;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(473, 128);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(100, 26);
            this.txtemail.TabIndex = 3;
            this.txtemail.Text = "Email";
            this.txtemail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.txtsdt);
            this.Controls.Add(this.txtName);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddContactForm";
            this.Text = "AddContactForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.TextBox txtemail;
    }
}