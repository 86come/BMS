using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using model;
using BLL;

namespace BMS
{
    /// <summary>
    /// Register.xaml 的交互逻辑
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            reader r = new reader();
            readerinfoBLL bll = new readerinfoBLL();
            r.id = txtID.Text;
            r.rpwd = txtPwd.Text;
            r.rsex = txtSex.Text;
            r.rtel = txtTel.Text;
            bll.Add(r);
            if (bll.Exists(r.id,r.rpwd) ){
                MessageBox.Show("注册成功");
                MainWindow m = new MainWindow();
                m.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("error");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
