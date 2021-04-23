
namespace NorthwindTest2
{
    partial class FrmUpPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUpPass));
            this.txtps1 = new System.Windows.Forms.TextBox();
            this.lblps = new System.Windows.Forms.Label();
            this.lblps1 = new System.Windows.Forms.Label();
            this.txtps2 = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.lblps2 = new System.Windows.Forms.Label();
            this.txtOldPss = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtps1
            // 
            this.txtps1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtps1.Location = new System.Drawing.Point(125, 53);
            this.txtps1.MaxLength = 20;
            this.txtps1.Name = "txtps1";
            this.txtps1.Size = new System.Drawing.Size(186, 24);
            this.txtps1.TabIndex = 1;
            // 
            // lblps
            // 
            this.lblps.AutoSize = true;
            this.lblps.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblps.Location = new System.Drawing.Point(45, 56);
            this.lblps.Name = "lblps";
            this.lblps.Size = new System.Drawing.Size(74, 18);
            this.lblps.TabIndex = 42;
            this.lblps.Text = "Yeni Şifre:";
            // 
            // lblps1
            // 
            this.lblps1.AutoSize = true;
            this.lblps1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblps1.Location = new System.Drawing.Point(27, 94);
            this.lblps1.Name = "lblps1";
            this.lblps1.Size = new System.Drawing.Size(92, 18);
            this.lblps1.TabIndex = 42;
            this.lblps1.Text = "Şifre Tekrarı:";
            // 
            // txtps2
            // 
            this.txtps2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtps2.Location = new System.Drawing.Point(125, 91);
            this.txtps2.MaxLength = 20;
            this.txtps2.Name = "txtps2";
            this.txtps2.Size = new System.Drawing.Size(186, 24);
            this.txtps2.TabIndex = 2;
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
            this.btnsave.TabIndex = 3;
            this.btnsave.Text = "Şifreyi Kaydet";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            this.btnsave.MouseEnter += new System.EventHandler(this.btnsave_MouseEnter);
            this.btnsave.MouseLeave += new System.EventHandler(this.btnsave_MouseLeave);
            // 
            // lblps2
            // 
            this.lblps2.AutoSize = true;
            this.lblps2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblps2.Location = new System.Drawing.Point(25, 20);
            this.lblps2.Name = "lblps2";
            this.lblps2.Size = new System.Drawing.Size(94, 18);
            this.lblps2.TabIndex = 42;
            this.lblps2.Text = "Mevcut Şifre:";
            // 
            // txtOldPss
            // 
            this.txtOldPss.Enabled = false;
            this.txtOldPss.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOldPss.Location = new System.Drawing.Point(125, 17);
            this.txtOldPss.MaxLength = 20;
            this.txtOldPss.Name = "txtOldPss";
            this.txtOldPss.Size = new System.Drawing.Size(186, 24);
            this.txtOldPss.TabIndex = 41;
            // 
            // FrmUpPass
            // 
            this.AcceptButton = this.btnsave;
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
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmUpPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Şifre Değiştirme";
            this.Load += new System.EventHandler(this.FrmUpPass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtps1;
        private System.Windows.Forms.Label lblps;
        private System.Windows.Forms.Label lblps1;
        public System.Windows.Forms.TextBox txtps2;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label lblps2;
        public System.Windows.Forms.TextBox txtOldPss;
    }
}