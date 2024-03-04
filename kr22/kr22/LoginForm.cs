using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kr22
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            string login = logintxt.Text;
            string password = pastxt.Text;
            if (login == "admin"&& password == "QweRt098")
            {

            }
            
        }

        private void btnlog_Click(object sender, EventArgs e)
        {
         string login = logintxt.Text;
            if(login=="admin")
            {
                //DialogResult = DialogResult.OK;
            }
           
        }

        private void btnpas_Click(object sender, EventArgs e)
        {
            string password = pastxt.Text;
            if (password == "QweRt098")
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Ты че, дурак что ли?", "Вспоминай сиди.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
