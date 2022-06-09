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
using System.Windows.Navigation;
using System.Windows.Shapes;
using BLL;
using model;

namespace BMS
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button_login(object sender, RoutedEventArgs e)
        {
            if(!String.IsNullOrEmpty(txtID.Text) || !String.IsNullOrEmpty(txtPwd.Text))
            {
                if (combobox.Text=="用户") { 
                    readerinfoBLL bll = new readerinfoBLL();
                    if (bll.Exists(txtID.Text, txtPwd.Text))
                    {
                        MessageBox.Show("登陆成功");
                        MainWindow m = new MainWindow();
                        m.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("不存在此用户或用户名密码错！");
                    }
                }else if(combobox.Text == "管理员")
                {
                    admininfoBLL bll1 = new admininfoBLL();
                    if(bll1.Exists(txtID.Text, txtPwd.Text))
                    {
                        MessageBox.Show("登陆成功");
                        MainWindowadmin m = new MainWindowadmin();
                        m.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("不存在此管理员或密码错！");
                    }
                }
            }
        }

        private void Button_register(object sender, RoutedEventArgs e)
        {
            Register r = new Register();
            r.Show();
            this.Close();
        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            combobox.Text = "管理员";
        }

        private void ComboBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {
            combobox.Text = "用户";
        }
    }
}
