
namespace QLTVT.SubForm
{
    partial class FrmBranchTransfer
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
            this.cmbBranch = new System.Windows.Forms.ComboBox();
            this.btnComfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(162, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "BRANCH TRANSFER";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbBranch
            // 
            this.cmbBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBranch.FormattingEnabled = true;
            this.cmbBranch.Location = new System.Drawing.Point(168, 139);
            this.cmbBranch.Name = "cmbBranch";
            this.cmbBranch.Size = new System.Drawing.Size(280, 24);
            this.cmbBranch.TabIndex = 4;
            // 
            // btnComfirm
            // 
            this.btnComfirm.BackColor = System.Drawing.Color.Lime;
            this.btnComfirm.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnComfirm.ForeColor = System.Drawing.Color.White;
            this.btnComfirm.Location = new System.Drawing.Point(168, 224);
            this.btnComfirm.Name = "btnComfirm";
            this.btnComfirm.Size = new System.Drawing.Size(280, 53);
            this.btnComfirm.TabIndex = 5;
            this.btnComfirm.Text = "CONFIRM";
            this.btnComfirm.UseVisualStyleBackColor = false;
            this.btnComfirm.Click += new System.EventHandler(this.btnComfirm_Click);
            // 
            // FrmBranchTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 377);
            this.Controls.Add(this.btnComfirm);
            this.Controls.Add(this.cmbBranch);
            this.Controls.Add(this.label1);
            this.Name = "FrmBranchTransfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Branch Transfer";
            this.Load += new System.EventHandler(this.FrmBranchTransfer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBranch;
        private System.Windows.Forms.Button btnComfirm;
    }
}