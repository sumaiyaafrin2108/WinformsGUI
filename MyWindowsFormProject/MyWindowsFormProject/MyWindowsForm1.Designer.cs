namespace MyWindowsFormProject
{
    partial class FrmRegistrationForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.cboNationality = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rtbAddress = new System.Windows.Forms.RichTextBox();
            this.pbProfileImage = new System.Windows.Forms.PictureBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.DBInsert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfileImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "DOB :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gender :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nationality :";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(134, 48);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(140, 20);
            this.txtStudentID.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(134, 90);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(229, 20);
            this.txtName.TabIndex = 6;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(134, 135);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(200, 20);
            this.dtpDOB.TabIndex = 7;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(134, 175);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(48, 17);
            this.rbMale.TabIndex = 8;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(240, 175);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(59, 17);
            this.rbFemale.TabIndex = 9;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // cboNationality
            // 
            this.cboNationality.FormattingEnabled = true;
            this.cboNationality.Location = new System.Drawing.Point(134, 218);
            this.cboNationality.Name = "cboNationality";
            this.cboNationality.Size = new System.Drawing.Size(200, 21);
            this.cboNationality.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(49, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Address :";
            // 
            // rtbAddress
            // 
            this.rtbAddress.Location = new System.Drawing.Point(134, 275);
            this.rtbAddress.Name = "rtbAddress";
            this.rtbAddress.Size = new System.Drawing.Size(200, 96);
            this.rtbAddress.TabIndex = 12;
            this.rtbAddress.Text = "";
            // 
            // pbProfileImage
            // 
            this.pbProfileImage.Location = new System.Drawing.Point(443, 48);
            this.pbProfileImage.Name = "pbProfileImage";
            this.pbProfileImage.Size = new System.Drawing.Size(143, 129);
            this.pbProfileImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProfileImage.TabIndex = 13;
            this.pbProfileImage.TabStop = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(519, 201);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 14;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(190, 405);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 15;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // rtbOutput
            // 
            this.rtbOutput.Location = new System.Drawing.Point(443, 278);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(174, 151);
            this.rtbOutput.TabIndex = 16;
            this.rtbOutput.Text = "";
            // 
            // DBInsert
            // 
            this.DBInsert.Location = new System.Drawing.Point(287, 446);
            this.DBInsert.Name = "DBInsert";
            this.DBInsert.Size = new System.Drawing.Size(75, 23);
            this.DBInsert.TabIndex = 17;
            this.DBInsert.Text = "DBINSERT";
            this.DBInsert.UseVisualStyleBackColor = true;
            this.DBInsert.Click += new System.EventHandler(this.dbinsert_Click);
            // 
            // FrmRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(629, 507);
            this.Controls.Add(this.DBInsert);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.pbProfileImage);
            this.Controls.Add(this.rtbAddress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboNationality);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name = "FrmRegistrationForm";
            this.Text = "REGISTRATION FORM";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbProfileImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.ComboBox cboNationality;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtbAddress;
        private System.Windows.Forms.PictureBox pbProfileImage;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Button DBInsert;
    }
}

