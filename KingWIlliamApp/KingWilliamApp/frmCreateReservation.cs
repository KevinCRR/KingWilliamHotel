using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KingWilliamApp
{
    public partial class frmEditReservation : Form
    {
        public frmEditReservation()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

        }

        private void frmCreateReservation_Load(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Termina1\Desktop\KingWilliamHotel\KingWilliamApp\KingWIlliamApp\KingWilliamDB.mdf;Integrated Security=True");

            try
            {
                sqlcon.Open();
                SqlCommand sc = new SqlCommand("SELECT (provinceCode) FROM tblProvinces", sqlcon);
                SqlDataReader reader;
                reader = sc.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("provinceCode", typeof(string));
                dt.Load(reader);
                cbxProvince.ValueMember = "provinceCode";
                cbxProvince.DataSource = dt;
                sqlcon.Close();
            }
            catch (Exception) {}
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
