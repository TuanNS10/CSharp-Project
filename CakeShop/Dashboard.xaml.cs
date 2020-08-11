using System;
using System.Collections.Generic;
using System.Configuration;
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

namespace CakeShop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sự kiện khi ấn các button command
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnCommands_Click(object sender, RoutedEventArgs e)
        {
            Button curButton = sender as Button;
            if (curButton.Tag.Equals("btnClose"))
            {
                this.Close();
            }
            else if (curButton.Tag.Equals("btnMinim"))
            {
                this.WindowState = WindowState.Minimized;
            }
            else if (curButton.Tag.Equals("btnMaxim"))
            {
                if (this.WindowState == WindowState.Maximized)
                {
                    this.WindowState = WindowState.Normal;
                }
                else
                {
                    this.WindowState = WindowState.Maximized;
                }
            }
        }

        /// <summary>
        /// Sự kiện di chuyển cửa sổ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ColorZone_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        /// <summary>
        /// Hiển thị danh sách loại sản phẩm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Dashboard_Loaded(object sender, RoutedEventArgs e)
        {
            this.Hide();
            var config = ConfigurationManager.AppSettings["ShowSplash"];

            if (config.ToLower() == "true")
            {
                var src = new SplashScreen();
                src.ShowDialog();
            }
            this.Show();
            _mainFrame.Navigate(new HomePage());
        }
    }
}
