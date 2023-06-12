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
    public partial class FrmSelectMaterial : Form
    {
        public FrmSelectMaterial()
        {
            InitializeComponent();
        }

        private void vattuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsVatTu.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

        }

        private void FrmSelectMaterial_Load(object sender, EventArgs e)
        {
            dataSet.EnforceConstraints = false;
            this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vattuTableAdapter.Fill(this.dataSet.Vattu);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string maVatTu = ((DataRowView)bdsVatTu.Current)["MAVT"].ToString();
            int soLuongVatTu = int.Parse( ((DataRowView)bdsVatTu.Current)["SOLUONGTON"].ToString() );

            String cauTruyVan =
                    "DECLARE	@result int " +
                            "EXEC @result = sp_KiemTraCTDDH '" +
                            FrmTheOrder.MADDH_temp + "','" + maVatTu + "' " +
                            "SELECT 'Value' = @result";
            SqlCommand sqlCommand = new SqlCommand(cauTruyVan, Program.conn);
            try
            {
                Program.myReader = Program.ExecSqlDataReader(cauTruyVan);
                if (Program.myReader == null)
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thực thi database thất bại!\n\n" + ex.Message, "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
                return;
            }
            Program.myReader.Read();
            int result = int.Parse(Program.myReader.GetValue(0).ToString());
            Program.myReader.Close();

            if (result == 1)
            {
                MessageBox.Show("Mã vật tư đã được sử dụng !", "Thông báo", MessageBoxButtons.OK);
                
                return;
            }

            Program.maVatTuDuocChon = maVatTu;
            Program.soLuongVatTu = soLuongVatTu;

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
