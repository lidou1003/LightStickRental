using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LightStickRental
{
    public partial class frmLightStickRental : Form
    {
        public frmLightStickRental()
        {
            InitializeComponent();
        }

        private void frmLightStickRental_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string account = txtAccount.Text;
            string password = txtPassword.Text;

            bool isLoginSuccess = false;
            bool isUserAdmin = false;

            if (account == "admin" && password == "1234")
            {
                isLoginSuccess = true;
                isUserAdmin = true;
            }
            else if (account == "dou" && password == "1003")
            {
                isLoginSuccess = true;
                isUserAdmin = false;
            }

            if (isLoginSuccess)
            {
                MessageBox.Show("登入成功！歡迎使用韓國手燈租借系統。");

                frmMain mainForm = new frmMain();

                mainForm.isAdmin = isUserAdmin;

                mainForm.Show();
                this.Hide(); // 隱藏登入畫面
            }
            else
            {
                MessageBox.Show("帳號或密碼錯誤，請重新輸入！", "登入失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
