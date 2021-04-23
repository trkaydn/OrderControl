
namespace NorthwindTest2
{
    partial class FrmAdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminLogin));
            this.btnLogin = new System.Windows.Forms.Button();
            this.TxtAdminPass = new System.Windows.Forms.TextBox();
            this.txtAdminUsrNm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNewCst = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.PaleGreen;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogin.Location = new System.Drawing.Point(150, 86);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(92, 36);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Giriş Yap";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.MouseEnter += new System.EventHandler(this.button3_MouseEnter);
            this.btnLogin.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
            // 
            // TxtAdminPass
            // 
            this.TxtAdminPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAdminPass.Location = new System.Drawing.Point(96, 53);
            this.TxtAdminPass.MaxLength = 20;
            this.TxtAdminPass.Name = "TxtAdminPass";
            this.TxtAdminPass.Size = new System.Drawing.Size(146, 24);
            this.TxtAdminPass.TabIndex = 2;
            // 
            // txtAdminUsrNm
            // 
            this.txtAdminUsrNm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdminUsrNm.Location = new System.Drawing.Point(96, 18);
            this.txtAdminUsrNm.MaxLength = 5;
            this.txtAdminUsrNm.Name = "txtAdminUsrNm";
            this.txtAdminUsrNm.Size = new System.Drawing.Size(146, 24);
            this.txtAdminUsrNm.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(41, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Admin ID:";
            // 
            // btnNewCst
            // 
            this.btnNewCst.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnNewCst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewCst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNewCst.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNewCst.Location = new System.Drawing.Point(8, 86);
            this.btnNewCst.Name = "btnNewCst";
            this.btnNewCst.Size = new System.Drawing.Size(96, 36);
            this.btnNewCst.TabIndex = 4;
            this.btnNewCst.Text = "Yönetici Kayıt";
            this.btnNewCst.UseVisualStyleBackColor = false;
            this.btnNewCst.Click += new System.EventHandler(this.btnNewCst_Click);
            this.btnNewCst.MouseEnter += new System.EventHandler(this.btnNewCst_MouseEnter);
            this.btnNewCst.MouseLeave += new System.EventHandler(this.btnNewCst_MouseLeave);
            // 
            // FrmAdminLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(264, 131);
            this.Controls.Add(this.btnNewCst);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.TxtAdminPass);
            this.Controls.Add(this.txtAdminUsrNm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Admin Girişi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox TxtAdminPass;
        private System.Windows.Forms.TextBox txtAdminUsrNm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnNewCst;
    }
}