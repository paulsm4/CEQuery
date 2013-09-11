namespace WindowsFormsApplication1
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
            this.label1 = new System.Windows.Forms.Label();
            this.edtCeUri = new System.Windows.Forms.TextBox();
            this.edtObjectStore = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.edtCeUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.edtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.edtCeQuery = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.edtStatus = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbSampleQueries = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CE URL:";
            // 
            // edtCeUri
            // 
            this.edtCeUri.Location = new System.Drawing.Point(12, 29);
            this.edtCeUri.Name = "edtCeUri";
            this.edtCeUri.Size = new System.Drawing.Size(279, 20);
            this.edtCeUri.TabIndex = 1;
            this.edtCeUri.Text = "http://RGBFileNet451:9080/wsi/FNCEWS40MTOM/";
            // 
            // edtObjectStore
            // 
            this.edtObjectStore.Location = new System.Drawing.Point(330, 29);
            this.edtObjectStore.Name = "edtObjectStore";
            this.edtObjectStore.Size = new System.Drawing.Size(120, 20);
            this.edtObjectStore.TabIndex = 3;
            this.edtObjectStore.Text = "OS3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Object Store:";
            // 
            // edtCeUser
            // 
            this.edtCeUser.Location = new System.Drawing.Point(489, 29);
            this.edtCeUser.Name = "edtCeUser";
            this.edtCeUser.Size = new System.Drawing.Size(120, 20);
            this.edtCeUser.TabIndex = 5;
            this.edtCeUser.Text = "p8admin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(486, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CE User:";
            // 
            // edtPassword
            // 
            this.edtPassword.Location = new System.Drawing.Point(649, 29);
            this.edtPassword.Name = "edtPassword";
            this.edtPassword.PasswordChar = '*';
            this.edtPassword.Size = new System.Drawing.Size(120, 20);
            this.edtPassword.TabIndex = 7;
            this.edtPassword.Text = "p8admin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(645, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password:";
            // 
            // edtCeQuery
            // 
            this.edtCeQuery.Location = new System.Drawing.Point(12, 143);
            this.edtCeQuery.Multiline = true;
            this.edtCeQuery.Name = "edtCeQuery";
            this.edtCeQuery.Size = new System.Drawing.Size(754, 57);
            this.edtCeQuery.TabIndex = 9;
            this.edtCeQuery.Text = "select d.[DocumentTitle] from Document d where IsOfClass(d, StoredSearch)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "CE Query:";
            // 
            // edtStatus
            // 
            this.edtStatus.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtStatus.Location = new System.Drawing.Point(12, 231);
            this.edtStatus.Multiline = true;
            this.edtStatus.Name = "edtStatus";
            this.edtStatus.ReadOnly = true;
            this.edtStatus.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.edtStatus.Size = new System.Drawing.Size(757, 179);
            this.edtStatus.TabIndex = 11;
            this.edtStatus.WordWrap = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Status:";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(347, 416);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(101, 38);
            this.btnGo.TabIndex = 12;
            this.btnGo.Text = "&Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Sample Queries:";
            // 
            // cbSampleQueries
            // 
            this.cbSampleQueries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSampleQueries.FormattingEnabled = true;
            this.cbSampleQueries.Location = new System.Drawing.Point(12, 77);
            this.cbSampleQueries.Name = "cbSampleQueries";
            this.cbSampleQueries.Size = new System.Drawing.Size(754, 21);
            this.cbSampleQueries.TabIndex = 15;
            this.cbSampleQueries.SelectedIndexChanged += new System.EventHandler(this.cbSampleQueries_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 457);
            this.Controls.Add(this.cbSampleQueries);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.edtStatus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.edtCeQuery);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.edtPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.edtCeUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.edtObjectStore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edtCeUri);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "CEQuery";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edtCeUri;
        private System.Windows.Forms.TextBox edtObjectStore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edtCeUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox edtCeQuery;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox edtStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbSampleQueries;
    }
}

