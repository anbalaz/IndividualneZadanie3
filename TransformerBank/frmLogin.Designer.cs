namespace TransformerBank
{
    partial class frmLogin
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.confirmButtonbttn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nmrcTxtBxLogin = new Controls.NumericTextBox();
            this.nmrcTxtBxPassword = new Controls.NumericTextBox();
            this.bttnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Login";
            // 
            // confirmButtonbttn
            // 
            this.confirmButtonbttn.Location = new System.Drawing.Point(252, 188);
            this.confirmButtonbttn.Name = "confirmButtonbttn";
            this.confirmButtonbttn.Size = new System.Drawing.Size(75, 23);
            this.confirmButtonbttn.TabIndex = 5;
            this.confirmButtonbttn.Text = "OK";
            this.confirmButtonbttn.UseVisualStyleBackColor = true;
            this.confirmButtonbttn.Click += new System.EventHandler(this.confirmButtonbttn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(364, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "WELCOME, PLEASE INSERT NAME CARD NUMBER AND PASSWORD ";
            // 
            // nmrcTxtBxLogin
            // 
            this.nmrcTxtBxLogin.Location = new System.Drawing.Point(149, 86);
            this.nmrcTxtBxLogin.Name = "nmrcTxtBxLogin";
            this.nmrcTxtBxLogin.Size = new System.Drawing.Size(100, 20);
            this.nmrcTxtBxLogin.TabIndex = 11;
            // 
            // nmrcTxtBxPassword
            // 
            this.nmrcTxtBxPassword.Location = new System.Drawing.Point(149, 127);
            this.nmrcTxtBxPassword.Name = "nmrcTxtBxPassword";
            this.nmrcTxtBxPassword.Size = new System.Drawing.Size(100, 20);
            this.nmrcTxtBxPassword.TabIndex = 12;
            // 
            // bttnCancel
            // 
            this.bttnCancel.Location = new System.Drawing.Point(104, 188);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.Size = new System.Drawing.Size(75, 23);
            this.bttnCancel.TabIndex = 13;
            this.bttnCancel.Text = "Cancel";
            this.bttnCancel.UseVisualStyleBackColor = true;
            this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 279);
            this.Controls.Add(this.bttnCancel);
            this.Controls.Add(this.nmrcTxtBxPassword);
            this.Controls.Add(this.nmrcTxtBxLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confirmButtonbttn);
            this.Name = "frmLogin";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button confirmButtonbttn;
        private System.Windows.Forms.Label label3;
        private Controls.NumericTextBox nmrcTxtBxLogin;
        private Controls.NumericTextBox nmrcTxtBxPassword;
        private System.Windows.Forms.Button bttnCancel;
    }
}