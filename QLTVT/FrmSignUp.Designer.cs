
namespace QLTVT
{
    partial class FrmSignUp
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtStaffID = new DevExpress.XtraEditors.TextEdit();
            this.btnStaff = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new DevExpress.XtraEditors.TextEdit();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rdBranch = new System.Windows.Forms.RadioButton();
            this.rdUser = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtStaffID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfirmPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(247, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign Up";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "Staff ID :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtStaffID
            // 
            this.txtStaffID.Enabled = false;
            this.txtStaffID.Location = new System.Drawing.Point(270, 102);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(142, 22);
            this.txtStaffID.TabIndex = 18;
            this.txtStaffID.EditValueChanged += new System.EventHandler(this.txtMaNhanVien_EditValueChanged);
            // 
            // btnStaff
            // 
            this.btnStaff.Location = new System.Drawing.Point(443, 92);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(155, 42);
            this.btnStaff.TabIndex = 19;
            this.btnStaff.Text = "Staff";
            this.btnStaff.UseVisualStyleBackColor = true;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 164);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 21);
            this.label4.TabIndex = 20;
            this.label4.Text = "Password :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(83, 219);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 21);
            this.label5.TabIndex = 21;
            this.label5.Text = "Confirm Password :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.EditValue = "123456";
            this.txtConfirmPassword.Location = new System.Drawing.Point(270, 220);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Properties.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(142, 22);
            this.txtConfirmPassword.TabIndex = 22;
            this.txtConfirmPassword.EditValueChanged += new System.EventHandler(this.txtXacNhanMatKhau_EditValueChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.EditValue = "123456";
            this.txtPassword.Location = new System.Drawing.Point(270, 161);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(142, 22);
            this.txtPassword.TabIndex = 23;
            this.txtPassword.EditValueChanged += new System.EventHandler(this.txtMatKhau_EditValueChanged);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.Lime;
            this.btnXacNhan.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.Location = new System.Drawing.Point(87, 365);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(170, 53);
            this.btnXacNhan.TabIndex = 24;
            this.btnXacNhan.Text = "OK";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Red;
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(404, 365);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(170, 53);
            this.btnThoat.TabIndex = 25;
            this.btnThoat.Text = "Cancel";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 21);
            this.label2.TabIndex = 26;
            this.label2.Text = "Role :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // rdBranch
            // 
            this.rdBranch.AutoSize = true;
            this.rdBranch.Checked = true;
            this.rdBranch.Location = new System.Drawing.Point(270, 277);
            this.rdBranch.Name = "rdBranch";
            this.rdBranch.Size = new System.Drawing.Size(67, 20);
            this.rdBranch.TabIndex = 27;
            this.rdBranch.TabStop = true;
            this.rdBranch.Text = "Branch";
            this.rdBranch.UseVisualStyleBackColor = true;
            this.rdBranch.CheckedChanged += new System.EventHandler(this.rdChiNhanh_CheckedChanged);
            // 
            // rdUser
            // 
            this.rdUser.AutoSize = true;
            this.rdUser.Location = new System.Drawing.Point(419, 277);
            this.rdUser.Name = "rdUser";
            this.rdUser.Size = new System.Drawing.Size(54, 20);
            this.rdUser.TabIndex = 28;
            this.rdUser.Text = "User";
            this.rdUser.UseVisualStyleBackColor = true;
            this.rdUser.CheckedChanged += new System.EventHandler(this.rdUser_CheckedChanged);
            // 
            // FrmSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 491);
            this.Controls.Add(this.rdUser);
            this.Controls.Add(this.rdBranch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnStaff);
            this.Controls.Add(this.txtStaffID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FrmSignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign up";
            this.Load += new System.EventHandler(this.FrmSignUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtStaffID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfirmPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtStaffID;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit txtConfirmPassword;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdBranch;
        private System.Windows.Forms.RadioButton rdUser;
    }
}