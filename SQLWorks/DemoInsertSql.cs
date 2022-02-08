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

namespace DemoInsertSQL
{
    public partial class MainCatalog : Form
    {
        public MainCatalog()
        {
            InitializeComponent();
        }

        SqlConnection connMagasin = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB; AttachDbFilename=D:\\CcharpWorks\\DemoInsertSQL\\myMagasin.mdf;Integrated Security=True;Connect Timeout=30;");
        int n = 0;

        public int GetLength()
        {
            SqlCommand cmdStock = new SqlCommand("Select * from Magasin", connMagasin);
            connMagasin.Open();
            //Create data adapter
            SqlDataAdapter daMagasin = new SqlDataAdapter(cmdStock);
            DataTable dataStock = new DataTable();
            daMagasin.Fill(dataStock);
            connMagasin.Close();
            daMagasin.Dispose();

            return dataStock.Rows.Count;
        }

        public void GetStock(int x)
        {
            SqlCommand cmdStock = new SqlCommand("Select * from Magasin", connMagasin);
            connMagasin.Open();
            //Create data adapter
            SqlDataAdapter daMagasin = new SqlDataAdapter(cmdStock);
            DataTable dataStock = new DataTable();
            daMagasin.Fill(dataStock);
            connMagasin.Close();
            daMagasin.Dispose();

            txtID.Text          = dataStock.Rows[x][0].ToString();
            txtName.Text     = dataStock.Rows[x][1].ToString();
            txtPrice.Text      = dataStock.Rows[x][2].ToString();
            txtQuantity.Text = dataStock.Rows[x][3].ToString();
        }

        public void InsertStock()
        {
            int      id       = Convert.ToInt32(txtID.Text);
            string name = txtName.Text;
            double  price  = double.Parse(txtPrice.Text);
            int    qtn      = int.Parse(txtQuantity.Text);
            connMagasin.Open();
            SqlCommand cmdMagasin = new SqlCommand();
            cmdMagasin.Connection = connMagasin;
            cmdMagasin.CommandText = "Insert into Magasin(idStock, nameStock, priceStock, qtnStock) values(@tabId, @tabName, @tabPrice, @tabQtn)" ;

            cmdMagasin.Parameters.AddWithValue("@tabId", id);
            cmdMagasin.Parameters.AddWithValue("@tabName", name);
            cmdMagasin.Parameters.AddWithValue("@tabPrice", price);
            cmdMagasin.Parameters.AddWithValue("@tabQtn", qtn);

            cmdMagasin.ExecuteNonQuery();
            connMagasin.Close();            
        }

        public void UpdateStock()
        {
            int id = Convert.ToInt32(txtID.Text);
            string name = txtName.Text;
            double price = double.Parse(txtPrice.Text);
            int qtn = int.Parse(txtQuantity.Text);

            connMagasin.Open();
            SqlCommand cmdMagasin = new SqlCommand();
            cmdMagasin.Connection = connMagasin;
            cmdMagasin.CommandText = "Update Magasin SET nameStock = @tabName, priceStock = @tabPrice, qtnStock = @tabQtn  WHERE idStock =@tabId";

            cmdMagasin.Parameters.AddWithValue("@tabId", id);
            cmdMagasin.Parameters.AddWithValue("@tabName", name);
            cmdMagasin.Parameters.AddWithValue("@tabPrice", price);
            cmdMagasin.Parameters.AddWithValue("@tabQtn", qtn);
            int rowsAffected = cmdMagasin.ExecuteNonQuery();

            connMagasin.Close();
        }
        public void DeleteStock()
        {
            int id = Convert.ToInt32(txtID.Text);
            string name = txtName.Text;
            double price = double.Parse(txtPrice.Text);
            int qtn = int.Parse(txtQuantity.Text);

            connMagasin.Open();
            SqlCommand cmdMagasin = new SqlCommand();
            cmdMagasin.Connection = connMagasin;
            cmdMagasin.CommandText = "Delete Magasin WHERE idStock =@tabId" ;

            cmdMagasin.Parameters.AddWithValue("@tabId", id);
            cmdMagasin.Parameters.AddWithValue("@tabName", name);
            cmdMagasin.Parameters.AddWithValue("@tabPrice", price);
            cmdMagasin.Parameters.AddWithValue("@tabQtn", qtn);
            int rowsAffected = cmdMagasin.ExecuteNonQuery();

            string msg = "Атрибут с каталожен № " + id + "\t" + name + " e изтрит от базата данни";
            MessageBox.Show(msg);

            connMagasin.Close();
        }



        private void btnPrev_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(GetLength().ToString());
            GetStock(n);
            if (n == 0)
            {
                n = GetLength() - 1;
            }
            else
            {
                n = n - 1;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            GetStock(n);
            if(n == GetLength() - 1)
            {
                n = 0;
            }
            else
            {
                n = n + 1;
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            InsertStock();
            MessageBox.Show("Новият артикул е въведен в базата данни!");
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            UpdateStock();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteStock();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            
            Facture vende = new Facture();
            vende.Show();
        }
    }
}
