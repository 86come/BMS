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

namespace BMS
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            frame1.Navigating += delegate
            {
                stackPanelLeft.Cursor = frame1.Cursor = Cursors.AppStarting;
            };
            frame1.ContentRendered += delegate
            {
                stackPanelLeft.Cursor = frame1.Cursor = Cursors.Arrow;
            };
            this.StateChanged += delegate
            {
                if (WindowState == WindowState.Maximized)
                {
                    gridTitle.Height = 80;
                    txtTitle.FontSize = 24;
                }
                else
                {
                    gridTitle.Height = 20;
                    txtTitle.FontSize = 12;
                }
            };
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.frame1.Source=new Uri("readerborrow.xaml", UriKind.Relative);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.frame1.Source = new Uri("readerreturn.xaml", UriKind.Relative);
        }
    }
}
