
namespace NorthwindTest2
{
    partial class FrmUpAdminPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUpAdminPass));
            this.btnsave = new System.Windows.Forms.Button();
            this.txtps2 = new System.Windows.Forms.TextBox();
            this.lblps1 = new System.Windows.Forms.Label();
            this.txtOldPss = new System.Windows.Forms.TextBox();
            this.txtps1 = new System.Windows.Forms.TextBox();
            this.lblps2 = new System.Windows.Forms.Label();
            this.lblps = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnsave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsave.Location = new System.Drawing.Point(0, 126);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(334, 35);
            this.btnsave.TabIndex = 45;
            this.btnsave.Text = "Şifreyi Kaydet";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            this.btnsave.MouseEnter += new System.EventHandler(this.btnsave_MouseEnter);
            this.btnsave.MouseLeave += new System.EventHandler(this.btnsave_MouseLeave);
            // 
            // txtps2
            // 
            this.txtps2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtps2.Location = new System.Drawing.Point(125, 90);
            this.txtps2.MaxLength = 20;
            this.txtps2.Name = "txtps2";
            this.txtps2.Size = new System.Drawing.Size(186, 24);
            this.txtps2.TabIndex = 44;
            // 
            // lblps1
            // 
            this.lblps1.AutoSize = true;
            this.lblps1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblps1.Location = new System.Drawing.Point(27, 93);
            this.lblps1.Name = "lblps1";
            this.lblps1.Size = new System.Drawing.Size(92, 18);
            this.lblps1.TabIndex = 47;
            this.lblps1.Text = "Şifre Tekrarı:";
            // 
            // txtOldPss
            // 
            this.txtOldPss.Enabled = false;
            this.txtOldPss.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOldPss.Location = new System.Drawing.Point(125, 16);
            this.txtOldPss.MaxLength = 20;
            this.txtOldPss.Name = "txtOldPss";
            this.txtOldPss.Size = new System.Drawing.Size(186, 24);
            this.txtOldPss.TabIndex = 46;
            // 
            // txtps1
            // 
            this.txtps1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtps1.Location = new System.Drawing.Point(125, 52);
            this.txtps1.MaxLength = 20;
            this.txtps1.Name = "txtps1";
            this.txtps1.Size = new System.Drawing.Size(186, 24);
            this.txtps1.TabIndex = 43;
            // 
            // lblps2
            // 
            this.lblps2.AutoSize = true;
            this.lblps2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblps2.Location = new System.Drawing.Point(25, 19);
            this.lblps2.Name = "lblps2";
            this.lblps2.Size = new System.Drawing.Size(94, 18);
            this.lblps2.TabIndex = 48;
            this.lblps2.Text = "Mevcut Şifre:";
            // 
            // lblps
            // 
            this.lblps.AutoSize = true;
            this.lblps.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblps.Location = new System.Drawing.Point(45, 55);
            this.lblps.Name = "lblps";
            this.lblps.Size = new System.Drawing.Size(74, 18);
            this.lblps.TabIndex = 49;
            this.lblps.Text = "Yeni Şifre:";
            // 
            // FrmUpAdminPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(334, 161);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtps2);
            this.Controls.Add(this.lblps1);
            this.Controls.Add(this.txtOldPss);
            this.Controls.Add(this.txtps1);
            this.Controls.Add(this.lblps2);
            this.Controls.Add(this.lblps);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmUpAdminPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Şifre Değiştirme";
            this.Load += new System.EventHandler(this.FrmUpAdminPass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsave;
        public System.Windows.Forms.TextBox txtps2;
        private System.Windows.Forms.Label lblps1;
        public System.Windows.Forms.TextBox txtOldPss;
        public System.Windows.Forms.TextBox txtps1;
        private System.Windows.Forms.Label lblps2;
        private System.Windows.Forms.Label lblps;
    }
}