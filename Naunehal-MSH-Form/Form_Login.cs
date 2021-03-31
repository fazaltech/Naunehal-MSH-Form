using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Naunehal_MSH_Form.Model;

namespace Naunehal_MSH_Form
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }
        private users urs = new users();
        private void Form_Login_Load(object sender, EventArgs e)
        {

        }

        private void button_login_Click(object sender, EventArgs e)
        {

            if (textbox_username.Text == "test1234" && textbox_password.Text == "test1234")
            {


                DataVariables.User_Name = textbox_username.Text;
                DataVariables.Form_Login = this;

                this.Hide();
                Form_MHS obj_main = new Form_MHS();
                obj_main.Show();

            }
            else if (textbox_username.Text == "dmu@aku" && textbox_password.Text == "aku?dmu")
            {


                DataVariables.User_Name = textbox_username.Text;
                DataVariables.Form_Login = this;

                this.Hide();
                Form_MHS obj_main = new Form_MHS();
                obj_main.Show();

            }
            else if (textbox_username.Text != null && textbox_password.Text != null)
            {


                urs.username = textbox_username.Text;
                urs.password = textbox_password.Text;

                //if (IsValid(urs.username, urs.password))
                //{
                //    DataVariables.User_Name = user_name.Text;
                //    DataVariables.Form_Login = this;
                //    this.Hide();
                //    Form_Data obj_main = new Form_Data();
                //    obj_main.Show();

                //}
               
            }
            else
            {
                MessageBox.Show("User does not exist ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textbox_username.Focus();
            }
        }
    }
}
