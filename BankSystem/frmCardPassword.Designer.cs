namespace BankSystem
{
    partial class frmCardPassword
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
            this.nmrcTxtBxPassword = new Controls.NumericTextBox();
            this.bttnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bttnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nmrcTxtBxPassword
            // 
            this.nmrcTxtBxPassword.Location = new System.Drawing.Point(80, 68);
            this.nmrcTxtBxPassword.Name = "nmrcTxtBxPassword";
            this.nmrcTxtBxPassword.Size = new System.Drawing.Size(100, 20);
            this.nmrcTxtBxPassword.TabIndex = 0;
            // 
            // bttnOK
            // 
            this.bttnOK.Location = new System.Drawing.Point(200, 66);
            this.bttnOK.Name = "bttnOK";
            this.bttnOK.Size = new System.Drawing.Size(75, 23);
            this.bttnOK.TabIndex = 1;
            this.bttnOK.Text = "OK";
            this.bttnOK.UseVisualStyleBackColor = true;
            this.bttnOK.Click += new System.EventHandler(this.bttnOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please insert password";
            // 
            // bttnCancel
            // 
            this.bttnCancel.Location = new System.Drawing.Point(200, 108);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.Size = new System.Drawing.Size(75, 23);
            this.bttnCancel.TabIndex = 3;
            this.bttnCancel.Text = "Cancel";
            this.bttnCancel.UseVisualStyleBackColor = true;
            // 
            // frmCardPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 157);
            this.ControlBox = false;
            this.Controls.Add(this.bttnCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttnOK);
            this.Controls.Add(this.nmrcTxtBxPassword);
            this.Name = "frmCardPassword";
            this.Text = "frmCardPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.NumericTextBox nmrcTxtBxPassword;
        private System.Windows.Forms.Button bttnOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttnCancel;
    }
}