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

namespace SecurityData
{
    public partial class ReferenceForm : Form
    {
        public ReferenceForm()
        {
            InitializeComponent();
            GetTown();
        }
        int n = 0;
        //SQL връзка
        SqlConnection connSecurity =
            new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=D:\11a SQL Works\SQL Works\SecurityData\dbSecurity.mdf; Integrated Security=True");
        public int SecurityCount()
        {
            int l;
            SqlCommand cmdSecurity = new SqlCommand("Select * from Account",connSecurity);
            connSecurity.Open();
            SqlDataAdapter daSecurity = new SqlDataAdapter(cmdSecurity);
            DataTable dataSecurity = new DataTable();
            daSecurity.Fill(dataSecurity);
            daSecurity.Dispose();
            connSecurity.Close();
            l = dataSecurity.Rows.Count - 1;
            //MessageBox.Show(l.ToString());
            return l;
        }
        public void SecurityGet(int x)
        {
            SqlCommand cmdSecurity = new SqlCommand("Select * from Account", connSecurity);
            connSecurity.Open();
            SqlDataAdapter daSecurity = new SqlDataAdapter(cmdSecurity);
            DataTable dataSecurity = new DataTable();
            daSecurity.Fill(dataSecurity);
            daSecurity.Dispose();
            connSecurity.Close();

            txtName.Text = dataSecurity.Rows[x][0].ToString();
            txtPassword.Text = dataSecurity.Rows[x][1].ToString();
        }
        public void SecrityInsert()
        {
            string userName = txtName.Text;
            string pass = txtPassword.Text;
            connSecurity.Open();
            //Създаване на Command връзка
            //SqlCommand("Select * from Account", connSecurity)
            SqlCommand cmdSecurity = new SqlCommand();
            cmdSecurity.Connection = connSecurity;
            cmdSecurity.CommandText =
                "Insert into Account(user,password) values(@user,@password)";
            cmdSecurity.Parameters.AddWithValue("@user", userName);
            cmdSecurity.Parameters.AddWithValue("@password", pass);
            cmdSecurity.ExecuteNonQuery();
            connSecurity.Close();
            /*
            try
            {
                connSecurity.Open();
                cmdSecurity.ExecuteNonQuery();
            }
            catch
            {
                //Error when save data

                MessageBox.Show("Error to save on database");
                
            }
            finally
            {
                connSecurity.Close();
            }
            */
        }
        private void GetTown()
        {
            //SqlDataAdapter daTown = new SqlDataAdapter("SELECT City FROM Town", connSecurity);
            SqlCommand cmdTown = 
                new SqlCommand("SELECT City FROM Town", connSecurity);
            SqlDataAdapter daTown = new SqlDataAdapter(cmdTown);
            DataTable dataTown = new DataTable();
            daTown.Fill(dataTown);
            connSecurity.Close();
            daTown.Dispose();
            for (int i = 0; i < dataTown.Rows.Count; i++)
            {
                ctTown.Items.Add(dataTown.Rows[i][0].ToString());
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            SecurityCount();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //GetTown();
            SecurityGet(n);
            if (n == 0)
            {
                n = SecurityCount();
            }
            else
            {
                n--;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //GetTown();
            SecurityGet(n);
            if (n == SecurityCount())
            {
                n = 0;
            }
            else
            {
                n++;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            SecrityInsert();
        }

        
    }
}
