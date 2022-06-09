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
using System.Data;
using System.Data.SqlClient;
namespace BMS
{
    /// <summary>
    /// curdbook.xaml 的交互逻辑
    /// </summary>
    public partial class curdbook : Page
    {
        public curdbook()
        {
            InitializeComponent();
            initevents();
        }
        bookinfoBLL bll = new bookinfoBLL();
        private void initevents()
        {
            dataGrid1.ItemsSource = bll.select().DefaultView;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            book b = new book();
            b.bno = txtbno.Text;
            b.bname = txtbname.Text;
            b.bauthor = txtbauthor.Text;
            b.bcbs = txtbcbs.Text;
            b.ISBN = txtISBN.Text;
            bll.insert(b);
            MessageBox.Show("添加成功");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            book b = new book();
            DataRowView dr = (DataRowView)dataGrid1.SelectedItem;
            b.bno = dr.Row[0].ToString();
            b.bname = dr.Row[1].ToString();
            b.bauthor = dr.Row[2].ToString();
            b.bcbs = dr.Row[3].ToString();
            b.ISBN = dr.Row[4].ToString();
            bll.delete(b);
            MessageBox.Show("删除成功");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            book b = new book();
            book b1 = new book();
            DataRowView dr = (DataRowView)dataGrid1.SelectedItem;
            b.bno = dr.Row[0].ToString();
            b.bname = dr.Row[1].ToString();
            b.bauthor = dr.Row[2].ToString();
            b.bcbs = dr.Row[3].ToString();
            b.ISBN = dr.Row[4].ToString();
            b1.bno = txtbno.Text;
            b1.bname = txtbname.Text;
            b1.bauthor = txtbauthor.Text;
            b1.bcbs = txtbcbs.Text;
            b1.ISBN = txtISBN.Text;
            bll.update(b,b1);
            MessageBox.Show("更新成功");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            book b = new book();
            b.bno = txtbno.Text;
            dataGrid1.ItemsSource=bll.select1(b).DefaultView;
            MessageBox.Show("查询成功");
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            initevents();
        }
    }
}
