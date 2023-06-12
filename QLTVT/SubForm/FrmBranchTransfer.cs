using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTVT.SubForm
{
    public partial class FrmBranchTransfer : DevExpress.XtraEditors.XtraForm
    {
        
        public FrmBranchTransfer()
        {
            InitializeComponent();
        }
       

        private void FrmBranchTransfer_Load(object sender, EventArgs e)
        {
            cmbBranch.DataSource  = Program.bindingSource.DataSource;
            cmbBranch.DisplayMember = "tencn";
            cmbBranch.ValueMember = "tenserver";
            cmbBranch.SelectedIndex = Program.brand;

        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        private void cmbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public delegate void MyDelegate(string chiNhanh, Form form);
        public MyDelegate branchTransfer;
        private void btnComfirm_Click(object sender, EventArgs e)
        {
            if (cmbBranch.Text.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng chọn chi nhánh", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn chuyển nhân viên này đi ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if( dialogResult == DialogResult.OK)
            {
                branchTransfer(cmbBranch.SelectedValue.ToString(), this);
            } else
            {
                return;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cCHINHANH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTHOAT_Click(object sender, EventArgs e)
        {

        }
    }
}