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

namespace PrepareDemo
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DataBase.Trade123Entities _context = new DataBase.Trade123Entities();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            if (_context.User.Select(t => t.UserLogin.Equals(Login.Text)).Count() != 0 &&
                _context.User.Select(v => v.UserPassword.Equals(Password.Password)).Count() != 0)
            {
                WindowProject.ProductList product = new WindowProject.ProductList();
                product.Show();
                this.Close();
            }
            else { 
            //
            }
        }

        private void Guest_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            WindowProject.ProductList product = new WindowProject.ProductList();
            product.Show();
        }
    }
}
