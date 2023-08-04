using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewClient.ClassLibrary;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NewClient
{
    public partial class GeneralTab : Form
    {
        public GeneralTab()
        {
            InitializeComponent();
        }


        private void CreateNewClient_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=RecordsDB;Integrated Security=True");

            string ClientName = NameTB.Text;
            string ClientCode = ClientCodeTB.Text;
            
            

            con.Open();
            SqlCommand push = new SqlCommand("INSERT into ClientTable(ClientCode, Name)values('" + ClientCode + "','" + ClientName + "')", con);

            int i = push.ExecuteNonQuery();

            if (i > -1)
            {
                MessageBox.Show("Saved!");
            }
            else
            {
                MessageBox.Show("Error!");
            }
            con.Close();

        }

        private void BackToMain_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            (new LandingPage()).Show(); 
            //this.Close();
        }

        private void ClientCodeTB_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(ClientCodeTB.Text, "^[a-zA-Z]"))
            {
                MessageBox.Show("This textbox accepts only alphabetical characters");
                ClientCodeTB.Text.Remove(ClientCodeTB.Text.Length - 1);
            }
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=RecordsDB;Integrated Security=True");
            con.Open();



            SqlDataAdapter da = new SqlDataAdapter("SELECT * ClientTable", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "ClientTable");
            GeneralDataGridView.DataSource = ds.Tables["ClientTable"].DefaultView;
        }
    }
}
