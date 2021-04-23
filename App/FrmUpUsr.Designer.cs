
namespace NorthwindTest2
{
    partial class FrmUpUsr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUpUsr));
            this.btnsave = new System.Windows.Forms.Button();
            this.txtconttitle = new System.Windows.Forms.TextBox();
            this.txtcontname = new System.Windows.Forms.TextBox();
            this.txtcompname = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblcontitle = new System.Windows.Forms.Label();
            this.lblcontname = new System.Windows.Forms.Label();
            this.lblcompname = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnsave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsave.Location = new System.Drawing.Point(0, 156);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(334, 35);
            this.btnsave.TabIndex = 35;
            this.btnsave.Text = "Güncelle";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            this.btnsave.MouseEnter += new System.EventHandler(this.btnsave_MouseEnter);
            this.btnsave.MouseLeave += new System.EventHandler(this.btnsave_MouseLeave);
            // 
            // txtconttitle
            // 
            this.txtconttitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtconttitle.Location = new System.Drawing.Point(136, 112);
            this.txtconttitle.Name = "txtconttitle";
            this.txtconttitle.Size = new System.Drawing.Size(186, 24);
            this.txtconttitle.TabIndex = 34;
            // 
            // txtcontname
            // 
            this.txtcontname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtcontname.Location = new System.Drawing.Point(136, 80);
            this.txtcontname.Name = "txtcontname";
            this.txtcontname.Size = new System.Drawing.Size(186, 24);
            this.txtcontname.TabIndex = 33;
            // 
            // txtcompname
            // 
            this.txtcompname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtcompname.Location = new System.Drawing.Point(136, 48);
            this.txtcompname.Name = "txtcompname";
            this.txtcompname.Size = new System.Drawing.Size(186, 24);
            this.txtcompname.TabIndex = 32;
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtid.Location = new System.Drawing.Point(136, 16);
            this.txtid.MaxLength = 5;
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(186, 24);
            this.txtid.TabIndex = 36;
            // 
            // lblcontitle
            // 
            this.lblcontitle.AutoSize = true;
            this.lblcontitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblcontitle.Location = new System.Drawing.Point(32, 115);
            this.lblcontitle.Name = "lblcontitle";
            this.lblcontitle.Size = new System.Drawing.Size(95, 18);
            this.lblcontitle.TabIndex = 38;
            this.lblcontitle.Text = "Contact Title:";
            // 
            // lblcontname
            // 
            this.lblcontname.AutoSize = true;
            this.lblcontname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblcontname.Location = new System.Drawing.Point(20, 83);
            this.lblcontname.Name = "lblcontname";
            this.lblcontname.Size = new System.Drawing.Size(108, 18);
            this.lblcontname.TabIndex = 37;
            this.lblcontname.Text = "Contact Name:";
            // 
            // lblcompname
            // 
            this.lblcompname.AutoSize = true;
            this.lblcompname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblcompname.Location = new System.Drawing.Point(10, 51);
            this.lblcompname.Name = "lblcompname";
            this.lblcompname.Size = new System.Drawing.Size(120, 18);
            this.lblcompname.TabIndex = 39;
            this.lblcompname.Text = "Company Name:";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblid.Location = new System.Drawing.Point(32, 19);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(96, 18);
            this.lblid.TabIndex = 40;
            this.lblid.Text = "Customer ID:";
            // 
            // FrmUpUsr
            // 
            this.AcceptButton = this.btnsave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(334, 191);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtconttitle);
            this.Controls.Add(this.txtcontname);
            this.Controls.Add(this.txtcompname);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lblcontitle);
            this.Controls.Add(this.lblcontname);
            this.Controls.Add(this.lblcompname);
            this.Controls.Add(this.lblid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmUpUsr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kişisel Bilgilerim";
            this.Load += new System.EventHandler(this.FrmUpUsr_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsave;
        public System.Windows.Forms.TextBox txtconttitle;
        public System.Windows.Forms.TextBox txtcontname;
        public System.Windows.Forms.TextBox txtcompname;
        public System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblcontitle;
        private System.Windows.Forms.Label lblcontname;
        private System.Windows.Forms.Label lblcompname;
        private System.Windows.Forms.Label lblid;
    }
}