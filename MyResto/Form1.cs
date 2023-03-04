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

namespace MyResto
{
    public partial class Form1 : Form
    {
        //ConnectionDb
        SqlConnection conn = new SqlConnection(@"Data Source=AQILSUKALOLI\SQLEXPRESS;Initial Catalog=MyResto;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (usernameTxt.Text == "")
            {
                MessageBox.Show("Kamu belum memasukkan Username");
            }
            else if (passwordTxt.Text == "")
            {
                MessageBox.Show("Kamu belum memasukkan Password");
            }

            else
            {
                SqlDataAdapter query = new SqlDataAdapter("select count (*) from users where username = '" + usernameTxt.Text + "' and password = '" + passwordTxt.Text + "'", conn);
                DataTable response = new DataTable();
                query.Fill(response);
                if (response.Rows[0][0].ToString() == "1")
                {
                    SqlDataAdapter querySelect = new SqlDataAdapter("SELECT * FROM users WHERE username = '" + usernameTxt.Text + "'", conn);
                    DataTable userdata = new DataTable();
                    querySelect.Fill(userdata);
                    String role = userdata.Rows[0]["role"].ToString();
                    if (role == "admin")
                    {
                        dashboardAdmin nav = new dashboardAdmin();
                        nav.Show();
                        this.Hide();
                    }
                    else
                    {
                        HomeUI nav = new HomeUI();
                        nav.Show();
                        this.Hide();
                    }

                }
                else
                {
                    MessageBox.Show("Username Atau Password Salah!");
                }
            }
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            if (usernameTxt.Text == "")
            {
                MessageBox.Show("Kamu belum memasukkan Username");
            }
            else if (passwordTxt.Text == "")
            {
                MessageBox.Show("Kamu belum memasukkan Password");
            }

            else
            {
                try
                {
                    conn.Open();
                    string queryInsert = "INSERT INTO users (username, password, role) VALUES ('" + usernameTxt.Text + "','" + passwordTxt.Text + "','user')";
                    SqlCommand cmd = new SqlCommand(queryInsert, conn);
                    int n = cmd.ExecuteNonQuery();
                    conn.Close();

                    SqlDataAdapter query = new SqlDataAdapter("select count (*) from users where username = '" + usernameTxt.Text + "' and password = '" + passwordTxt.Text + "'", conn);
                    DataTable response = new DataTable();
                    query.Fill(response);
                    if (response.Rows[0][0].ToString() == "1")
                    {
                        SqlDataAdapter querySelect = new SqlDataAdapter("SELECT * FROM users WHERE username = '" + usernameTxt.Text + "'", conn);
                        DataTable userdata = new DataTable();
                        querySelect.Fill(userdata);
                        String role = userdata.Rows[0]["role"].ToString();
                        if (role == "admin")
                        {
                            dashboardAdmin nav = new dashboardAdmin();
                            nav.Show();
                            this.Hide();
                        }
                        else
                        {
                            HomeUI nav = new HomeUI();
                            nav.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Berhasil registrasi, silahkan login");
                    }
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
            }
        }
    }
}
