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

namespace AvtogaraShumen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connGara =
            new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\SQLworks\AvtogaraShumenSQLWork\AvtogaraShumen\TicketData.mdf;Integrated Security=True");

        public int ShumenGara()
        {
            SqlCommand cmdGara = new SqlCommand("Select * from Gara", connGara);
            connGara.Open();
            SqlDataAdapter Gara1 = new SqlDataAdapter(cmdGara);
            DataTable dataGara = new DataTable();
            Gara1.Fill(dataGara);
            connGara.Close();
            Gara1.Dispose();
            return dataGara.Rows.Count;
        }
        int y = 0;
        int z = 0;
     
        public void GaraBilet(int x)
        {
            SqlCommand cmdGara = new SqlCommand("Select * from Gara", connGara);
            connGara.Open();
            SqlDataAdapter daAvtogara = new SqlDataAdapter(cmdGara);
            DataTable dataAvtogara = new DataTable();
            daAvtogara.Fill(dataAvtogara);
            connGara.Close();
            dataAvtogara.Dispose();
            txtNumLine.Text = dataAvtogara.Rows[x][0].ToString();
            txtFromTheCity.Text = dataAvtogara.Rows[x][1].ToString();
            txtToTheCity.Text = dataAvtogara.Rows[x][2].ToString();
            txtArrivalTime.Text = dataAvtogara.Rows[x][3].ToString();
            txtPrice.Text = dataAvtogara.Rows[x][4].ToString();
            txtDepartureTime.Text = dataAvtogara.Rows[x][5].ToString();
            y = dataAvtogara.Rows.Count - 1;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            GaraBilet(z);
            if (z == ShumenGara() - 1)
            {
                z = 0;
            }
            else
            {
                z ++;
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            GaraBilet(z);
            if (z == 0)
            {
                z = ShumenGara() - 1;

            }
            else
            {
                z--;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}