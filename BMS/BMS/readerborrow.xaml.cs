using System;
using System.Collections.Generic;
using System.Data;
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
    /// readerborrow.xaml 的交互逻辑
    /// </summary>
    public partial class readerborrow : Page
    {
        public readerborrow()
        {
            InitializeComponent();
            InitEvents();
            dataGrid1.SelectedIndex = -1;
            StackPanelDetail.Visibility = Visibility.Collapsed;
        }
        private void InitEvents()
        {
            dataGrid1.SelectionMode = DataGridSelectionMode.Single;
            RefreshDataGrid1();
            dataGrid1.SelectionChanged += (s, e) =>
            {
                if (dataGrid1.SelectedIndex == -1)
                {
                    StackPanelDetail.Visibility = System.Windows.Visibility.Collapsed;
                    LabelTip.Visibility = System.Windows.Visibility.Visible;
                    return;
                }
                else
                {
                    StackPanelDetail.Visibility = System.Windows.Visibility.Visible;
                    LabelTip.Visibility = System.Windows.Visibility.Collapsed;
                }
                DataRowView b = (DataRowView)dataGrid1.SelectedItem;
                //DataTable dt= b.ToTable();
                textBno.Text = b.Row[0].ToString();
                textBoxBookname.Text = b.Row[1].ToString();
                textBoxAuthor.Text = b.Row[2].ToString();
                textBoxCbs.Text = b.Row[3].ToString();
                textBoxISBN.Text = b.Row[4].ToString();
            };
        }
        private void RefreshDataGrid1()
        {
            bookinfoBLL bll = new bookinfoBLL();
            dataGrid1.ItemsSource = bll.select().DefaultView;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txtID.Text !=""&& txtTel.Text != "")
            {
                if (textBno.Text != "")
                {
                    borrowinfoBLL bll = new borrowinfoBLL();
                    borrow b = new borrow();
                    b.id = txtID.Text;
                    b.btel = txtTel.Text;
                    b.bno = textBno.Text;
                    b.btime = DateTimeOffset.Now.ToString();
                    if (bll.insert(b))
                    {
                        MessageBox.Show("借书成功");
                    }
                    else
                    {
                        MessageBox.Show("该书已被借出");
                    }

                }
                else
                {
                    MessageBox.Show("请选择书籍");
                }
            }
            else
            {
                MessageBox.Show("请输入用户信息");

            }
        }
    }
}