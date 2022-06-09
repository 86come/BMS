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
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;
namespace BMS
{
    /// <summary>
    /// selectbr.xaml 的交互逻辑
    /// </summary>
    public partial class selectbr : Page
    {
        public selectbr()
        {
            InitializeComponent();
            Initevents();
        }

        private void Initevents()
        {
            borrowinfoBLL bll = new borrowinfoBLL();
            returninfoBLL bll1 = new returninfoBLL();
            dataGrid1.ItemsSource = bll.select().DefaultView;
            dataGrid2.ItemsSource = bll1.select().DefaultView;
        }
    }
}
