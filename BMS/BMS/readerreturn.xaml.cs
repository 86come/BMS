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
using model;
using BLL;
using System.Data;
namespace BMS
{
    /// <summary>
    /// readerreturn.xaml 的交互逻辑
    /// </summary>
    public partial class readerreturn : Page
    {
        public readerreturn()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            borrowinfoBLL bll = new borrowinfoBLL();
            borrow b = new borrow();
            b.id = txtid.Text;
            dataGrid1.ItemsSource= bll.select1(b).DefaultView;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            returninfoBLL bll = new returninfoBLL();
            @return r = new @return();
            r.id = txtid.Text;
            r.rtime = DateTimeOffset.Now.ToString();
            DataRowView b = (DataRowView)dataGrid1.SelectedItem;
            r.bno = b.Row[1].ToString();
            r.rtel = b.Row[3].ToString();
            bll.insert(r);
            MessageBox.Show("还书成功");
        }
    }
}
