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
using MySql.Data.MySqlClient;
using NewClient.ClassLibrary;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;




namespace NewClient
{
    public partial class ContactsForm : Form
    {

       List<Client> ContClients = new List<Client> ();
        public ContactsForm()
        {
            InitializeComponent();

            BindingUpdate();
            
        }

        private void BackToMain_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ( new LandingPage()).Show(); 
            //this.Close();
        }
        private void BindingUpdate()
        {
            
        }

        private void CreateContact_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=RecordsDB;Integrated Security=True");
            
            string ContactName = NameTB.Text;
            string ContactSurname = SurnameTB.Text;
            string ContactMail = EmailTB.Text;
            

            con.Open();
            SqlCommand push = new SqlCommand("INSERT into ContactsTable(Name, Surname, Email)values('" + ContactName + "','" + ContactSurname + "','" + ContactMail + "')", con);

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
            /* try
            {
                AccessControl NewEntry = new AccessControl();

                NewEntry.ConnectDB();
                int n = NewEntry.ExecuteSQL(InsertContact);
                NewEntry.DisconnectDB();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           */
            //AccessControl db = new AccessControl();
            //ContClients = db.GetClients(NameInput.Text);
            //BindingUpdate();


            //MessageBox.Show(ContactName+" "+ContactSurn);
            /*string server = "localhost";
            string uid = "root";
            string password = "";
            string database = "ClientContactDB";
            string constring = "server=" + server + ";uid=" + uid + ";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(constring);
            con.Open();

            Random rnd = new Random();
            string query = "insert into ContactsTable(ClientCode,Name,Surname,Email) values('"+rnd.Next()+ "','" + NameInput.Text+ "','"+SurnameInput.Text+ "','"+rnd.Next()+"')";
            MySqlCommand cmd = new MySqlCommand(query, con);

            int i = cmd.ExecuteNonQuery();

            if (i > -1)
            {
                MessageBox.Show("Saved!");
            }

            SqlConnection con = new SqlConnection("");  
            //SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True;User Instance=True");
            SqlCommand cmd = new SqlCommand("sp_insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", textBox1.Text);
            cmd.Parameters.AddWithValue("@email", textBox2.Text);
            cmd.Parameters.AddWithValue("@phone", textBox3.Text);
            cmd.Parameters.AddWithValue("@address", textBox4.Text);
            con.Open();
            int i = cmd.ExecuteNonQuery();

            con.Close();

            if (i != 0)
            {
                MessageBox.Show(i + "Data Saved");
            }*/
        }

        private void NameTB_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(NameTB.Text, "^[a-zA-Z]"))
            {
                MessageBox.Show("This textbox accepts only alphabetical characters");
                NameTB.Text.Remove(NameTB.Text.Length - 1);
            }
        }

        private void SurnameTB_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(SurnameTB.Text, "^[a-zA-Z]"))
            {
                MessageBox.Show("This textbox accepts only alphabetical characters");
                SurnameTB.Text.Remove(SurnameTB.Text.Length - 1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=RecordsDB;Integrated Security=True");
            con.Open();
            
            

            SqlDataAdapter da = new SqlDataAdapter("SELECT * ContactsTable", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "ContactsTable");
            ContactsGridView.DataSource = ds.Tables["ContactsTable"].DefaultView;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=RecordsDB;Integrated Security=True");
            con.Open();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ", con);
        }
    }
}
