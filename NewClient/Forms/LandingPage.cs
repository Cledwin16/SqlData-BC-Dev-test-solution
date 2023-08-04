using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewClient
{
    public partial class LandingPage : Form
    {
        public LandingPage()
        {
            InitializeComponent();
            
        }

        private void createNewClient_Click(object sender, EventArgs e)
        {
            (new GeneralTab()).Show(); this.Close();
        }

        private void createNewContact_Click(object sender, EventArgs e)
        {
            
            (new ContactsForm()).Show();

            //this.Close();
            
        }
    }
}
