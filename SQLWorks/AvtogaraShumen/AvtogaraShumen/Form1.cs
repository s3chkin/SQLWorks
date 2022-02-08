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
        int b = 0;
        int c = 0;
        SqlConnection connBilet =
            new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\SQLworks\AvtogaraShumenSQLWork\AvtogaraShumen\AvtogaraShumen\TicketData.mdf; Integrated Security=True");

        public int GetLength()
        {
            SqlCommand cmdTicket = new SqlCommand("Select * from Ticket", connBilet);
            connBilet.Open();
            SqlDataAdapter daTicket = new SqlDataAdapter(cmdTicket);
            DataTable dataBilet = new DataTable();
            daTicket.Fill(dataBilet);
            connBilet.Close();
            daTicket.Dispose();
            return dataBilet.Rows.Count;
        }
        public void Ticket(int a)
        {
            SqlCommand cmdTicket = new SqlCommand("Select * from Ticket", connBilet);
            connBilet.Open();
            SqlDataAdapter daTicket = new SqlDataAdapter(cmdTicket);
            DataTable dataTicket = new DataTable();
            daTicket.Fill(dataTicket);
            connBilet.Close();
            dataTicket.Dispose();
            txtNumLine.Text = dataTicket.Rows[a][0].ToString();
            txtFromTheCity.Text = dataTicket.Rows[a][1].ToString();
            txtToTheCity.Text = dataTicket.Rows[a][2].ToString();
            txtArrivalTime.Text = dataTicket.Rows[a][3].ToString();
            txtPrice.Text = dataTicket.Rows[a][4].ToString();
            txtDepartureTime.Text = dataTicket.Rows[a][5].ToString();
            b = dataTicket.Rows.Count - 1;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Ticket(c);
            if (c == GetLength() - 1)
            {
                c = 0;
            }
            else
            {
                c = c + 1;
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Ticket(c);
            if (c == 0)
            {
                c = GetLength() - 1;

            }
            else
            {
                c = c - 1;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
