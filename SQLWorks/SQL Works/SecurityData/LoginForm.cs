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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        SqlConnection connLogin =
            new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\11a SQL Works\\SQL Works\\SecurityData\\dbSecurity.mdf;Integrated Security=True; Connect Timeout = 30");
        
        public bool getAccess()
        {
            SqlCommand cmdAccess = new SqlCommand("Select * from Account",connLogin);
            connLogin.Open();
            SqlDataAdapter daAccess = new SqlDataAdapter(cmdAccess);
            DataTable dataAccess = new DataTable();
            daAccess.Fill(dataAccess);
            connLogin.Close();
            daAccess.Dispose();

            //Проверка за съвпадение на акаунта
            bool check = false;
            int i = 0;
            while (!check)
            {
                if ((dataAccess.Rows[i][0].ToString() == txtUser.Text)&&
                    
                    dataAccess.Rows[i][1].ToString() == txtPass.Text)
                {
                    check = true;
                    break;
                }
                i++;
                if (i == dataAccess.Rows.Count - 1)
                    break;
            }
            if (!check)
            {
                MessageBox.Show("Нямате достъп");
                return check;
            }
            else
            {
                MessageBox.Show("Имате достъп");
                return check;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            getAccess();
        }
    }
}
