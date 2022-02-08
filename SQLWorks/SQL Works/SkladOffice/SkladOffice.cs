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

namespace SkladOffice
{
    public partial class SkladOffice : Form
    {
        public SkladOffice()
        {
            InitializeComponent();
        }
        int n = 0;
        int l = 0;
        SqlConnection connSklad = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename = D:\\11a SQL Works\\SQL Works\\SkladOffice\\SkladOffice.mdf; Integrated Security=True; Connect Timeout = 30");
        
        public void getStock(int x)
        {
            SqlCommand cmdStock = new SqlCommand("Select * from Sklad", connSklad);
            connSklad.Open();
            SqlDataAdapter daStock = new SqlDataAdapter(cmdStock);
            DataTable dataStock = new DataTable();
            daStock.Fill(dataStock);
            connSklad.Close();
            daStock.Dispose();
            idNumber.Text = dataStock.Rows[x][0].ToString();
            nameStock.Text = dataStock.Rows[x][1].ToString();
            priseStock.Text = dataStock.Rows[x][2].ToString();
            qtyStock.Text = dataStock.Rows[x][3].ToString();
            l = dataStock.Rows.Count - 1;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            getStock(n);
            /*
            for (int i = 0; i <= l; i++)
            {
                n = i; 
            }
            */
            if (n == 0)
            {
                n = l;
            }
            else
            {
                n = n - 1;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            getStock(n);
            if (n == l)
            {
                n = 0;
            }
            else
            {
                n = n + 1;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
