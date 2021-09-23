using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winLogin
{
    public partial class frmLogin : Form
    {
        //create and empty list to hold users
        List<User> UserList = new List<User>();

        private string inputUser;
        private string inputPass;
        int currentUser;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPassword.TextLength == 0 || txtUser.TextLength == 0)
            {
                MessageBox.Show("Incomplete data entry");
            }
            else
            {
                inputPass = txtPassword.Text.ToString();
                inputUser = txtUser.Text.ToString();

                for (int i = 0; i<UserList.Count; i++)
                {
                    if (UserList[i].UserName.Equals(inputUser))
                    {
                        currentUser = i;
                        if (UserList[i].Tries == 0)
                        {
                            MessageBox.Show("This account is locked due to many failed login attempts.");
                        }
                        else
                        {

                            if (UserList[i].Password.Equals(inputPass))
                            {
                                UserList[currentUser].Tries = 3;
                                frmMain frmM = new frmMain();
                                frmM.Show();
                            }
                            else
                            {
                                UserList[currentUser].Tries -= 1;
                                if (UserList[currentUser].Tries == 0)
                                {
                                    MessageBox.Show("Wrong Password. Your account is now blocked");

                                }
                                else
                                {
                                    MessageBox.Show("Wrong Password.\nYou have " + UserList[currentUser].Tries + " more tries");
                                }
                            }

                        }
                        i = UserList.Count;
                    }
                    else
                    {
                        if (i == UserList.Count - 1)
                        {
                            MessageBox.Show("Not a valid user.");
                        }
                    }
                }
            }
        }

        private void frmLogin_Load_1(object sender, EventArgs e)
        {
            UserList.Add(new User("Georgios", "1234"));
            UserList.Add(new User("Diogo", "domingues"));
            UserList.Add(new User("Larissa", "brasil"));
            UserList.Add(new User("Eoin", "0000"));
            UserList.Add(new User("Peter", "carlow"));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
