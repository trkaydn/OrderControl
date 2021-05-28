
namespace NorthwindTest2
{
    partial class FrmNewAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNewAdmin));
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtcountry = new System.Windows.Forms.TextBox();
            this.txtpostalcode = new System.Windows.Forms.TextBox();
            this.txtregion = new System.Windows.Forms.TextBox();
            this.txtcity = new System.Windows.Forms.TextBox();
            this.txtadress = new System.Windows.Forms.TextBox();
            this.txttitle = new System.Windows.Forms.TextBox();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.lblconutry = new System.Windows.Forms.Label();
            this.lblpostalcd = new System.Windows.Forms.Label();
            this.lblregion = new System.Windows.Forms.Label();
            this.lblcity = new System.Windows.Forms.Label();
            this.lbladdress = new System.Windows.Forms.Label();
            this.lblcontitle = new System.Windows.Forms.Label();
            this.lblcontname = new System.Windows.Forms.Label();
            this.lblcompname = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.dateTimeBirth = new System.Windows.Forms.DateTimePicker();
            this.dateTimeHire = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.TxtNotes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.lblphone = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSave.Location = new System.Drawing.Point(361, 282);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(144, 46);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Kayıt Ol";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseEnter += new System.EventHandler(this.btnSave_MouseEnter);
            this.btnSave.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPassword.Location = new System.Drawing.Point(95, 51);
            this.txtPassword.MaxLength = 0;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(144, 22);
            this.txtPassword.TabIndex = 14;
            // 
            // txtcountry
            // 
            this.txtcountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtcountry.Location = new System.Drawing.Point(361, 209);
            this.txtcountry.MaxLength = 0;
            this.txtcountry.Name = "txtcountry";
            this.txtcountry.Size = new System.Drawing.Size(144, 22);
            this.txtcountry.TabIndex = 12;
            // 
            // txtpostalcode
            // 
            this.txtpostalcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtpostalcode.Location = new System.Drawing.Point(361, 177);
            this.txtpostalcode.MaxLength = 0;
            this.txtpostalcode.Name = "txtpostalcode";
            this.txtpostalcode.Size = new System.Drawing.Size(144, 22);
            this.txtpostalcode.TabIndex = 11;
            // 
            // txtregion
            // 
            this.txtregion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtregion.Location = new System.Drawing.Point(361, 145);
            this.txtregion.MaxLength = 0;
            this.txtregion.Name = "txtregion";
            this.txtregion.Size = new System.Drawing.Size(144, 22);
            this.txtregion.TabIndex = 10;
            // 
            // txtcity
            // 
            this.txtcity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtcity.Location = new System.Drawing.Point(361, 110);
            this.txtcity.MaxLength = 0;
            this.txtcity.Name = "txtcity";
            this.txtcity.Size = new System.Drawing.Size(144, 22);
            this.txtcity.TabIndex = 9;
            // 
            // txtadress
            // 
            this.txtadress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtadress.Location = new System.Drawing.Point(361, 51);
            this.txtadress.MaxLength = 0;
            this.txtadress.Multiline = true;
            this.txtadress.Name = "txtadress";
            this.txtadress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtadress.Size = new System.Drawing.Size(144, 44);
            this.txtadress.TabIndex = 8;
            // 
            // txttitle
            // 
            this.txttitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txttitle.Location = new System.Drawing.Point(113, 83);
            this.txttitle.MaxLength = 0;
            this.txttitle.Name = "txttitle";
            this.txttitle.Size = new System.Drawing.Size(144, 22);
            this.txttitle.TabIndex = 3;
            this.txttitle.Tag = "tag1";
            // 
            // txtlname
            // 
            this.txtlname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtlname.Location = new System.Drawing.Point(113, 51);
            this.txtlname.MaxLength = 0;
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(144, 22);
            this.txtlname.TabIndex = 2;
            this.txtlname.Tag = "tag1";
            // 
            // txtfname
            // 
            this.txtfname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtfname.Location = new System.Drawing.Point(113, 19);
            this.txtfname.MaxLength = 0;
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(144, 22);
            this.txtfname.TabIndex = 1;
            this.txtfname.Tag = "tag1";
            // 
            // lblconutry
            // 
            this.lblconutry.AutoSize = true;
            this.lblconutry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblconutry.Location = new System.Drawing.Point(313, 212);
            this.lblconutry.Name = "lblconutry";
            this.lblconutry.Size = new System.Drawing.Size(39, 16);
            this.lblconutry.TabIndex = 44;
            this.lblconutry.Text = "Ülke:";
            // 
            // lblpostalcd
            // 
            this.lblpostalcd.AutoSize = true;
            this.lblpostalcd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblpostalcd.Location = new System.Drawing.Point(275, 180);
            this.lblpostalcd.Name = "lblpostalcd";
            this.lblpostalcd.Size = new System.Drawing.Size(80, 16);
            this.lblpostalcd.TabIndex = 43;
            this.lblpostalcd.Text = "Posta Kodu:";
            // 
            // lblregion
            // 
            this.lblregion.AutoSize = true;
            this.lblregion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblregion.Location = new System.Drawing.Point(308, 148);
            this.lblregion.Name = "lblregion";
            this.lblregion.Size = new System.Drawing.Size(47, 16);
            this.lblregion.TabIndex = 42;
            this.lblregion.Text = "Bölge:";
            // 
            // lblcity
            // 
            this.lblcity.AutoSize = true;
            this.lblcity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblcity.Location = new System.Drawing.Point(313, 113);
            this.lblcity.Name = "lblcity";
            this.lblcity.Size = new System.Drawing.Size(42, 16);
            this.lblcity.TabIndex = 41;
            this.lblcity.Text = "Şehir:";
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbladdress.Location = new System.Drawing.Point(308, 54);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(47, 16);
            this.lbladdress.TabIndex = 40;
            this.lbladdress.Text = "Adres:";
            // 
            // lblcontitle
            // 
            this.lblcontitle.AutoSize = true;
            this.lblcontitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblcontitle.Location = new System.Drawing.Point(15, 122);
            this.lblcontitle.Name = "lblcontitle";
            this.lblcontitle.Size = new System.Drawing.Size(92, 16);
            this.lblcontitle.TabIndex = 39;
            this.lblcontitle.Text = "Doğum Tarihi:";
            // 
            // lblcontname
            // 
            this.lblcontname.AutoSize = true;
            this.lblcontname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblcontname.Location = new System.Drawing.Point(52, 86);
            this.lblcontname.Name = "lblcontname";
            this.lblcontname.Size = new System.Drawing.Size(55, 16);
            this.lblcontname.TabIndex = 38;
            this.lblcontname.Text = "Meslek:";
            // 
            // lblcompname
            // 
            this.lblcompname.AutoSize = true;
            this.lblcompname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblcompname.Location = new System.Drawing.Point(48, 54);
            this.lblcompname.Name = "lblcompname";
            this.lblcompname.Size = new System.Drawing.Size(59, 16);
            this.lblcompname.TabIndex = 48;
            this.lblcompname.Text = "Soyisim:";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblid.Location = new System.Drawing.Point(72, 22);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(35, 16);
            this.lblid.TabIndex = 49;
            this.lblid.Text = "İsim:";
            // 
            // dateTimeBirth
            // 
            this.dateTimeBirth.Location = new System.Drawing.Point(113, 118);
            this.dateTimeBirth.Name = "dateTimeBirth";
            this.dateTimeBirth.Size = new System.Drawing.Size(144, 20);
            this.dateTimeBirth.TabIndex = 4;
            // 
            // dateTimeHire
            // 
            this.dateTimeHire.Location = new System.Drawing.Point(113, 152);
            this.dateTimeHire.Name = "dateTimeHire";
            this.dateTimeHire.Size = new System.Drawing.Size(144, 20);
            this.dateTimeHire.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(11, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 39;
            this.label1.Text = "İşe Giriş Tarihi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(34, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 47;
            this.label2.Text = "Hakkımda:";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUserName.Location = new System.Drawing.Point(95, 23);
            this.txtUserName.MaxLength = 0;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(144, 22);
            this.txtUserName.TabIndex = 13;
            // 
            // TxtNotes
            // 
            this.TxtNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtNotes.Location = new System.Drawing.Point(113, 186);
            this.TxtNotes.MaxLength = 0;
            this.TxtNotes.Multiline = true;
            this.TxtNotes.Name = "TxtNotes";
            this.TxtNotes.Size = new System.Drawing.Size(144, 44);
            this.TxtNotes.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(51, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 47;
            this.label3.Text = "Şifre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 47;
            this.label4.Text = "Kullanıcı Adı:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(16, 245);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 83);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sisteme Girişte Kullanılacak:";
            // 
            // txtphone
            // 
            this.txtphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtphone.Location = new System.Drawing.Point(361, 19);
            this.txtphone.MaxLength = 0;
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(144, 22);
            this.txtphone.TabIndex = 7;
            // 
            // lblphone
            // 
            this.lblphone.AutoSize = true;
            this.lblphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblphone.Location = new System.Drawing.Point(298, 22);
            this.lblphone.Name = "lblphone";
            this.lblphone.Size = new System.Drawing.Size(57, 16);
            this.lblphone.TabIndex = 65;
            this.lblphone.Text = "Telefon:";
            // 
            // FrmNewAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(518, 340);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.lblphone);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TxtNotes);
            this.Controls.Add(this.dateTimeHire);
            this.Controls.Add(this.dateTimeBirth);
            this.Controls.Add(this.txtcountry);
            this.Controls.Add(this.txtpostalcode);
            this.Controls.Add(this.txtregion);
            this.Controls.Add(this.txtcity);
            this.Controls.Add(this.txtadress);
            this.Controls.Add(this.txttitle);
            this.Controls.Add(this.txtlname);
            this.Controls.Add(this.txtfname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblconutry);
            this.Controls.Add(this.lblpostalcd);
            this.Controls.Add(this.lblregion);
            this.Controls.Add(this.lblcity);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblcontitle);
            this.Controls.Add(this.lblcontname);
            this.Controls.Add(this.lblcompname);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.btnSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmNewAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Yeni Admin Kaydı";
            this.Load += new System.EventHandler(this.FrmNewAdmin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.TextBox txtPassword;
        public System.Windows.Forms.TextBox txtcountry;
        public System.Windows.Forms.TextBox txtpostalcode;
        public System.Windows.Forms.TextBox txtregion;
        public System.Windows.Forms.TextBox txtcity;
        public System.Windows.Forms.TextBox txtadress;
        public System.Windows.Forms.TextBox txttitle;
        public System.Windows.Forms.TextBox txtlname;
        public System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.Label lblconutry;
        private System.Windows.Forms.Label lblpostalcd;
        private System.Windows.Forms.Label lblregion;
        private System.Windows.Forms.Label lblcity;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.Label lblcontitle;
        private System.Windows.Forms.Label lblcontname;
        private System.Windows.Forms.Label lblcompname;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.DateTimePicker dateTimeBirth;
        private System.Windows.Forms.DateTimePicker dateTimeHire;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtUserName;
        public System.Windows.Forms.TextBox TxtNotes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.Label lblphone;
    }
}